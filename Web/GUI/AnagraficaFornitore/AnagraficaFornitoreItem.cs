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

namespace Web.GUI.AnagraficaFornitore
{
	public partial class AnagraficaFornitoreItem : TemplateItem
	{
        public AnagraficaFornitoreItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.AnagraficaFornitoreDto)model;

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void AnagraficaFornitoreItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new AnagraficaFornitoreModel();
                    space.Title = "DETTAGLI ANAGRAFICA FORNITORE";
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
