using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PagamentoUnificato
    {

        public static decimal GetTotalePagamentoUnificato(WcfService.Dto.PagamentoUnificatoDto pagamentoUnificato)
        {
            try
            {
                decimal totale = 0;
                var pagamentiUnificatiFattureAcquisto = pagamentoUnificato.PagamentoUnificatoFatturaAcquistos;
                 var totaleSaldo = (from q in pagamentiUnificatiFattureAcquisto select q.Saldo).Sum();
                totale = UtilityValidation.GetDecimal(totaleSaldo);

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
