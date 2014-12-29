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
                    infoDenominazione.Text = obj.Denominazione;
                    infoData.Text = obj.Data.ToString();
                    var commessa = obj.Commessa;
                    if (commessa != null)
                    {
                        infoCommesssa.Text = commessa.Denominazione;
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
