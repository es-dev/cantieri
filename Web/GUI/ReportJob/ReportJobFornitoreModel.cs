using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.ReportJob
{
	public partial class ReportJobFornitoreModel : TemplateModel
	{
        public ReportJobFornitoreModel()
		{
			InitializeComponent();
		}

        public override void BindViewSubTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.ReportJobDto)model;
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    infoSubtitle.Text = codice;
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
                    var obj = (WcfService.Dto.ReportJobDto)model;
                    editFornitore.Value = obj.CodiceFornitore;
                    editDenominazione.Value = obj.Denominazione;
                    editCodice.Value = obj.Codice;
                    editNote.Value = obj.Note;
                    editCreazione.Value = obj.Creazione;
                    editElaborazione.Value = obj.Elaborazione;
                    editTipoReport.Value = obj.Tipo;
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
                    var obj = (WcfService.Dto.ReportJobDto)model;
                    obj.CodiceFornitore = editFornitore.Value;
                    obj.Denominazione = editDenominazione.Value;
                    obj.Codice = editCodice.Value;
                    obj.Note= editNote.Value;
                    obj.Creazione = editCreazione.Value;
                    obj.Elaborazione = editElaborazione.Value;
                    obj.Tipo = editTipoReport.Value;
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
                var view = new AnagraficaFornitore.AnagraficaFornitoreView();
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
                var anagraficaFornitore = (WcfService.Dto.AnagraficaFornitoreDto)model;
                if (anagraficaFornitore != null)
                {
                    editFornitore.Value = anagraficaFornitore.Codice + " - " + anagraficaFornitore.RagioneSociale;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


	}
}
