using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Calcoli
    {
        public static decimal? GetTotaleFatturaAcquisto(decimal? imponibile, decimal? iva)
        {
            try
            {
                decimal? totale = 0;
                if (imponibile != null)
                    totale += imponibile;
                if (iva != null)
                    totale += iva;
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
