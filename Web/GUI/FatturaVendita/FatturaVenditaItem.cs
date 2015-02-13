using BusinessLogic;
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
                    var data = "N/D";
                    if (obj.Data != null)
                        data = obj.Data.Value.ToString("dd/MM/yyyy");
                    infoNumeroData.Text = "Fattura N." + numero + " del " + data;
                    var cliente = obj.Cliente;
                    if (cliente != null)
                        infoCliente.Text = cliente.RagioneSociale;

                    var today = DateTime.Today;
                    var totaleFattura = "N/D";
                    if (obj.Totale != null)
                        totaleFattura = obj.Totale.Value.ToString("0.00") + "€";
                    var totaleLiquidazioni = BusinessLogic.Fattura.GetTotaleLiquidazioni(obj, today);
                    infoLiquidazioneTotale.Text = "Incassato " + totaleLiquidazioni.ToString("0.00") + "€ su un totale di " + totaleFattura;

                    var stato = BusinessLogic.Fattura.GetStato(obj);
                    var image = "";
                    var descrizione = "";
                    if (stato == Tipi.StatoFattura.Pagata)
                    {
                        image = "Images.messageConfirm.png";
                        descrizione = "Fattura incassata";
                    }
                    else if (stato == Tipi.StatoFattura.NonPagata)
                    {
                        image = "Images.messageQuestion.png";
                        descrizione = "Fattura non incassata";
                    }
                    else if (stato == Tipi.StatoFattura.Insoluta)
                    {
                        image = "Images.messageAlert.png";
                        var ritardo = BusinessLogic.Fattura.GetRitardo(obj);
                        descrizione = "Fattura insoluta, scaduta da " + ritardo;
                    }
                    toolTip.SetToolTip(imgStato, descrizione);
                    imgStato.Image = image;
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
