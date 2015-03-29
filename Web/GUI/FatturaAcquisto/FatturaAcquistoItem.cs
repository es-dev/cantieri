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

namespace Web.GUI.FatturaAcquisto
{
	public partial class FatturaAcquistoItem : TemplateItem
	{
        public FatturaAcquistoItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.FatturaAcquistoDto)model;
                    var numero = UtilityValidation.GetStringND(obj.Numero);
                    var data = UtilityValidation.GetDataND(obj.Data);
                    var today = DateTime.Today;
                    var totaleFattura = UtilityValidation.GetEuro(obj.Totale);
                    var totalePagamenti = UtilityValidation.GetEuro(BusinessLogic.Fattura.GetTotalePagamenti(obj, today));
                    var stato = GetStato(obj);
                    var centroCosto = obj.CentroCosto;
                    var fornitore = obj.Fornitore;

                    infoImage.Image = "Images.dashboard.fatturaacquisto.png";
                    infoCodice.Text = "FA";
                    infoNumeroData.Text = "Fattura N." + numero + " del " + data;
                    infoPagamentoTotale.Text = "Pagato " + totalePagamenti + " su un totale di " + totaleFattura;
                    infoCentroCosto.Text = UtilityValidation.GetStringND(centroCosto.Denominazione);
                    infoFornitore.Text = UtilityValidation.GetStringND(fornitore.RagioneSociale);
                    imgStato.Image = stato.Image;
                    toolTip.SetToolTip(imgStato, stato.Description);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static DescriptionImage GetStato(FatturaAcquistoDto fattura)
        {
            try
            {
                var image = "";
                var descrizione = "";
                var stato = BusinessLogic.Fattura.GetStato(fattura);
                if (stato == Tipi.StatoFattura.Pagata)
                {
                    image = "Images.messageConfirm.png";
                    descrizione = "Fattura pagata";
                }
                else if (stato == Tipi.StatoFattura.NonPagata)
                {
                    image = "Images.messageQuestion.png";
                    descrizione = "Fattura non pagata";
                }
                else if (stato == Tipi.StatoFattura.Insoluta)
                {
                    image = "Images.messageAlert.png";
                    var ritardo = BusinessLogic.Fattura.GetRitardo(fattura);
                    descrizione = "Fattura insoluta, scaduta da " + ritardo;
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

        private void FatturaAcquistoItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var obj = (WcfService.Dto.FatturaAcquistoDto)Model;
                    var space = new FatturaAcquistoModel();
                    var fornitore= obj.Fornitore;
                    space.Title = "FATTURA DI ACQUISTO N." + obj.Numero + " - " + fornitore.RagioneSociale;
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
