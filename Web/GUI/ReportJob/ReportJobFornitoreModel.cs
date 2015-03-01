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
                    var obj = (ReportJobDto)model;
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
                    var obj = (ReportJobDto)model;
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
                var viewModel = (ReportJobViewModel)ViewModel;
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
                    var obj = (ReportJobDto)model;
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
                var anagraficaFornitore = (AnagraficaFornitoreDto)editFornitore.Model;
                if (anagraficaFornitore != null)
                {
                    var codiceFornitore = anagraficaFornitore.Codice;
                    var data = DateTime.Today.ToString("ddMMyyyy");
                    var elaborazione = UtilityValidation.GetData(editElaborazione.Value);
                    string pathTemplate = UtilityWeb.GetRootPath(Context) + @"Resources\Templates\TemplateSituazioneFornitore.doc";
                    var fileName = "SituazioneFornitore_" + codiceFornitore + "_" + data + ".PDF";
                    var pathReport = UtilityWeb.GetRootPath(Context) + @"Resources\Reports\" + fileName;

                    var account = SessionManager.GetAccount(Context);
                    var viewModelAzienda = new Azienda.AziendaViewModel(this);
                    var azienda = viewModelAzienda.ReadAzienda(account);

                    var report = new UtilityReport.Report();

                    //azienda e dati generali
                    AddReportAzienda(azienda, elaborazione, report);
 
                    //fornitore
                    AddReportFornitore(anagraficaFornitore, report);
                    
                    //totali fornitore
                    var viewModelFornitore = new Fornitore.FornitoreViewModel(this);
                    var fornitori = viewModelFornitore.ReadFornitori(codiceFornitore).ToList();
                    AddReportTotaliFornitore(elaborazione, fornitori, report);

                    //totali per commessa
                    var tableCommesse = new UtilityReport.Table("Commessa", "TotaleImponibile", "TotaleIVA", "TotaleFatture", "TotalePagamentiDato", "TotalePagamentiDare");
                    var tableFatture = new UtilityReport.Table("Numero", "Data", "Scadenza", "Descrizione", "Imponibile", "IVA", "Totale", "TotalePagamentiDato", "TotalePagamentiDare");
                    foreach (var fornitore in fornitori)
                    {
                        AddReportCommessaFornitore(elaborazione, tableCommesse, fornitore);

                        //totali per fattura
                        var fattureAcquisto = fornitore.FatturaAcquistos;
                        foreach (var fatturaAcquisto in fattureAcquisto)
                            AddReportFatturaAcquistoFornitore(elaborazione, tableFatture, fatturaAcquisto);
                    
                    }
                    report.Tables.Add(tableCommesse);
                    report.Tables.Add(tableFatture);

                    bool performed = report.Create(pathTemplate, pathReport);
                    if (performed)
                    {
                        string url = UtilityWeb.GetRootUrl(Context) + @"/Resources/Reports/"+fileName;
                        editNomeFile.Url = url;
                        editNomeFile.Value = fileName;

                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void AddReportAzienda(AziendaDto azienda, DateTime elaborazione, UtilityReport.Report report)
        {
            try
            {
                report.AddData("RagioneSocialeAzienda", azienda.RagioneSociale);
                report.AddData("IndirizzoAzienda", azienda.Indirizzo + " " + azienda.CAP + " " + azienda.Comune+ " ("+azienda.Provincia+")");
                report.AddData("TelefonoAzienda", azienda.Telefono, TypeFormat.StringND);
                report.AddData("EmailAzienda", azienda.Email, TypeFormat.StringND);
                report.AddData("PartitaIvaAzienda", azienda.PartitaIva, TypeFormat.StringND);
                report.AddData("Elaborazione", elaborazione, TypeFormat.DateDDMMYYYY);

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
        

        private static void AddReportFatturaAcquistoFornitore(DateTime elaborazione, UtilityReport.Table tableFatture, FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                var numero = fatturaAcquisto.Numero;
                var dataFattura = UtilityValidation.GetDataND(fatturaAcquisto.Data);
                var scadenza = UtilityValidation.GetDataND(BusinessLogic.Fattura.GetScadenza(fatturaAcquisto));
                var descrizione = fatturaAcquisto.Descrizione;
                var imponibile = UtilityValidation.GetEuro(fatturaAcquisto.Imponibile);
                var iva = UtilityValidation.GetEuro(fatturaAcquisto.IVA);
                var totale = UtilityValidation.GetEuro(fatturaAcquisto.Totale);
                var totalePagamentiFatturaDato = UtilityValidation.GetEuro(BusinessLogic.Fattura.GetTotalePagamenti(fatturaAcquisto, elaborazione));
                var totalePagamentiFatturaDare = UtilityValidation.GetEuro(BusinessLogic.Fattura.GetTotalePagamentiDare(fatturaAcquisto, elaborazione));

                tableFatture.AddRow(numero, dataFattura, scadenza, descrizione, imponibile, iva, totale, totalePagamentiFatturaDato, totalePagamentiFatturaDare);

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static void AddReportCommessaFornitore(DateTime elaborazione, UtilityReport.Table tableCommesse, FornitoreDto fornitore)
        {
            try
            {
                var commessa = fornitore.Commessa;
                var _commessa = commessa.Codice + " - " + commessa.Denominazione;
                var totaleImponibile = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotaleImponibile(fornitore, elaborazione));
                var totaleIVA = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotaleIVA(fornitore, elaborazione));
                var totaleFatture = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotaleFatture(fornitore, elaborazione));
                var totalePagamentiDato = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotalePagamenti(fornitore, elaborazione));
                var totalePagamentiDare = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotalePagamentiDare(fornitore, elaborazione));

                tableCommesse.AddRow(_commessa, totaleImponibile, totaleIVA, totaleFatture, totalePagamentiDato, totalePagamentiDare);

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static void AddReportTotaliFornitore(DateTime elaborazione, IList<FornitoreDto> fornitori, UtilityReport.Report report)
        {
            try
            {
                report.AddData("TotaleImponibileFornitore", BusinessLogic.Fornitore.GetTotaleImponibile(fornitori, elaborazione), TypeFormat.Euro);
                report.AddData("TotaleIVAFornitore", BusinessLogic.Fornitore.GetTotaleIVA(fornitori, elaborazione), TypeFormat.Euro);
                report.AddData("TotaleFattureFornitore", BusinessLogic.Fornitore.GetTotaleFatture(fornitori, elaborazione), TypeFormat.Euro);
                report.AddData("TotalePagamentiDatoFornitore", BusinessLogic.Fornitore.GetTotalePagamenti(fornitori, elaborazione), TypeFormat.Euro);
                report.AddData("TotalePagamentiDareFornitore", BusinessLogic.Fornitore.GetTotalePagamentiDare(fornitori, elaborazione), TypeFormat.Euro);

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static void AddReportFornitore(AnagraficaFornitoreDto anagraficaFornitore, UtilityReport.Report report)
        {
            try
            {
                report.AddData("RagioneSociale", anagraficaFornitore.RagioneSociale);
                report.AddData("PartitaIva", anagraficaFornitore.PartitaIva);
                report.AddData("Indirizzo", anagraficaFornitore.Indirizzo);
                report.AddData("CAP", anagraficaFornitore.CAP);
                report.AddData("Localita", anagraficaFornitore.Localita);
                report.AddData("Comune", anagraficaFornitore.Comune);
                report.AddData("Provincia", anagraficaFornitore.Provincia);

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

        private void SetNewValue()
        {
            try
            {
                editCodice.Value = GetCodice();
                editDenominazione.Value = GetDenominazione(tipoReport);
                editElaborazione.Value = DateTime.Today;
                editCreazione.Value = DateTime.Today;
                editTipoReport.Value = tipoReport.ToString();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


	}
}
