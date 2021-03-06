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

namespace Web.GUI.Fornitore
{
	public partial class FornitoreItem : TemplateItem
	{
        public FornitoreItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (FornitoreDto)model;

                    var today = DateTime.Today;
                    var totaleFattureAcquisto = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotaleFattureAcquisto(obj, today));
                    var totalePagamenti = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotalePagamenti(obj, today));
                    infoPagamentoTotale.Text = "Pagato " + totalePagamenti + " su un totale di " + totaleFattureAcquisto;
                    var stato = GetStato(obj);
                    toolTip.SetToolTip(imgStato, stato.Description);
                    imgStato.Image = stato.Image;
                    infoImage.Image = "Images.dashboard.fornitore.png";
                    
                    var anagraficaFornitore = obj.AnagraficaFornitore;
                    if (anagraficaFornitore != null)
                    {
                        infoRagioneSociale.Text = UtilityValidation.GetStringND(anagraficaFornitore.RagioneSociale);
                        infoCodice.Text = "FOR-" + UtilityValidation.GetStringND(anagraficaFornitore.Codice);
                        infoPartitaIVA.Text = "Partita IVA " + UtilityValidation.GetStringND(anagraficaFornitore.PartitaIva);
                    }

                    var commessa = obj.Commessa;
                    if (commessa != null)
                        infoCommesssa.Text = "Commessa " + BusinessLogic.Commessa.GetCodifica(commessa);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static DescriptionImage GetStato(FornitoreDto fornitore)
        {
            try
            {
                var fatture = fornitore.FatturaAcquistos;
                var fattureNonPagate = BusinessLogic.Fornitore.GetFattureNonPagate(fatture);
                var fattureInsolute = BusinessLogic.Fornitore.GetFattureInsolute(fatture);
                var listaFattureNonPagate = BusinessLogic.Fattura.GetListaFatture(fattureNonPagate);
                var listaFattureInsolute = BusinessLogic.Fattura.GetListaFatture(fattureInsolute);

                var image = "";
                var descrizione = "";
                var stato = BusinessLogic.Fornitore.GetStato(fornitore);
                if (stato == Tipi.StatoFornitore.Pagato)
                {
                    image = "Images.messageConfirm.png";
                    descrizione = "Fornitore pagato";
                }
                else if (stato == Tipi.StatoFornitore.Incoerente)
                {
                    image = "Images.messageQuestion.png";
                    descrizione = "Fornitore incoerente (pagamenti superiori al totale fatture)";
                }
                else if (stato == Tipi.StatoFornitore.NonPagato)
                {
                    image = "Images.messageQuestion.png";
                    descrizione = "Fornitore non pagato, le fatture non pagate sono " + listaFattureNonPagate;
                }
                else if (stato == Tipi.StatoFornitore.Insoluto)
                {
                    image = "Images.messageAlert.png";
                    descrizione = "Fornitore insoluto, le fatture insolute sono " + listaFattureInsolute;
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
