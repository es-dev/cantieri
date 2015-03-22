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

        public override void BindViewSubTitle(object model)
        {
            try
            {
                var obj = (ResoDto)model;
                var codice = UtilityValidation.GetStringND(obj.Codice);
                var descrizione = UtilityValidation.GetStringND(obj.Descrizione);
                infoSubtitle.Text = codice + " - " + descrizione;
                infoSubtitleImage.Image = "Images.dashboard.reso.png";
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
                editNotaCredito.Value = (notaCredito != null ? notaCredito.Numero + " del " + notaCredito.Data.Value.ToString("dd/MM/yyyy") : null);
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
                var fatturaAcquisto = (FatturaAcquistoDto)model;
                if (fatturaAcquisto != null)
                {
                    editFatturaAcquisto.Value = fatturaAcquisto.Numero + " del " + fatturaAcquisto.Data.Value.ToString("dd/MM/yyyy");
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void ResoModel_Load(object sender, EventArgs e)
        {
            try
            {
                var obj = (ResoDto)Model;
                if (obj != null && obj.Id == 0)
                    SetNewValue();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private void SetNewValue()
        {
            try
            {
                if (notaCredito!=null)
                {
                    editNotaCredito.Model = notaCredito;
                    editNotaCredito.Value = notaCredito.Numero + " del " + notaCredito.Data.Value.ToString("dd/MM/yyyy"); 
                }
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
                view.Title = "SELEZIONA LA NOTA DI CREDITO";
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
                if (notaCredito != null)
                {
                    editNotaCredito.Value = notaCredito.Numero + " del " + notaCredito.Data.Value.ToString("dd/MM/yyyy");
                    var obj = (ResoDto)Model;
                    if (obj != null && obj.Id == 0)
                    {
                        var codice = BusinessLogic.Reso.GetCodice(notaCredito);
                        editCodice.Value = codice;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editImportoIVA_Leave(object sender, EventArgs e)
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

	}
}
