using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Commessa
    {
        public static decimal GetImportoAvanzamentoLavori(WcfService.Dto.CommessaDto commessa)
        {
            try
            {
                if (commessa != null)
                {
                    var SALs = commessa.SALs;
                    if (SALs != null)
                    {
                        var lastSAL = (from q in SALs orderby q.Id select q).Take(1).FirstOrDefault();
                        if(lastSAL!=null)
                        {
                            var importoAvanzamentoLavori = UtilityValidation.GetDecimal(lastSAL.TotaleLiquidazioni);
                            return importoAvanzamentoLavori;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetPercentualeAvanzamento(WcfService.Dto.CommessaDto commessa)
        {
            try
            {
                if (commessa != null)
                {
                    var importoAvanzamentoLavori = GetImportoAvanzamentoLavori(commessa);
                    var importoLavori = UtilityValidation.GetDecimal(commessa.Importo);
                    if (importoLavori > 0)
                    {
                        var percentualeAvanzamento = (importoAvanzamentoLavori / importoLavori) * 100;
                        return percentualeAvanzamento;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleImponibile(WcfService.Dto.CommessaDto commessa, DateTime data)
        {
            try
            {
                decimal totaleImponibile = 0;
                if (commessa != null)
                {
                    var fornitori = commessa.Fornitores;
                    totaleImponibile = Fornitore.GetTotaleImponibile(fornitori, data);
                }
                return totaleImponibile;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleIVA(WcfService.Dto.CommessaDto commessa, DateTime data)
        {
            try
            {
                decimal totaleIVA = 0;
                if (commessa != null)
                {
                    var fornitori = commessa.Fornitores;
                    totaleIVA = Fornitore.GetTotaleIVA(fornitori, data);
                }
                return totaleIVA;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleFatture(WcfService.Dto.CommessaDto commessa, DateTime data)
        {
            try
            {
                decimal totaleFatture = 0;
                if (commessa != null)
                {
                    var fornitori = commessa.Fornitores;
                    totaleFatture = Fornitore.GetTotaleFatture(fornitori, data);
                }
                return totaleFatture;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotalePagamenti(WcfService.Dto.CommessaDto commessa, DateTime data)
        {
            try
            {
                decimal totalePagamentiDato = 0;
                if (commessa != null)
                {
                    var fornitori = commessa.Fornitores;
                    totalePagamentiDato = Fornitore.GetTotalePagamenti(fornitori, data);
                }
                return totalePagamentiDato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotalePagamentiDare(WcfService.Dto.CommessaDto commessa, DateTime data)
        {
            try
            {
                decimal totalePagamentiDare = 0;
                if (commessa != null)
                {
                    var fornitori = commessa.Fornitores;
                    totalePagamentiDare = Fornitore.GetTotalePagamentiDare(fornitori, data);
                }
                return totalePagamentiDare;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
    }
}
