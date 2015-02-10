using Library.Code;
using Library.Code.Enum;
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
	public partial class FornitoreModel : TemplateModel
	{
        public FornitoreModel()
		{
			InitializeComponent();
		}

        public override void BindViewSubTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.FornitoreDto)model;
                    infoSubtitleImage.Image = "Images.dashboard.fornitore.png";
                    infoSubtitle.Text = obj.Codice + " - " + obj.RagioneSociale;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindView(object model)  
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.FornitoreDto)model;
                    editRagioneSociale.Value = obj.RagioneSociale;
                    editIndirizzo.Value = obj.Indirizzo;
                    editCAP.Value = obj.CAP;
                    editComune.Value = new Library.Controls.ComuniProvince.Comune(obj.Comune, obj.CodiceCatastale, obj.Provincia);
                    editTelefono.Value = obj.Telefono;
                    editFAX.Value = obj.Fax;
                    editMobile.Value = obj.Mobile;
                    editEmail.Value = obj.Email;
                    editPartitaIVA.Value = obj.PIva;
                    editLocalita.Value = obj.Localita;
                    editTotaleFattureAcquisto.Value = obj.TotaleFattureAcquisto;
                    editStato.Value = obj.Stato;
                    editTotalePagamenti.Value = obj.TotalePagamenti;
                    var commessa = obj.Commessa;
                    if (commessa != null)
                    {
                        editCommessa.Model = commessa;
                        editCommessa.Value = "("+ commessa.Codice + ") - " +commessa.Denominazione;
                    }
                    editCodiceFornitore.Value = obj.Codice;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindModel(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.FornitoreDto)model;
                    obj.RagioneSociale = editRagioneSociale.Value;
                    obj.Indirizzo = editIndirizzo.Value;
                    obj.CAP = editCAP.Value;
                    obj.Comune = editComune.Value.Denominazione;
                    obj.CodiceCatastale = editComune.Value.CodiceCatastale;
                    obj.Provincia = editComune.Value.Provincia;
                    obj.Telefono = editTelefono.Value;
                    obj.Fax = editFAX.Value;
                    obj.Mobile = editMobile.Value;
                    obj.Email = editEmail.Value;
                    obj.Localita = editLocalita.Value;
                    obj.PIva = editPartitaIVA.Value;
                    obj.Codice = editCodiceFornitore.Value;
                    obj.TotaleFattureAcquisto = editTotaleFattureAcquisto.Value;
                    obj.Stato = editStato.Value;
                    obj.TotalePagamenti = editTotalePagamenti.Value;
                    var commessa = (WcfService.Dto.CommessaDto)editCommessa.Model;
                    if(commessa!=null)
                        obj.CommessaId = commessa.Id;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCommessa_ComboClick()
        {
            try
            {
                var view = new Commessa.CommessaView();
                view.Title = "SELEZIONA UNA COMMESSA";
                editCommessa.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
        private void editCommessa_ComboConfirm(object model)
        {
            try
            {
                var commessa = (WcfService.Dto.CommessaDto)model;
                if (commessa != null)
                    editCommessa.Value = "(" + commessa.Codice + ") - " + commessa.Denominazione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCodiceFornitore_ComboClick()
        {
            try
            {
                var view = new AnagraficaFornitore.AnagraficaFornitoreView();
                view.Title = "SELEZIONA UN FORNITORE DALL'ANAGRAFICA FORNITORI";
                editCodiceFornitore.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCodiceFornitore_ComboConfirm(object model)
        {
            try
            {
                var anagraficaFornitore = (WcfService.Dto.AnagraficaFornitoreDto)model;
                if (anagraficaFornitore != null)
                {
                    editCodiceFornitore.Value = anagraficaFornitore.Codice;
                    editCAP.Value = anagraficaFornitore.CAP;
                    editComune.Value  = new Library.Controls.ComuniProvince.Comune(anagraficaFornitore.Comune, anagraficaFornitore.Provincia);
                    editEmail.Value = anagraficaFornitore.Email;
                    editFAX.Value = anagraficaFornitore.Fax;
                    editIndirizzo.Value = anagraficaFornitore.Indirizzo;
                    editMobile.Value = anagraficaFornitore.Mobile;
                    editPartitaIVA.Value = anagraficaFornitore.PIva;
                    editRagioneSociale.Value = anagraficaFornitore.RagioneSociale;
                    editTelefono.Value = anagraficaFornitore.Telefono;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCalcoloTotali_Click(object sender, EventArgs e)
        {
            try
            {
                if (Editing==true)
                    CalcolaTotali();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private void CalcolaTotali()
        {
            try
            {
                //prelievo dati da GUI -->non prelevo nnt da GUI
                //prelievo dati DB
                var obj = (WcfService.Dto.FornitoreDto)Model;
                var fatture = obj.FatturaAcquistos;
                var today= DateTime.Today;
                if (fatture != null)
                {
                    var totaleFatture = BusinessLogic.Fornitore.GetTotaleFatture(obj, today);
                    var totalePagamenti = BusinessLogic.Fornitore.GetTotalePagamenti(obj, today);
                    var fattureInsolute = BusinessLogic.Fornitore.GetFattureInsolute(fatture);
                    var fattureNonPagate = BusinessLogic.Fornitore.GetFattureNonPagate(fatture);
 
                    //valutazione dell'andamento del lavoro
                    var stato = GetStato(totaleFatture, totalePagamenti, fattureInsolute, fattureNonPagate);

                    ////binding dati in GUI
                    editStato.Value = stato.ToString();
                    editTotaleFattureAcquisto.Value = totaleFatture;
                    editTotalePagamenti.Value= totalePagamenti;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private StatoDescrizione GetStato(decimal totaleFattura, decimal totalePagamenti, IList<WcfService.Dto.FatturaAcquistoDto> fattureInsolute, IList<WcfService.Dto.FatturaAcquistoDto> fattureNonPagate)
        {
            try
            {
                var descrizione = "";
                var stato = TypeStato.None;
                var existFattureInsolute = (fattureInsolute.Count >= 1);
                var existFattureNonPagate = (fattureNonPagate.Count >= 1);
                var listaFattureInsolute = BusinessLogic.Fattura.GetLista(fattureInsolute);
                var listaFattureNonPagate = BusinessLogic.Fattura.GetLista(fattureNonPagate);

                if (totalePagamenti < totaleFattura)
                {
                    if (existFattureInsolute) //condizione di non soluzione delle fatture, segalo le fatture insolute ed eventualmente quelle non pagate
                    {
                        descrizione = "Il fornitore risulta insoluto. Il totale pagamenti pari a " + totalePagamenti.ToString("0.00€") + " è inferiore al totale delle fatture pari a " + totaleFattura.ToString("0.00€") + ". Le fatture insolute sono " + listaFattureInsolute;
                        if (existFattureNonPagate)
                            descrizione += " Le fatture non pagate sono " + listaFattureNonPagate;
                        stato = TypeStato.Critical;
                    }
                    else //condizione di non pagamento (pagamenti nulli o non completi, se non completi segnalo le fatture non pagate)
                    {
                        descrizione = "Il fornitore risulta non pagato. Il totale pagamenti pari a " + totalePagamenti.ToString("0.00€") + " è inferiore al totale delle fatture pari a " + totaleFattura.ToString("0.00€");
                        if (existFattureNonPagate)
                            descrizione += " Le fatture non pagate sono " + listaFattureNonPagate;
                        stato = TypeStato.Warning;
                    }
                }
                else if (totalePagamenti >= totaleFattura)
                {
                    descrizione = "Il fornitore risulta pagato. Tutte le fatture sono state saldate";  //non so se ha senso indicargli anche insolute o no!!!!! per ora NO
                    stato = TypeStato.Normal;
                }
                var statoDescrizione = new StatoDescrizione(stato, descrizione);
                return statoDescrizione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

       




	}
}
