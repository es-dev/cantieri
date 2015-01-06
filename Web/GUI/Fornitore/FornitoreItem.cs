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

namespace Web.GUI.Fornitore
{
	public partial class FornitoreItem : TemplateItem
	{
        public FornitoreItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.FornitoreDto)model;
                    infoImage.Image = "Images.dashboard.fornitore.png";
                    infoRagioneSociale.Text = obj.RagioneSociale;
                    infoPartitaIVA.Text = "P.IVA " +obj.PIva;
                    infoCodice.Text = obj.Codice;
                    infoCentroCosto.Text = obj.CodiceCentroCosto;
                    var commessa= obj.Commessa;
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

        private void FornitoreItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new FornitoreModel();
                    space.Title = "DETTAGLI FORNITORE";
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
