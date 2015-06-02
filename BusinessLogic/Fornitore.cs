using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class Fornitore
    {
        public static decimal GetTotaleSaldoFattureAcquisto(FornitoreDto fornitore, DateTime data)
        {
            try
            {
                if (fornitore != null)
                {
                    var fattureAcquisto = fornitore.FatturaAcquistos;
                    if (fattureAcquisto != null)
                    {
                        decimal totale = 0;
                        foreach (var fatturaAcquisto in fattureAcquisto)
                        {
                            var totaleSaldoFatturaAcquisto = Fattura.GetTotaleSaldoFatturaAcquisto(fatturaAcquisto, data);
                            totale += totaleSaldoFatturaAcquisto;
                        }
                        return totale;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleFattureAcquisto(FornitoreDto fornitore, DateTime data)
        {
            try
            {
                if (fornitore != null)
                {
                    var fattureAcquisto = (from q in fornitore.FatturaAcquistos where q.Data<=data select q);
                    if (fattureAcquisto != null)
                    {
                        decimal totale = 0;
                        foreach (var fatturaAcquisto in fattureAcquisto)
                        {
                            var totaleFatturaAcquisto = Fattura.GetTotaleFatturaAcquisto(fatturaAcquisto);
                            totale += totaleFatturaAcquisto;
                        }
                        return totale;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleNoteCredito(FornitoreDto fornitore, DateTime data)
        {
            try
            {
                if (fornitore != null)
                {
                    var noteCredito = fornitore.NotaCreditos;
                    if (noteCredito != null)
                    {
                        decimal totale = 0;
                        foreach (var notaCredito in noteCredito)
                        {
                            var totaleNoteCredito = Fattura.GetTotaleNotaCredito(notaCredito, data);
                            totale += totaleNoteCredito;
                        }
                        return totale;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotalePagamenti(FornitoreDto fornitore, DateTime data)
        {
            try
            {
                if (fornitore != null)
                {
                    var fattureAcquisto = fornitore.FatturaAcquistos;
                    if (fattureAcquisto != null)
                    {
                        decimal totale = 0;
                        foreach (var fatturaAcquisto in fattureAcquisto)
                        {
                            var totalePagamenti = Fattura.GetTotalePagamenti(fatturaAcquisto, data);
                            totale += totalePagamenti;
                        }
                        return totale;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static IList<FatturaAcquistoDto> GetFattureInsolute(IList<FatturaAcquistoDto> fattureAcquisto)
        {
            try
            {
                if (fattureAcquisto != null)
                {
                    var fattureInsolute = GetFatture(fattureAcquisto, Tipi.StatoFattura.Insoluta);
                    return fattureInsolute;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static IList<FatturaAcquistoDto> GetFattureNonPagate(IList<FatturaAcquistoDto> fattureAcquisto)
        {
            try
            {
                if (fattureAcquisto != null)
                {
                    var fattureNonPagate = GetFatture(fattureAcquisto, Tipi.StatoFattura.NonPagata);
                    return fattureNonPagate;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static IList<FatturaAcquistoDto> GetFatture(IList<FatturaAcquistoDto> fattureAcquisto, Tipi.StatoFattura stato)
        {
            try
            {
                if (fattureAcquisto != null)
                {
                    var fatture = (from q in fattureAcquisto where Fattura.GetStato(q) == stato select q).ToList();
                    return fatture;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static Tipi.StatoFornitore GetStato(FornitoreDto fornitore)
        {
            try
            {
                if (fornitore != null)
                {
                    var today = DateTime.Today;
                    var totaleSaldoFattureAcquisto = GetTotaleSaldoFattureAcquisto(fornitore, today);
                    var totalePagamenti = GetTotalePagamenti(fornitore, today);
                    var fatture = fornitore.FatturaAcquistos;
                    var stato = Tipi.StatoFornitore.None;

                    if (fatture != null && fatture.Count>0)
                    {
                        var fattureInsolute = GetFattureInsolute(fatture);
                        var existFattureInsolute = (fattureInsolute.Count >= 1);

                        if (totalePagamenti < totaleSaldoFattureAcquisto)
                        {
                            if (existFattureInsolute)
                                stato = Tipi.StatoFornitore.Insoluto;
                            else
                                stato = Tipi.StatoFornitore.NonPagato;
                        }
                        else if (totalePagamenti == totaleSaldoFattureAcquisto)
                            stato = Tipi.StatoFornitore.Pagato;
                        else if (totalePagamenti > totaleSaldoFattureAcquisto)
                            stato = Tipi.StatoFornitore.Incoerente;

                    }
                    return stato;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return Tipi.StatoFornitore.None; 
        }

        public static decimal GetTotaleImponibile(FornitoreDto fornitore, DateTime data)
        {
            try
            {
                if (fornitore != null)
                {
                    var fattureAcquisto = (from q in fornitore.FatturaAcquistos where q.Data <= data select q);
                    if (fattureAcquisto != null)
                    {
                        decimal totale = 0;
                        foreach (var fatturaAcquisto in fattureAcquisto)
                        {
                            var totaleImponibile = UtilityValidation.GetDecimal(fatturaAcquisto.Imponibile);
                            totale += totaleImponibile;
                        }
                        return totale;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleIVA(FornitoreDto fornitore, DateTime data)
        {
            try
            {
                if (fornitore != null)
                {
                    var fattureAcquisto = (from q in fornitore.FatturaAcquistos where q.Data <= data select q);
                    if (fattureAcquisto != null)
                    {
                        decimal totale = 0;
                        foreach (var fatturaAcquisto in fattureAcquisto)
                        {
                            var totaleIVA = UtilityValidation.GetDecimal(fatturaAcquisto.IVA);
                            totale += totaleIVA;
                        }
                        return totale;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotalePagamentiDato(FornitoreDto fornitore, DateTime data)
        {
            try
            {
                if (fornitore != null)
                {
                    var fattureAcquisto = fornitore.FatturaAcquistos;
                    if (fattureAcquisto != null)
                    {
                        decimal totale = 0;
                        foreach (var fatturaAcquisto in fattureAcquisto)
                        {
                            var totalePagamentiDato = Fattura.GetTotalePagamentiDato(fatturaAcquisto, data);
                            totale += totalePagamentiDato;
                        }
                        return totale;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotalePagamentiDare(FornitoreDto fornitore, DateTime data)
        {
            try
            {
                if (fornitore != null)
                {
                    var totaleFattureAcquisto = GetTotaleFattureAcquisto(fornitore, data);
                    var totalePagamentiDato = GetTotalePagamentiDato(fornitore, data);
                    var totalePagamentiDare = totaleFattureAcquisto - totalePagamentiDato;
                    return totalePagamentiDare;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleFatturaAcquisto(FornitoreDto fornitore)
        {
            try
            {
                var today = DateTime.Today;
                if (fornitore != null)
                {
                    var commessa = fornitore.Commessa;
                    if (commessa != null)
                    {
                        decimal totale = 0;
                        var statoCommessa = commessa.Stato;
                        if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                            totale = UtilityValidation.GetDecimal(fornitore.TotaleFattureAcquisto);
                        else
                            totale = GetTotaleFattureAcquisto(fornitore, today);
                        return totale;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotalePagamenti(FornitoreDto fornitore)
        {
            try
            {
                if (fornitore != null)
                {
                    var today = DateTime.Today;
                    var commessa = fornitore.Commessa;
                    if (commessa != null)
                    {
                        decimal totale = 0;
                        var statoCommessa = commessa.Stato;
                        if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                            totale = UtilityValidation.GetDecimal(fornitore.TotalePagamenti);
                        else
                            totale = GetTotalePagamenti(fornitore, today);
                        return totale;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleNoteCredito(FornitoreDto fornitore)
        {
            try
            {
                if (fornitore != null)
                {
                    var today = DateTime.Today;
                    var commessa = fornitore.Commessa;
                    if (commessa != null)
                    {
                        decimal totale = 0;
                        var statoCommessa = commessa.Stato;
                        if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                            totale = UtilityValidation.GetDecimal(fornitore.TotalePagamenti);
                        else
                            totale = GetTotaleNoteCredito(fornitore, today);
                        return totale;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static string GetStatoDescrizione(FornitoreDto fornitore)
        {
            try
            {
                var statoDescrizione = "N/D";
                if (fornitore != null)
                {
                    var commessa = fornitore.Commessa;
                    if (commessa != null)
                    {
                        var statoCommessa = commessa.Stato;
                        if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                            statoDescrizione = fornitore.Stato;
                        else
                        {
                            var today = DateTime.Today;
                            var fatture = fornitore.FatturaAcquistos;
                            var totaleSaldoFattureAcquisto = GetTotaleSaldoFattureAcquisto(fornitore, today);
                            var totalePagamenti = GetTotalePagamenti(fornitore, today);
                            var fattureInsolute = GetFattureInsolute(fatture);
                            var fattureNonPagate = GetFattureNonPagate(fatture);
                            var statoFornitore = GetStato(fornitore);
                            var _statoDescrizione = GetStatoDescrizione(totaleSaldoFattureAcquisto, totalePagamenti, fattureInsolute, fattureNonPagate, statoFornitore);
                            statoDescrizione = _statoDescrizione.ToString();
                        }
                    }
                }
                return statoDescrizione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static StateDescriptionImage GetStatoDescrizione(decimal totaleSaldoFattureAcquisto, decimal totalePagamenti, IList<FatturaAcquistoDto> fattureInsolute,
         IList<FatturaAcquistoDto> fattureNonPagate, Tipi.StatoFornitore statoFornitore)
        {
            try
            {
                var descrizione = "";
                var stato = TypeState.None;
                var existFattureInsolute = (fattureInsolute.Count >= 1);
                var existFattureNonPagate = (fattureNonPagate.Count >= 1);
                var listaFattureInsolute = BusinessLogic.Fattura.GetListaFatture(fattureInsolute);
                var listaFattureNonPagate = BusinessLogic.Fattura.GetListaFatture(fattureNonPagate);
                var _totalePagamenti = UtilityValidation.GetEuro(totalePagamenti);
                var _totaleSaldoFattureAcquisto = UtilityValidation.GetEuro(totaleSaldoFattureAcquisto);

                if (statoFornitore == Tipi.StatoFornitore.Insoluto) //condizione di non soluzione delle fatture, segnalo le fatture insolute ed eventualmente quelle non pagate
                {
                    descrizione = "Il fornitore risulta insoluto. Il totale pagamenti pari a " + _totalePagamenti + " è inferiore al totale saldo fatture pari a " + _totaleSaldoFattureAcquisto + ". Le fatture insolute sono " + listaFattureInsolute;
                    if (existFattureNonPagate)
                        descrizione += " Le fatture non pagate sono " + listaFattureNonPagate;
                    stato = TypeState.Critical;
                }
                else if (statoFornitore == Tipi.StatoFornitore.NonPagato)
                {
                    descrizione = "Il fornitore risulta non pagato. Il totale pagamenti pari a " + _totalePagamenti + " è inferiore al totale saldo fatture pari a " + _totaleSaldoFattureAcquisto;
                    if (existFattureNonPagate)
                        descrizione += " Le fatture non pagate sono " + listaFattureNonPagate;
                    stato = TypeState.Warning;
                }
                else if (statoFornitore == Tipi.StatoFornitore.Incoerente)
                {
                    descrizione = "Il fornitore risulta pagato ma è in uno stato incoerente. Tutte le fatture sono state saldate, tuttavia il totale pagamenti pari a " + _totalePagamenti + " è superiore al totale fatture pari a " + _totaleSaldoFattureAcquisto;  
                    stato = TypeState.Normal;
                }
                else if (statoFornitore == Tipi.StatoFornitore.Pagato)
                {
                    if (totaleSaldoFattureAcquisto > 0 && totalePagamenti > 0)
                    {
                        descrizione = "Il fornitore risulta pagato. Tutte le fatture sono state saldate";
                        stato = TypeState.Normal;
                    }
                    else
                        stato = TypeState.None;
                }
                var statoDescrizione = new StateDescriptionImage(statoFornitore.ToString(), stato, descrizione);
                return statoDescrizione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static IList<FatturaAcquistoDto> GetFattureDare(IList<FatturaAcquistoDto> fattureAcquisto)
        {
            try
            {
                var fattureDare= new List<FatturaAcquistoDto>();
                if (fattureAcquisto!=null)
                {
                    foreach(var fatturaAcquisto in fattureAcquisto)
                    {
                        var statoFattura = Fattura.GetStato(fatturaAcquisto);
                        if (statoFattura == Tipi.StatoFattura.Insoluta || statoFattura == Tipi.StatoFattura.NonPagata)
                            fattureDare.Add(fatturaAcquisto);
                    }
                }
                return fattureDare;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetCodifica(FornitoreDto fornitore)
        {
            try
            {
                if(fornitore!=null)
                {
                    var codifica = GetCodifica(fornitore.AnagraficaFornitore);
                    return codifica;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetCodifica(AnagraficaFornitoreDto anagraficaFornitore)
        {
            try
            {
                if (anagraficaFornitore != null)
                {
                    var codifica = anagraficaFornitore.Codice + " - " + anagraficaFornitore.RagioneSociale;
                    return codifica;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetCodifica(FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                if(fatturaAcquisto!=null)
                {
                    var codifica = GetCodifica(fatturaAcquisto.Fornitore);
                    return codifica;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}
