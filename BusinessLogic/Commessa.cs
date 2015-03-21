using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

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
                    totaleImponibile = GetTotaleImponibile(fornitori, data);
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
                    totaleIVA = GetTotaleIVA(fornitori, data);
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
                    totaleFatture = GetTotaleFatture(fornitori, data);
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
                decimal totalePagamenti = 0;
                if (commessa != null)
                {
                    var fornitori = commessa.Fornitores;
                    totalePagamenti = GetTotalePagamenti(fornitori, data);
                }
                return totalePagamenti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleNoteCredito(WcfService.Dto.CommessaDto commessa, DateTime data)
        {
            try
            {
                decimal totaleNoteCredito = 0;
                if (commessa != null)
                {
                    var fornitori = commessa.Fornitores;
                    totaleNoteCredito = GetTotaleNoteCredito(fornitori, data);
                }
                return totaleNoteCredito;
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
                    totalePagamentiDare = GetTotalePagamentiDare(fornitori, data);
                }
                return totalePagamentiDare;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleImponibile(IList<FornitoreDto> fornitori, DateTime data)
        {
            try
            {
                decimal totaleImponibile = 0;
                if (fornitori != null)
                {
                    foreach (var fornitore in fornitori)
                    {
                        var _totaleImponibile = Fornitore.GetTotaleImponibile(fornitore, data);
                        totaleImponibile += _totaleImponibile;
                    }
                    return totaleImponibile;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleIVA(IList<FornitoreDto> fornitori, DateTime data)
        {
            try
            {
                decimal totaleIVA = 0;
                if (fornitori != null)
                {
                    foreach (var fornitore in fornitori)
                    {
                        var _totaleIVA = Fornitore.GetTotaleIVA(fornitore, data);
                        totaleIVA += _totaleIVA;
                    }
                }
                return totaleIVA;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleFatture(IList<FornitoreDto> fornitori, DateTime data)
        {
            try
            {
                decimal totaleFatture = 0;
                if (fornitori != null)
                {
                    foreach (var fornitore in fornitori)
                    {
                        var _totaleFatture = Fornitore.GetTotaleFatture(fornitore, data);
                        totaleFatture += _totaleFatture;
                    }
                    return totaleFatture;
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
                decimal totalePagamenti = 0;
                if (fornitori != null)
                {
                    foreach (var fornitore in fornitori)
                    {
                        var _totalePagamenti = Fornitore.GetTotalePagamenti(fornitore, data);
                        totalePagamenti += _totalePagamenti;
                    }
                    return totalePagamenti;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleNoteCredito(IList<FornitoreDto> fornitori, DateTime data)
        {
            try
            {
                decimal totaleNoteCredito = 0;
                if (fornitori != null)
                {
                    foreach (var fornitore in fornitori)
                    {
                        var _totaleNoteCredito = Fornitore.GetTotaleNoteCredito(fornitore, data);
                        totaleNoteCredito += _totaleNoteCredito;
                    }
                    return totaleNoteCredito;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        public static decimal GetTotalePagamentiDare(IList<FornitoreDto> fornitori, DateTime data)
        {
            try
            {
                if (fornitori != null)
                {
                    var totaleFatture = GetTotaleFatture(fornitori, data);
                    var totalePagamentiDato = GetTotalePagamenti(fornitori, data);
                    var totalePagamentiDare = totaleFatture - totalePagamentiDato;
                    return totalePagamentiDare;
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
