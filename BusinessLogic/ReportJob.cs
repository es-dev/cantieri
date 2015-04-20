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
                var codice = progressivo.ToString("000") + "/" + DateTime.Today.Year.ToString();
                return codice;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static UtilityReport.Report GetReportFornitore(AziendaDto azienda, AnagraficaFornitoreDto anagraficaFornitore, IList<FornitoreDto> fornitori, DateTime data)
        {
            try
            {
                var report = new UtilityReport.Report();

                AddReportAzienda(azienda, report, data);
                AddReportProspettoFornitore(anagraficaFornitore, report);
                AddReportTotaliFornitore(fornitori, report, data);

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
                        var codificaFattura = BusinessLogic.Fattura.GetCodifica(fatturaAcquisto) + " - TOTALE IVATO " + totaleFattura + " - " + statoFattura.ToUpper();
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
                var totalePagamentiFatturaDato = UtilityValidation.GetEuro(BusinessLogic.Fattura.GetTotalePagamentiDato(fatturaAcquisto, data));
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
                var totalePagamentiDato = UtilityValidation.GetEuro(BusinessLogic.Fornitore.GetTotalePagamentiDato(fornitore, data));
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

        private static void AddReportProspettoFornitore(AnagraficaFornitoreDto anagraficaFornitore, UtilityReport.Report report)
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
        
        public static UtilityReport.Report GetReportFornitori(AziendaDto azienda, IList<AnagraficaFornitoreDto> anagraficheFornitori, IList<FornitoreDto> fornitori, DateTime data)
        {
            try
            {
                var report = new UtilityReport.Report();

                var fornitoriDare = GetFornitoriDare(fornitori, data);
                var anagraficheFornitoriDare = GetAnagraficheFornitoriDare(anagraficheFornitori, fornitoriDare);

                AddReportAzienda(azienda, report, data);
                AddReportProspettoFornitori(anagraficheFornitoriDare, fornitoriDare, report);

                var tableFornitori = new UtilityReport.Table("RagioneSociale", "TotaleFatture", "TotalePagamentiDato", "TotalePagamentiDare");
                var tableFatture = new UtilityReport.Table("Numero", "Data", "Scadenza", "Descrizione", "Imponibile", "IVA", "Totale", "TotalePagamentiDato", "TotalePagamentiDare");
                var tablePagamenti = new UtilityReport.Table("Numero", "Data", "TipoPagamento", "Descrizione", "Note", "Importo");

                foreach (var anagraficaFornitore in anagraficheFornitoriDare)
                {
                    var fornitoriAnagrafica = (from q in fornitoriDare where q.Codice == anagraficaFornitore.Codice select q).ToList();
                    if (fornitoriAnagrafica != null && fornitoriAnagrafica.Count >= 1)
                    {
                        AddReportFornitore(tableFornitori, anagraficaFornitore, fornitoriAnagrafica, data);

                        var codificaFornitore = "FORNITORE " + anagraficaFornitore.Codice + " - " + anagraficaFornitore.RagioneSociale;
                        tableFatture.AddRowMerge(Color.LightGray, codificaFornitore, "", "", "", "", "", "", "", "");
                        foreach (var fornitore in fornitoriAnagrafica)
                        {
                            //fatture per fornitore
                            var fattureAcquisto = fornitore.FatturaAcquistos;
                            var fattureAcquistoDare = GetFattureAcquistoDare(fattureAcquisto, data);
                            foreach (var fatturaAcquisto in fattureAcquistoDare)
                            {
                                AddReportFatturaAcquistoFornitore(tableFatture, fatturaAcquisto, data);

                                //pagamenti per fattura
                                var totaleFattura = UtilityValidation.GetEuro(fatturaAcquisto.Totale);
                                var _statoFattura = BusinessLogic.Fattura.GetStato(fatturaAcquisto);
                                var statoFattura = UtilityEnum.GetDescription<Tipi.StatoFattura>(_statoFattura);
                                var codificaFattura = BusinessLogic.Fattura.GetCodifica(fatturaAcquisto)  + " - TOTALE IVATO " + totaleFattura + " - " + statoFattura.ToUpper();
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
                    }
                }
                report.Tables.Add(tableFornitori);
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

        private static IList<FatturaAcquistoDto> GetFattureAcquistoDare(IList<FatturaAcquistoDto> fattureAcquisto, DateTime data)
        {
            try
            {
                var fattureAcquistoDare = (from q in fattureAcquisto where BusinessLogic.Fattura.GetTotalePagamentiDare(q, data) > 0 select q).ToList();
                return fattureAcquistoDare;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static IList<FornitoreDto> GetFornitoriDare(IList<FornitoreDto> fornitori, DateTime data)
        {
            try
            {
                var fornitoriDare = (from q in fornitori where BusinessLogic.Fornitore.GetTotalePagamentiDare(q, data) > 0 select q).ToList();
                return fornitoriDare;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static IList<AnagraficaFornitoreDto> GetAnagraficheFornitoriDare(IList<AnagraficaFornitoreDto> anagraficheFornitori, IList<FornitoreDto> fornitoriDare)
        {
            try
            {
                var codiciFornitoriDare = (from q in fornitoriDare select q.Codice).Distinct().ToList();
                var anagraficheFornitoriDare = (from q in anagraficheFornitori where codiciFornitoriDare.Contains(q.Codice) select q).ToList();
                return anagraficheFornitoriDare;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static void AddReportFornitore(UtilityReport.Table tableFornitori, AnagraficaFornitoreDto anagraficaFornitore, IList<FornitoreDto> fornitoriAnagrafica, DateTime data)
        {
            try
            {
                var ragioneSociale = anagraficaFornitore.RagioneSociale;
                var _totaleFatture = BusinessLogic.Commessa.GetTotaleFattureAcquisto(fornitoriAnagrafica, data);
                var _totalePagamentiDato = BusinessLogic.Commessa.GetTotalePagamentiDato(fornitoriAnagrafica, data);
                var _totalePagamentiDare = BusinessLogic.Commessa.GetTotalePagamentiDare(fornitoriAnagrafica, data);
                var totaleFatture = UtilityValidation.GetEuro(_totaleFatture);
                var totalePagamentiDato = UtilityValidation.GetEuro(_totalePagamentiDato);
                var totalePagamentiDare = UtilityValidation.GetEuro(_totalePagamentiDare);

                tableFornitori.AddRow(ragioneSociale, totaleFatture, totalePagamentiDato, totalePagamentiDare);

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static void AddReportProspettoFornitori(IList<AnagraficaFornitoreDto> anagraficheFornitori, IList<FornitoreDto> fornitori, UtilityReport.Report report)
        {
            try
            {
                var fattureAcquisto = GetFattureAcquisto(fornitori);
                var noteCredito = GetNoteCredito(fornitori);
                var commesse = GetCommesse(fornitori);
                var pagamenti = GetPagamenti(fattureAcquisto);
                var resi = GetResi(noteCredito);
                
                report.AddData("NumeroFornitori", anagraficheFornitori.Count());
                report.AddData("NumeroFattureAcquisto", fattureAcquisto.Count());
                report.AddData("NumeroNoteCredito", noteCredito.Count());
                report.AddData("NumeroCommesse", commesse.Count());
                report.AddData("NumeroPagamenti", pagamenti.Count());
                report.AddData("NumeroResi", resi.Count());

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static IEnumerable<ResoDto> GetResi(IList<NotaCreditoDto> noteCredito)
        {
            try
            {
                var resi = new List<ResoDto>();
                foreach (var notaCredito in noteCredito)
                    resi.AddRange(notaCredito.Resos);

                return resi;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static IList<PagamentoDto> GetPagamenti(IList<FatturaAcquistoDto> fattureAcquisto)
        {
            try
            {
                var pagamenti = new List<PagamentoDto>();
                foreach (var fatturaAcquisto in fattureAcquisto)
                    pagamenti.AddRange(fatturaAcquisto.Pagamentos);

                return pagamenti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static IList<CommessaDto> GetCommesse(IList<FornitoreDto> fornitori)
        {
            try
            {
                var commesse = new List<CommessaDto>();
                foreach(var fornitore in fornitori)
                {
                    var commessa=fornitore.Commessa;
                    var exist = ((from q in commesse where q.Id == commessa.Id select q).Count()>=1);
                    if (!exist)
                        commesse.Add(commessa);
                }
                return commesse;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static IList<NotaCreditoDto> GetNoteCredito(IList<FornitoreDto> fornitori)
        {
            try
            {
                var noteCredito = new List<NotaCreditoDto>();
                foreach (var fornitore in fornitori)
                    noteCredito.AddRange(fornitore.NotaCreditos);

                return noteCredito;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static IList<FatturaAcquistoDto> GetFattureAcquisto(IList<FornitoreDto> fornitori)
        {
            try
            {
                var fattureAcquisto = new List<FatturaAcquistoDto>();
                foreach(var fornitore in fornitori)
                    fattureAcquisto.AddRange(fornitore.FatturaAcquistos);

                return fattureAcquisto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static UtilityReport.Report GetReportCommittente(AziendaDto azienda, AnagraficaCommittenteDto anagraficaCommittente, List<CommittenteDto> committenti, DateTime data)
        {
            try
            {
                var report = new UtilityReport.Report();

                AddReportAzienda(azienda, report, data);
                AddReportProspettoCommittente(anagraficaCommittente, report);
                AddReportTotaliCommittente(committenti, report, data);

                var tableCommesse = new UtilityReport.Table("Commessa", "TotaleImponibile", "TotaleIVA", "TotaleFatture", "TotaleIncassiAvuto", "TotaleIncassiAvere");
                var tableFatture = new UtilityReport.Table("Numero", "Data", "Scadenza", "Descrizione", "Imponibile", "IVA", "Totale", "TotaleIncassiAvuto", "TotaleIncassiAvere");
                var tableIncassi = new UtilityReport.Table("Numero", "Data", "TipoPagamento", "Descrizione", "Note", "Importo");
                foreach (var committente in committenti)
                {
                    //totali per commessa
                    var commessa = committente.Commessa;
                    AddReportCommessaCommittente(tableCommesse, committente, commessa, data);

                    //fatture per commessa
                    var codificaCommessa = "COMMESSA " + commessa.Codice + " - " + commessa.Denominazione;
                    tableFatture.AddRowMerge(Color.LightGray, codificaCommessa, "", "", "", "", "", "", "", "");
                    var fattureVendita = committente.FatturaVenditas;
                    foreach (var fatturaVendita in fattureVendita)
                    {
                        AddReportFatturaVenditaCommittente(tableFatture, fatturaVendita, data);

                        //pagamenti per fattura
                        var totaleFattura = UtilityValidation.GetEuro(fatturaVendita.Totale);
                        var _statoFattura = BusinessLogic.Fattura.GetStato(fatturaVendita);
                        var statoFattura = UtilityEnum.GetDescription<Tipi.StatoFattura>(_statoFattura);
                        var codificaFattura = BusinessLogic.Fattura.GetCodifica(fatturaVendita) + " - TOTALE IVATO " + totaleFattura + " - " + statoFattura.ToUpper();
                        tableIncassi.AddRowMerge(Color.LightGray, codificaFattura, "", "", "", "", "");
                        var incassi = (from q in fatturaVendita.Incassos orderby q.Data ascending select q).ToList();
                        foreach (var incasso in incassi)
                            AddReportIncassoCommittente(tableIncassi, incasso);
                    }
                }
                report.Tables.Add(tableCommesse);
                report.Tables.Add(tableFatture);
                report.Tables.Add(tableIncassi);

                return report;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static void AddReportIncassoCommittente(UtilityReport.Table tableIncassi, IncassoDto incasso)
        {
            try
            {
                var numero = incasso.Codice;
                var data = UtilityValidation.GetDataND(incasso.Data);
                var tipoPagamento = incasso.TipoPagamento;
                var descrizione = incasso.Descrizione;
                var note = incasso.Note;
                var importo = UtilityValidation.GetEuro(incasso.Importo);

                tableIncassi.AddRow(numero, data, tipoPagamento, descrizione, note, importo);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


        private static void AddReportFatturaVenditaCommittente(UtilityReport.Table tableFatture, FatturaVenditaDto fatturaVendita, DateTime data)
        {
            try
            {
                var numero = fatturaVendita.Numero;
                var dataFattura = UtilityValidation.GetDataND(fatturaVendita.Data);
                var scadenza = UtilityValidation.GetDataND(BusinessLogic.Fattura.GetScadenza(fatturaVendita));
                var descrizione = fatturaVendita.Descrizione;
                var imponibile = UtilityValidation.GetEuro(fatturaVendita.Imponibile);
                var iva = UtilityValidation.GetEuro(fatturaVendita.IVA);
                var totale = UtilityValidation.GetEuro(fatturaVendita.Totale);
                var totaleIncassiFatturaAvuto = UtilityValidation.GetEuro(BusinessLogic.Fattura.GetTotaleIncassi(fatturaVendita, data));
                var totaleIncassiFatturaFatturaAvere = UtilityValidation.GetEuro(BusinessLogic.Fattura.GetTotaleIncassiAvere(fatturaVendita, data));

                tableFatture.AddRow(numero, dataFattura, scadenza, descrizione, imponibile, iva, totale, totaleIncassiFatturaAvuto, totaleIncassiFatturaFatturaAvere);

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


        private static void AddReportCommessaCommittente(UtilityReport.Table tableCommesse, CommittenteDto committente, CommessaDto commessa, DateTime data)
        {
            try
            {
                var _commessa = commessa.Codice + " - " + commessa.Denominazione;
                var totaleImponibile = UtilityValidation.GetEuro(BusinessLogic.Committente.GetTotaleImponibile(committente, data));
                var totaleIVA = UtilityValidation.GetEuro(BusinessLogic.Committente.GetTotaleIVA(committente, data));
                var totaleFattureVendita = UtilityValidation.GetEuro(BusinessLogic.Committente.GetTotaleFattureVendita(committente, data));
                var totaleIncassiAvuto = UtilityValidation.GetEuro(BusinessLogic.Committente.GetTotaleIncassi(committente, data));
                var totaleIncassiAvere = UtilityValidation.GetEuro(BusinessLogic.Committente.GetTotaleIncassiAvere(committente, data));

                tableCommesse.AddRow(_commessa, totaleImponibile, totaleIVA, totaleFattureVendita, totaleIncassiAvuto, totaleIncassiAvere);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }



        private static void AddReportTotaliCommittente(List<CommittenteDto> committenti, UtilityReport.Report report, DateTime data)
        {
            try
            {
                report.AddData("TotaleImponibileCommittente", BusinessLogic.Commessa.GetTotaleImponibile(committenti, data), TypeFormat.Euro);
                report.AddData("TotaleIVACommittente", BusinessLogic.Commessa.GetTotaleIVA(committenti, data), TypeFormat.Euro);
                report.AddData("TotaleFattureCommittente", BusinessLogic.Commessa.GetTotaleFattureVendita(committenti, data), TypeFormat.Euro);
                report.AddData("TotaleIncassiAvutoCommittente", BusinessLogic.Commessa.GetTotaleIncassi(committenti, data), TypeFormat.Euro);
                report.AddData("TotaleIncassiAvereCommittente", BusinessLogic.Commessa.GetTotaleIncassiAvere(committenti, data), TypeFormat.Euro);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static void AddReportProspettoCommittente(AnagraficaCommittenteDto anagraficaCommittente, UtilityReport.Report report)
        {
            try
            {
                report.AddData("RagioneSociale", anagraficaCommittente.RagioneSociale);
                report.AddData("PartitaIva", anagraficaCommittente.PartitaIva);
                report.AddData("Indirizzo", anagraficaCommittente.Indirizzo);
                report.AddData("CAP", anagraficaCommittente.CAP);
                report.AddData("Localita", anagraficaCommittente.Localita);
                report.AddData("Comune", anagraficaCommittente.Comune);
                report.AddData("Provincia", anagraficaCommittente.Provincia);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public static UtilityReport.Report GetReportCommittenti(AziendaDto azienda, IList<AnagraficaCommittenteDto> anagraficheCommittenti, IList<CommittenteDto> committenti, DateTime data)
        {
            try
            {
                var report = new UtilityReport.Report();

                var committentiAvere = GetCommittentiAvere(committenti, data);
                var anagraficheCommittentiAvere = GetAnagraficheCommittentiAvere(anagraficheCommittenti, committentiAvere);

                AddReportAzienda(azienda, report, data);
                AddReportProspettoCommittenti(anagraficheCommittentiAvere, committentiAvere, report);

                var tableCommittenti= new UtilityReport.Table("RagioneSociale", "TotaleFatture", "TotaleIncassiAvuto", "TotaleIncassiAvere");
                var tableFatture = new UtilityReport.Table("Numero", "Data", "Scadenza", "Descrizione", "Imponibile", "IVA", "Totale", "TotaleIncassiAvuto", "TotaleIncassiAvere");
                var tableIncassi= new UtilityReport.Table("Numero", "Data", "TipoPagamento", "Descrizione", "Note", "Importo");

                foreach (var anagraficaCommittente in anagraficheCommittentiAvere)
                {
                    var committentiAnagrafica = (from q in committentiAvere where q.Codice == anagraficaCommittente.Codice select q).ToList();
                    if (committentiAnagrafica != null && committentiAnagrafica.Count >= 1)
                    {
                        AddReportCommittente(tableCommittenti, anagraficaCommittente, committentiAnagrafica, data);

                        var codificaCommittente = "COMMITTENTE " + anagraficaCommittente.Codice + " - " + anagraficaCommittente.RagioneSociale;
                        tableFatture.AddRowMerge(Color.LightGray, codificaCommittente, "", "", "", "", "", "", "", "");
                        foreach (var committente in committentiAnagrafica)
                        {
                            //fatture per committente
                            var fattureVendita= committente.FatturaVenditas;
                            var fattureVenditaAvere = GetFattureVenditaAvere(fattureVendita, data);
                            foreach (var fatturaVendita in fattureVenditaAvere)
                            {
                                AddReportFatturaVenditaCommittente(tableFatture, fatturaVendita, data);

                                //pagamenti per fattura
                                var totaleFattura = UtilityValidation.GetEuro(fatturaVendita.Totale);
                                var _statoFattura = BusinessLogic.Fattura.GetStato(fatturaVendita);
                                var statoFattura = UtilityEnum.GetDescription<Tipi.StatoFattura>(_statoFattura);
                                var codificaFattura = BusinessLogic.Fattura.GetCodifica(fatturaVendita) + " - TOTALE IVATO " + totaleFattura + " - " + statoFattura.ToUpper();
                                tableIncassi.AddRowMerge(Color.LightGray, codificaFattura, "", "", "", "", "");
                                var incassi = (from q in fatturaVendita.Incassos orderby q.Data ascending select q).ToList();
                                foreach (var incasso in incassi)
                                    AddReportIncassoCommittente(tableIncassi, incasso);

                            }
                        }
                    }
                }
                report.Tables.Add(tableCommittenti);
                report.Tables.Add(tableFatture);
                report.Tables.Add(tableIncassi);

                return report;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static void AddReportProspettoCommittenti(IList<AnagraficaCommittenteDto> anagraficheCommittenti, IList<CommittenteDto> committenti, UtilityReport.Report report)
        {
            try
            {
                var fattureVendita = GetFattureVendita(committenti);
                var commesse = GetCommesse(committenti);
                var incassi = GetIncassi(fattureVendita);

                report.AddData("NumeroCommittenti", anagraficheCommittenti.Count());
                report.AddData("NumeroFattureVendita", fattureVendita.Count());
                report.AddData("NumeroCommesse", commesse.Count());
                report.AddData("NumeroIncassi", incassi.Count());

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


       private static IList<CommittenteDto> GetCommittentiAvere(IList<CommittenteDto> committenti, DateTime data)
        {
            try
            {
                var committentiAvere = (from q in committenti where BusinessLogic.Committente.GetTotaleIncassiAvere(q, data) > 0 select q).ToList();
                return committentiAvere;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        private static IList<AnagraficaCommittenteDto> GetAnagraficheCommittentiAvere(IList<AnagraficaCommittenteDto> anagraficheCommittenti, IList<CommittenteDto > committentiAvere)
        {
            try
            {
                var codiciCommittentiAvere = (from q in committentiAvere select q.Codice).Distinct().ToList();
                var anagraficheCommittentiAvere = (from q in anagraficheCommittenti where codiciCommittentiAvere.Contains(q.Codice) select q).ToList();
                return anagraficheCommittentiAvere;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        private static IList<FatturaVenditaDto> GetFattureVendita(IList<CommittenteDto> committenti)
        {
            try
            {
                var fattureVendita = new List<FatturaVenditaDto>();
                foreach (var committente in committenti)
                    fattureVendita.AddRange(committente.FatturaVenditas);

                return fattureVendita;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        private static IList<IncassoDto> GetIncassi(IList<FatturaVenditaDto> fattureVendita)
        {
            try
            {
                var incassi = new List<IncassoDto>();
                foreach (var fatturaVendita in fattureVendita)
                    incassi.AddRange(fatturaVendita.Incassos);

                return incassi;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static IList<CommessaDto> GetCommesse(IList<CommittenteDto> committenti)
        {
            try
            {
                var commesse = new List<CommessaDto>();
                foreach (var committente in committenti)
                {
                    var commessa = committente.Commessa;
                    var exist = ((from q in commesse where q.Id == commessa.Id select q).Count() >= 1);
                    if (!exist)
                        commesse.Add(commessa);
                }
                return commesse;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        private static void AddReportCommittente(UtilityReport.Table tableCommittenti, AnagraficaCommittenteDto anagraficaCommittente, IList<CommittenteDto> committentiAnagrafica, DateTime data)
        {
            try
            {
                var ragioneSociale = anagraficaCommittente.RagioneSociale;
                var _totaleFatture = BusinessLogic.Commessa.GetTotaleFattureVendita(committentiAnagrafica, data);
                var _totaleIncassiAvuto = BusinessLogic.Commessa.GetTotaleIncassi(committentiAnagrafica, data);
                var _totaleIncassiAvere = BusinessLogic.Commessa.GetTotaleIncassiAvere(committentiAnagrafica, data);
                var totaleFatture = UtilityValidation.GetEuro(_totaleFatture);
                var totaleIncassiAvuto = UtilityValidation.GetEuro(_totaleIncassiAvuto);
                var totaleIncassiAvere = UtilityValidation.GetEuro(_totaleIncassiAvere);

                tableCommittenti.AddRow(ragioneSociale, totaleFatture, totaleIncassiAvuto, totaleIncassiAvere);

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
        private static IList<FatturaVenditaDto> GetFattureVenditaAvere(IList<FatturaVenditaDto> fattureVendita, DateTime data)
        {
            try
            {
                var fattureVenditaAvere = (from q in fattureVendita where BusinessLogic.Fattura.GetTotaleIncassiAvere(q, data) > 0 select q).ToList();
                return fattureVenditaAvere;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

    }
}
