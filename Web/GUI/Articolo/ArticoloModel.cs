using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.Articolo
{
	public partial class ArticoloModel : TemplateModel
	{
        public ArticoloModel()
		{
			InitializeComponent();
		}

        public override void BindViewSubTitle(object model)
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
                    editCodiceArticolo.Value = obj.Codice;
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
                    obj.Codice = editCodiceArticolo.Value;
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
                if (fatturaAcquisto != null)
                    editFatturaAcquisto.Value = fatturaAcquisto.Numero + " del " + fatturaAcquisto.Data.Value.ToString("dd/MM/yyyy");
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
                editCodiceArticolo.Show(view);
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
                    editCodiceArticolo.Value = anagraficaArticolo.Codice;
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
                var quantita = editQuantita.Value;
                var prezzoUnitario = editPrezzounitario.Value;
                if (quantita != null && prezzoUnitario != null)
                {
                    var importo = BusinessLogic.Articolo.GetImporto((decimal)quantita, (decimal)prezzoUnitario);
                    editImporto.Value = importo;
                }
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
                var importo = editImporto.Value;
                var sconto = editSconto.Value;
                if (importo != null && sconto != null)
                {
                    //da una variabile decimal? puoi prelevare i valori dopo il controllo nullità, o mediante cast, o medinate .Value
                    var costo = BusinessLogic.Articolo.GetCosto((decimal)importo, (decimal)sconto);
                    editCosto.Value = costo;
                }
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
                var costo = editCosto.Value;
                var iva = editIVA.Value;
                if (costo != null && iva != null)
                {
                    var totale = BusinessLogic.Articolo.GetTotale((decimal)costo, (decimal)iva);
                    editTotale.Value = totale;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
