using BusinessLogic;
using Library.Code;
using Library.Code.Enum;
using Library.Controls;
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
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var ragioneSociale = UtilityValidation.GetStringND(obj.RagioneSociale);
                    infoSubtitle.Text = codice + " - " + ragioneSociale;
                    infoSubtitleImage.Image = "Images.dashboard.fornitore.png";
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
                    editComune.Value = new Countries.City(obj.Comune, obj.CodiceCatastale, obj.Provincia);
                    editTelefono.Value = obj.Telefono;
                    editFAX.Value = obj.Fax;
                    editMobile.Value = obj.Mobile;
                    editEmail.Value = obj.Email;
                    editPartitaIVA.Value = obj.PartitaIva;
                    editLocalita.Value = obj.Localita;
                    editNote.Value = obj.Note;
                    editTotaleFattureAcquisto.Value = GetTotaleFatturaAcquisto(obj);
                    editStato.Value = GetStato(obj);
                    editTotalePagamenti.Value = GetTotalePagamenti(obj);
                    var commessa = obj.Commessa;
                    if (commessa != null)
                    {
                        editCommessa.Model = commessa;
                        editCommessa.Value =  commessa.Codice + " - " +commessa.Denominazione;
                    }
                    editCodiceFornitore.Value = obj.Codice;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private decimal GetTotalePagamenti(WcfService.Dto.FornitoreDto fornitore)
        {
            try
            {
                decimal totalePagamenti = 0;
                if (fornitore != null)
                {
                    var today = DateTime.Today;
                    var commessa = fornitore.Commessa;
                    if (commessa != null)
                    {
                        var statoCommessa = commessa.Stato;
                        if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                            totalePagamenti = UtilityValidation.GetDecimal(fornitore.TotalePagamenti);
                        else
                            totalePagamenti = BusinessLogic.Fornitore.GetTotalePagamenti(fornitore, today);
                    }
                }
                return totalePagamenti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        private string GetStato(WcfService.Dto.FornitoreDto fornitore)
        {
            try
            {
                var stato = "N/D";
                if (fornitore != null)
                {
                    var commessa = fornitore.Commessa;
                    if (commessa != null)
                    {
                        var statoCommessa = commessa.Stato;
                        if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                            stato = fornitore.Stato;
                        else
                        {
                            var today = DateTime.Today;
                            var fatture = fornitore.FatturaAcquistos;
                            var totaleFatture = BusinessLogic.Fornitore.GetTotaleFatture(fornitore, today);
                            var totalePagamenti = BusinessLogic.Fornitore.GetTotalePagamenti(fornitore, today);
                            var fattureInsolute = BusinessLogic.Fornitore.GetFattureInsolute(fatture);
                            var fattureNonPagate = BusinessLogic.Fornitore.GetFattureNonPagate(fatture);
                            var statoFornitore = BusinessLogic.Fornitore.GetStato(fornitore);
                            var _stato = GetStato(totaleFatture, totalePagamenti, fattureInsolute, fattureNonPagate, statoFornitore);
                            stato = _stato.ToString();
                        }
                    }
                }
                return stato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private decimal GetTotaleFatturaAcquisto(WcfService.Dto.FornitoreDto fornitore)
        {
            try
            {
                decimal totaleFatturaAcquisto = 0;
                var today = DateTime.Today;
                if (fornitore != null)
                {
                    var commessa = fornitore.Commessa;
                    if (commessa != null)
                    {
                        var statoCommessa = commessa.Stato;
                        if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                            totaleFatturaAcquisto = UtilityValidation.GetDecimal(fornitore.TotaleFattureAcquisto);
                        else
                            totaleFatturaAcquisto = BusinessLogic.Fornitore.GetTotaleFatture(fornitore, today);
                    }
                }
                return totaleFatturaAcquisto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
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
                    obj.Comune = editComune.Value.Description;
                    obj.CodiceCatastale = editComune.Value.Code;
                    obj.Provincia = editComune.Value.County;
                    obj.Telefono = editTelefono.Value;
                    obj.Fax = editFAX.Value;
                    obj.Mobile = editMobile.Value;
                    obj.Email = editEmail.Value;
                    obj.Localita = editLocalita.Value;
                    obj.PartitaIva = editPartitaIVA.Value;
                    obj.Codice = editCodiceFornitore.Value;
                    obj.Note = editNote.Value;
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
                {
                    editCommessa.Value = "(" + commessa.Codice + ") - " + commessa.Denominazione;
                    CalcolaTotali();
                }
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
                view.Title = "SELEZIONA UN FORNITORE";
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
                    editComune.Value = new Countries.City(anagraficaFornitore.Comune, anagraficaFornitore.CodiceCatastale, anagraficaFornitore.Provincia);
                    editEmail.Value = anagraficaFornitore.Email;
                    editFAX.Value = anagraficaFornitore.Fax;
                    editIndirizzo.Value = anagraficaFornitore.Indirizzo;
                    editMobile.Value = anagraficaFornitore.Mobile;
                    editPartitaIVA.Value = anagraficaFornitore.PartitaIva;
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
                if (Editing)
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
                var obj = (WcfService.Dto.FornitoreDto)Model;
                var fatture = obj.FatturaAcquistos;
                var today= DateTime.Today;
                if (fatture != null)
                {
                    var totaleFatture = BusinessLogic.Fornitore.GetTotaleFatture(obj, today);
                    var totalePagamenti = BusinessLogic.Fornitore.GetTotalePagamenti(obj, today);
                    var fattureInsolute = BusinessLogic.Fornitore.GetFattureInsolute(fatture);
                    var fattureNonPagate = BusinessLogic.Fornitore.GetFattureNonPagate(fatture);
                    var statoFornitore = BusinessLogic.Fornitore.GetStato(obj);
                    var stato = GetStato(totaleFatture, totalePagamenti, fattureInsolute, fattureNonPagate, statoFornitore);

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

        private StateDescriptionImage GetStato(decimal totaleFatture, decimal totalePagamenti, IList<WcfService.Dto.FatturaAcquistoDto> fattureInsolute, 
            IList<WcfService.Dto.FatturaAcquistoDto> fattureNonPagate, Tipi.StatoFornitore statoFornitore)
        {
            try
            {
                var descrizione = "";
                var stato = TypeState.None;
                var existFattureInsolute = (fattureInsolute.Count >= 1);
                var existFattureNonPagate = (fattureNonPagate.Count >= 1);
                var listaFattureInsolute = BusinessLogic.Fattura.GetLista(fattureInsolute);
                var listaFattureNonPagate = BusinessLogic.Fattura.GetLista(fattureNonPagate);
                var _totalePagamenti = UtilityValidation.GetEuro(totalePagamenti);
                var _totaleFatture = UtilityValidation.GetEuro(totaleFatture);

                if (statoFornitore == Tipi.StatoFornitore.Insoluto) //condizione di non soluzione delle fatture, segnalo le fatture insolute ed eventualmente quelle non pagate
                {
                    descrizione = "Il fornitore risulta insoluto. Il totale pagamenti pari a " + _totalePagamenti + " è inferiore al totale delle fatture pari a " + _totaleFatture + ". Le fatture insolute sono " + listaFattureInsolute;
                    if (existFattureNonPagate)
                        descrizione += " Le fatture non pagate sono " + listaFattureNonPagate;
                    stato = TypeState.Critical;
                }
                else if (statoFornitore == Tipi.StatoFornitore.NonPagato)
                {
                    descrizione = "Il fornitore risulta non pagato. Il totale pagamenti pari a " + _totalePagamenti + " è inferiore al totale delle fatture pari a " + _totaleFatture;
                    if (existFattureNonPagate)
                        descrizione += " Le fatture non pagate sono " + listaFattureNonPagate;
                    stato = TypeState.Warning;
                }
                else if (statoFornitore == Tipi.StatoFornitore.Pagato)
                {
                    descrizione = "Il fornitore risulta pagato. Tutte le fatture sono state saldate";  //non so se ha senso indicargli anche insolute o no!!!!! per ora NO
                    stato = TypeState.Normal;
                }
                var _stato = new StateDescriptionImage(stato, descrizione);
                return _stato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public override void SetEditing(bool editing, bool deleting)
        {
            try
            {
                base.SetEditing(editing, deleting);
                btnCalcoloTotali.Enabled = editing;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
