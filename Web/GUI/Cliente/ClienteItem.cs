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

namespace Web.GUI.Cliente
{
	public partial class ClienteItem : TemplateItem
	{
        public ClienteItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.ClienteDto)model;
                    infoImage.Image = "Images.dashboard.cliente.png";
                    infoRagioneSociale.Text = obj.RagioneSociale;
                    infoPartitaIVA.Text ="P.IVA" +obj.PIva;
                    infoCodice.Text = obj.Codice;
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

        private void ClienteItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new ClienteModel();
                    space.Title = "DETTAGLI CLIENTE";
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
