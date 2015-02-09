using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Cliente
    {
        public static decimal GetTotaleFatture(WcfService.Dto.ClienteDto cliente, DateTime data)
        {
            try
            {
                decimal totale = 0;
                if (cliente != null)
                {
                    var fattureVendita = cliente.FatturaVenditas;
                    if (fattureVendita != null)
                    {
                        var totaleImponibile = (from q in fattureVendita where q.Totale != null && q.Data <= data select q.Totale).Sum();
                        totale = UtilityValidation.GetDecimal(totaleImponibile);
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

        public static decimal GetTotaleIncassi(WcfService.Dto.ClienteDto cliente, DateTime data)
        {
            try
            {
                decimal totale = 0;
                if (cliente != null)
                {
                    var fattureVendita = cliente.FatturaVenditas;
                    foreach (var fatturaVendita in fattureVendita)
                    {
                        var totaleIncassi = BusinessLogic.Fattura.GetTotaleIncassi(fatturaVendita, data);
                        totale += totaleIncassi;
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

        public static List<WcfService.Dto.FatturaVenditaDto> GetFattureInsolute(IList<WcfService.Dto.FatturaVenditaDto> fatture)
        {
            try
            {
                var fattureInsolute = new List<WcfService.Dto.FatturaVenditaDto>();
                foreach (var fattura in fatture)
                {
                    var data = fattura.Data;
                    var scadenzaPagamento = fattura.ScadenzaPagamento;
                    var _scadenzaPagamento = (Tipi.ScadenzaPagamento)Enum.Parse(typeof(Tipi.ScadenzaPagamento), scadenzaPagamento);
                    var scadenza = BusinessLogic.Fattura.GetScadenza(data.Value, _scadenzaPagamento);
                    var today = DateTime.Today;
                    var totaleFattura = UtilityValidation.GetDecimal(fattura.Totale);
                    var totaleincassi = UtilityValidation.GetDecimal(fattura.TotaleLiquidazioni);
                    var stato = BusinessLogic.Fattura.GetStato(today, scadenza, totaleFattura, totaleincassi);
                    if (stato == BusinessLogic.Tipi.StatoFattura.Insoluta)
                        fattureInsolute.Add(fattura);
                }
                return fattureInsolute;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static List<WcfService.Dto.FatturaVenditaDto> GetFattureNonPagate(IList<WcfService.Dto.FatturaVenditaDto> fatture)
        {
            try
            {
                var fattureNonPagate = new List<WcfService.Dto.FatturaVenditaDto>();
                foreach (var fattura in fatture)
                {
                    var data = fattura.Data;
                    var scadenzaPagamento = fattura.ScadenzaPagamento;
                    var _scadenzaPagamento = (Tipi.ScadenzaPagamento)Enum.Parse(typeof(Tipi.ScadenzaPagamento), scadenzaPagamento);
                    var scadenza = BusinessLogic.Fattura.GetScadenza(data.Value, _scadenzaPagamento);
                    var today = DateTime.Today;
                    var totaleFattura = UtilityValidation.GetDecimal(fattura.Totale);
                    var totaleLiquidazioni = UtilityValidation.GetDecimal(fattura.TotaleLiquidazioni);
                    var stato = BusinessLogic.Fattura.GetStato(today, scadenza, totaleFattura, totaleLiquidazioni);
                    if (stato == BusinessLogic.Tipi.StatoFattura.NonPagata)
                        fattureNonPagate.Add(fattura);
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
