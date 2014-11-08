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

namespace Web.GUI.Comune
{
	public partial class AziendaItem : TemplateItem
	{
        public AziendaItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.ComuneDto)model;
                    infoComune.Text = obj.Nome + " (" + obj.Provincia + ")";
                    infoDescrizione.Text = "Numero Sezioni: " + obj.NumeroSezioni.ToString();

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void ComuneItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new AziendaModel();
                    space.Title = "DETTAGLI COMUNE";
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
