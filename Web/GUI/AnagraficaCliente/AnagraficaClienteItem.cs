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
                    var ragioneSociale = UtilityValidation.GetStringND(obj.RagioneSociale);
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var partitaIVA = UtilityValidation.GetStringND(obj.PartitaIva);
                    var indirizzo = UtilityValidation.GetStringND(obj.Indirizzo);
                    var cap = UtilityValidation.GetStringND(obj.CAP);
                    var comune = UtilityValidation.GetStringND(obj.Comune);
                    var provincia = UtilityValidation.GetStringND(obj.Provincia);
                    infoImage.Image = "Images.dashboard.anagraficacliente.png";
                    infoRagioneSociale.Text = ragioneSociale;
                    infoCodice.Text = codice;
                    infoPartitaIVA.Text = "P.IVA " + partitaIVA;
                    infoIndirizzo.Text = indirizzo + " - " + cap + " - " + comune + " (" + provincia + ")";
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
                    var obj = (WcfService.Dto.AnagraficaClienteDto)Model;
                    var space = new AnagraficaClienteModel();
                    space.Title = "ANAGRAFICA COMMITTENTE " + obj.RagioneSociale;
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
