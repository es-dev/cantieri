using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Fornitore
    {
        public static decimal GetTotaleFatture(WcfService.Dto.FornitoreDto fornitore, DateTime data)
        {
            try
            {
                decimal totale = 0;
                if (fornitore != null)
                {
                    var fattureAcquisto = fornitore.FatturaAcquistos;
                    if (fattureAcquisto != null)
                    {
                        var totaleImponibile = (from q in fattureAcquisto where q.Totale != null && q.Data <= data select q.Totale).Sum();
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

        public static decimal GetTotalePagamenti(WcfService.Dto.FornitoreDto fornitore, DateTime data)
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
                            var totalePagamenti = BusinessLogic.Fattura.GetTotalePagamenti(fatturaAcquisto, data);
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

        public static IList<WcfService.Dto.FatturaAcquistoDto> GetFattureInsolute(IList<WcfService.Dto.FatturaAcquistoDto> fatture)
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

        public static IList<WcfService.Dto.FatturaAcquistoDto> GetFattureNonPagate(IList<WcfService.Dto.FatturaAcquistoDto> fatture)
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

        private static IList<WcfService.Dto.FatturaAcquistoDto> GetFatture(IList<WcfService.Dto.FatturaAcquistoDto> fatture, BusinessLogic.Tipi.StatoFattura stato)
        {
            try
            {
                var _fatture = (from q in fatture where BusinessLogic.Fattura.GetStato(q) == stato select q).ToList();
                return _fatture;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }


        public static Tipi.StatoFornitore GetStato(WcfService.Dto.FornitoreDto fornitore)
        {
            try
            {
                var today = DateTime.Today;
                var stato = Tipi.StatoFornitore.None;
                var totaleFatture = GetTotaleFatture(fornitore, today);
                var totalePagamenti = GetTotalePagamenti(fornitore, today);
                var fatture = fornitore.FatturaAcquistos;
                var fattureInsolute = GetFattureInsolute(fatture);
                var fattureNonPagate = GetFattureNonPagate(fatture);

                var existFattureInsolute = (fattureInsolute.Count >= 1);
                var existFattureNonPagate = (fattureNonPagate.Count >= 1);

                if (totalePagamenti < totaleFatture)
                {
                    if (existFattureInsolute) 
                    {
                        stato = Tipi.StatoFornitore.Insoluto;
                    }
                    else 
                    {
                        stato = Tipi.StatoFornitore.NonPagato;
                    }
                }
                else if (totalePagamenti >= totaleFatture)
                {
                    stato = Tipi.StatoFornitore.Pagato;
                }
                return stato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return Tipi.StatoFornitore.None; 
        }
    }
}
