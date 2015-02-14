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
                    var indirizzo = "Non definito";
                    if (obj.Indirizzo != null)
                    {
                        indirizzo = obj.Indirizzo;
                        if (obj.CAP != null)
                            indirizzo += " - " + obj.CAP;
                        if (obj.Comune != null)
                            indirizzo += " - " + obj.Comune;
                        if (obj.Provincia != null)
                            indirizzo += " (" + obj.Provincia + ")";
                    }
                    infoIndirizzo.Text = indirizzo;
                    var commessa = obj.Commessa;
                    if (commessa != null)
                        infoCommesssa.Text = "Commessa " + commessa.Codice + " - " + commessa.Denominazione;

                    var today = DateTime.Today;
                    var totaleFattureVendita = BusinessLogic.Cliente.GetTotaleFatture(obj, today);
                    var totaleFatture = totaleFattureVendita.ToString("0.00") + "€";

                    var totaleLiquidazioni = BusinessLogic.Cliente.GetTotaleLiquidazioni(obj, today);
                    infoLiquidazioneTotale.Text = "Incassato " + totaleLiquidazioni.ToString("0.00") + "€ su un totale di " + totaleFatture;

                    var fatture = obj.FatturaVenditas;
                    var fattureNonLiquidate = BusinessLogic.Cliente.GetFattureNonLiquidate(fatture);
                    var fattureInsolute = BusinessLogic.Cliente.GetFattureInsolute(fatture);
                    var listaFattureNonLiquidate = BusinessLogic.Fattura.GetLista(fattureNonLiquidate);
                    var listaFattureInsolute = BusinessLogic.Fattura.GetLista(fattureInsolute);

                    var stato = BusinessLogic.Cliente.GetStato(obj);
                    var image = "";
                    var descrizione = "";
                    if (stato == Tipi.StatoCliente.Liquidato)
                    {
                        image = "Images.messageConfirm.png";
                        descrizione = "Cliente incassato";
                    }
                    else if (stato == Tipi.StatoCliente.NonLiquidato)
                    {
                        image = "Images.messageQuestion.png";
                        descrizione = "Cliente non incassato, le fatture non incassate sono " + listaFattureNonLiquidate;
                    }
                    else if (stato == Tipi.StatoCliente.Insoluto)
                    {
                        image = "Images.messageAlert.png";
                        descrizione = "Cliente insoluto, le fatture insolute sono " + listaFattureInsolute;
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
