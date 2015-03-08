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
                    if (fattureAcquisto != null)
                    {
                        var totaleFattura = (from q in fattureAcquisto where q.Totale != null && q.Data <= data select q.Totale).Sum();
                        totale = UtilityValidation.GetDecimal(totaleFattura);
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

        public static decimal GetTotaleNoteCredito(FornitoreDto fornitore, DateTime data)
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
                            var totaleNoteCredito = Fattura.GetTotaleNoteCredito(fatturaAcquisto, data);
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

        public static IList<WcfService.Dto.FatturaAcquistoDto> GetFattureInsolute(IList<FatturaAcquistoDto> fatture)
        {
            try
            {
                var fattureInsolute = GetFatture(fatture, Tipi.StatoFattura.Insoluta);
                return fattureInsolute;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static IList<WcfService.Dto.FatturaAcquistoDto> GetFattureNonPagate(IList<FatturaAcquistoDto> fatture)
        {
            try
            {
                var fattureNonPagate = GetFatture(fatture, Tipi.StatoFattura.NonPagata);
                return fattureNonPagate;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static IList<WcfService.Dto.FatturaAcquistoDto> GetFatture(IList<FatturaAcquistoDto> fatture, Tipi.StatoFattura stato)
        {
            try
            {
                var _fatture = (from q in fatture where Fattura.GetStato(q) == stato select q).ToList();
                return _fatture;
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
                var today = DateTime.Today;
                var totaleFatture = GetTotaleFatture(fornitore, today);
                var totalePagamenti = GetTotalePagamenti(fornitore, today);
                var fatture = fornitore.FatturaAcquistos;
                var fattureInsolute = GetFattureInsolute(fatture);
                var fattureNonPagate = GetFattureNonPagate(fatture);
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
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return Tipi.StatoFornitore.None; 
        }

        public static decimal GetTotaleImponibile(IList<FornitoreDto> fornitori, DateTime data)
        {
            try
            {
                decimal totaleImponibile = 0;
                foreach (var fornitore in fornitori)
                {
                    var _totaleImponibile = GetTotaleImponibile(fornitore, data);
                    totaleImponibile += _totaleImponibile;
                }
                return totaleImponibile;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleImponibile(FornitoreDto fornitore, DateTime data)
        {
            try
            {
                decimal totale = 0;
                if (fornitore != null)
                {
                    var fattureAcquisto = fornitore.FatturaAcquistos;
                    if (fattureAcquisto != null)
                    {
                        var totaleImponibile = (from q in fattureAcquisto where q.Imponibile != null && q.Data <= data select q.Imponibile).Sum();
                        totale = UtilityValidation.GetDecimal(totaleImponibile);
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



        public static decimal GetTotaleIVA(IList<FornitoreDto> fornitori, DateTime data)
        {
            try
            {
                decimal totaleIVA = 0;
                foreach (var fornitore in fornitori)
                {
                    var _totaleIVA = GetTotaleIVA(fornitore, data);
                    totaleIVA += _totaleIVA;
                }
                return totaleIVA;
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
                    var fattureAcquisto = fornitore.FatturaAcquistos;
                    if (fattureAcquisto != null)
                    {
                        var totaleIVA= (from q in fattureAcquisto where q.IVA != null && q.Data <= data select q.IVA).Sum();
                        totale = UtilityValidation.GetDecimal(totaleIVA);
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

        public static decimal GetTotaleFatture(IList<FornitoreDto> fornitori, DateTime data)
        {
            try
            {
                decimal totaleFatture = 0;
                foreach (var fornitore in fornitori)
                {
                    var _totaleFatture = GetTotaleFatture(fornitore, data);
                    totaleFatture += _totaleFatture;
                }
                return totaleFatture;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotalePagamenti(IList<FornitoreDto> fornitori, DateTime data)
        {
            try
            {
                decimal totalePagamenti = 0;
                foreach (var fornitore in fornitori)
                {
                    var _totalePagamenti = GetTotalePagamenti(fornitore, data);
                    totalePagamenti += _totalePagamenti;
                }
                return totalePagamenti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleNoteCredito(IList<FornitoreDto> fornitori, DateTime data)
        {
            try
            {
                decimal totaleNoteCredito = 0;
                foreach (var fornitore in fornitori)
                {
                    var _totaleNoteCredito = GetTotaleNoteCredito(fornitore, data);
                    totaleNoteCredito += _totaleNoteCredito;
                }
                return totaleNoteCredito;
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
                var totaleFatture = GetTotaleFatture(fornitore,data);
                var totalePagamentiDato = GetTotalePagamenti(fornitore, data);
                var totalePagamentiDare = totaleFatture - totalePagamentiDato;
                return totalePagamentiDare;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }


        public static decimal GetTotalePagamentiDare(IList<FornitoreDto> fornitori, DateTime data)
        {
            try
            {
                var totaleFatture = GetTotaleFatture(fornitori, data);
                var totalePagamentiDato = GetTotalePagamenti(fornitori, data);
                var totalePagamentiDare = totaleFatture - totalePagamentiDato;
                return totalePagamentiDare;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
    }
}
