using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class PagamentoUnificato
    {

        public static decimal GetTotalePagamentoUnificato(PagamentoUnificatoDto pagamentoUnificato)
        {
            try
            {
                if (pagamentoUnificato != null)
                {
                    var pagamentiUnificatiFattureAcquisto = pagamentoUnificato.PagamentoUnificatoFatturaAcquistos;
                    if (pagamentiUnificatiFattureAcquisto != null)
                    {
                        var totale = UtilityValidation.GetDecimal((from q in pagamentiUnificatiFattureAcquisto where q.Saldo!=null select q.Saldo).Sum());
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
    }
}
