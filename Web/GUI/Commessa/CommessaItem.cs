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

namespace Web.GUI.Commessa
{
	public partial class CommessaItem : TemplateItem
	{
        public CommessaItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.CommessaDto)model;
                    infoDenominazione.Text = obj.Denominazione;
                    var azienda = obj.Azienda;
                    if (azienda != null)
                        infoAzienda.Text = azienda.Denominazione;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void CommessaItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new CommessaModel();
                    space.Title = "DETTAGLI COMMESSA";
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
