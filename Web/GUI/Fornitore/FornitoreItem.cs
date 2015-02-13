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
                    infoImage.Image = "Images.dashboard.fornitore.png";
                    var ragioneSociale = "Non definito";
                    if (obj.RagioneSociale != null)
                        ragioneSociale = obj.RagioneSociale;
                    infoRagioneSociale.Text = ragioneSociale;
                    var codice = "N/D";
                    if (obj.Codice != null)
                        codice = obj.Codice;
                    infoCodice.Text = codice;
                    var pIva = "N/D";
                    if (obj.PIva != null)
                        pIva = obj.PIva;
                    infoPartitaIVA.Text = "P.IVA " + pIva;
                    var commessa = obj.Commessa;
                    if (commessa != null)
                        infoCommesssa.Text ="Commessa "+ commessa.Codice +" - "+ commessa.Denominazione;

                    var today = DateTime.Today;
                    var totaleFattureAcquisto = BusinessLogic.Fornitore.GetTotaleFatture(obj, today);
                    var totaleFatture = totaleFattureAcquisto.ToString("0.00") + "€";

                    var totalePagamenti = BusinessLogic.Fornitore.GetTotalePagamenti(obj, today);
                    infoPagamentoTotale.Text = "Pagato " + totalePagamenti.ToString("0.00") + "€ su un totale di " + totaleFatture;

                    var fatture = obj.FatturaAcquistos;
                    var fattureNonPagate = BusinessLogic.Fornitore.GetFattureNonPagate(fatture);
                    var fattureInsolute = BusinessLogic.Fornitore.GetFattureInsolute(fatture);
                    var listaFattureNonPagate = BusinessLogic.Fattura.GetLista(fattureNonPagate);
                    var listaFattureInsolute = BusinessLogic.Fattura.GetLista(fattureInsolute);

                    var stato = BusinessLogic.Fornitore.GetStato(obj);
                    var image = "";
                    var descrizione = "";
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
                    toolTip.SetToolTip(imgStato, descrizione);
                    imgStato.Image = image;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
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
