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
                    var obj = (FatturaVenditaDto)model;
                    var numero = UtilityValidation.GetStringND(obj.Numero);
                    var today = DateTime.Today;
                    var totaleFattura = UtilityValidation.GetEuro(obj.Totale);
                    var totaleIncassi = UtilityValidation.GetEuro(BusinessLogic.Fattura.GetTotaleIncassi(obj, today));
                    var stato = GetStato(obj);
                    imgStato.Image = stato.Image;
                    toolTip.SetToolTip(imgStato, stato.Description);
                    infoImage.Image = "Images.dashboard.fatturavendita.png";
                    infoCodice.Text = "FV-" + numero;
                    infoNumeroData.Text ="FATTURA "+ BusinessLogic.Fattura.GetCodifica(obj);
                    infoIncassoTotale.Text = "Incassato " + totaleIncassi + " su un totale di " + totaleFattura;

                    var committente = obj.Committente;
                    if (committente != null)
                    {
                        var anagraficaCommittente = committente.AnagraficaCommittente;
                        infoCommittente.Text = (anagraficaCommittente!=null? anagraficaCommittente.RagioneSociale:null);
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static DescriptionImage GetStato(FatturaVenditaDto fattura)
        {
            try
            {
                var image = "";
                var descrizione = "";
                var stato = BusinessLogic.Fattura.GetStato(fattura);
                if (stato == Tipi.StatoFattura.Pagata)
                {
                    image = "Images.messageConfirm.png";
                    descrizione = "Fattura incassata";
                }
                else if (stato == Tipi.StatoFattura.Incoerente)
                {
                    image = "Images.messageQuestion.png";
                    descrizione = "Fattura incoerente (incasso superiore al totale fattura)";
                }
                else if (stato == Tipi.StatoFattura.NonPagata)
                {
                    image = "Images.messageQuestion.png";
                    descrizione = "Fattura non incassata";
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
