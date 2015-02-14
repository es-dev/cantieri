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
                    var obj = (WcfService.Dto.FornitoreDto)model;
                    var ragioneSociale = UtilityValidation.GetStringND(obj.RagioneSociale);
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var indirizzo = UtilityValidation.GetStringND(obj.Indirizzo);
                    var cap = UtilityValidation.GetStringND(obj.CAP);
                    var comune = UtilityValidation.GetStringND(obj.Comune);
                    var provincia = UtilityValidation.GetStringND(obj.Provincia);
                    var partitaIva = UtilityValidation.GetStringND(obj.PIva);
                    var commessa = obj.Commessa;
                    var today = DateTime.Today;
                    var totaleFatture = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotaleFatture(obj, today));
                    var totalePagamenti = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotalePagamenti(obj, today));
                    var stato = GetStato(obj);

                    toolTip.SetToolTip(imgStato, stato.Description);
                    imgStato.Image = stato.Image;
                    infoImage.Image = "Images.dashboard.fornitore.png";
                    infoRagioneSociale.Text = ragioneSociale;
                    infoCodice.Text = codice;
                    infoPartitaIVA.Text = "Partita IVA " + partitaIva;
                    infoPagamentoTotale.Text = "Pagato " + totalePagamenti + " su un totale di " + totaleFatture;
                    infoCommesssa.Text = "Commessa " + commessa.Codice + " - " + commessa.Denominazione;
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
                var listaFattureNonPagate = BusinessLogic.Fattura.GetLista(fattureNonPagate);
                var listaFattureInsolute = BusinessLogic.Fattura.GetLista(fattureInsolute);

                var image = "";
                var descrizione = "";
                var stato = BusinessLogic.Fornitore.GetStato(fornitore);
                if (stato == Tipi.StatoFornitore.Pagato)
                {
                    image = "Images.messageConfirm.png";
                    descrizione = "Fornitore pagato";
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

        private void FornitoreItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new FornitoreModel();
                    space.Title = "DETTAGLI FORNITORE";
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
