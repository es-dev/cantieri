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
                    var fattureVendita = (from q in cliente.FatturaVenditas where q.Data <= data select q);
                    if (fattureVendita != null)
                    {
                        foreach (var fatturaVendita in fattureVendita)
                        {
                            var totaleImponibile = UtilityValidation.GetDecimal(fatturaVendita.Imponibile);
                            totale += totaleImponibile;
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

        public static decimal GetTotaleLiquidazioni(WcfService.Dto.ClienteDto cliente, DateTime data)
        {
            try
            {
                decimal totale = 0;
                if (cliente != null)
                {
                    var fattureVendita = cliente.FatturaVenditas;
                    foreach (var fatturaVendita in fattureVendita)
                    {
                        var totaleLiquidazioni = Fattura.GetTotaleLiquidazioni(fatturaVendita, data);
                        totale += totaleLiquidazioni;
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

        public static IList<WcfService.Dto.FatturaVenditaDto> GetFattureInsolute(IList<WcfService.Dto.FatturaVenditaDto> fattureVendita)
        {
            try
            {
                if (fattureVendita != null)
                {
                    var fattureInsolute = GetFatture(fattureVendita, Tipi.StatoFattura.Insoluta);
                    return fattureInsolute;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static IList<WcfService.Dto.FatturaVenditaDto> GetFattureNonLiquidate(IList<WcfService.Dto.FatturaVenditaDto> fattureVendita)
        {
            try
            {
                if (fattureVendita != null)
                {
                    var fattureNonLiquidate = GetFatture(fattureVendita, Tipi.StatoFattura.NonPagata);
                    return fattureNonLiquidate;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static IList<WcfService.Dto.FatturaVenditaDto> GetFatture(IList<WcfService.Dto.FatturaVenditaDto> fattureVendita, Tipi.StatoFattura stato)
        {
            try
            {
                if (fattureVendita != null)
                {
                    var _fatture = (from q in fattureVendita where Fattura.GetStato(q) == stato select q).ToList();
                    return _fatture;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static Tipi.StatoCliente GetStato(WcfService.Dto.ClienteDto cliente)
        {
            try
            {
                if (cliente != null)
                {
                    var today = DateTime.Today;
                    var totaleFatture = GetTotaleFatture(cliente, today);
                    var totaleLiquidazioni = GetTotaleLiquidazioni(cliente, today);
                    var fatture = cliente.FatturaVenditas;
                    var fattureInsolute = GetFattureInsolute(fatture);
                    var existFattureInsolute = (fattureInsolute.Count >= 1);

                    var stato = Tipi.StatoCliente.None;
                    if (totaleLiquidazioni < totaleFatture)
                    {
                        if (existFattureInsolute)
                            stato = Tipi.StatoCliente.Insoluto;
                        else
                            stato = Tipi.StatoCliente.NonLiquidato;
                    }
                    else if (totaleLiquidazioni >= totaleFatture)
                        stato = Tipi.StatoCliente.Liquidato;

                    return stato;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return Tipi.StatoCliente.None;
        }
    }
}
