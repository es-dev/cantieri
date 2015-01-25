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
                        infoCommesssa.Text = "Commessa (" + commessa.Codice + ") " + commessa.Denominazione;
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
