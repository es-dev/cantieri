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
                    var obj = (FatturaAcquistoDto)model;
                    var numero = UtilityValidation.GetStringND(obj.Numero);
                    var today = DateTime.Today;
                    var totaleFattura = UtilityValidation.GetEuro(obj.Totale);
                    var totalePagamenti = UtilityValidation.GetEuro(BusinessLogic.Fattura.GetTotalePagamenti(obj, today));
                    var stato = GetStato(obj);
                    var centroCosto = obj.CentroCosto;
                    imgStato.Image = stato.Image;
                    toolTip.SetToolTip(imgStato, stato.Description);
                    infoImage.Image = "Images.dashboard.fatturaacquisto.png";
                    infoCodice.Text = "FA-" + numero;
                    infoNumeroData.Text = "FATTURA " + BusinessLogic.Fattura.GetCodifica(obj);
                    infoPagamentoTotale.Text = "Pagato " + totalePagamenti + " su un totale di " + totaleFattura;
                    infoCentroCosto.Text = UtilityValidation.GetStringND(centroCosto.Denominazione);
                    infoFornitore.Text = BusinessLogic.Fornitore.GetCodifica(obj.Fornitore);
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
                else if (stato == Tipi.StatoFattura.Incoerente)
                {
                    image = "Images.messageQuestion.png";
                    descrizione = "Fattura incoerente (pagamento superiore al totale fattura)";
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

        
	}
}
