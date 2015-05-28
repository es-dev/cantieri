using BusinessLogic;
using Library.Code;
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
using System.Linq;


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
                    infoSubtitleImage.Image = "Images.dashboard.fornitore.png";
                    var commessa = obj.Commessa;

                    var anagraficaFornitore = obj.AnagraficaFornitore;
                    if (anagraficaFornitore != null)
                    {
                        infoSubtitle.Text = anagraficaFornitore.Codice + " - " + anagraficaFornitore.RagioneSociale;
                        infoTitle.Text = (obj.Id != 0 ? "FORNITORE " + anagraficaFornitore.RagioneSociale + " - COMMESSA " + commessa.Codice : "NUOVO FORNITORE");
                    }
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
                    editNote.Value = obj.Note;

                    BindViewAnagraficaFornitore(obj.AnagraficaFornitore);
                    BindViewCommessa(obj.Commessa);
                    BindViewFattureAcquisto(obj.FatturaAcquistos);
                    BindViewNoteCredito(obj.NotaCreditos);
                    BindViewPagamenti(obj.FatturaAcquistos);
                    BindViewTotali(obj);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewAnagraficaFornitore(AnagraficaFornitoreDto anagraficaFornitore)
        {
            try
            {
                editCodiceFornitore.Model = anagraficaFornitore;
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
                    editLocalita.Value = anagraficaFornitore.Localita;

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private void BindViewPagamenti(IList<FatturaAcquistoDto> fattureAcquisto)
        {
            try
            {
                var count = (from q in fattureAcquisto select q.Pagamentos.Count).Sum();
                btnPagamenti.TextButton = "Pagamenti (" + count + ")";
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

        private void BindViewTotali(FornitoreDto obj)
        {
            try
            {
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
                    obj.Note = editNote.Value;
                    obj.TotaleFattureAcquisto = editTotaleFattureAcquisto.Value;
                    obj.Stato = editStato.Value;
                    obj.TotalePagamenti = editTotalePagamenti.Value;
                    obj.TotaleNoteCredito = editTotaleNoteCredito.Value;

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
                BindViewCommessa(commessa);
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
                BindViewAnagraficaFornitore(anagraficaFornitore);
                
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
                    var obj = (FornitoreDto)Model;
                    BindViewTotali(obj);
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
                    space.Title = "NOTE DI CREDITO DEL FORNITORE " + obj.AnagraficaFornitore.RagioneSociale;
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
                    space.Title = "FATTURE ACQUISTO DEL FORNITORE " + obj.AnagraficaFornitore.RagioneSociale;
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
                    space.Title = "PAGAMENTI FORNITORE " + obj.AnagraficaFornitore.RagioneSociale;
                    Workspace.AddSpace(space);

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
      
        public override void SetNewValue(object model)
        {
            try
            {
                BindViewCommessa(commessa);
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
                var viewModelFornitore = new Fornitore.FornitoreViewModel();
                var commessa = (CommessaDto)editCommessa.Model;
                var fornitori = viewModelFornitore.ReadFornitori(commessa);
                var anagraficaFornitore = obj.AnagraficaFornitore;
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
