using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class Committente
    {
        public static decimal GetTotaleFattureVendita(CommittenteDto committente, DateTime data)
        {
            try
            {
                if (committente != null)
                {
                    var fattureVendita = (from q in committente.FatturaVenditas where q.Data <= data select q);
                    if (fattureVendita != null)
                    {
                        decimal totale = 0;
                        foreach (var fatturaVendita in fattureVendita)
                        {
                            var totaleFatturaVendita = Fattura.GetTotaleFatturaVendita(fatturaVendita);
                            totale += totaleFatturaVendita;
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


        public static decimal GetTotaleFattureVendita(CommittenteDto committente)
        {
            try
            {
                if (committente != null)
                {
                    var today = DateTime.Today;
                    var commessa = committente.Commessa;
                    if (commessa != null)
                    {
                        decimal totale = 0;
                        var statoCommessa = commessa.Stato;
                        if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                            totale = UtilityValidation.GetDecimal(committente.TotaleFattureVendita);
                        else
                            totale = GetTotaleFattureVendita(committente, today);
                   
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

        public static decimal GetTotaleIncassi(CommittenteDto committente, DateTime data)
        {
            try
            {
                if (committente != null)
                {
                    decimal totale = 0;
                    var fattureVendita = committente.FatturaVenditas;
                    foreach (var fatturaVendita in fattureVendita)
                    {
                        var totaleIncassi = Fattura.GetTotaleIncassi(fatturaVendita, data);
                        totale += totaleIncassi;
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

        public static decimal GetTotaleIncassi(CommittenteDto committente)
        {
            try
            {
                if (committente != null)
                {
                    var today = DateTime.Today;
                    var commessa = committente.Commessa;
                    if (commessa != null)
                    {
                        decimal totale = 0;
                        var statoCommessa = commessa.Stato;
                        if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                            totale = UtilityValidation.GetDecimal(committente.TotaleIncassi);
                        else
                            totale = BusinessLogic.Committente.GetTotaleIncassi(committente, today);
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

        public static IList<FatturaVenditaDto> GetFattureInsolute(IList<FatturaVenditaDto> fattureVendita)
        {
            try
            {
                if (fattureVendita != null)
                {
                    var fatture = GetFatture(fattureVendita, Tipi.StatoFattura.Insoluta);
                    return fatture;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static IList<FatturaVenditaDto> GetFattureNonIncassate(IList<FatturaVenditaDto> fattureVendita)
        {
            try
            {
                if (fattureVendita != null)
                {
                    var fatture = GetFatture(fattureVendita, Tipi.StatoFattura.NonPagata);
                    return fatture;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static IList<FatturaVenditaDto> GetFatture(IList<FatturaVenditaDto> fattureVendita, Tipi.StatoFattura stato)
        {
            try
            {
                if (fattureVendita != null)
                {
                    var fatture = (from q in fattureVendita where Fattura.GetStato(q) == stato select q).ToList();
                    return fatture;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static Tipi.StatoCommittente GetStato(CommittenteDto committente)
        {
            try
            {
                if (committente != null)
                {
                    var today = DateTime.Today;
                    var totaleFattureVendita = GetTotaleFattureVendita(committente, today);
                    var totaleIncassi = GetTotaleIncassi(committente, today);
                    var fattureVendita = committente.FatturaVenditas;
                    var fattureInsolute = GetFattureInsolute(fattureVendita);
                    var existFattureInsolute = (fattureInsolute.Count >= 1);

                    var stato = Tipi.StatoCommittente.None;
                    if (totaleIncassi < totaleFattureVendita)
                    {
                        if (existFattureInsolute)
                            stato = Tipi.StatoCommittente.Insoluto;
                        else
                            stato = Tipi.StatoCommittente.NonIncassato;
                    }
                    else if (totaleIncassi == totaleFattureVendita)
                        stato = Tipi.StatoCommittente.Incassato;
                    else if (totaleIncassi > totaleFattureVendita)
                        stato = Tipi.StatoCommittente.Incoerente;

                    return stato;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return Tipi.StatoCommittente.None;
        }

        public static string GetStatoDescrizione(CommittenteDto committente)
        {
            try
            {
                var statoDescrizione = "N/D";
                if (committente != null)
                {
                    var commessa = committente.Commessa;
                    if (commessa != null)
                    {
                        var statoCommessa = commessa.Stato;
                        if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                            statoDescrizione = committente.Stato;
                        else
                        {
                            var today = DateTime.Today;
                            var fattureVendita = committente.FatturaVenditas;
                            var totaleFattureVendita = GetTotaleFattureVendita(committente, today);
                            var totaleIncassi = GetTotaleIncassi(committente, today);
                            var fattureInsolute = GetFattureInsolute(fattureVendita);
                            var fattureNonIncassate = GetFattureNonIncassate(fattureVendita);
                            var statoCommittente = GetStato(committente);
                            var _statoDescrizione = GetStatoDescrizione(totaleFattureVendita, totaleIncassi, fattureInsolute, fattureNonIncassate, statoCommittente);
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

        //todo: da modificare
        private static StateDescriptionImage GetStatoDescrizione(decimal totaleFattureVendita, decimal totaleIncassi, IList<FatturaVenditaDto> fattureInsolute,
           IList<FatturaVenditaDto> fattureNonIncassate, Tipi.StatoCommittente statoCommittente)
        {
            try
            {
                var descrizione = "";
                var stato = TypeState.None;
                var existFattureInsolute = (fattureInsolute.Count >= 1);
                var existFattureNonIncassate = (fattureNonIncassate.Count >= 1);
                var listaFattureInsolute = BusinessLogic.Fattura.GetListaFatture(fattureInsolute);
                var listaFattureNonIncassate = BusinessLogic.Fattura.GetListaFatture(fattureNonIncassate);
                var _totaleIncassi = UtilityValidation.GetEuro(totaleIncassi);
                var _totaleFattureVendita = UtilityValidation.GetEuro(totaleFattureVendita);

                if (statoCommittente == Tipi.StatoCommittente.Insoluto) //condizione di non soluzione delle fatture, segalo le fatture insolute ed eventualmente quelle non pagate
                {
                    descrizione = "Il committente risulta insoluto. Il totale incassi pari a " + _totaleIncassi + " è inferiore al totale fatture pari a " + _totaleFattureVendita + ". Le fatture insolute sono " + listaFattureInsolute;
                    if (existFattureNonIncassate)
                        descrizione += " Le fatture non incassate sono " + listaFattureNonIncassate;
                    stato = TypeState.Critical;
                }
                else if (statoCommittente == Tipi.StatoCommittente.NonIncassato) //condizione di non pagamento (pagamenti nulli o non completi, se non completi segnalo le fatture non pagate)
                {
                    descrizione = "Il committente risulta non incassato. Il totale incassi pari a " + _totaleIncassi + " è inferiore al totale fatture pari a " + _totaleFattureVendita;
                    if (existFattureNonIncassate)
                        descrizione += " Le fatture non pagate sono " + listaFattureNonIncassate;
                    stato = TypeState.Warning;
                }
                else if (statoCommittente == Tipi.StatoCommittente.Incoerente) 
                {
                    descrizione = "Il committente risulta incassato ma è in uno stato incoerente. Il totale incassi pari a " + _totaleIncassi + " è superiore al totale fatture pari a " + _totaleFattureVendita;
                    stato = TypeState.Warning;
                }
                else if (statoCommittente == Tipi.StatoCommittente.Incassato)
                {
                    if (totaleFattureVendita > 0 && totaleIncassi > 0)
                    {
                        descrizione = "Il committente risulta incassato. Tutte le fatture sono state incassate";
                        stato = TypeState.Normal;
                    }
                    else
                        stato = TypeState.None;
                }
                var statoDescrizione = new StateDescriptionImage(statoCommittente.ToString(), stato, descrizione);
                return statoDescrizione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal static decimal GetTotaleImponibile(CommittenteDto committente, DateTime data)
        {
            try
            {
                if (committente != null)
                {
                    var fattureVentita = (from q in committente.FatturaVenditas where q.Data <= data select q);
                    if (fattureVentita != null)
                    {
                        decimal totale = 0;
                        foreach (var fatturaVentita in fattureVentita)
                        {
                            var totaleImponibile = UtilityValidation.GetDecimal(fatturaVentita.Imponibile);
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

        internal static decimal GetTotaleIVA(CommittenteDto committente, DateTime data)
        {
            try
            {
                if (committente != null)
                {
                    var fattureVentita = (from q in committente.FatturaVenditas where q.Data <= data select q);
                    if (fattureVentita != null)
                    {
                        decimal totale = 0;
                        foreach (var fatturaVentita in fattureVentita)
                        {
                            var totaleIVA = UtilityValidation.GetDecimal(fatturaVentita.IVA);
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

        internal static decimal GetTotaleIncassiAvere(CommittenteDto committente, DateTime data)
        {
            try
            {
                if (committente != null)
                {
                    var totaleFattureVendita = GetTotaleFattureVendita(committente, data);
                    var totaleIncassiAvuti = GetTotaleIncassi(committente, data);
                    var totaleIncassiAvere = totaleFattureVendita - totaleIncassiAvuti;
                    return totaleIncassiAvere;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static string GetCodifica(CommittenteDto committente)
        {
            try
            {
                if(committente!=null)
                {
                    var codifica = GetCodifica(committente.AnagraficaCommittente);
                    return codifica;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetCodifica(AnagraficaCommittenteDto anagraficaCommittente)
        {
            try
            {
                if (anagraficaCommittente != null)
                {
                    var codifica = anagraficaCommittente.Codice + " - " + anagraficaCommittente.RagioneSociale;
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
