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

namespace Web.GUI.Committente
{
	public partial class CommittenteItem : TemplateItem
	{
        public CommittenteItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (CommittenteDto)model;
                    
                    var today = DateTime.Today;
                    var totaleFatture = BusinessLogic.Committente.GetTotaleFattureVendita(obj, today);
                    var totaleIncassi = BusinessLogic.Committente.GetTotaleIncassi(obj, today);
                    var stato = GetStato(obj);
                    var _totaleIncassi = UtilityValidation.GetEuro(totaleIncassi);
                    var _totaleFatture = UtilityValidation.GetEuro(totaleFatture);
                    infoIncassoTotale.Text = "Incassato " + _totaleIncassi + " su un totale di " + _totaleFatture;
                    toolTip.SetToolTip(imgStato, stato.Description);
                    imgStato.Image = stato.Image;
                    infoImage.Image = "Images.dashboard.committente.png";

                    var anagraficaCommittente = obj.AnagraficaCommittente;
                    if (anagraficaCommittente != null)
                    {
                        var indirizzo = UtilityValidation.GetStringND(anagraficaCommittente.Indirizzo);
                        var cap = UtilityValidation.GetStringND(anagraficaCommittente.CAP);
                        var comune = UtilityValidation.GetStringND(anagraficaCommittente.Comune);
                        var provincia = UtilityValidation.GetStringND(anagraficaCommittente.Provincia);
                        infoRagioneSociale.Text = UtilityValidation.GetStringND(anagraficaCommittente.RagioneSociale);
                        infoCodice.Text = "CT-" + UtilityValidation.GetStringND(anagraficaCommittente.Codice);
                        infoIndirizzo.Text = indirizzo + " - " + cap + " - " + comune + " (" + provincia + ")";
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

        private static DescriptionImage GetStato(CommittenteDto committente)
        {
            try
            {
                var fatture = committente.FatturaVenditas;
                var fattureNonLiquidate = BusinessLogic.Committente.GetFattureNonLiquidate(fatture);
                var fattureInsolute = BusinessLogic.Committente.GetFattureInsolute(fatture);
                var listaFattureNonLiquidate = BusinessLogic.Fattura.GetLista(fattureNonLiquidate);
                var listaFattureInsolute = BusinessLogic.Fattura.GetLista(fattureInsolute);

                var image = "";
                var descrizione = "";
                var stato = BusinessLogic.Committente.GetStato(committente);
                if (stato == Tipi.StatoCommittente.Incassato)
                {
                    image = "Images.messageConfirm.png";
                    descrizione = "Committente incassato";
                }
                else if (stato == Tipi.StatoCommittente.Incoerente)
                {
                    image = "Images.messageQuestion.png";
                    descrizione = "Committente incoerente (incassi superiori al totale fatture)";
                }
                else if (stato == Tipi.StatoCommittente.NonIncassato)
                {
                    image = "Images.messageQuestion.png";
                    descrizione = "Committente non incassato, le fatture non incassate sono " + listaFattureNonLiquidate;
                }
                else if (stato == Tipi.StatoCommittente.Insoluto)
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
             
	}
}
