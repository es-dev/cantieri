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

        public static IList<WcfService.Dto.FatturaVenditaDto> GetFattureInsolute(IList<WcfService.Dto.FatturaVenditaDto> fatture)
        {
            try
            {
                var fattureInsolute = GetFatture(fatture, Tipi.StatoFattura.Insoluta);
                return fattureInsolute;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static IList<WcfService.Dto.FatturaVenditaDto> GetFattureNonPagate(IList<WcfService.Dto.FatturaVenditaDto> fatture)
        {
            try
            {
                var fattureNonPagate = GetFatture(fatture, Tipi.StatoFattura.NonPagata);
                return fattureNonPagate;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static IList<WcfService.Dto.FatturaVenditaDto> GetFatture(IList<WcfService.Dto.FatturaVenditaDto> fatture, BusinessLogic.Tipi.StatoFattura stato)
        {
            try
            {
                var _fatture = (from q in fatture where BusinessLogic.Fattura.GetStato(q) == stato select q).ToList();
                return _fatture;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

    }
}
