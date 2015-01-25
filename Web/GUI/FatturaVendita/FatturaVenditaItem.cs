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
                    infoImage.Image = "Images.dashboard.fatturavendita.png";
                    infoCodice.Text = "FV";
                    var numero = "N/D";
                    if (obj.Numero != null)
                        numero = obj.Numero;
                    infoNumero.Text = "Fattura N. " + numero;
                    var data = "N/D";
                    if (obj.Data != null)
                        data = obj.Data.Value.ToString("dd/MM/yyyy");
                    infoData.Text = "Data: " + data;
                    //todo: da verificare--> infoDescrizione.Text = obj.Descrizione;
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
                    space.Title = "DETTAGLI FATTURA DI VENDITA";
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
