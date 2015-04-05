﻿using Library.Code;
using Library.Code.Enum;
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
        public static decimal GetTotaleFattureAcquisto(FornitoreDto fornitore, DateTime data)
        {
            try
            {
                decimal totale = 0;
                if (fornitore != null)
                {
                    var fattureAcquisto = fornitore.FatturaAcquistos;
                    foreach(var fatturaAcquisto in fattureAcquisto)
                    {
                        var totaleFattura = Fattura.GetTotaleFattura(fatturaAcquisto,data);
                        totale += totaleFattura;
                    }
                    return totale;
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
                decimal totale = 0;
                if (fornitore != null)
                {
                    var noteCredito = fornitore.NotaCreditos;
                    if (noteCredito != null)
                    {
                        foreach (var notaCredito in noteCredito)
                        {
                            var totaleNoteCredito = Fattura.GetTotaleNotaCredito(notaCredito, data);
                            totale += totaleNoteCredito;
                        }
                    }
                    return totale;
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
                decimal totale = 0;
                if (fornitore != null)
                {
                    var fattureAcquisto = fornitore.FatturaAcquistos;
                    if (fattureAcquisto != null)
                    {
                        foreach (var fatturaAcquisto in fattureAcquisto)
                        {
                            var totalePagamenti = Fattura.GetTotalePagamenti(fatturaAcquisto, data);
                            totale += totalePagamenti;
                        }
                    }
                    return totale;
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
                    var _fatture = (from q in fattureAcquisto where Fattura.GetStato(q) == stato select q).ToList();
                    return _fatture;
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
                    var totaleFattureAcquisto = GetTotaleFattureAcquisto(fornitore, today);
                    var totalePagamenti = GetTotalePagamenti(fornitore, today);
                    var fatture = fornitore.FatturaAcquistos;
                    var fattureInsolute = GetFattureInsolute(fatture);
                    var existFattureInsolute = (fattureInsolute.Count >= 1);

                    var stato = Tipi.StatoFornitore.None;
                    if (totalePagamenti < totaleFattureAcquisto)
                    {
                        if (existFattureInsolute)
                            stato = Tipi.StatoFornitore.Insoluto;
                        else
                            stato = Tipi.StatoFornitore.NonPagato;
                    }
                    else if (totalePagamenti == totaleFattureAcquisto)
                        stato = Tipi.StatoFornitore.Pagato;
                    else if (totalePagamenti > totaleFattureAcquisto)
                        stato = Tipi.StatoFornitore.Incoerente;

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
                decimal totale = 0;
                if (fornitore != null)
                {
                    var fattureAcquisto = (from q in fornitore.FatturaAcquistos where q.Data <= data select q);
                    if (fattureAcquisto != null)
                    {
                        foreach (var fatturaAcquisto in fattureAcquisto)
                        {
                            var totaleImponibile = UtilityValidation.GetDecimal(fatturaAcquisto.Imponibile);
                            totale += totaleImponibile;
                        }
                    }
                    return totale;
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
                decimal totale = 0;
                if (fornitore != null)
                {
                    var fattureAcquisto = (from q in fornitore.FatturaAcquistos where q.Data <= data select q);
                    if (fattureAcquisto != null)
                    {
                        foreach (var fatturaAcquisto in fattureAcquisto)
                        {
                            var totaleIVA = UtilityValidation.GetDecimal(fatturaAcquisto.IVA);
                            totale += totaleIVA;
                        }
                    }
                    return totale;
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
                    var totalePagamentiDato = GetTotalePagamenti(fornitore, data);
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

        public static decimal GetTotalePagamenti(FornitoreDto fornitore)
        {
            try
            {
                decimal totalePagamenti = 0;
                if (fornitore != null)
                {
                    var today = DateTime.Today;
                    var commessa = fornitore.Commessa;
                    if (commessa != null)
                    {
                        var statoCommessa = commessa.Stato;
                        if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                            totalePagamenti = UtilityValidation.GetDecimal(fornitore.TotalePagamenti);
                        else
                            totalePagamenti = GetTotalePagamenti(fornitore, today);
                    }
                }
                return totalePagamenti;
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
                decimal totaleNoteCredito = 0;
                if (fornitore != null)
                {
                    var today = DateTime.Today;
                    var commessa = fornitore.Commessa;
                    if (commessa != null)
                    {
                        var statoCommessa = commessa.Stato;
                        if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                            totaleNoteCredito = UtilityValidation.GetDecimal(fornitore.TotalePagamenti);
                        else
                            totaleNoteCredito = GetTotaleNoteCredito(fornitore, today);
                    }
                }
                return totaleNoteCredito;
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
                            var totaleFattureAcquisto = GetTotaleFattureAcquisto(fornitore, today);
                            var totalePagamenti = GetTotalePagamenti(fornitore, today);
                            var fattureInsolute = GetFattureInsolute(fatture);
                            var fattureNonPagate = GetFattureNonPagate(fatture);
                            var statoFornitore = GetStato(fornitore);
                            var _statoDescrizione = GetStatoDescrizione(totaleFattureAcquisto, totalePagamenti, fattureInsolute, fattureNonPagate, statoFornitore);
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

        private static StateDescriptionImage GetStatoDescrizione(decimal totaleFattureAcquisto, decimal totalePagamenti, IList<FatturaAcquistoDto> fattureInsolute,
         IList<FatturaAcquistoDto> fattureNonPagate, Tipi.StatoFornitore statoFornitore)
        {
            try
            {
                var descrizione = "";
                var stato = TypeState.None;
                var existFattureInsolute = (fattureInsolute.Count >= 1);
                var existFattureNonPagate = (fattureNonPagate.Count >= 1);
                var listaFattureInsolute = BusinessLogic.Fattura.GetLista(fattureInsolute);
                var listaFattureNonPagate = BusinessLogic.Fattura.GetLista(fattureNonPagate);
                var _totalePagamenti = UtilityValidation.GetEuro(totalePagamenti);
                var _totaleFattureAcquisto = UtilityValidation.GetEuro(totaleFattureAcquisto);

                if (statoFornitore == Tipi.StatoFornitore.Insoluto) //condizione di non soluzione delle fatture, segnalo le fatture insolute ed eventualmente quelle non pagate
                {
                    descrizione = "Il fornitore risulta insoluto. Il totale pagamenti pari a " + _totalePagamenti + " è inferiore al totale fatture pari a " + _totaleFattureAcquisto + ". Le fatture insolute sono " + listaFattureInsolute;
                    if (existFattureNonPagate)
                        descrizione += " Le fatture non pagate sono " + listaFattureNonPagate;
                    stato = TypeState.Critical;
                }
                else if (statoFornitore == Tipi.StatoFornitore.NonPagato)
                {
                    descrizione = "Il fornitore risulta non pagato. Il totale pagamenti pari a " + _totalePagamenti + " è inferiore al totale fatture pari a " + _totaleFattureAcquisto;
                    if (existFattureNonPagate)
                        descrizione += " Le fatture non pagate sono " + listaFattureNonPagate;
                    stato = TypeState.Warning;
                }
                else if (statoFornitore == Tipi.StatoFornitore.Incoerente)
                {
                    descrizione = "Il fornitore risulta pagato ma è in uno stato incoerente. Tutte le fatture sono state saldate, tuttavia il totale pagamenti pari a " + _totalePagamenti + " è superiore al totale fatture pari a " + _totaleFattureAcquisto;  
                    stato = TypeState.Normal;
                }
                else if (statoFornitore == Tipi.StatoFornitore.Pagato)
                {
                    descrizione = "Il fornitore risulta pagato. Tutte le fatture sono state saldate";  
                    stato = TypeState.Normal;
                }
                var statoDescrizione = new StateDescriptionImage(stato, descrizione);
                return statoDescrizione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static decimal GetTotaleFatturaAcquisto(FornitoreDto fornitore)
        {
            try
            {
                decimal totaleFatturaAcquisto = 0;
                var today = DateTime.Today;
                if (fornitore != null)
                {
                    var commessa = fornitore.Commessa;
                    if (commessa != null)
                    {
                        var statoCommessa = commessa.Stato;
                        if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                            totaleFatturaAcquisto = UtilityValidation.GetDecimal(fornitore.TotaleFattureAcquisto);
                        else
                            totaleFatturaAcquisto = GetTotaleFattureAcquisto(fornitore, today);
                    }
                }
                return totaleFatturaAcquisto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static IList<WcfService.Dto.FatturaAcquistoDto> GetFattureDare(IEnumerable<FatturaAcquistoDto> fattureAcquistoAnagraficaFornitore)
        {
            try
            {
                var fattureDare= new List<WcfService.Dto.FatturaAcquistoDto>();
                if (fattureAcquistoAnagraficaFornitore!=null)
                {
                    foreach(var fatturaAcquistoAnagraficaFornitore in fattureAcquistoAnagraficaFornitore)
                    {
                        var statoFattura = Fattura.GetStato(fatturaAcquistoAnagraficaFornitore);
                        if (statoFattura == Tipi.StatoFattura.Insoluta || statoFattura == Tipi.StatoFattura.NonPagata)
                            fattureDare.Add(fatturaAcquistoAnagraficaFornitore);
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
    }
}
