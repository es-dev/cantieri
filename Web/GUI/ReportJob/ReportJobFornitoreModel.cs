using BusinessLogic;
using Library.Code;
using Library.Code.Enum;
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
        private BusinessLogic.Tipi.TipoReport tipoReport = Tipi.TipoReport.None;
        public ReportJobFornitoreModel(BusinessLogic.Tipi.TipoReport tipoReport = Tipi.TipoReport.None)
        {
            InitializeComponent();
            try
            {
                InitCombo();
                this.tipoReport = tipoReport;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void InitCombo()
        {
            try
            {
                editTipoReport.DisplayValues = UtilityEnum.GetDisplayValues<Tipi.TipoReport>();
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
                    var obj = (WcfService.Dto.ReportJobDto)model;
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    infoSubtitle.Text = codice;
                    infoSubtitleImage.Image = "Images.dashboard.reportjob.png";
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
                    var obj = (WcfService.Dto.ReportJobDto)model;
                    editNote.Value = obj.Note;
                    var codiceFornitore = obj.CodiceFornitore;
                    var viewModelAnagraficaFornitore = new AnagraficaFornitore.AnagraficaFornitoreViewModel(this);
                    var anagraficaFornitore = viewModelAnagraficaFornitore.ReadAnagraficaFornitore(codiceFornitore);
                    if (anagraficaFornitore != null)
                    {
                        editFornitore.Model = anagraficaFornitore;
                        editFornitore.Value = anagraficaFornitore.Codice + " - " + anagraficaFornitore.RagioneSociale;
                    }
                    editCodice.Value = obj.Codice;
                    editDenominazione.Value = obj.Denominazione;
                    editElaborazione.Value = obj.Elaborazione;
                    editCreazione.Value = obj.Creazione;
                    editTipoReport.Value = obj.Tipo;

                    var fileName = obj.NomeFile;
                    editNomeFile.Value = fileName;
                    if (fileName != null && fileName.Length > 0)
                    {
                        var url = UtilityWeb.GetRootUrl(Context) + "/Resources/Reports/" + fileName;
                        editNomeFile.Url = url;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private string GetDenominazione(Tipi.TipoReport tipoReport)
        {
            try
            {
                var description = UtilityEnum.GetDescription<Tipi.TipoReport>(tipoReport.ToString());
                var denominazione = "Report generato per l'analisi di: " + description;
                return denominazione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private string GetCodice()
        {
            try
            {
                var viewModel = (ReportJob.ReportJobViewModel)ViewModel;
                var count = viewModel.GetCount();
                count += 1;
                var codice = "RPT" + count.ToString("000")+"/"+DateTime.Today.Year.ToString();
                return codice;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public override void BindModel(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.ReportJobDto)model;
                    obj.Denominazione = editDenominazione.Value;
                    obj.Codice = editCodice.Value;
                    obj.Note= editNote.Value;
                    obj.Creazione = editCreazione.Value;
                    obj.Elaborazione = editElaborazione.Value;
                    obj.Tipo = editTipoReport.Value;
                    obj.NomeFile = editNomeFile.Value;
                    var anagraficaFornitore = (AnagraficaFornitoreDto)editFornitore.Model;
                    if (anagraficaFornitore != null)
                        obj.CodiceFornitore = anagraficaFornitore.Codice;

                }
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
                var anagraficaFornitore = (WcfService.Dto.AnagraficaFornitoreDto)model;
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
                var anagraficaFornitore = (AnagraficaFornitoreDto)editFornitore.Model;
                if (anagraficaFornitore != null)
                {
                    var codiceFornitore = anagraficaFornitore.Codice;
                    var data = DateTime.Today.ToString("ddMMyyyy");
                    var elaborazione = editElaborazione.Value;
                    string pathTemplateWord = UtilityWeb.GetRootPath(Context) + @"Resources\Templates\TemplateSituazioneFornitore.doc";
                    var fileNamePDF = "SituazioneFornitore_" + codiceFornitore + "_" + data + ".PDF";
                    var pathReportPDF = UtilityWeb.GetRootPath(Context) + @"Resources\Reports\" + fileNamePDF;
                    var report = new UtilityReport.Report();

                    //header
                    report.AddData("RagioneSociale", anagraficaFornitore.RagioneSociale);
                    report.AddData("PartitaIva", anagraficaFornitore.PartitaIva);
                    report.AddData("Indirizzo", anagraficaFornitore.Indirizzo);
                    report.AddData("CAP", anagraficaFornitore.CAP);
                    report.AddData("Localita", anagraficaFornitore.Localita);
                    report.AddData("Comune", anagraficaFornitore.Comune);
                    report.AddData("Provincia", anagraficaFornitore.Provincia);
                    
                    //totali fornitre
                    var viewModelFornitore = new Fornitore.FornitoreViewModel(this);
                    var fornitori = viewModelFornitore.ReadFornitori(codiceFornitore).ToList();
                    report.AddData("TotaleImponibileFornitore", BusinessLogic.Fornitore.GetTotaleImponibile(fornitori, elaborazione.Value), TypeFormat.Euro);
                    report.AddData("TotaleIVAFornitore", BusinessLogic.Fornitore.GetTotaleIVA(fornitori, elaborazione.Value), TypeFormat.Euro);
                    report.AddData("TotaleFattureFornitore", BusinessLogic.Fornitore.GetTotaleFatture(fornitori, elaborazione.Value), TypeFormat.Euro);
                    report.AddData("TotalePagamentiDatoFornitore", BusinessLogic.Fornitore.GetTotalePagamenti(fornitori, elaborazione.Value), TypeFormat.Euro);
                    report.AddData("TotalePagamentiDareFornitore", BusinessLogic.Fornitore.GetTotalePagamentiDare(fornitori, elaborazione.Value), TypeFormat.Euro);

                    //totali per commessa
                    var tableCommesse = new UtilityReport.Table("Commessa", "TotaleImponibile", "TotaleIVA", "TotaleFatture", "TotalePagamentiDato", "TotalePagamentiDare");
                    var tableFatture = new UtilityReport.Table("Numero", "Data", "Scadenza", "Descrizione", "Imponibile", "IVA", "Totale", "TotalePagamentiDato", "TotalePagamentiDare");
                    foreach (var fornitore in fornitori)
                    {
                        var commessa = fornitore.Commessa;
                        var _commessa = commessa.Codice + " - " + commessa.Denominazione;
                        var totaleImponibile = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotaleImponibile(fornitore, elaborazione.Value));
                        var totaleIVA = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotaleIVA(fornitore, elaborazione.Value));
                        var totaleFatture = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotaleFatture(fornitore, elaborazione.Value));
                        var totalePagamentiDato = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotalePagamenti(fornitore, elaborazione.Value));
                        var totalePagamentiDare = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotalePagamentiDare(fornitore, elaborazione.Value));

                        tableCommesse.AddRow(_commessa, totaleImponibile, totaleIVA, totaleFatture, totalePagamentiDato, totalePagamentiDare);

                        var fattureAcquisto = fornitore.FatturaAcquistos;
                        foreach (var fatturaAcquisto in fattureAcquisto)
                        {
                            var numero = fatturaAcquisto.Numero;
                            var dataFattura = UtilityValidation.GetDataND(fatturaAcquisto.Data);
                            var scadenza = UtilityValidation.GetDataND(BusinessLogic.Fattura.GetScadenza(fatturaAcquisto));
                            var descrizione = fatturaAcquisto.Descrizione;
                            var imponibile = UtilityValidation.GetEuro(fatturaAcquisto.Imponibile);
                            var iva = UtilityValidation.GetEuro(fatturaAcquisto.IVA);
                            var totale = UtilityValidation.GetEuro(fatturaAcquisto.Totale);
                            var totalePagamentiFatturaDato = UtilityValidation.GetEuro(BusinessLogic.Fattura.GetTotalePagamenti(fatturaAcquisto, elaborazione.Value));
                            var totalePagamentiFatturaDare = UtilityValidation.GetEuro(BusinessLogic.Fattura.GetTotalePagamentiDare(fatturaAcquisto, elaborazione.Value));

                            tableFatture.AddRow(numero, dataFattura, scadenza, descrizione, imponibile, iva, totale, totalePagamentiFatturaDato, totalePagamentiFatturaDare);
                        }
                    }
                    report.Tables.Add(tableCommesse);
                    report.Tables.Add(tableFatture);

                    bool performed = report.Create(pathTemplateWord, pathReportPDF);
                    if (performed)
                    {
                        string url = UtilityWeb.GetRootUrl(Context) + @"/Resources/Reports/"+fileNamePDF;
                        editNomeFile.Url = url;
                        editNomeFile.Value = fileNamePDF;

                    }
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
                var obj = (WcfService.Dto.ReportJobDto)Model;
                if (obj != null && obj.Id == 0)
                {
                    editCodice.Value = GetCodice();
                    editDenominazione.Value = GetDenominazione(tipoReport);
                    editElaborazione.Value = DateTime.Today;
                    editCreazione.Value = DateTime.Today;
                    editTipoReport.Value = tipoReport.ToString();
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


	}
}
