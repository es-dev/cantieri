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
                    infoCodice.Text = "CA";
                    infoCodiceArticolo.Text = obj.Codice;
                    infoDescrizione.Text = obj.Descrizione;
                    var fattura = obj.Fattura;
                    if (fattura != null)
                        infoFattura.Text = "Fattura N. " + fattura.Numero;
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
                    var space = new ArticoloModel();
                    space.Title = "DETTAGLI ARTICOLO";
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
