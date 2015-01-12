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
                var obj = (WcfService.Dto.AnagraficaArticoloDto)model;
                infoSubtitleImage.Image = "Images.dashboard.anagraficaarticolo.png";
                infoSubtitle.Text = obj.Codice;
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
                var obj = (WcfService.Dto.AnagraficaArticoloDto)model;
                obj.Codice = editCodice.Value;
                obj.Descrizione = editDescrizione.Value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
