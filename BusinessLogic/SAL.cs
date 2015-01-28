using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class SAL
    {
        public static decimal GetTotalePagamenti(IEnumerable<FatturaAcquistoDto> fattureAcquisto) //todo: che gli passo?????
        {
            try
            {
                decimal totale = 0;
                foreach (var fatturaAcquisto in fattureAcquisto)
                {
                    var totaleFattura = fatturaAcquisto.Totale;
                    if(totaleFattura!=null)
                        totale += (decimal)totaleFattura;
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
