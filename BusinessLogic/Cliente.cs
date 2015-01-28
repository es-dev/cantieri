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
                var fattureVendita = cliente.FatturaVenditas;
                if (fattureVendita != null)
                {
                    var totaleImponibile = (from q in fattureVendita where q.Data <= data select q.Imponibile).Sum();
                    totale = (decimal)totaleImponibile;

                    //fattureVendita = (from q in cliente.FatturaVenditas where q.Data <= data select q);
                    //foreach (var fatturaVendita in fattureVendita)
                    //    totale += (decimal)fatturaVendita.Imponibile;
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
