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

        internal static decimal GetTotaleIncassi(WcfService.Dto.FatturaVenditaDto fatturaVendita, DateTime data)
        {
            try
            {
                decimal totale = 0;
                var incassi = fatturaVendita.Liquidaziones;
                if (incassi != null)
                {
                    var totaleIncassi = (from q in incassi where q.Data <= data select q.Importo).Sum();
                    totale = (decimal)totaleIncassi;
                }
                return totale;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        internal static decimal GetTotalePagamenti(WcfService.Dto.FatturaAcquistoDto fatturaAcquisto, DateTime data)
        {
            try
            {
                decimal totale = 0;
                var pagamenti = fatturaAcquisto.Pagamentos;
                if (pagamenti != null)
                {
                    var totalePagamenti = (from q in pagamenti where q.Data <= data select q.Importo).Sum();
                    totale = (decimal)totalePagamenti;
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
