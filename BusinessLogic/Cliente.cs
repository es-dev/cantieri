using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class Cliente
    {
        internal static decimal GetTotaleFatture(WcfService.Dto.ClienteDto cliente, DateTime data)
        {
            try
            {
                decimal totale = 0;
                if (cliente != null)
                {
                    var fattureVendita = cliente.FatturaVenditas;
                    if (fattureVendita != null)
                    {
                        var totaleImponibile = (from q in fattureVendita where q.Totale != null && q.Data <= data select q.Totale).Sum();
                        totale = (decimal)totaleImponibile;
                        return totale;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        internal static decimal GetTotaleIncassi(WcfService.Dto.ClienteDto cliente, DateTime data)
        {
            try
            {
                decimal totale = 0;
                if (cliente != null)
                {
                    var fattureVendita = cliente.FatturaVenditas;
                    foreach (var fatturaVendita in fattureVendita)
                    {
                        var totaleIncassi = BusinessLogic.Fattura.GetTotaleIncassi(fatturaVendita, data);
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
    }
}
