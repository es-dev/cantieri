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
        private FatturaAcquistoDto  fatturaAcquisto = null;

        public ArticoloModel()
		{
			InitializeComponent();
		}

        public ArticoloModel(FatturaAcquistoDto fatturaAcquisto)
        {
            InitializeComponent();
            try
            {
                this.fatturaAcquisto = fatturaAcquisto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
        public override void BindViewTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (ArticoloDto)model;
                    infoSubtitle.Text = BusinessLogic.Articolo.GetCodifica(obj);
                    infoSubtitleImage.Image = "Images.dashboard.articolo.png";
                    infoTitle.Text = (obj.Id != 0 ? "ARTICOLO " + BusinessLogic.Articolo.GetCodifica(obj) : "NUOVO ARTICOLO") + " | FATTURA "+
                        BusinessLogic.Fattura.GetCodifica(obj.FatturaAcquisto);
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
                    var obj = (ArticoloDto)model;
                    editCosto.Value = obj.Costo;
                    editPrezzounitario.Value = obj.PrezzoUnitario;
                    editImporto.Value = obj.Importo;
                    editIVA.Value = obj.IVA;
                    editQuantita.Value = obj.Quantita;
                    editSconto.Value = obj.Sconto;
                    editTotale.Value = obj.Totale;
                    editNote.Value = obj.Note;

                    BindViewAnagraficaArticolo(obj.AnagraficaArticolo);
                    BindViewFatturaAcquisto(obj.FatturaAcquisto);
                    BindViewTotali();
                }
            }
            catch (Exception ex) 
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewFatturaAcquisto(FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                editFatturaAcquisto.Model = fatturaAcquisto;
                editFatturaAcquisto.Value = BusinessLogic.Fattura.GetCodifica(fatturaAcquisto);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            
        }

        private void BindViewAnagraficaArticolo(AnagraficaArticoloDto anagraficaArticolo)
        {
            try
            {
                editCodice.Model = anagraficaArticolo;
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

        public override void BindModel(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (ArticoloDto)model;
                    obj.Costo = editCosto.Value;
                    obj.PrezzoUnitario = editPrezzounitario.Value;
                    obj.Importo = editImporto.Value;
                    obj.IVA = editIVA.Value;
                    obj.Quantita = editQuantita.Value;
                    obj.Sconto = editSconto.Value;
                    obj.Totale = editTotale.Value;
                    obj.Note = editNote.Value;

                    var fatturaAcquisto = (FatturaAcquistoDto)editFatturaAcquisto.Model;
                    if(fatturaAcquisto!=null)
                        obj.FatturaAcquistoId = fatturaAcquisto.Id;

                    var anagraficaArticolo = (AnagraficaArticoloDto)editCodice.Model;
                    if (anagraficaArticolo != null)
                        obj.AnagraficaArticoloId = anagraficaArticolo.Id;
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
                view.Title = "SELEZIONA UNA FATTURA ACQUISTO";
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
                var fatturaAcquisto = (FatturaAcquistoDto)model;
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
                var anagraficaArticolo = (AnagraficaArticoloDto)model;
                BindViewAnagraficaArticolo(anagraficaArticolo);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewTotali()
        {
            try
            {
                var quantita = UtilityValidation.GetDecimal(editQuantita.Value);
                var prezzoUnitario = UtilityValidation.GetDecimal(editPrezzounitario.Value);
                var importo = BusinessLogic.Articolo.GetImporto(quantita, prezzoUnitario);
                var sconto = UtilityValidation.GetDecimal(editSconto.Value);
                var costo = BusinessLogic.Articolo.GetCosto(importo, sconto);
                var iva = UtilityValidation.GetDecimal(editIVA.Value);
                var totale = BusinessLogic.Articolo.GetTotale(costo, iva);
                editImporto.Value = importo;
                editCosto.Value = costo;
                editTotale.Value = totale;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }
        
        public override void SetNewValue(object model)
        {
            try
            {
                BindViewFatturaAcquisto(fatturaAcquisto);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editTotali_Leave(object sender, EventArgs e)
        {
            try
            {
                BindViewTotali();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
    }
}
