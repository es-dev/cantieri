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
                    infoSubtitleImage.Image = "Images.dashboard.articolo.png";
                    infoSubtitle.Text = obj.Codice;
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
                    var fatturaAcquisto = obj.Fattura;
                    if (fatturaAcquisto != null)
                    {
                        editFatturaAcquisto.Model = fatturaAcquisto;
                        editFatturaAcquisto.Value = fatturaAcquisto.Numero;
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
                    obj.FatturaId = (int)editFatturaAcquisto.Id;
                    obj.Fattura = (WcfService.Dto.FatturaAcquistoDto)editFatturaAcquisto.Model;
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
                    editFatturaAcquisto.Value = fatturaAcquisto.Numero;
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
                var quantita = (decimal)editQuantita.Value;
                var prezzoUnitario = (decimal)editPrezzounitario.Value;
                if (quantita != null && prezzoUnitario != null)
                {
                    var importo = BusinessLogic.Articolo.GetImporto(quantita, prezzoUnitario);
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
                var importo = (decimal)editImporto.Value;
                var sconto = (decimal)editSconto.Value;
                if (importo != null && sconto != null)
                {
                    var costo = BusinessLogic.Articolo.GetCosto(importo, sconto);
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
                var costo = (decimal)editCosto.Value;
                var iva = (decimal)editIVA.Value;
                if (costo != null && iva != null)
                {
                    var totale = BusinessLogic.Articolo.GetTotale(costo, iva);
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
