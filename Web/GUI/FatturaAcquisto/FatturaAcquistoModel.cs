using BusinessLogic;
using Library.Code;
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
                var tipiPagamenti = Tipi.GetNames(typeof(Tipi.TipoPagamento));
                editTipoPagamento.Items = tipiPagamenti;
                var scadenzaPagamenti = Tipi.GetNames(typeof(Tipi.ScadenzaPagamento));
                editScadenzaPagamento.Items = scadenzaPagamenti;
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
                    var centroCosto = (WcfService.Dto.CentroCostoDto)editCentroCosto.Model;
                    if(centroCosto!=null)
                        obj.CentroCostoId = centroCosto.Id;
                    var fornitore = (WcfService.Dto.FornitoreDto)editFornitore.Model;
                    if(fornitore!=null)
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
                var imponibile = editImponibile.Value;
                var iva = editIVA.Value;
                if (imponibile != null && iva != null)
                {
                    var totale = BusinessLogic.Fattura.GetTotale((decimal)imponibile, (decimal)iva);
                    editTotale.Value = totale;
                }
                //prelievo valori da grafica in variabili var xxx = editControl.Value
                //invio i dati a BL per calcolo e restituzione valori  ver tot = BL.GetXXXXXX
                //impostazione dei dati in grafica  editControl.Value = tot
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }



	}
}
