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

        public override void BindViewTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.CommittenteDto)model;
                    infoSubtitleImage.Image = "Images.dashboard.committente.png";
                    var commessa = obj.Commessa;
                    var anagraficaCommittente = obj.AnagraficaCommittente;
                    if (anagraficaCommittente != null)
                    {
                        infoSubtitle.Text = anagraficaCommittente.Codice + " - " + anagraficaCommittente.RagioneSociale;
                        infoTitle.Text = (obj.Id != 0 ? "COMMITTENTE " + anagraficaCommittente.RagioneSociale + " - COMMESSA " + commessa.Codice : "NUOVO COMMITTENTE");
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
                    var obj = (WcfService.Dto.CommittenteDto)model;
                    editNote.Value = obj.Note;                                      

                    BindViewAnagraficaCommittente(obj.AnagraficaCommittente);
                    BindViewCommessa(obj.Commessa);
                    BindViewFattureVendita(obj.FatturaVenditas);
                    BindViewIncassi(obj.FatturaVenditas);
                    BindViewTotali(obj);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewIncassi(IList<FatturaVenditaDto> fattureVendita)
        {
            try
            {
                var count = (from q in fattureVendita select q.Incassos.Count).Sum();
                btnIncassi.TextButton = "Incassi (" + count + ")";
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

        private void BindViewAnagraficaCommittente(AnagraficaCommittenteDto anagraficaCommittente)
        {
            try
            {
                editCodiceCommittente.Model = anagraficaCommittente;
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
                    editLocalita.Value = anagraficaCommittente.Localita;

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
                    var obj = (WcfService.Dto.CommittenteDto)model;
                    obj.Note = editNote.Value;
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

        private void BindViewTotali(CommittenteDto obj)
        {
            try
            {
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
                btnFattureVendita.Enabled = editing;
                btnIncassi.Enabled = editing;
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

        private void btnFattureVendita_Click(object sender, EventArgs e)
        {
            try
            {
                bool saved = Save();
                if (saved)
                {
                    var obj = (CommittenteDto)Model;
                    var anagraficaCommittente = obj.AnagraficaCommittente;
                    if (anagraficaCommittente != null)
                    {
                        var space = new FatturaVendita.FatturaVenditaView(obj);
                        space.Title = "FATTURE DI VENDITA - " + anagraficaCommittente.RagioneSociale;
                        Workspace.AddSpace(space);
                    }
                }
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
                bool saved = Save();
                if (saved)
                {
                    var obj = (CommittenteDto)Model;
                    var anagraficaCommittente = obj.AnagraficaCommittente;
                    if (anagraficaCommittente != null)
                    {
                        var space = new Incasso.IncassoView(obj);
                        space.Title = "INCASSI - " + anagraficaCommittente.RagioneSociale;
                        Workspace.AddSpace(space);
                    }
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
                BindViewAnagraficaCommittente(anagraficaCommittente);
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
                    var obj = (CommittenteDto)Model;
                    BindViewTotali(obj);
                }
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
                var viewModelCommittente = new Committente.CommittenteViewModel();
                var commessa = (CommessaDto)editCommessa.Model;
                var committenti = viewModelCommittente.ReadCommittenti(commessa);
                var anagraficaCommittente = obj.AnagraficaCommittente; 
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
