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
    }
}
