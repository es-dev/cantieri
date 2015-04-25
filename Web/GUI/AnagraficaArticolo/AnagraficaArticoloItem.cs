using Library.Code;
using Library.Interfaces;
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
	public partial class AnagraficaArticoloItem : TemplateItem
	{
        public AnagraficaArticoloItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.AnagraficaArticoloDto)model;
                    var codice = UtilityValidation.GetStringND(obj.Codice);

                    infoImage.Image = "Images.dashboard.anagraficaarticolo.png";
                    infoCodice.Text = "CA";
                    infoCodiceArticolo.Text = "CODICE ARTICOLO: " + codice;
                    infoDescrizione.Text = obj.Descrizione;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        
	}
}
