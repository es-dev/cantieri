using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class Fornitore
    {
        internal static decimal GetTotaleFatture(WcfService.Dto.FornitoreDto fornitore, DateTime data)
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
                        totale = (decimal)totaleImponibile;
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

        internal static decimal GetTotalePagamenti(WcfService.Dto.FornitoreDto fornitore, DateTime data)
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
    }
}
