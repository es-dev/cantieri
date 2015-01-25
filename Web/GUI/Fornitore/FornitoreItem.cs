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
                    var ragioneSociale = "Non definito";
                    if (obj.RagioneSociale != null)
                        ragioneSociale = obj.RagioneSociale;
                    infoRagioneSociale.Text = ragioneSociale;
                    var codice = "N/D";
                    if (obj.Codice != null)
                        codice = obj.Codice;
                    infoCodice.Text = codice;
                    var pIva = "N/D";
                    if (obj.PIva != null)
                        pIva = obj.PIva;
                    infoPartitaIVA.Text = "P.IVA " + pIva;
                    var commessa = obj.Commessa;
                    if (commessa != null)
                    {
                        infoCommesssa.Text ="Commessa ("+ commessa.Codice +") "+ commessa.Denominazione;
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
