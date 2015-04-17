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
                decimal totale = 0;
                if (pagamentoUnificato != null)
                {
                    var pagamentiUnificatiFattureAcquisto = pagamentoUnificato.PagamentoUnificatoFatturaAcquistos;
                    if (pagamentiUnificatiFattureAcquisto != null)
                    {
                        foreach (var pagamentoUnificatoFatturaAcquisto in pagamentiUnificatiFattureAcquisto)
                            totale += UtilityValidation.GetDecimal(pagamentoUnificatoFatturaAcquisto.Saldo);

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
