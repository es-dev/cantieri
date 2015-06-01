using BusinessLogic;
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
using Web.GUI.FatturaAcquisto;

namespace Web.GUI.Reso
{
	public partial class ResoModel : TemplateModel
	{
        private NotaCreditoDto notaCredito = null;
        public ResoModel()
		{
			InitializeComponent();
		}

        public ResoModel(NotaCreditoDto notaCredito)
        {
            InitializeComponent();
            try
            {
                this.notaCredito = notaCredito;
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
                var obj = (ResoDto)model;
                infoSubtitle.Text = BusinessLogic.Reso.GetCodifica(obj);
                infoSubtitleImage.Image = "Images.dashboard.reso.png";
                infoTitle.Text = (obj.Id != 0 ? "RESO " + obj.Codice : "NUOVO RESO") + " / NOTA CREDITO " + BusinessLogic.Fattura.GetCodifica(obj.NotaCredito);
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
                    var obj = (ResoDto)model;
                    editCodice.Value = obj.Codice;
                    editData.Value = obj.Data;
                    editNote.Value = obj.Note;
                    editImporto.Value = obj.Importo;
                    editDescrizione.Value = obj.Descrizione;
                    editIVA.Value = obj.IVA;
                    editTotale.Value = obj.Totale;

                    BindViewFatturaAcquisto(obj.FatturaAcquisto);
                    BindViewNotaCredito(obj.NotaCredito);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewNotaCredito(NotaCreditoDto notaCredito)
        {
            try
            {
                editNotaCredito.Model = notaCredito;
                editNotaCredito.Value = BusinessLogic.Fattura.GetCodifica(notaCredito);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewCodiceNotaCredito(NotaCreditoDto notaCredito)
        {
            try
            {
                var codice = BusinessLogic.Reso.GetCodice(notaCredito);
                editCodice.Value = codice;

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
                var fatturaAcquistoFornitore = BusinessLogic.Fattura.GetCodifica(fatturaAcquisto);
                if (fatturaAcquisto != null)
                {
                    var fornitore = fatturaAcquisto.Fornitore;
                    fatturaAcquistoFornitore += " | FORNITORE " + BusinessLogic.Fornitore.GetCodifica(fornitore);
                }
                editFatturaAcquisto.Value = fatturaAcquistoFornitore;
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
                var importo = UtilityValidation.GetDecimal(editImporto.Value);
                var iva = UtilityValidation.GetDecimal(editIVA.Value);
                var totale = BusinessLogic.Fattura.GetTotale(importo, iva);
                editTotale.Value = totale;
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
                    var obj = (ResoDto)model;
                    obj.Codice = editCodice.Value;
                    obj.Data = editData.Value;
                    obj.Importo = editImporto.Value;
                    obj.IVA = editIVA.Value;
                    obj.Totale = editTotale.Value;
                    obj.Note = editNote.Value;
                    obj.Descrizione = editDescrizione.Value;

                    var fatturaAcquisto = (FatturaAcquistoDto)editFatturaAcquisto.Model;
                    if(fatturaAcquisto!=null)
                        obj.FatturaAcquistoId = fatturaAcquisto.Id;

                    var notaCredito = (NotaCreditoDto)editNotaCredito.Model;
                    if (notaCredito != null)
                        obj.NotaCreditoId = notaCredito.Id;
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
                var notaCredito = (NotaCreditoDto)editNotaCredito.Model;
                if (notaCredito != null)
                {
                    var fornitore = notaCredito.Fornitore;
                    var anagraficaFornitore = fornitore.AnagraficaFornitore;
                    var view = new FatturaAcquisto.FatturaAcquistoView(anagraficaFornitore, Tipi.StatoFattura.NonPagata | Tipi.StatoFattura.Insoluta);
                    view.Title = "SELEZIONA UNA FATTURA DI ACQUISTO";
                    editFatturaAcquisto.Show(view);
                }
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

       

        private void editNotaCredito_ComboClick()
        {
            try
            {
                var view = new NotaCredito.NotaCreditoView();
                view.Title = "SELEZIONA UNA NOTA DI CREDITO";
                editNotaCredito.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editNotaCredito_ComboConfirm(object model)
        {
            try
            {
                var notaCredito = (NotaCreditoDto)model;
                BindViewNotaCredito(notaCredito);
                BindViewCodiceNotaCredito(notaCredito);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editTotale_Leave(object sender, EventArgs e)
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

        public override void SetNewValue(object model)
        {
            try
            {
                BindViewNotaCredito(notaCredito);
                BindViewCodiceNotaCredito(notaCredito);

                editData.Value = DateTime.Now;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
