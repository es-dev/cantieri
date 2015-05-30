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
                decimal totale = 0;
                if (committente != null)
                {
                    var fattureVendita = (from q in committente.FatturaVenditas where q.Data <= data select q);
                    if (fattureVendita != null)
                    {
                        foreach (var fatturaVendita in fattureVendita)
                        {
                            var totaleFatturaVendita = Fattura.GetTotaleFatturaVendita(fatturaVendita);
                            totale += totaleFatturaVendita;
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


        public static decimal GetTotaleFattureVendita(CommittenteDto committente)
        {
            try
            {
                decimal totaleFattureVendita = 0;
                if (committente != null)
                {
                    var today = DateTime.Today;
                    var commessa = committente.Commessa;
                    if (commessa != null)
                    {
                        var statoCommessa = commessa.Stato;
                        if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                            totaleFattureVendita = UtilityValidation.GetDecimal(committente.TotaleFattureVendita);
                        else
                            totaleFattureVendita = GetTotaleFattureVendita(committente, today);
                    }
                }
                return totaleFattureVendita;
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
                decimal totale = 0;
                if (committente != null)
                {
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
                decimal totaleIncassi = 0;
                if (committente != null)
                {
                    var today = DateTime.Today;
                    var commessa = committente.Commessa;
                    if (commessa != null)
                    {
                        var statoCommessa = commessa.Stato;
                        if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                            totaleIncassi = UtilityValidation.GetDecimal(committente.TotaleIncassi);
                        else
                            totaleIncassi = BusinessLogic.Committente.GetTotaleIncassi(committente, today);
                    }
                }
                return totaleIncassi;
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
                    var fattureInsolute = GetFatture(fattureVendita, Tipi.StatoFattura.Insoluta);
                    return fattureInsolute;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static IList<FatturaVenditaDto> GetFattureNonLiquidate(IList<FatturaVenditaDto> fattureVendita)
        {
            try
            {
                if (fattureVendita != null)
                {
                    var fattureNonLiquidate = GetFatture(fattureVendita, Tipi.StatoFattura.NonPagata);
                    return fattureNonLiquidate;
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
                    var _fatture = (from q in fattureVendita where Fattura.GetStato(q) == stato select q).ToList();
                    return _fatture;
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
                    var fatture = committente.FatturaVenditas;
                    var fattureInsolute = GetFattureInsolute(fatture);
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
                            var fatture = committente.FatturaVenditas;
                            var totaleFattureVendita = GetTotaleFattureVendita(committente, today);
                            var totaleIncassi = GetTotaleIncassi(committente, today);
                            var fattureInsolute = GetFattureInsolute(fatture);
                            var fattureNonLiquidate = GetFattureNonLiquidate(fatture);
                            var statoCommittente = GetStato(committente);
                            var _statoDescrizione = GetStatoDescrizione(totaleFattureVendita, totaleIncassi, fattureInsolute, fattureNonLiquidate, statoCommittente);
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
           IList<FatturaVenditaDto> fattureNonLiquidate, Tipi.StatoCommittente statoCommittente)
        {
            try
            {
                var descrizione = "";
                var stato = TypeState.None;
                var existFattureInsolute = (fattureInsolute.Count >= 1);
                var existFattureNonLiquidate = (fattureNonLiquidate.Count >= 1);
                var listaFattureInsolute = BusinessLogic.Fattura.GetLista(fattureInsolute);
                var listaFattureNonLiquidate = BusinessLogic.Fattura.GetLista(fattureNonLiquidate);
                var _totaleIncassi = UtilityValidation.GetEuro(totaleIncassi);
                var _totaleFattureVendita = UtilityValidation.GetEuro(totaleFattureVendita);

                if (statoCommittente == Tipi.StatoCommittente.Insoluto) //condizione di non soluzione delle fatture, segalo le fatture insolute ed eventualmente quelle non pagate
                {
                    descrizione = "Il committente risulta insoluto. Il totale incassi pari a " + _totaleIncassi + " è inferiore al totale fatture pari a " + _totaleFattureVendita + ". Le fatture insolute sono " + listaFattureInsolute;
                    if (existFattureNonLiquidate)
                        descrizione += " Le fatture non incassate sono " + listaFattureNonLiquidate;
                    stato = TypeState.Critical;
                }
                else if (statoCommittente == Tipi.StatoCommittente.NonIncassato) //condizione di non pagamento (pagamenti nulli o non completi, se non completi segnalo le fatture non pagate)
                {
                    descrizione = "Il committente risulta non incassato. Il totale incassi pari a " + _totaleIncassi + " è inferiore al totale fatture pari a " + _totaleFattureVendita;
                    if (existFattureNonLiquidate)
                        descrizione += " Le fatture non pagate sono " + listaFattureNonLiquidate;
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
                        descrizione = "Il committente risulta incassato. Tutte le fatture sono state liquidate";
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
                decimal totale = 0;
                if (committente != null)
                {
                    var fattureVentita = (from q in committente.FatturaVenditas where q.Data <= data select q);
                    if (fattureVentita != null)
                    {
                        foreach (var fatturaVentita in fattureVentita)
                        {
                            var totaleImponibile = UtilityValidation.GetDecimal(fatturaVentita.Imponibile);
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

        internal static decimal GetTotaleIVA(CommittenteDto committente, DateTime data)
        {
            try
            {
                decimal totale = 0;
                if (committente != null)
                {
                    var fattureVentita = (from q in committente.FatturaVenditas where q.Data <= data select q);
                    if (fattureVentita != null)
                    {
                        foreach (var fatturaVentita in fattureVentita)
                        {
                            var totaleIVA = UtilityValidation.GetDecimal(fatturaVentita.IVA);
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
    }

}
