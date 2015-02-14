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
                    editTotaleLiquidazioni.Value = obj.TotaleLiquidazioni;
                    editStato.Value = obj.Stato;
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
                if (statoFattura == Tipi.StatoFattura.Insoluta)
                {
                    descrizione = "La fattura risulta insoluta. Il totale incassi pari a " + totaleLiquidazioni.ToString("0.00�") + " � inferiore al totale della fattura pari a " + totaleFattura.ToString("0.00�") + ". La fattura risulta scaduta il  " + scadenza.ToString("dd/MM/yyyy") + " con un ritardo di pagamento pari a " + ritardo;
                    stato = TypeState.Critical;
                }
                else if (statoFattura == Tipi.StatoFattura.NonPagata)
                {
                    descrizione = "La fattura risulta in liquidazione. Il totale incassi pari a " + totaleLiquidazioni.ToString("0.00�") + " � inferiore al totale della fattura pari a " + totaleFattura.ToString("0.00�") + ". La fattura scade il  " + scadenza.ToString("dd/MM/yyyy");
                    stato = TypeState.Warning;
                }
                else if (statoFattura == Tipi.StatoFattura.Pagata)
                {
                    descrizione = "La fattura � stata liquidata";
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
                CalcolaTotali();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
