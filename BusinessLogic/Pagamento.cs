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
                    var progressivo = 1;
                    var pagamenti = fatturaAcquisto.Pagamentos;
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
                    pagamento.Note = "Pagamento unificato " + pagamentoUnificato.Codice;
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
                    var codifica = "Pagamento n." + codice + " del " + data;
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
