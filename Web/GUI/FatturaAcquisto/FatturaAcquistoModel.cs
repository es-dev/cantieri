using BusinessLogic;
using Library.Code;
using Library.Code.Enum;
using Library.Template.Controls;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.FatturaAcquisto
{
	public partial class FatturaAcquistoModel : TemplateModel
	{
        public FatturaAcquistoModel()
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
                editTipoPagamento.DisplayValues = UtilityEnum.GetDisplayValues<Tipi.TipoPagamento>(); ;
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
                    var obj = (WcfService.Dto.FatturaAcquistoDto)model;
                    infoSubtitleImage.Image = "Images.dashboard.fatturaacquisto.png";
                    infoSubtitle.Text = obj.Numero;
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
                    var obj = (WcfService.Dto.FatturaAcquistoDto)model;
                    editData.Value = obj.Data;
                    editDescrizione.Value = obj.Descrizione;
                    editImponibile.Value = obj.Imponibile; 
                    editIVA.Value = obj.IVA;               
                    editNumero.Value = obj.Numero;
                    editTipoPagamento.Value = obj.TipoPagamento;
                    editScadenzaPagamento.Value = obj.ScadenzaPagamento;
                    editTotale.Value = obj.Totale;
                    editTotalePagamenti.Value = obj.TotalePagamenti;
                    editStato.Value = obj.Stato;
                    var centroCosto=obj.CentroCosto;
                    if (centroCosto!=null)
                    {
                        editCentroCosto.Model = centroCosto;
                        editCentroCosto.Value = "(" + centroCosto.Codice + ") - " + centroCosto.Denominazione;
                    }
                    var fornitore = obj.Fornitore;
                    if (fornitore != null)
                    {
                        editFornitore.Model = fornitore;
                        editFornitore.Value = "(" + fornitore.Codice + ") - " + fornitore.RagioneSociale;
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
                    var obj = (WcfService.Dto.FatturaAcquistoDto)model;
                    obj.Data = editData.Value;
                    obj.Descrizione = editDescrizione.Value;
                    obj.Imponibile = editImponibile.Value;
                    obj.IVA = editIVA.Value;
                    obj.Numero = editNumero.Value;
                    obj.TipoPagamento = editTipoPagamento.Value;
                    obj.ScadenzaPagamento = editScadenzaPagamento.Value;
                    obj.Totale = editTotale.Value;
                    obj.TotalePagamenti = editTotalePagamenti.Value;
                    obj.Stato = editStato.Value;
                    var centroCosto = (WcfService.Dto.CentroCostoDto)editCentroCosto.Model;
                    if (centroCosto != null)
                        obj.CentroCostoId = centroCosto.Id;
                    var fornitore = (WcfService.Dto.FornitoreDto)editFornitore.Model;
                    if (fornitore != null)
                        obj.FornitoreId = fornitore.Id;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editFornitore_ComboClick()
        {
            try
            {
                var view = new Fornitore.FornitoreView();
                view.Title = "SELEZIONA UN FORNITORE";
                editFornitore.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editFornitore_ComboConfirm(object model)
        {
            try
            {
                var fornitore = (WcfService.Dto.FornitoreDto)model;
                if (fornitore != null)
                    editFornitore.Value = "(" + fornitore.Codice+ ") - " +fornitore.RagioneSociale;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCentroCosto_ComboClick()
        {
            try
            {
                var view = new CentroCosto.CentroCostoView();
                view.Title = "SELEZIONA UN CENTRO DI COSTO";
                editCentroCosto.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCentroCosto_ComboConfirm(object model)
        {
            try
            {
                var centroCosto = (WcfService.Dto.CentroCostoDto)model;
                if (centroCosto != null)
                    editCentroCosto.Value = "(" + centroCosto.Codice + ") - " + centroCosto.Denominazione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
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

        private void CalcolaTotali()
        {
            try
            {
                //prelievo dati da GUI
                var imponibile = UtilityValidation.GetDecimal(editImponibile.Value);
                var iva = UtilityValidation.GetDecimal(editIVA.Value);
                var data = editData.Value;
                var _scadenzaPagamento = editScadenzaPagamento.Value;
                var today= DateTime.Today;

                if (data != null)
                {
                    //prelievo dati da DB
                    var obj = (WcfService.Dto.FatturaAcquistoDto)Model;

                    var scadenzaPagamento = UtilityEnum.GetValue<Tipi.ScadenzaPagamento>(_scadenzaPagamento);
                    var scadenza = BusinessLogic.Fattura.GetScadenza(data.Value, scadenzaPagamento);
                    var totaleFattura = BusinessLogic.Fattura.GetTotale(imponibile, iva);
                    var totalePagamenti = BusinessLogic.Fattura.GetTotalePagamenti(obj, today);
                    var statoFattura = BusinessLogic.Fattura.GetStato(obj);

                    //valutazione dell'andamento del lavoro
                    var statoDescrizione = GetStatoDescrizione(today, scadenza, totaleFattura, totalePagamenti, statoFattura);

                    //binding dati in GUI
                    editStato.Value = statoDescrizione.ToString();
                    editTotale.Value = totaleFattura;
                    editTotalePagamenti.Value = totalePagamenti;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private StatoDescrizione GetStatoDescrizione(DateTime data, DateTime scadenza, decimal totaleFattura, decimal totalePagamenti, BusinessLogic.Tipi.StatoFattura statoFattura)
        {
            try
            {
                var stato = TypeStato.None;
                var descrizione = "";
                var ritardo = BusinessLogic.Fattura.GetRitardo(data, scadenza);
                if (statoFattura == Tipi.StatoFattura.Insoluta)
                {
                    descrizione = "La fattura risulta insoluta. Il totale pagamenti pari a " + totalePagamenti.ToString("0.00€") + " è inferiore al totale della fattura pari a " + totaleFattura.ToString("0.00€") + ". La fattura risulta scaduta il  " + scadenza.ToString("dd/MM/yyyy") + " con un ritardo di pagamento pari a " + ritardo;
                    stato = TypeStato.Critical;
                }
                else if (statoFattura == Tipi.StatoFattura.NonPagata)
                {
                    descrizione = "La fattura risulta in pagamento. Il totale pagamenti pari a " + totalePagamenti.ToString("0.00€") + " è inferiore al totale della fattura pari a " + totaleFattura.ToString("0.00€") + ". La fattura scade il  " + scadenza.ToString("dd/MM/yyyy");
                    stato = TypeStato.Warning;
                }
                else if (statoFattura == Tipi.StatoFattura.Pagata)
                {
                    descrizione = "La fattura è stata pagata";
                    stato = TypeStato.Normal;
                }
                var statoDescrizione = new StatoDescrizione(stato, descrizione);
                return statoDescrizione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
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


	}
}
