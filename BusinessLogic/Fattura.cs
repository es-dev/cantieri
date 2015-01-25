using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Fattura
    {
        public static decimal GetTotale(decimal imponibile, decimal iva)
        {
            try
            {
                decimal totale = imponibile + iva;
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
