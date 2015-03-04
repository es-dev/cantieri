﻿using Library.Code;
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
                        var totaleFatture = Fornitore.GetTotaleFatture(fornitore, data);
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

        public static decimal GetTotaleFattureVendita(IList<ClienteDto> clienti, DateTime data)
        {
            try
            {
                decimal totale = 0;
                if (clienti != null)
                {
                    foreach (var cliente in clienti)
                    {
                        var totaleFattura = Cliente.GetTotaleFatture(cliente, data);
                        totale += totaleFattura;
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

        public static decimal GetTotalePagamenti(IList<FornitoreDto> fornitori, DateTime data)
        {
            try
            {
                decimal totale = 0;
                if (fornitori != null)
                {
                    foreach (var fornitore in fornitori)
                    {
                        var totalePagamenti = Fornitore.GetTotalePagamenti(fornitore, data);
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

        public static decimal GetTotaleLiquidazioni(IList<ClienteDto> clienti, DateTime data)
        {
            try
            {
                decimal totale = 0;
                if (clienti != null)
                {
                    foreach (var cliente in clienti)
                    {
                        var totaleLiquidazioni = Cliente.GetTotaleLiquidazioni(cliente, data);
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

        public static Tipi.StatoSAL GetStato(CommessaDto commessa, DateTime data)
        {
            try
            {
                if (commessa != null)
                {
                    var fornitori = commessa.Fornitores;
                    var clienti = commessa.Clientes;

                    var totaleAcquisti = GetTotaleFattureAcquisto(fornitori, data);
                    var totaleVendite = GetTotaleFattureVendita(clienti, data);
                    var totalePagamenti = GetTotalePagamenti(fornitori, data);
                    var totaleLiquidazioni = GetTotaleLiquidazioni(clienti, data);

                    var importoLavori = UtilityValidation.GetDecimal(commessa.Importo);
                    var margine = UtilityValidation.GetDecimal(commessa.Margine);
                    var margineOperativo = importoLavori - totaleAcquisti;

                    var stato = Tipi.StatoSAL.None;
                    if (margineOperativo < 0)
                        stato = Tipi.StatoSAL.Perdita;
                    else if (margineOperativo < margine)
                        stato = Tipi.StatoSAL.Negativo;
                    else if (margineOperativo >= margine)
                        stato = Tipi.StatoSAL.Positivo;
                    return stato;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return Tipi.StatoSAL.None;
        }
    }
}
