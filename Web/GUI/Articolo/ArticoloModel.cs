using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WcfService.Dto;
using Web.Code;

namespace Web.GUI.Articolo
{
	public partial class ArticoloModel : TemplateModel
	{
        public ArticoloModel()
		{
			InitializeComponent();
		}

        public override void BindViewTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.ArticoloDto)model;
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var descrizione = UtilityValidation.GetStringND(obj.Descrizione);
                    infoSubtitle.Text = codice + " - " + descrizione;
                    infoSubtitleImage.Image = "Images.dashboard.articolo.png";
                    infoTitle.Text = (obj.Id!=0? "ARTICOLO " + obj.Codice:"NUOVO ARTICOLO");
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
                    var obj = (WcfService.Dto.ArticoloDto)model;
                    editCosto.Value = obj.Costo;
                    editCodice.Value = obj.Codice;
                    editDescrizione.Value = obj.Descrizione;
                    editPrezzounitario.Value = obj.PrezzoUnitario;
                    editImporto.Value = obj.Importo;
                    editIVA.Value = obj.IVA;
                    editQuantita.Value = obj.Quantita;
                    editSconto.Value = obj.Sconto;
                    editTotale.Value = obj.Totale;
                    editNote.Value = obj.Note;

                    BindViewFatturaAcquisto(obj.Fattura);
                }
            }
            catch (Exception ex) 
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewFatturaAcquisto(WcfService.Dto.FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                editFatturaAcquisto.Model = fatturaAcquisto;
                editFatturaAcquisto.Value = (fatturaAcquisto != null ? fatturaAcquisto.Numero + " del " + fatturaAcquisto.Data.Value.ToString("dd/MM/yyyy") : null);
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
                    var obj = (WcfService.Dto.ArticoloDto)model;
                    obj.Costo = editCosto.Value;
                    obj.Codice = editCodice.Value;
                    obj.PrezzoUnitario = editPrezzounitario.Value;
                    obj.Descrizione = editDescrizione.Value;
                    obj.Importo = editImporto.Value;
                    obj.IVA = editIVA.Value;
                    obj.Quantita = editQuantita.Value;
                    obj.Sconto = editSconto.Value;
                    obj.Totale = editTotale.Value;
                    obj.Note = editNote.Value;
                    var fatturaAcquisto = (WcfService.Dto.FatturaAcquistoDto)editFatturaAcquisto.Model;
                    if(fatturaAcquisto!=null)
                        obj.FatturaAcquistoId = fatturaAcquisto.Id;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editFatturaAcquisto_ComboClick()
        {
            try
            {
                var view = new FatturaAcquisto.FatturaAcquistoView();
                view.Title = "SELEZIONA LA FATTURA DI ACQUISTO";
                editFatturaAcquisto.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editFatturaAcquisto_ComboConfirm(object model)
        {
            try
            {
                var fatturaAcquisto = (WcfService.Dto.FatturaAcquistoDto)model;
                BindViewFatturaAcquisto(fatturaAcquisto);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCodice_ComboClick()
        {
            try
            {
                var view = new AnagraficaArticolo.AnagraficaArticoloView();
                view.Title = "SELEZIONA UN ARTICOLO";
                editCodice.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCodice_ComboConfirm(object model)
        {
            try
            {
                var anagraficaArticolo = (WcfService.Dto.AnagraficaArticoloDto)model;
                if (anagraficaArticolo != null)
                {
                    editCodice.Value = anagraficaArticolo.Codice;
                    editDescrizione.Value = anagraficaArticolo.Descrizione;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editQuantitaPrezzoUnitario_Leave(object sender, EventArgs e)
        {
            try
            {
                var quantita = UtilityValidation.GetDecimal(editQuantita.Value);
                var prezzoUnitario = UtilityValidation.GetDecimal(editPrezzounitario.Value);
                var importo = BusinessLogic.Articolo.GetImporto(quantita, prezzoUnitario);
                editImporto.Value = importo;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private void editImportoSconto_Leave(object sender, EventArgs e)
        {
            try
            {
                var importo = UtilityValidation.GetDecimal(editImporto.Value);
                var sconto = UtilityValidation.GetDecimal(editSconto.Value);
                var costo = BusinessLogic.Articolo.GetCosto(importo, sconto);
                editCosto.Value = costo;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCostoIVA_Leave(object sender, EventArgs e)
        {
            try
            {
                var costo = UtilityValidation.GetDecimal(editCosto.Value);
                var iva = UtilityValidation.GetDecimal(editIVA.Value);
                var totale = BusinessLogic.Articolo.GetTotale(costo, iva);
                editTotale.Value = totale;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
    }
}
