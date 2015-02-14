using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.AnagraficaArticolo
{
	public partial class AnagraficaArticoloModel : TemplateModel
	{
        public AnagraficaArticoloModel()
		{
			InitializeComponent();
		}

        public override void BindViewSubTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.AnagraficaArticoloDto)model;
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var descrizione = UtilityValidation.GetStringND(obj.Descrizione);
                    infoSubtitle.Text = codice + " - " + descrizione;
                    infoSubtitleImage.Image = "Images.dashboard.anagraficaarticolo.png";
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
                    var obj = (WcfService.Dto.AnagraficaArticoloDto)model;
                    editCodice.Value = obj.Codice;
                    editDescrizione.Value = obj.Descrizione;
                    editNote.Value = obj.Note;
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
                    var obj = (WcfService.Dto.AnagraficaArticoloDto)model;
                    obj.Codice = editCodice.Value;
                    obj.Descrizione = editDescrizione.Value;
                    obj.Note = editNote.Value;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
