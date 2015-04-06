using Library.Code;
using Library.Code.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;
using System.Drawing;

namespace BusinessLogic
{
    public class ReportJob
    {
        public static string GetDenominazione(Tipi.TipoReport tipoReport)
        {
            try
            {
                var description = UtilityEnum.GetDescription<Tipi.TipoReport>(tipoReport);
                var denominazione = "Report generato per l'analisi di: " + description;
                return denominazione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetCodice(int count)
        {
            try
            {
                var progressivo = count+1;
                var codice = "RPT" + progressivo.ToString("000") + "/" + DateTime.Today.Year.ToString();
                return codice;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static UtilityReport.Report GetReportFornitore(AziendaDto azienda, AnagraficaFornitoreDto anagraficaFornitore, IEnumerable<FornitoreDto> fornitori, DateTime data)
        {
            try
            {
                var report = new UtilityReport.Report();

                AddReportAzienda(azienda, report, data);
                AddReportFornitore(anagraficaFornitore, report);
                AddReportTotaliFornitore(fornitori.ToList(), report, data);

                var tableCommesse = new UtilityReport.Table("Commessa", "TotaleImponibile", "TotaleIVA", "TotaleFatture", "TotalePagamentiDato", "TotalePagamentiDare");
                var tableFatture = new UtilityReport.Table("Numero", "Data", "Scadenza", "Descrizione", "Imponibile", "IVA", "Totale", "TotalePagamentiDato", "TotalePagamentiDare");
                var tablePagamenti = new UtilityReport.Table("Numero", "Data", "TipoPagamento", "Descrizione", "Note", "Importo");
                foreach (var fornitore in fornitori)
                {
                    //totali per commessa
                    var commessa = fornitore.Commessa;
                    AddReportCommessaFornitore(tableCommesse, fornitore, commessa, data);

                    //fatture per commessa
                    var codificaCommessa = "COMMESSA " + commessa.Codice + " - " + commessa.Denominazione;
                    tableFatture.AddRowMerge(Color.LightGray, codificaCommessa, "", "", "", "", "", "", "", "");
                    var fattureAcquisto = fornitore.FatturaAcquistos;
                    foreach (var fatturaAcquisto in fattureAcquisto)
                    {
                        AddReportFatturaAcquistoFornitore(tableFatture, fatturaAcquisto, data);

                        //pagamenti per fattura
                        var totaleFattura = UtilityValidation.GetEuro(fatturaAcquisto.Totale);
                        var _statoFattura = BusinessLogic.Fattura.GetStato(fatturaAcquisto);
                        var statoFattura = UtilityEnum.GetDescription<Tipi.StatoFattura>(_statoFattura);
                        var codificaFattura = "FATTURA N." + fatturaAcquisto.Numero + " del " + fatturaAcquisto.Data.Value.ToString("dd/MM/yyyy") + " - TOTALE IVATO " + totaleFattura + " - " + statoFattura.ToUpper();
                        tablePagamenti.AddRowMerge(Color.LightGray, codificaFattura, "", "", "", "", "");
                        var pagamenti = (from q in fatturaAcquisto.Pagamentos orderby q.Data ascending select q).ToList();
                        foreach (var pagamento in pagamenti)
                            AddReportPagamentoFornitore(tablePagamenti, pagamento);

                        //sconto
                        var _sconto = UtilityValidation.GetDecimal(fatturaAcquisto.Sconto);
                        if (_sconto > 0)
                        {
                            var sconto = UtilityValidation.GetEuro(_sconto);
                            tablePagamenti.AddRow("", "", "", "", "SCONTO", sconto);
                        }

                        //nota di credito/resi
                        var _totaleResi = BusinessLogic.Fattura.GetTotaleResi(fatturaAcquisto);
                        if (_totaleResi > 0)
                        {
                            var totaleResi = UtilityValidation.GetEuro(_totaleResi);
                            tablePagamenti.AddRow("", "", "", "", "NOTA DI CREDITO", totaleResi);
                        }
                    }
                }
                report.Tables.Add(tableCommesse);
                report.Tables.Add(tableFatture);
                report.Tables.Add(tablePagamenti);

                return report;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static void AddReportPagamentoFornitore(UtilityReport.Table tablePagamenti, PagamentoDto pagamento)
        {
            try
            {
                var numero = pagamento.Codice;
                var data = UtilityValidation.GetDataND(pagamento.Data);
                var tipoPagamento = pagamento.TipoPagamento;
                var descrizione = pagamento.Descrizione;
                var note = pagamento.Note;
                var importo = UtilityValidation.GetEuro(pagamento.Importo);

                tablePagamenti.AddRow(numero, data, tipoPagamento, descrizione, note, importo);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static void AddReportFatturaAcquistoFornitore(UtilityReport.Table tableFatture, FatturaAcquistoDto fatturaAcquisto, DateTime data)
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
                var totalePagamentiFatturaDato = UtilityValidation.GetEuro(BusinessLogic.Fattura.GetTotalePagamenti(fatturaAcquisto, data));
                var totalePagamentiFatturaDare = UtilityValidation.GetEuro(BusinessLogic.Fattura.GetTotalePagamentiDare(fatturaAcquisto, data));

                tableFatture.AddRow(numero, dataFattura, scadenza, descrizione, imponibile, iva, totale, totalePagamentiFatturaDato, totalePagamentiFatturaDare);

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static void AddReportCommessaFornitore(UtilityReport.Table tableCommesse, FornitoreDto fornitore, CommessaDto commessa, DateTime data)
        {
            try
            {
                var _commessa = commessa.Codice + " - " + commessa.Denominazione;
                var totaleImponibile = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotaleImponibile(fornitore, data));
                var totaleIVA = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotaleIVA(fornitore, data));
                var totaleFattureAcquisto = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotaleFattureAcquisto(fornitore, data));
                var totalePagamentiDato = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotalePagamenti(fornitore, data));
                var totalePagamentiDare = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotalePagamentiDare(fornitore, data));

                tableCommesse.AddRow(_commessa, totaleImponibile, totaleIVA, totaleFattureAcquisto, totalePagamentiDato, totalePagamentiDare);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static void AddReportTotaliFornitore(IList<FornitoreDto> fornitori, UtilityReport.Report report, DateTime data)
        {
            try
            {
                report.AddData("TotaleImponibileFornitore", BusinessLogic.Commessa.GetTotaleImponibile(fornitori, data), TypeFormat.Euro);
                report.AddData("TotaleIVAFornitore", BusinessLogic.Commessa.GetTotaleIVA(fornitori, data), TypeFormat.Euro);
                report.AddData("TotaleFattureFornitore", BusinessLogic.Commessa.GetTotaleFattureAcquisto(fornitori, data), TypeFormat.Euro);
                report.AddData("TotalePagamentiDatoFornitore", BusinessLogic.Commessa.GetTotalePagamenti(fornitori, data), TypeFormat.Euro);
                report.AddData("TotalePagamentiDareFornitore", BusinessLogic.Commessa.GetTotalePagamentiDare(fornitori, data), TypeFormat.Euro);
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

        private static void AddReportAzienda(AziendaDto azienda, UtilityReport.Report report, DateTime data)
        {
            try
            {
                report.AddData("RagioneSocialeAzienda", azienda.RagioneSociale);
                report.AddData("IndirizzoAzienda", azienda.Indirizzo + " " + azienda.CAP + " " + azienda.Comune + " (" + azienda.Provincia + ")");
                report.AddData("TelefonoAzienda", azienda.Telefono, TypeFormat.StringND);
                report.AddData("EmailAzienda", azienda.Email, TypeFormat.StringND);
                report.AddData("PartitaIvaAzienda", azienda.PartitaIva, TypeFormat.StringND);
                report.AddData("Elaborazione", data, TypeFormat.DateDDMMYYYY);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


    }
}
