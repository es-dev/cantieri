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

namespace Web.GUI.Liquidazione
{
	public partial class LiquidazioneItem : TemplateItem
	{
        public LiquidazioneItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.LiquidazioneDto)model;

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void LiquidazioneItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new LiquidazioneModel();
                    space.Title = "DETTAGLI LIQUIDAZIONE";
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
