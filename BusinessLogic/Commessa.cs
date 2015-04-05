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
        public static decimal GetTotaleImponibile(CommessaDto commessa, DateTime data)
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

        public static decimal GetTotaleIVA(CommessaDto commessa, DateTime data)
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

        public static decimal GetTotaleFattureAcquisto(CommessaDto commessa, DateTime data)
        {
            try
            {
                if (commessa != null)
                {
                    var fornitori = commessa.Fornitores;
                    var totaleFattureAcquisto = GetTotaleFattureAcquisto(fornitori, data);
                    return totaleFattureAcquisto;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotalePagamenti(CommessaDto commessa, DateTime data)
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

        public static decimal GetTotaleNoteCredito(CommessaDto commessa, DateTime data)
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

        public static decimal GetTotalePagamentiDare(CommessaDto commessa, DateTime data)
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

        public static decimal GetTotaleFattureAcquisto(IList<FornitoreDto> fornitori, DateTime data)
        {
            try
            {
                if (fornitori != null)
                {
                    decimal totaleFattureAcquisto = 0;
                    foreach (var fornitore in fornitori)
                    {
                        var _totaleFattureAcquisto = Fornitore.GetTotaleFattureAcquisto(fornitore, data);
                        totaleFattureAcquisto += _totaleFattureAcquisto;
                    }
                    return totaleFattureAcquisto;
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
                    var totaleFattureAcquisto = GetTotaleFattureAcquisto(fornitori, data);
                    var totalePagamentiDato = GetTotalePagamenti(fornitori, data);
                    var totalePagamentiDare = totaleFattureAcquisto - totalePagamentiDato;
                    return totalePagamentiDare;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetImportoAvanzamentoLavori(CommessaDto commessa)
        {
            try
            {
                decimal importoAvanzamentoLavori = 0;
                if (commessa != null)
                {
                    var statoCommessa = commessa.Stato;
                    if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                        importoAvanzamentoLavori = UtilityValidation.GetDecimal(commessa.ImportoAvanzamento);
                    else
                    {
                        importoAvanzamentoLavori = BusinessLogic.SAL.GetImportoAvanzamentoLavori(commessa);
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetPercentualeAvanzamento(CommessaDto commessa)
        {
            try
            {
                decimal percentualeAvanzamento = 0;
                if (commessa != null)
                {
                    var statoCommessa = commessa.Stato;
                    if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                        percentualeAvanzamento = UtilityValidation.GetDecimal(commessa.Percentuale);
                    else
                    {
                        percentualeAvanzamento = BusinessLogic.SAL.GetPercentualeAvanzamento(commessa);
                    }
                }
                return percentualeAvanzamento;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
    }
}
