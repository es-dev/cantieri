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
using WcfService.Dto;
using Web.Code;

namespace Web.GUI.Fornitore
{
	public partial class FornitoreModel : TemplateModel
	{
        private CommessaDto commessa = null;

        public FornitoreModel()
		{
			InitializeComponent();
		}

        public FornitoreModel(CommessaDto commessa)
        {
            InitializeComponent();
            try
            {
                this.commessa = commessa;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindViewTitle(object model)
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
                    var commessa = obj.Commessa;
                    infoTitle.Text= (obj.Id!=0? "FORNITORE " + obj.RagioneSociale + " - COMMESSA " + commessa.Codice:"NUOVO FORNITORE");
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
                    editStato.Value = BusinessLogic.Fornitore.GetStatoDescrizione(obj);
                    editTotaleFattureAcquisto.Value = BusinessLogic.Fornitore.GetTotaleFatturaAcquisto(obj);
                    editTotalePagamenti.Value = BusinessLogic.Fornitore.GetTotalePagamenti(obj);
                    editTotaleNoteCredito.Value = BusinessLogic.Fornitore.GetTotaleNoteCredito(obj);
                    editCodiceFornitore.Value = obj.Codice;

                    BindViewCommessa(obj.Commessa);
                    BindViewFattureAcquisto(obj.FatturaAcquistos);
                    BindViewNoteCredito(obj.NotaCreditos);
                    BindViewPagamenti(obj);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewPagamenti(FornitoreDto obj)
        {
            try
            {
                var viewModel = new Pagamento.PagamentoViewModel(this);
                viewModel.Fornitore = obj;
                btnPagamenti.TextButton = "Pagamenti (" + viewModel.Count() + ")";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewNoteCredito(IList<NotaCreditoDto> noteCredito)
        {
            try
            {
                btnNoteCredito.TextButton = "Note credito (" + (noteCredito != null ? noteCredito.Count : 0) + ")";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewFattureAcquisto(IList<FatturaAcquistoDto> fattureAcquisto)
        {
            try
            {
                btnFattureAcquisto.TextButton = "Fatture acquisto (" + (fattureAcquisto != null ? fattureAcquisto.Count : 0) + ")";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewCommessa(CommessaDto commessa)
        {
            try
            {
                editCommessa.Model = commessa;
                editCommessa.Value = (commessa != null ? commessa.Codice + " - " + commessa.Denominazione : null);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
           
        }

        private void BindViewTotali()
        {
            try
            {
                var obj = (WcfService.Dto.FornitoreDto)Model;
                var fatture = obj.FatturaAcquistos;
                var today = DateTime.Today;
                if (fatture != null)
                {
                    var totaleFattureAcquisto = BusinessLogic.Fornitore.GetTotaleFattureAcquisto(obj, today);
                    var totalePagamenti = BusinessLogic.Fornitore.GetTotalePagamenti(obj, today);
                    var totaleNoteCredito = BusinessLogic.Fornitore.GetTotaleNoteCredito(obj, today);
                    var statoDescrizione = BusinessLogic.Fornitore.GetStatoDescrizione(obj);

                    editStato.Value = statoDescrizione;
                    editTotaleFattureAcquisto.Value = totaleFattureAcquisto;
                    editTotalePagamenti.Value = totalePagamenti;
                    editTotaleNoteCredito.Value = totaleNoteCredito;
                    
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
                    obj.Comune = editComune.Value.Description;
                    obj.CodiceCatastale = editComune.Value.Code;
                    obj.Provincia = editComune.Value.County;
                    obj.Telefono = editTelefono.Value;
                    obj.Fax = editFAX.Value;
                    obj.Mobile = editMobile.Value;
                    obj.Email = editEmail.Value;
                    obj.Localita = editLocalita.Value;
                    obj.PartitaIva = editPartitaIVA.Value;
                    obj.Note = editNote.Value;
                    obj.TotaleFattureAcquisto = editTotaleFattureAcquisto.Value;
                    obj.Stato = editStato.Value;
                    obj.TotalePagamenti = editTotalePagamenti.Value;
                    obj.TotaleNoteCredito = editTotaleNoteCredito.Value;
                    obj.Codice = editCodiceFornitore.Value;

                    var commessa = (WcfService.Dto.CommessaDto)editCommessa.Model;
                    if (commessa != null)
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
                    editCommessa.Value =  commessa.Codice + " - " + commessa.Denominazione;
                    BindViewTotali();
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
                var anagraficaFornitore = (AnagraficaFornitoreDto)model;
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
                bool saved = Save();
                if (saved)
                {
                    BindViewTotali();
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private void btnNoteCredito_Click(object sender, EventArgs e)
        {
            try
            {
                bool saved = Save();
                if (saved)
                {
                    var obj = (FornitoreDto)Model;
                    var space = new NotaCredito.NotaCreditoView(obj);
                    space.Title = "NOTE DI CREDITO DEL FORNITORE " + obj.RagioneSociale;
                    Workspace.AddSpace(space);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnFattureAcquisto_Click(object sender, EventArgs e)
        {
            try
            {
                bool saved = Save();
                if (saved)
                {
                    var obj = (FornitoreDto)Model;
                    var space = new FatturaAcquisto.FatturaAcquistoView(obj);
                    space.Title = "FATTURE ACQUISTO DEL FORNITORE " + obj.RagioneSociale;
                    Workspace.AddSpace(space);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnPagamenti_Click(object sender, EventArgs e)
        {
            try
            {
                bool saved = Save();
                if (saved)
                {
                    var obj = (FornitoreDto)Model;
                    var space = new Pagamento.PagamentoView(obj);
                    space.Title = "PAGAMENTI FORNITORE " + obj.RagioneSociale;
                    Workspace.AddSpace(space);

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void FornitoreModel_Load(object sender, EventArgs e)
        {
            try
            {
                var obj = (FornitoreDto)Model;
                if (obj != null && obj.Id == 0)
                    SetNewValue();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetNewValue()
        {
            try
            {
                if (commessa != null)
                {
                    editCommessa.Model = commessa;
                    editCommessa.Value = commessa.Codice + " - " + commessa.Denominazione;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void SetEditing(bool editing, bool deleting)
        {
            try
            {
                base.SetEditing(editing, deleting);
                btnCalcoloTotali.Enabled = editing;
                btnFattureAcquisto.Enabled = editing;
                btnNoteCredito.Enabled = editing;
                btnPagamenti.Enabled = editing;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override UtilityValidation.ValidationState IsValidated()
        {
            try
            {
                var validated = new UtilityValidation.ValidationState();

                var obj = (FornitoreDto)Model;
                var viewModelFornitore = new Fornitore.FornitoreViewModel(this);
                var commessa = (CommessaDto)editCommessa.Model;
                var fornitori = viewModelFornitore.ReadFornitori(commessa);
                var codiceFornitore = editCodiceFornitore.Value;
                var viewModelAnagraficaFornitore = new AnagraficaFornitore.AnagraficaFornitoreViewModel(this);
                var anagraficaFornitore = viewModelAnagraficaFornitore.ReadAnagraficaFornitore(codiceFornitore);
                
                var validateFornitore = BusinessLogic.Diagnostico.ValidateFornitore(obj, fornitori, anagraficaFornitore, commessa);
                if (validateFornitore != null)
                {
                    validated.State = validateFornitore.State;
                    validated.Message = validateFornitore.Message;
                }
                return validated;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
	}
}
