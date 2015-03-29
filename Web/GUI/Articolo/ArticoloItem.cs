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
                    var obj = (WcfService.Dto.ArticoloDto)model;
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var descrizione = UtilityValidation.GetStringND(obj.Descrizione);
                    var fattura = obj.Fattura;
                    var numeroFattura = UtilityValidation.GetStringND(fattura.Numero);
                    infoImage.Image = "Images.dashboard.articolo.png";
                    infoCodice.Text = "ART";
                    infoFattura.Text = "Fattura N." + numeroFattura;
                    infoDescrizione.Text = descrizione;
                    infoCodiceArticolo.Text = codice;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void ArticoloItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var obj = (WcfService.Dto.ArticoloDto)Model;
                    var space = new ArticoloModel();
                    space.Title = "ARTICOLO " + obj.Codice;
                    AddSpace(space);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }
	}
}
