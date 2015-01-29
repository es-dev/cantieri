using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class SAL
    {
        public static decimal GetTotaleFattureAcquisto(IList<FornitoreDto> fornitori, DateTime data)
        {
            try
            {
                decimal totale = 0;
                if (fornitori != null)
                {
                    foreach (var fornitore in fornitori)
                    {
                        var totaleFatture = BusinessLogic.Fornitore.GetTotaleFatture(fornitore, data);
                        totale += totaleFatture;
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

        public static decimal GetTotaleFattureVendita(ClienteDto cliente, DateTime data)
        {
            try
            {
                decimal totale = 0;
                if (cliente != null)
                {
                    var totaleFattura = BusinessLogic.Cliente.GetTotaleFatture(cliente, data);
                    totale = totaleFattura;
                    return totale;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotalePagamenti(IList<FornitoreDto> fornitori, DateTime data)
        {
            try
            {
                decimal totale = 0;
                if (fornitori != null)
                {
                    foreach (var fornitore in fornitori)
                    {
                        var totalePagamenti = BusinessLogic.Fornitore.GetTotalePagamenti(fornitore, data);
                        totale += totalePagamenti;
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

        public static decimal GetTotaleIncassi(ClienteDto cliente, DateTime data)
        {
            try
            {
                decimal totale = 0;
                if (cliente != null)
                {
                    var totaleIncassi = BusinessLogic.Cliente.GetTotaleIncassi(cliente, data);
                    totale = totaleIncassi;
                    return totale;
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
