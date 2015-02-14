using BusinessLogic;
using Library.Code;
using Library.Code.Enum;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.FatturaVendita
{
	public partial class FatturaVenditaModel : TemplateModel
	{
        public FatturaVenditaModel()
		{
			InitializeComponent();
            try
            {
                InitCombo();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
		}

        private void InitCombo()
        {
            try
            {
                editTipoPagamento.DisplayValues = UtilityEnum.GetDisplayValues<Tipi.TipoPagamento>();
                editScadenzaPagamento.DisplayValues = UtilityEnum.GetDisplayValues<Tipi.ScadenzaPagamento>();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindViewSubTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.FatturaVenditaDto)model;
                    var numero = UtilityValidation.GetStringND(obj.Numero);
                    var descrizione = UtilityValidation.GetStringND(obj.Descrizione);
                    infoSubtitle.Text = numero + " - " + descrizione;
                    infoSubtitleImage.Image = "Images.dashboard.fatturavendita.png";
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindView(object model)  
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.FatturaVenditaDto)model;
                    editData.Value = obj.Data;
                    editDescrizione.Value = obj.Descrizione;
                    editImponibile.Value = obj.Imponibile;
                    editIVA.Value = obj.IVA;              
                    editNumero.Value = obj.Numero;
                    editTipoPagamento.Value = obj.TipoPagamento;
                    editScadenzaPagamento.Value = obj.ScadenzaPagamento;
                    editNote.Value = obj.Note;
                    editTotale.Value = obj.Totale;
                    editTotaleLiquidazioni.Value = GetTotaleLiquidazioni(obj);
                    editStato.Value = GetStato(obj); ;
                    var cliente = obj.Cliente;
                    if (cliente != null)
                    {
                        editCliente.Model = cliente;
                        editCliente.Value =  cliente.Codice + " - " + cliente.RagioneSociale;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private string GetStato(WcfService.Dto.FatturaVenditaDto fatturaVendita)
        {
            try
            {
                var stato = "N/D";
                var clienteId = fatturaVendita.ClienteId;
                var viewModelCliente = new Cliente.ClienteViewModel(this);
                var cliente = viewModelCliente.Read(clienteId);
                var commessa = cliente.Commessa;
                var statoCommessa = commessa.Stato;
                if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                    stato = fatturaVendita.Stato;
                else
                {
                    var imponibile = UtilityValidation.GetDecimal(editImponibile.Value);
                    var iva = UtilityValidation.GetDecimal(editIVA.Value);
                    var _scadenzaPagamento = editScadenzaPagamento.Value;
                    var today = DateTime.Today;
                    var scadenzaPagamento = UtilityEnum.GetValue<Tipi.ScadenzaPagamento>(_scadenzaPagamento);
                    var scadenza = BusinessLogic.Fattura.GetScadenza(fatturaVendita);
                    var totaleFattura = BusinessLogic.Fattura.GetTotale(imponibile, iva);
                    var totaleLiquidazioni = BusinessLogic.Fattura.GetTotaleLiquidazioni(fatturaVendita, today);
                    var statoFattura = BusinessLogic.Fattura.GetStato(fatturaVendita);

                    var statoDescrizione = GetStato(today, scadenza, totaleFattura, totaleLiquidazioni, statoFattura);
                    stato = statoDescrizione.ToString();
                }
                return stato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private decimal GetTotaleLiquidazioni(WcfService.Dto.FatturaVenditaDto fatturaVendita)
        {
            try
            {
                decimal totaleLiquidazioni = 0;
                var clienteId = fatturaVendita.ClienteId;
                var viewModelCliente = new Cliente.ClienteViewModel(this);
                var cliente = viewModelCliente.Read(clienteId);
                var commessa = cliente.Commessa;
                var statoCommessa = commessa.Stato;
                if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                    totaleLiquidazioni = UtilityValidation.GetDecimal(fatturaVendita.TotaleLiquidazioni);
                else
                {
                    var today = DateTime.Today;
                    totaleLiquidazioni = BusinessLogic.Fattura.GetTotaleLiquidazioni(fatturaVendita, today);
                }
                return totaleLiquidazioni;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public override void BindModel(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.FatturaVenditaDto)model;
                    obj.Data = editData.Value;
                    obj.Descrizione = editDescrizione.Value;
                    obj.Imponibile = editImponibile.Value;
                    obj.IVA = editIVA.Value;
                    obj.Numero = editNumero.Value;
                    obj.TipoPagamento = editTipoPagamento.Value;
                    obj.ScadenzaPagamento = editScadenzaPagamento.Value;
                    obj.Note = editNote.Value;
                    obj.Totale = editTotale.Value;
                    obj.TotaleLiquidazioni = editTotaleLiquidazioni.Value;
                    obj.Stato = editStato.Value;
                    var cliente = (WcfService.Dto.ClienteDto)editCliente.Model;
                    if(cliente!=null)
                        obj.ClienteId = cliente.Id;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCliente_ComboClick()
        {
            try
            {
                var view = new Cliente.ClienteView();
                view.Title = "SELEZIONA UN CLIENTE";
                editCliente.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCliente_ComboConfirm(object model)
        {
            try
            {
                var cliente = (WcfService.Dto.ClienteDto)model;
                if (cliente != null)
                    editCliente.Value = cliente.Codice + " - " + cliente.RagioneSociale;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCalcoloTotali_Click(object sender, EventArgs e)
        {
            try
            {
                if (Editing)
                    CalcolaTotali();

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void CalcolaTotali()
        {
            try
            {
                var imponibile = UtilityValidation.GetDecimal(editImponibile.Value);
                var iva = UtilityValidation.GetDecimal(editIVA.Value);
                var data = editData.Value;
                var _scadenzaPagamento = editScadenzaPagamento.Value;
                var today = DateTime.Today;

                if (data != null)
                {
                    var obj = (WcfService.Dto.FatturaVenditaDto)Model;
                    var scadenza = BusinessLogic.Fattura.GetScadenza(obj);
                    var totaleFattura = BusinessLogic.Fattura.GetTotale(imponibile, iva);
                    var totaleLiquidazioni= BusinessLogic.Fattura.GetTotaleLiquidazioni(obj, today);
                    var statoFattura = BusinessLogic.Fattura.GetStato(obj);

                    var stato = GetStato(today, scadenza, totaleFattura, totaleLiquidazioni, statoFattura);

                    editStato.Value = stato.ToString();
                    editTotale.Value = totaleFattura;
                    editTotaleLiquidazioni.Value = totaleLiquidazioni;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


        private StateDescriptionImage GetStato(DateTime data, DateTime scadenza, decimal totaleFattura, decimal totaleLiquidazioni, BusinessLogic.Tipi.StatoFattura statoFattura)
        {
            try
            {
                var stato = TypeState.None;
                var descrizione = "";
                var ritardo = BusinessLogic.Fattura.GetRitardo(data, scadenza);
                var _totaleLiquidazioni = UtilityValidation.GetEuro(totaleLiquidazioni);
                var _totaleFattura = UtilityValidation.GetEuro(totaleFattura);
                var _scadenza = UtilityValidation.GetDataND(scadenza);

                if (statoFattura == Tipi.StatoFattura.Insoluta)
                {
                    descrizione = "La fattura risulta insoluta. Il totale incassi pari a " + _totaleLiquidazioni + " è inferiore al totale della fattura pari a " + _totaleFattura + ". La fattura risulta scaduta il " + _scadenza + " con un ritardo di liquidazione pari a " + ritardo;
                    stato = TypeState.Critical;
                }
                else if (statoFattura == Tipi.StatoFattura.NonPagata)
                {
                    descrizione = "La fattura risulta non incassata. Il totale incassi pari a " + _totaleLiquidazioni + " è inferiore al totale della fattura pari a " + _totaleFattura + ". La fattura scade il " + _scadenza;
                    stato = TypeState.Warning;
                }
                else if (statoFattura == Tipi.StatoFattura.Pagata)
                {
                    descrizione = "La fattura è stata incassata";
                    stato = TypeState.Normal;
                }
                var _stato = new StateDescriptionImage(stato, descrizione);
                return _stato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private void editImponibileIVA_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Editing)
                    CalcolaTotali();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void SetEditing(bool editing, bool deleting)
        {
            try
            {
                base.SetEditing(editing, deleting);
                btnCalcoloTotali.Enabled = editing;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
