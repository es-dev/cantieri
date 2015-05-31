using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class Pagamento
    {
        public static string GetCodice(FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                if (fatturaAcquisto != null)
                {
                    var numeroFattura = fatturaAcquisto.Numero;
                    var pagamenti = fatturaAcquisto.Pagamentos;
                    var progressivo = 1;
                    if (pagamenti != null)
                        progressivo = pagamenti.Count + 1;
                    var codice = numeroFattura + "/" + DateTime.Today.Year.ToString() + "/" + progressivo.ToString("000");  //numerofattura/anno/progressivo
                    return codice;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static PagamentoDto CreatePagamento(PagamentoUnificatoFatturaAcquistoDto pagamenoUnificatoFatturaAcquisto)
        {
            try
            {
                if (pagamenoUnificatoFatturaAcquisto != null)
                {
                    var fatturaAcquisto = pagamenoUnificatoFatturaAcquisto.FatturaAcquisto;
                    var pagamentoUnificato = pagamenoUnificatoFatturaAcquisto.PagamentoUnificato;
                    var pagamento = new PagamentoDto();
                    pagamento.Codice = GetCodice(fatturaAcquisto);
                    pagamento.Data = pagamentoUnificato.Data;
                    pagamento.Descrizione = pagamentoUnificato.Descrizione;
                    pagamento.FatturaAcquistoId = pagamenoUnificatoFatturaAcquisto.FatturaAcquistoId;
                    pagamento.Importo = pagamenoUnificatoFatturaAcquisto.Saldo;
                    pagamento.TransazionePagamento = pagamenoUnificatoFatturaAcquisto.TransazionePagamento;
                    pagamento.Note = "Pagamento unificato " + BusinessLogic.PagamentoUnificato.GetCodifica(pagamentoUnificato);
                    pagamento.PagamentoUnificatoId = pagamenoUnificatoFatturaAcquisto.PagamentoUnificatoId;
                    pagamento.TipoPagamento = pagamentoUnificato.TipoPagamento;
                    return pagamento;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetCodifica(PagamentoDto pagamento)
        {
            try
            {
                if(pagamento!=null)
                {
                    var codice = UtilityValidation.GetStringND(pagamento.Codice);
                    var data = UtilityValidation.GetDataND(pagamento.Data);
                    var codifica =  codice + " del " + data;
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
