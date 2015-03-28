using BusinessLogic;
using Library.Code;
using Library.Code.Enum;
using Library.Interfaces;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WcfService.Dto;
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
                    var ragioneSociale = UtilityValidation.GetStringND(obj.RagioneSociale);
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var indirizzo = UtilityValidation.GetStringND(obj.Indirizzo);
                    var cap = UtilityValidation.GetStringND(obj.CAP);
                    var comune = UtilityValidation.GetStringND(obj.Comune);
                    var provincia = UtilityValidation.GetStringND(obj.Provincia);
                    var commessa = obj.Commessa;
                    var today = DateTime.Today;
                    var totaleFatture = BusinessLogic.Cliente.GetTotaleFattureVendita(obj, today);
                    var totaleLiquidazioni = BusinessLogic.Cliente.GetTotaleLiquidazioni(obj, today);
                    var stato = GetStato(obj);
                    var _totaleLiquidazioni = UtilityValidation.GetEuro(totaleLiquidazioni);
                    var _totaleFatture = UtilityValidation.GetEuro(totaleFatture);

                    toolTip.SetToolTip(imgStato, stato.Description);
                    imgStato.Image = stato.Image;
                    infoImage.Image = "Images.dashboard.cliente.png";
                    infoRagioneSociale.Text = ragioneSociale;
                    infoCodice.Text = codice;
                    infoIndirizzo.Text = indirizzo + " - " + cap + " - " + comune + " (" + provincia + ")";
                    infoLiquidazioneTotale.Text = "Incassato " + _totaleLiquidazioni +" su un totale di " + _totaleFatture;
                    infoCommesssa.Text = "Commessa " + commessa.Codice + " - " + commessa.Denominazione;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static DescriptionImage GetStato(ClienteDto cliente)
        {
            try
            {
                var fatture = cliente.FatturaVenditas;
                var fattureNonLiquidate = BusinessLogic.Cliente.GetFattureNonLiquidate(fatture);
                var fattureInsolute = BusinessLogic.Cliente.GetFattureInsolute(fatture);
                var listaFattureNonLiquidate = BusinessLogic.Fattura.GetLista(fattureNonLiquidate);
                var listaFattureInsolute = BusinessLogic.Fattura.GetLista(fattureInsolute);

                var image = "";
                var descrizione = "";
                var stato = BusinessLogic.Cliente.GetStato(cliente);
                if (stato == Tipi.StatoCliente.Liquidato)
                {
                    image = "Images.messageConfirm.png";
                    descrizione = "Committente incassato";
                }
                else if (stato == Tipi.StatoCliente.NonLiquidato)
                {
                    image = "Images.messageQuestion.png";
                    descrizione = "Committente non incassato, le fatture non incassate sono " + listaFattureNonLiquidate;
                }
                else if (stato == Tipi.StatoCliente.Insoluto)
                {
                    image = "Images.messageAlert.png";
                    descrizione = "Committente insoluto, le fatture insolute sono " + listaFattureInsolute;
                }
                var _stato = new DescriptionImage(descrizione, image);
                return _stato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
             

        private void ClienteItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var obj = (WcfService.Dto.ClienteDto)Model;
                    var space = new ClienteModel();
                    var commessa = obj.Commessa;
                    space.Title = "COMMITTENTE " + obj.RagioneSociale + " - COMMESSA " + commessa.Codice;
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
