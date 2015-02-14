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
                    var numero = UtilityValidation.GetStringND(obj.Numero);
                    var descrizione = UtilityValidation.GetStringND(obj.Descrizione);
                    infoSubtitle.Text = numero + " - " + descrizione;
                    infoSubtitleImage.Image = "Images.dashboard.fatturaacquisto.png";
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
                    editNote.Value = obj.Note;
                    editTotale.Value = obj.Totale;
                    editTotalePagamenti.Value = GetTotalePagamenti(obj);
                    editStato.Value = obj.Stato;
                    var centroCosto = obj.CentroCosto;
                    if (centroCosto != null)
                    {
                        editCentroCosto.Model = centroCosto;
                        editCentroCosto.Value = "(" + centroCosto.Codice + ") - " + centroCosto.Denominazione;
                    }
                    var fornitore = obj.Fornitore;
                    if (fornitore != null)
                    {
                        editFornitore.Model = fornitore;
                        editFornitore.Value =  fornitore.Codice + " - " + fornitore.RagioneSociale;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private string GetStato(WcfService.Dto.FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                var stato = "N/D";
                var fornitoreId = fatturaAcquisto.FornitoreId;
                var viewModelFornitore = new Fornitore.FornitoreViewModel(this);
                var fornitore = viewModelFornitore.Read(fornitoreId);
                var commessa = fornitore.Commessa;
                var statoCommessa = commessa.Stato;
                if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                    stato =fatturaAcquisto.Stato;
                else
                {
                    var today = DateTime.Today;
                    var _scadenzaPagamento = fatturaAcquisto.ScadenzaPagamento;
                    var imponibile = UtilityValidation.GetDecimal(fatturaAcquisto.Imponibile);
                    var iva = UtilityValidation.GetDecimal(fatturaAcquisto.IVA);
                    var scadenzaPagamento = UtilityEnum.GetValue<Tipi.ScadenzaPagamento>(_scadenzaPagamento);
                    var scadenza = BusinessLogic.Fattura.GetScadenza(fatturaAcquisto);
                    var totaleFattura = BusinessLogic.Fattura.GetTotale(imponibile, iva);
                    var totalePagamenti = BusinessLogic.Fattura.GetTotalePagamenti(fatturaAcquisto, today);
                    var statoFattura = BusinessLogic.Fattura.GetStato(fatturaAcquisto);

                    var statoDescrizione = GetStato(today, scadenza, totaleFattura, totalePagamenti, statoFattura);
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

        private decimal GetTotalePagamenti(WcfService.Dto.FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                decimal totalePagamenti= 0;
                var fornitoreId = fatturaAcquisto.FornitoreId;
                var viewModelFornitore = new Fornitore.FornitoreViewModel(this);
                var fornitore = viewModelFornitore.Read(fornitoreId);
                var commessa = fornitore.Commessa;
                var statoCommessa = commessa.Stato;
                if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                    totalePagamenti = UtilityValidation.GetDecimal(fatturaAcquisto.TotalePagamenti);
                else
                {
                    var today = DateTime.Today;
                    totalePagamenti = BusinessLogic.Fattura.GetTotalePagamenti(fatturaAcquisto, today);
                }
                return totalePagamenti;
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
                    var obj = (WcfService.Dto.FatturaAcquistoDto)model;
                    obj.Data = editData.Value;
                    obj.Descrizione = editDescrizione.Value;
                    obj.Imponibile = editImponibile.Value;
                    obj.IVA = editIVA.Value;
                    obj.Numero = editNumero.Value;
                    obj.TipoPagamento = editTipoPagamento.Value;
                    obj.ScadenzaPagamento = editScadenzaPagamento.Value;
                    obj.Totale = editTotale.Value;
                    obj.Note = editNote.Value;
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
                    editFornitore.Value =  fornitore.Codice+ " - " +fornitore.RagioneSociale;
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
                    editCentroCosto.Value = centroCosto.Codice + " - " + centroCosto.Denominazione;
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
                if(Editing)
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
                var today= DateTime.Today;

                if (data != null)
                {
                    var obj = (WcfService.Dto.FatturaAcquistoDto)Model;
                    var scadenza = BusinessLogic.Fattura.GetScadenza(obj);
                    var totaleFattura = BusinessLogic.Fattura.GetTotale(imponibile, iva);
                    var totalePagamenti = BusinessLogic.Fattura.GetTotalePagamenti(obj, today);
                    var statoFattura = BusinessLogic.Fattura.GetStato(obj);
                    var stato = GetStato(today, scadenza, totaleFattura, totalePagamenti, statoFattura);

                    editStato.Value = stato.ToString();
                    editTotale.Value = totaleFattura;
                    editTotalePagamenti.Value = totalePagamenti;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private StateDescriptionImage GetStato(DateTime data, DateTime scadenza, decimal totaleFattura, decimal totalePagamenti, BusinessLogic.Tipi.StatoFattura statoFattura)
        {
            try
            {
                var stato = TypeState.None;
                var descrizione = "";
                var ritardo = BusinessLogic.Fattura.GetRitardo(data, scadenza);
                var _totalePagamenti = UtilityValidation.GetEuro(totalePagamenti);
                var _totaleFattura = UtilityValidation.GetEuro(totaleFattura);
                var _scadenza = UtilityValidation.GetDataND(scadenza);

                if (statoFattura == Tipi.StatoFattura.Insoluta)
                {
                    descrizione = "La fattura risulta insoluta. Il totale pagamenti pari a " + _totalePagamenti + " è inferiore al totale della fattura pari a " + _totaleFattura + ". La fattura risulta scaduta il " + _scadenza+ " con un ritardo di pagamento pari a " + ritardo;
                    stato = TypeState.Critical;
                }
                else if (statoFattura == Tipi.StatoFattura.NonPagata)
                {
                    descrizione = "La fattura risulta in pagamento. Il totale pagamenti pari a " + _totalePagamenti + " è inferiore al totale della fattura pari a " + _totaleFattura + ". La fattura scade il " + _scadenza;
                    stato = TypeState.Warning;
                }
                else if (statoFattura == Tipi.StatoFattura.Pagata)
                {
                    descrizione = "La fattura è stata pagata";
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
