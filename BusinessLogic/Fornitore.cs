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
                var fattureAcquisto = fornitore.Fatturas;
                if (fattureAcquisto != null)
                {
                    var totaleImponibile = (from q in fattureAcquisto where q.Data <= data select q.Imponibile).Sum();
                    totale = (decimal)totaleImponibile;
                    
                    //fattureAcquisto = (from q in fattureAcquisto where q.Data <= data select q).ToList();
                    //foreach (var fatturaAcquisto in fattureAcquisto)
                    //    totale += (decimal)fatturaAcquisto.Imponibile;
                }
                return totale;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        internal static decimal GetTotalePagamentiFornitore(WcfService.Dto.FornitoreDto fornitore, DateTime data)
        {
            try
            {
                decimal totale = 0;
                var fattureAcquisto = fornitore.Fatturas;
                if (fattureAcquisto != null)
                {
                    foreach(var fatturaAcquisto in fattureAcquisto)
                    {
                        var totalePagamenti = BusinessLogic.Fattura.GetTotalePagamenti(fatturaAcquisto, data);
                        totale += totalePagamenti;
                    }
                }
                return totale;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
    }
}
