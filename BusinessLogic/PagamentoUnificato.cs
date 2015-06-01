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

        public static string GetCodifica(PagamentoUnificatoFatturaAcquistoDto pagamentoUnificatoFatturaAcquisto)
        {
            try
            {
                if(pagamentoUnificatoFatturaAcquisto!=null)
                {
                    var pagamentoUnificato = pagamentoUnificatoFatturaAcquisto.PagamentoUnificato;
                    var fatturaAcquisto = pagamentoUnificatoFatturaAcquisto.FatturaAcquisto;
                    if(pagamentoUnificato!=null)
                    {
                        var codifica = pagamentoUnificato.Codice;
                        if (fatturaAcquisto != null)
                            codifica += "-" + fatturaAcquisto.Numero;

                        return codifica;

                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetCodifica(PagamentoUnificatoDto pagamentoUnificato)
        {
            try
            {
                if(pagamentoUnificato!=null)
                {
                    var data = UtilityValidation.GetDataND(pagamentoUnificato.Data);
                    var codice = pagamentoUnificato.Codice;
                    var codifica = codice + " DEL " + data;
                    return codifica;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}
