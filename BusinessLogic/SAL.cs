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
                foreach (var fornitore in fornitori)
                {
                    var totaleFattureAcquisto = BusinessLogic.Fornitore.GetTotaleFatture(fornitore, data);
                    totale += totaleFattureAcquisto;
                }
                return totale;
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
                var totaleFatturaVendita = BusinessLogic.Cliente.GetTotaleFatture(cliente, data);
                totale = totaleFatturaVendita;

                return totale;
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
                foreach (var fornitore in fornitori)
                {
                    var totalePagamenti = BusinessLogic.Fornitore.GetTotalePagamentiFornitore(fornitore, data);
                    totale += totalePagamenti;
                }
                return totale;
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
                var fattureVendita = cliente.FatturaVenditas;
                foreach (var fatturaVendita in fattureVendita)
                {
                    var totaleIncassi = BusinessLogic.Fattura.GetTotaleIncassi(fatturaVendita, data);
                    totale += totaleIncassi;
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
