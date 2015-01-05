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

namespace Web.GUI.AnagraficaCliente
{
	public partial class AnagraficaClienteItem : TemplateItem
	{
        public AnagraficaClienteItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.AnagraficaClienteDto)model;
                    infoImage.Image = "Images.dashboard.anagraficacliente.png";
                    infoRagioneSociale.Text = obj.RagioneSociale;
                    infoCodice.Text = obj.Codice;
                    infoPartitaIVA.Text = "P.IVA" + obj.PIva;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void AnagraficaClienteItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new AnagraficaClienteModel();
                    space.Title = "DETTAGLI ANAGRAFICA CLIENTE";
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
