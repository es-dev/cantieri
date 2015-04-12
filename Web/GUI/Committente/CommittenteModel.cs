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

namespace Web.GUI.Committente
{
	public partial class CommittenteModel : TemplateModel
	{
        private CommessaDto commessa = null;

        public CommittenteModel()
		{
			InitializeComponent();
		}

        public CommittenteModel(CommessaDto commessa)
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

        public override void BindViewSubTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.CommittenteDto)model;
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var ragioneSociale = UtilityValidation.GetStringND(obj.RagioneSociale);
                    infoSubtitle.Text = codice + " - " + ragioneSociale;
                    infoSubtitleImage.Image = "Images.dashboard.committente.png";
                    var commessa = obj.Commessa;
                    infoTitle.Text = (obj.Id!=0? "COMMITTENTE " + obj.RagioneSociale + " - COMMESSA " + commessa.Codice: "NUOVO COMMITTENTE");
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
                    var obj = (WcfService.Dto.CommittenteDto)model;
                    editRagioneSociale.Value = obj.RagioneSociale;
                    editIndirizzo.Value = obj.Indirizzo;
                    editCAP.Value = obj.CAP;
                    editComune.Value = new Countries.City(obj.Comune, obj.CodiceCatastale, obj.Provincia);
                    editTelefono.Value = obj.Telefono;
                    editFAX.Value = obj.Fax;
                    editMobile.Value = obj.Mobile;
                    editEmail.Value = obj.Email;
                    editLocalita.Value = obj.Localita;
                    editPartitaIVA.Value = obj.PartitaIva;
                    editNote.Value = obj.Note;
                    editTotaleFattureVendita.Value = BusinessLogic.Committente.GetTotaleFattureVendita(obj);
                    editStato.Value = BusinessLogic.Committente.GetStatoDescrizione(obj);
                    editTotaleIncassi.Value = BusinessLogic.Committente.GetTotaleIncassi(obj);
                    editCodiceCommittente.Value = obj.Codice;

                    BindViewCommessa(obj.Commessa);
                    BindViewFattureVendita(obj.FatturaVenditas);
                    BindViewIncassi(obj);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewIncassi(CommittenteDto committente)
        {
            try
            {
                var viewModel = new Incasso.IncassoViewModel(this);
                viewModel.Committente = committente;
                btnIncassi.TextButton = "Incassi (" + viewModel.GetCount() + ")";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewFattureVendita(IList<FatturaVenditaDto> fattureVendita)
        {
            try
            {
                btnFattureVendita.TextButton = "Fatture di vendita (" + (fattureVendita!=null?fattureVendita.Count:0) + ")";
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
                editCommessa.Value = (commessa!=null?commessa.Codice + " - " + commessa.Denominazione:null);
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
                    var obj = (WcfService.Dto.CommittenteDto)model;
                    obj.RagioneSociale = editRagioneSociale.Value;
                    obj.Indirizzo = editIndirizzo.Value;
                    obj.CAP = editCAP.Value;
                    obj.Comune = editComune.Value.Description;
                    obj.CodiceCatastale = editComune.Value.Code;
                    obj.Provincia = editComune.Value.County;
                    obj.Localita = editLocalita.Value;
                    obj.Telefono = editTelefono.Value;
                    obj.Fax = editFAX.Value;
                    obj.Mobile = editMobile.Value;
                    obj.Email = editEmail.Value;
                    obj.PartitaIva = editPartitaIVA.Value;
                    obj.Note = editNote.Value;
                    obj.Codice = editCodiceCommittente.Value;
                    obj.TotaleFattureVendita = editTotaleFattureVendita.Value;
                    obj.Stato = editStato.Value;
                    obj.TotaleIncassi = editTotaleIncassi.Value;
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

        private void BindViewTotali()
        {
            try
            {
                var obj = (WcfService.Dto.CommittenteDto)Model;
                var fatture = obj.FatturaVenditas;
                var today = DateTime.Today;
                if (fatture != null)
            {
                    var totaleFatture = BusinessLogic.Committente.GetTotaleFattureVendita(obj, today);
                    var totaleIncassi = BusinessLogic.Committente.GetTotaleIncassi(obj, today);
                    var statoDescrizione = BusinessLogic.Committente.GetStatoDescrizione(obj);

                    editStato.Value = statoDescrizione;
                    editTotaleFattureVendita.Value = totaleFatture;
                    editTotaleIncassi.Value = totaleIncassi;
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

        private void btnFattureVendita_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = (CommittenteDto)Model;
                var space = new FatturaVendita.FatturaVenditaView(obj);
                space.Title = "FATTURE DI VENDITA - " + obj.RagioneSociale;
                Workspace.AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnIncassi_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = (CommittenteDto)Model;
                var space = new Incasso.IncassoView(obj);
                space.Title = "INCASSI - " + obj.RagioneSociale;
                Workspace.AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void CommittenteModel_Load(object sender, EventArgs e)
        {
            try
            {
                var obj = (CommittenteDto)Model;
                if (obj != null && obj.Id == 0)
                    SetNewValue();

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
                BindViewTotali();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCodiceCommittente_ComboClick()
        {
            try
            {
                var view = new AnagraficaCommittente.AnagraficaCommittenteView();
                view.Title = "SELEZIONA UN COMMITTENTE";
                editCodiceCommittente.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCodiceCommittente_ComboConfirm(object model)
        {
            try
            {
                var anagraficaCommittente = (WcfService.Dto.AnagraficaCommittenteDto)model;
                if (anagraficaCommittente != null)
                {
                    editCodiceCommittente.Value = anagraficaCommittente.Codice;
                    editCAP.Value = anagraficaCommittente.CAP;
                    editComune.Value = new Library.Controls.Countries.City(anagraficaCommittente.Comune, anagraficaCommittente.CodiceCatastale, anagraficaCommittente.Provincia);
                    editEmail.Value = anagraficaCommittente.Email;
                    editFAX.Value = anagraficaCommittente.Fax;
                    editIndirizzo.Value = anagraficaCommittente.Indirizzo;
                    editMobile.Value = anagraficaCommittente.Mobile;
                    editPartitaIVA.Value = anagraficaCommittente.PartitaIva;
                    editRagioneSociale.Value = anagraficaCommittente.RagioneSociale;
                    editTelefono.Value = anagraficaCommittente.Telefono;
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
                    BindViewTotali();
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

                var obj = (CommittenteDto)Model;
                var viewModelCommittente = new Committente.CommittenteViewModel(this);
                var commessa = (CommessaDto)editCommessa.Model;
                var committenti = viewModelCommittente.ReadCommittenti(commessa);
                var codiceCommittente = editCodiceCommittente.Value;
                var viewModelAnagraficaCommittente = new AnagraficaCommittente.AnagraficaCommittenteViewModel(this);
                var anagraficaCommittente = viewModelAnagraficaCommittente.ReadAnagraficaCommittente(codiceCommittente);
                var validateCommittente = BusinessLogic.Diagnostico.ValidateCommittente(obj, committenti, anagraficaCommittente, commessa);
                if (validateCommittente != null)
                {
                    validated.State = validateCommittente.State;
                    validated.Message = validateCommittente.Message;
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
