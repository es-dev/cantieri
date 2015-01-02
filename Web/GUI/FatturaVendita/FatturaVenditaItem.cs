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

namespace Web.GUI.FatturaVendita
{
	public partial class FatturaVenditaItem : TemplateItem
	{
        public FatturaVenditaItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.FatturaVenditaDto)model;
                    infoCodice.Text = "FV";
                    infoNumero.Text = obj.Numero;
                    infoData.Text = (obj.Data != null ? obj.Data.Value.ToString("dd/MM/yyyy") : "Non Impostata");
                    infoDescrizione.Text = obj.Descrizione;
                    var cliente = obj.Cliente;
                    if (cliente != null)
                        infoCliente.Text = cliente.RagioneSociale;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void FatturaVenditaItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new FatturaVenditaModel();
                    space.Title = "DETTAGLI FATTURA VENDITA";
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
