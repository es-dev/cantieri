using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Fornitore
    {
        public static decimal GetTotaleFatture(WcfService.Dto.FornitoreDto fornitore, DateTime data)
        {
            try
            {
                decimal totale = 0;
                if (fornitore != null)
                {
                    var fattureAcquisto = fornitore.FatturaAcquistos;
                    if (fattureAcquisto != null)
                    {
                        var totaleImponibile = (from q in fattureAcquisto where q.Totale != null && q.Data <= data select q.Totale).Sum();
                        totale = (decimal)totaleImponibile;
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

        public static decimal GetTotalePagamenti(WcfService.Dto.FornitoreDto fornitore, DateTime data)
        {
            try
            {
                decimal totale = 0;
                if (fornitore != null)
                {
                    var fattureAcquisto = fornitore.FatturaAcquistos;
                    if (fattureAcquisto != null)
                    {
                        foreach (var fatturaAcquisto in fattureAcquisto)
                        {
                            var totalePagamenti = BusinessLogic.Fattura.GetTotalePagamenti(fatturaAcquisto, data);
                            totale += totalePagamenti;
                        }
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

        public static List<WcfService.Dto.FatturaAcquistoDto> GetFattureInsolute(IList<WcfService.Dto.FatturaAcquistoDto> fatture)
        {
            try
            {
                var fattureInsolute = new List<WcfService.Dto.FatturaAcquistoDto>();
                foreach (var fattura in fatture)
                {
                    var data = fattura.Data;
                    var scadenzaPagamento = fattura.ScadenzaPagamento;
                    var _scadenzaPagamento = (Tipi.ScadenzaPagamento)Enum.Parse(typeof(Tipi.ScadenzaPagamento), scadenzaPagamento);
                    var scadenza = BusinessLogic.Fattura.GetScadenza(data.Value, _scadenzaPagamento);
                    var today = DateTime.Today;
                    var totaleFattura = fattura.Totale;
                    var totalePagamenti = fattura.TotalePagamenti;
                    if (totaleFattura != null && totalePagamenti != null)
                    {
                        var stato = BusinessLogic.Fattura.GetStato(today, scadenza, totaleFattura.Value, totalePagamenti.Value);

                        if (stato == BusinessLogic.Tipi.StatoFattura.Insoluta)
                            fattureInsolute.Add(fattura);
                    }
                }
                return fattureInsolute;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static List<WcfService.Dto.FatturaAcquistoDto> GetFattureNonPagate(IList<WcfService.Dto.FatturaAcquistoDto> fatture)
        {
            try
            {
                var fattureNonPagate = new List<WcfService.Dto.FatturaAcquistoDto>();
                foreach (var fattura in fatture)
                {
                    var data = fattura.Data;
                    var scadenzaPagamento = fattura.ScadenzaPagamento;
                    var _scadenzaPagamento = (Tipi.ScadenzaPagamento)Enum.Parse(typeof(Tipi.ScadenzaPagamento), scadenzaPagamento);
                    var scadenza = BusinessLogic.Fattura.GetScadenza(data.Value, _scadenzaPagamento);
                    var today = DateTime.Today;
                    var totaleFattura = fattura.Totale;
                    var totalePagamenti = fattura.TotalePagamenti;
                    if (totaleFattura != null && totalePagamenti != null)
                    {
                        var stato = BusinessLogic.Fattura.GetStato(today, scadenza, totaleFattura.Value, totalePagamenti.Value);

                        if (stato == BusinessLogic.Tipi.StatoFattura.NonPagata)
                            fattureNonPagate.Add(fattura);
                    }
                }
                return fattureNonPagate;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}
