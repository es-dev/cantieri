using BusinessLogic;
using Library.Code;
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
using System.Collections;

namespace Web.GUI.ReportJob
{
	public partial class ReportJobCommittenteModel : TemplateModel
	{
        private Tipi.TipoReport tipoReport = Tipi.TipoReport.Committente;
        public ReportJobCommittenteModel()
        {
            InitializeComponent();
        }

        public override void SetNewValue(object model)
        {
            try
            {
                var azienda = SessionManager.GetAzienda(Context);
                BindViewAzienda(azienda);

                var viewModel = (ReportJobViewModel)ViewModel;
                var count = viewModel.Count();
                editCodice.Value = BusinessLogic.ReportJob.GetCodice(count);
                editDenominazione.Value = BusinessLogic.ReportJob.GetDenominazione(tipoReport);
                editElaborazione.Value = DateTime.Today;
                editCreazione.Value = DateTime.Today;
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
                    var obj = (ReportJobDto)model;
                    infoSubtitle.Text = "RTP N." + obj.Codice + " - Tipo " + obj.Tipo;
                    infoSubtitleImage.Image = "Images.dashboard.reportjob.png";

                    var anagraficaCommittente = obj.AnagraficaCommittente;
                    var ragioneSociale = (anagraficaCommittente != null ? anagraficaCommittente.RagioneSociale : "N/D");
                    infoTitle.Text = (obj.Id!=0? "REPORT " + obj.Codice + " - " + ragioneSociale:"NUOVO REPORT");
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
                    var obj = (ReportJobDto)model;
                    editNote.Value = obj.Note;
                    editCodice.Value = obj.Codice;
                    editDenominazione.Value = obj.Denominazione;
                    editElaborazione.Value = obj.Elaborazione;
                    editCreazione.Value = obj.Creazione;

                    var fileName = obj.NomeFile;
                    BindViewReport(fileName);
                    BindViewAnagraficaCommittente(obj.AnagraficaCommittente);
                    BindViewAzienda(obj.Azienda);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewAzienda(AziendaDto azienda)
        {
            try
            {
                editAzienda.Model = azienda;
                editAzienda.Value = (azienda != null ? azienda.Codice + " - " + azienda.RagioneSociale : null);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewReport(string fileName)
        {
            try
            {
                string url = null;
                if (fileName != null && fileName.Length > 0)
                    url = UtilityWeb.GetRootUrl(Context) + "/Resources/Reports/" + fileName;
                
                editNomeFile.Url = url;
                editNomeFile.Value = fileName;
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
                editCommittente.Model = anagraficaCommittente;
                editCommittente.Value = (anagraficaCommittente != null ? anagraficaCommittente.Codice + " - " + anagraficaCommittente.RagioneSociale : null);
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
                    var obj = (ReportJobDto)model;
                    obj.Denominazione = editDenominazione.Value;
                    obj.Codice = editCodice.Value;
                    obj.Note= editNote.Value;
                    obj.Creazione = editCreazione.Value;
                    obj.Elaborazione = editElaborazione.Value;
                    obj.Tipo = tipoReport.ToString();
                    obj.NomeFile = editNomeFile.Value;

                    var anagraficaCommittente = (AnagraficaCommittenteDto)editCommittente.Model;
                    if (anagraficaCommittente != null)
                        obj.AnagraficaCommittenteId = anagraficaCommittente.Id;

                    var azienda = (WcfService.Dto.AziendaDto)editAzienda.Model;
                    if (azienda != null)
                        obj.AziendaId = azienda.Id;

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
                btnStampaReport.Enabled = editing;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCommittente_ComboClick()
        {
            try
            {
                var view = new AnagraficaCommittente.AnagraficaCommittenteView();
                view.Title = "SELEZIONA UN COMMITTENTE";
                editCommittente.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCommittente_ComboConfirm(object model)
        {
            try
            {
                var anagraficaCommittente = (AnagraficaCommittenteDto)model;
                BindViewAnagraficaCommittente(anagraficaCommittente);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnStampaReport_Click(object sender, EventArgs e)
        {
            try
            {
                var anagraficaCommittente = (AnagraficaCommittenteDto)editCommittente.Model;
                if (anagraficaCommittente != null)
                {
                    var ragioneSocialeCommittente = (anagraficaCommittente.RagioneSociale != null ? anagraficaCommittente.RagioneSociale.Replace(" ", "") : "N/D");
                    var data = DateTime.Today.ToString("ddMMyyyy");
                    var elaborazione = UtilityValidation.GetData(editElaborazione.Value);
                    string pathTemplate = UtilityWeb.GetRootPath(Context) + @"Resources\Templates\TemplateSituazioneCommittente.doc";
                    var fileName = "SituazioneCommittente_" + ragioneSocialeCommittente + "_" + data + ".PDF";
                    var pathReport = UtilityWeb.GetRootPath(Context) + @"Resources\Reports\" + fileName;
                    var account = SessionManager.GetAccount(Context);
                    var viewModelAzienda = new Azienda.AziendaViewModel();
                    var azienda = viewModelAzienda.ReadAzienda(account);
                    var viewModelCommittente = new Committente.CommittenteViewModel();
                    var committenti = viewModelCommittente.ReadCommittenti(anagraficaCommittente);

                    var report = BusinessLogic.ReportJob.GetReportCommittente(azienda, anagraficaCommittente, committenti.ToList(), elaborazione);
                    if (report != null)
                    {
                        bool performed = report.Create(pathTemplate, pathReport);
                        if (performed)
                        {
                            string url = UtilityWeb.GetRootUrl(Context) + @"/Resources/Reports/" + fileName;
                            editNomeFile.Url = url;
                            editNomeFile.Value = fileName;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editAzienda_ComboClick()
        {
            try
            {
                var view = new Azienda.AziendaView();
                view.Title = "SELEZIONA UN'AZIENDA";
                editAzienda.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editAzienda_ComboConfirm(object model)
        {
            try
            {
                var azienda = (WcfService.Dto.AziendaDto)model;
                BindViewAzienda(azienda);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
	}
}
