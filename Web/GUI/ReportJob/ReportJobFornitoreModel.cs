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
        public ReportJobFornitoreModel(BusinessLogic.Tipi.TipoReport tipoReport)
        {
            InitializeComponent();
            try
            {
                this.tipoReport = tipoReport;
                InitCombo();
                SetTipoReport(tipoReport);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetTipoReport(Tipi.TipoReport tipoReport)
        {
            try
            {
                editTipoReport.Value = tipoReport.ToString();
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
                    editDenominazione.Value = obj.Denominazione;
                    editCodice.Value = obj.Codice;
                    editNote.Value = obj.Note;
                    editCreazione.Value = obj.Creazione;
                    editElaborazione.Value = obj.Elaborazione;
                    editTipoReport.Value = obj.Tipo;
                    var codiceFornitore = obj.CodiceFornitore;
                    var viewModelAnagraficaFornitore = new AnagraficaFornitore.AnagraficaFornitoreViewModel(this);
                    var anagraficaFornitore = viewModelAnagraficaFornitore.ReadAnagraficaFornitore(codiceFornitore);
                    if (anagraficaFornitore != null)
                    {
                        editFornitore.Model = anagraficaFornitore;
                        editFornitore.Value = anagraficaFornitore.Codice + " - " + anagraficaFornitore.RagioneSociale;
                    }
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
                    var obj = (WcfService.Dto.ReportJobDto)model;
                    obj.Denominazione = editDenominazione.Value;
                    obj.Codice = editCodice.Value;
                    obj.Note= editNote.Value;
                    obj.Creazione = editCreazione.Value;
                    obj.Elaborazione = editElaborazione.Value;
                    obj.Tipo = editTipoReport.Value;
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

                    //devi ottenere tutti i fornitori di questa anagrafica nelle commesse
                    var ragioneSociale = UtilityValidation.GetStringND(anagraficaFornitore.RagioneSociale);
                    var partitaIva = UtilityValidation.GetStringND(anagraficaFornitore.PartitaIva);
                    var indirizzo = UtilityValidation.GetStringND(anagraficaFornitore.Indirizzo);
                    var cap = UtilityValidation.GetStringND(anagraficaFornitore.CAP);
                    var localita = UtilityValidation.GetStringND(anagraficaFornitore.Localita);
                    var comune = UtilityValidation.GetStringND(anagraficaFornitore.Comune);
                    var provincia = UtilityValidation.GetStringND(anagraficaFornitore.Provincia);
                    report.AddData("RagioneSociale", ragioneSociale);
                    report.AddData("PartitaIva", partitaIva);
                    report.AddData("Indirizzo", indirizzo);
                    report.AddData("CAP", cap);
                    report.AddData("Localita", localita);
                    report.AddData("Comune", comune);
                    report.AddData("Provincia", provincia);
                    
                    var viewModelFornitore = new Fornitore.FornitoreViewModel(this);
                    var fornitori = viewModelFornitore.ReadFornitori(codiceFornitore).ToList();

                    var totaleImponibileFornitore = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotaleImponibile(fornitori, elaborazione.Value));
                    var totaleIVAFornitore = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotaleIVA(fornitori, elaborazione.Value));
                    var totaleFattureFornitore = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotaleFatture(fornitori, elaborazione.Value));
                    var totalePagamentiDatoFornitore = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotalePagamenti(fornitori, elaborazione.Value));
                    var totalePagamentiDareFornitore = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotalePagamentiDare(fornitori, elaborazione.Value));

                    report.AddData("TotaleImponibileFornitore", totaleImponibileFornitore);
                    report.AddData("TotaleIVAFornitore", totaleIVAFornitore);
                    report.AddData("TotaleFattureFornitore", totaleFattureFornitore);
                    report.AddData("TotalePagamentiDatoFornitore", totalePagamentiDatoFornitore);
                    report.AddData("TotalePagamentiDareFornitore", totalePagamentiDareFornitore);

                    //var viewModelCommessa = new Commessa.CommessaViewModel(this);
                    //var commesse = viewModelCommessa.ReadCommesse(fornitori);


                    var tableCommessa = new UtilityReport.Table("Commessa", "TotaleImponibile", "TotaleIVA", "TotaleFatture", "TotalePagamentiDato", "TotalePagamentiDare");
                    foreach (var fornitore in fornitori)
                    {
                        var commessa = fornitore.Commessa;
                        var _commessa = commessa.Codice + " - " + commessa.Denominazione;
                        var totaleImponibile = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotaleImponibile(fornitore, elaborazione.Value));
                        var totaleIVA = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotaleIVA(fornitore, elaborazione.Value));
                        var totaleFatture = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotaleFatture(fornitore, elaborazione.Value));
                        var totalePagamentiDato = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotalePagamenti(fornitore, elaborazione.Value));
                        var totalePagamentiDare = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotalePagamentiDare(fornitore, elaborazione.Value));

                        tableCommessa.AddRow(_commessa, totaleImponibile, totaleIVA, totaleFatture, totalePagamentiDato, totalePagamentiDare);

                    //    var tableFornitore = new UtilityReport.Table("Numero", "Data", "Scadenza", "Descrizione", "Imponibile", "IVA", "Totale", "TotalePagamenti", "Dare");
                    //    foreach (var fornitore in fornitori)
                    //    {
                    //        tableFornitore.AddRow(numero, data, scadenza, descrizione, imponibile, iva, totale, totalePagamenti, dare);
                    //    }
                    //    report.Tables.Add(tableFornitore);
                    }
                    report.Tables.Add(tableCommessa);

                    bool performed = report.Create(pathTemplateWord, pathReportPDF);
                    if (performed)
                    {
                        string url = UtilityWeb.GetRootUrl(Context) + @"/Resources/Reports/"+fileNamePDF;
                        editReport.RegisterClientAction("open", url);
                        editReport.Text = "Open Report.PDF";

                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


	}
}
