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
	public partial class ReportJobFornitoreModel : TemplateModel
	{
        private Tipi.TipoReport tipoReport = Tipi.TipoReport.Fornitore;
        public ReportJobFornitoreModel()
        {
            InitializeComponent();
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

                    var viewModel = new AnagraficaFornitore.AnagraficaFornitoreViewModel();
                    var codiceFornitore = obj.CodiceFornitore;
                    var anagraficaFornitore = viewModel.ReadAnagraficaFornitore(codiceFornitore);
                    var ragioneSociale = (anagraficaFornitore != null ? anagraficaFornitore.RagioneSociale : "N/D");
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
                    BindViewAnagraficaFornitore(obj.CodiceFornitore);
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

        private void BindViewAnagraficaFornitore(string codiceFornitore)
        {
            try
            {
                var viewModelAnagraficaFornitore = new AnagraficaFornitore.AnagraficaFornitoreViewModel();
                var anagraficaFornitore = viewModelAnagraficaFornitore.ReadAnagraficaFornitore(codiceFornitore);
                editFornitore.Model = anagraficaFornitore;
                editFornitore.Value = (anagraficaFornitore != null ? anagraficaFornitore.Codice + " - " + anagraficaFornitore.RagioneSociale : null);
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

                    var anagraficaFornitore = (AnagraficaFornitoreDto)editFornitore.Model;
                    if (anagraficaFornitore != null)
                        obj.CodiceFornitore = anagraficaFornitore.Codice;

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

        private void ReportJobFornitoreModel_Load(object sender, EventArgs e)
        {
            try
            {
                var obj = (ReportJobDto)Model;
                if (obj != null && obj.Id == 0)
                    SetNewValue();
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

        private void SetNewValue()
        {
            try
            {
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

        private void editFornitore_ComboClick()
        {
            try
            {
                var view = new AnagraficaFornitore.AnagraficaFornitoreView();
                view.Title = "SELEZIONA UN FORNITORE";
                editFornitore.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editFornitore_ComboConfirm(object model)
        {
            try
            {
                var anagraficaFornitore = (AnagraficaFornitoreDto)model;
                if (anagraficaFornitore != null)
                {
                    editFornitore.Value = anagraficaFornitore.Codice + " - " + anagraficaFornitore.RagioneSociale;
                }
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
                bool saved = Save();
                if (saved)
                {
                    var anagraficaFornitore = (AnagraficaFornitoreDto)editFornitore.Model;
                    if (anagraficaFornitore != null)
                    {
                        var ragioneSocialeFornitore = (anagraficaFornitore.RagioneSociale != null ? anagraficaFornitore.RagioneSociale.Replace(" ", "") : "N/D");
                        var data = DateTime.Today.ToString("ddMMyyyy");
                        var elaborazione = UtilityValidation.GetData(editElaborazione.Value);
                        string pathTemplate = UtilityWeb.GetRootPath(Context) + @"Resources\Templates\TemplateSituazioneFornitore.doc";
                        var fileName = "SituazioneFornitore_" + ragioneSocialeFornitore + "_" + data + ".PDF";
                        var pathReport = UtilityWeb.GetRootPath(Context) + @"Resources\Reports\" + fileName;
                        var account = SessionManager.GetAccount(Context);
                        var viewModelAzienda = new Azienda.AziendaViewModel();
                        var azienda = viewModelAzienda.ReadAzienda(account);
                        var viewModelFornitore = new Fornitore.FornitoreViewModel();
                        var fornitori = viewModelFornitore.ReadFornitori(anagraficaFornitore);

                        var report = BusinessLogic.ReportJob.GetReportFornitore(azienda, anagraficaFornitore, fornitori.ToList(), elaborazione);
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
                if (azienda != null)
                    editAzienda.Value = azienda.RagioneSociale;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


	}
}
