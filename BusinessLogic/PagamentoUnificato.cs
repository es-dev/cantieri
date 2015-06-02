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
                        decimal totale = 0;
                        foreach (var pagamentoUnificatoFatturaAcquisto in pagamentiUnificatiFattureAcquisto)
                        {
                            var saldo = UtilityValidation.GetDecimal(pagamentoUnificatoFatturaAcquisto.Saldo);
                            totale += saldo;
                        }
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
                    var codifica = pagamentoUnificato.Codice + " DEL " + UtilityValidation.GetDataND(pagamentoUnificato.Data);
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
