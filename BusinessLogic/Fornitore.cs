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
        public static decimal GetTotaleFatture(FornitoreDto fornitore, DateTime data)
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


        public static IList<WcfService.Dto.FatturaAcquistoDto> GetFattureInsolute(IList<FatturaAcquistoDto> fattureAcquisto)
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

        public static IList<WcfService.Dto.FatturaAcquistoDto> GetFattureNonPagate(IList<FatturaAcquistoDto> fattureAcquisto)
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

        private static IList<WcfService.Dto.FatturaAcquistoDto> GetFatture(IList<FatturaAcquistoDto> fattureAcquisto, Tipi.StatoFattura stato)
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
                    var totaleFatture = GetTotaleFatture(fornitore, today);
                    var totalePagamenti = GetTotalePagamenti(fornitore, today);
                    var fatture = fornitore.FatturaAcquistos;
                    var fattureInsolute = GetFattureInsolute(fatture);
                    var existFattureInsolute = (fattureInsolute.Count >= 1);

                    var stato = Tipi.StatoFornitore.None;
                    if (totalePagamenti < totaleFatture)
                    {
                        if (existFattureInsolute)
                            stato = Tipi.StatoFornitore.Insoluto;
                        else
                            stato = Tipi.StatoFornitore.NonPagato;
                    }
                    else if (totalePagamenti >= totaleFatture)
                        stato = Tipi.StatoFornitore.Pagato;

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
                    var totaleFatture = GetTotaleFatture(fornitore, data);
                    var totalePagamentiDato = GetTotalePagamenti(fornitore, data);
                    var totalePagamentiDare = totaleFatture - totalePagamentiDato;
                    return totalePagamentiDare;
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
