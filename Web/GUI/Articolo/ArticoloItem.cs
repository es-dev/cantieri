using Library.Code;
using Library.Interfaces;
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
	public partial class ArticoloItem : TemplateItem
	{
        public ArticoloItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (ArticoloDto)model;
                    var fatturaAcquisto = obj.FatturaAcquisto;
                    infoImage.Image = "Images.dashboard.articolo.png";
                    infoCodice.Text = "ART";
                    infoFattura.Text = BusinessLogic.Fattura.GetCodifica(fatturaAcquisto);
                  
                    var anagraficaArticolo = obj.AnagraficaArticolo;
                    infoDescrizione.Text = (anagraficaArticolo != null ? anagraficaArticolo.Descrizione : null);
                    infoCodiceArticolo.Text = (anagraficaArticolo!=null? anagraficaArticolo.Codice:null);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
	}
}
