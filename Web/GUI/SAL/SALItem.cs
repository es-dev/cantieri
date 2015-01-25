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

namespace Web.GUI.SAL
{
	public partial class SALItem : TemplateItem
	{
        public SALItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.SALDto)model;
                    infoImage.Image = "Images.dashboard.SAL.png";
                    infoDenominazione.Text = obj.Denominazione;
                    var data = "N/D";
                    if (obj.Data != null)
                        data = obj.Data.Value.ToString("dd/MM/yyyy");
                    infoData.Text = "Data: " + data;
                    var commessa = obj.Commessa;
                    if (commessa != null)
                    {
                        infoCommesssa.Text = "Commessa (" + commessa.Codice + ") - " + commessa.Denominazione;
                    }

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SALItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new SALModel();
                    space.Title = "DETTAGLI SAL";
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
