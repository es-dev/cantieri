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

namespace Web.GUI.CentroCosto
{
	public partial class CentroCostoItem : TemplateItem
	{
        public CentroCostoItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.CentroCostoDto)model;
                    infoImage.Image = "Images.dashboard.centrocosto.png";
                    infoCodice.Text = "CC";
                    infoDenominazione.Text = obj.Denominazione;
                    infoCodiceCentroCosto.Text = obj.Codice;

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void CentroCostoItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new CentroCostoModel();
                    space.Title = "DETTAGLI CENTRO DI COSTO";
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
