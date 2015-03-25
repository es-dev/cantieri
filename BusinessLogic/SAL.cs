using Library.Code;
using Library.Code.Enum;
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
        public static decimal GetImportoAvanzamentoLavori(CommessaDto commessa)
        {
            try
            {
                if (commessa != null)
                {
                    var SALs = commessa.SALs;
                    if (SALs != null)
                    {
                        var lastSAL = (from q in SALs orderby q.Id descending select q).Take(1).FirstOrDefault();
                        if (lastSAL != null)
                        {
                            var totaleLiquidazioni = UtilityValidation.GetDecimal(lastSAL.TotaleLiquidazioni);
                            return totaleLiquidazioni;
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

        public static decimal GetPercentualeAvanzamento(CommessaDto commessa)
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
                        var totaleFattura = Cliente.GetTotaleFattureVendita(cliente, data);
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








        public static string GetStatoDescrizione(SALDto sal, CommessaDto commessa)
        {
            try
            {
                var statoDescrizione = "N/D";
                if (commessa != null)
                {
                    var statoCommessa = commessa.Stato;
                    if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                        statoDescrizione = sal.Stato;
                    else
                    {
                        var today = DateTime.Today;
                        var data = sal.Data;
                        var fornitori = commessa.Fornitores;
                        var totaleAcquisti = GetTotaleFattureAcquisto(fornitori, data.Value);
                        var importoLavori = UtilityValidation.GetDecimal(commessa.Importo);
                        var margine = UtilityValidation.GetDecimal(commessa.Margine);
                        var margineOperativo = importoLavori - totaleAcquisti;
                        var statoSAL = GetStato(commessa, data.Value);
                        var _statoDescrizione = GetStatoDescrizione(importoLavori, margine, margineOperativo, statoSAL);
                        statoDescrizione = _statoDescrizione.ToString();
                    }
                }
                return statoDescrizione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }



        private static StateDescriptionImage GetStatoDescrizione(decimal importoLavori, decimal margine, decimal margineOperativo, Tipi.StatoSAL statoSAL)
        {
            try
            {
                var descrizione = "";
                var stato = TypeState.None;
                var _margine = UtilityValidation.GetEuro(margine);
                var _margineOperativo = UtilityValidation.GetEuro(margineOperativo);
                var _importoLavori = UtilityValidation.GetEuro(importoLavori);

                if (statoSAL == Tipi.StatoSAL.Perdita)
                {
                    descrizione = "Andamento del lavoro critico. Il margine aziendale previsto è di " + _margine + " e il margine operativo si attesta al valore critico di " + _margineOperativo + " per un importo lavori di " + _importoLavori;
                    stato = TypeState.Critical;
                }
                else if (statoSAL == Tipi.StatoSAL.Negativo)
                {
                    descrizione = "Andamento del lavoro negativo. Il margine aziendale previsto è di " + _margine + " e il margine operativo si attesta ad un valore inferiore pari a " + _margineOperativo + " per un importo lavori di " + _importoLavori;
                    stato = TypeState.Warning;
                }
                else if (statoSAL == Tipi.StatoSAL.Positivo)
                {
                    descrizione = "Andamento del lavoro positivo. Il margine aziendale previsto è di " + _margine + " e il margine operativo si attesta a valori superiori pari a " + _margineOperativo + " per un importo lavori di " + _importoLavori;
                    stato = TypeState.Normal;
                }
                var statoDescrizione = new StateDescriptionImage(stato, descrizione);
                return statoDescrizione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public  static decimal GatTotalePagamenti(SALDto sal, CommessaDto commessa)
        {
            try
            {
                decimal totalePagamenti = 0;
                if (commessa != null)
                {
                    var fornitori = commessa.Fornitores;
                    var statoCommessa = commessa.Stato;
                    if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                        totalePagamenti = UtilityValidation.GetDecimal(sal.TotalePagamenti);
                    else
                    {
                        var data = sal.Data;
                        totalePagamenti = GetTotalePagamenti(fornitori, data.Value);
                    }
                }
                return totalePagamenti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleLiquidazioni(SALDto sal, CommessaDto commessa)
        {
            try
            {
                decimal totaleLiquidazioni = 0;
                if (commessa != null)
                {
                    var clienti = commessa.Clientes;
                    var statoCommessa = commessa.Stato;
                    if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                        totaleLiquidazioni = UtilityValidation.GetDecimal(sal.TotaleLiquidazioni);
                    else
                    {
                        var data = sal.Data;
                        totaleLiquidazioni = GetTotaleLiquidazioni(clienti, data.Value);
                    }
                }
                return totaleLiquidazioni;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleVendite(SALDto sal, CommessaDto commessa)
        {
            try
            {
                decimal totaleVendite = 0;
                if (commessa != null)
                {
                    var clienti = commessa.Clientes;
                    var statoCommessa = commessa.Stato;
                    if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                        totaleVendite = UtilityValidation.GetDecimal(sal.TotaleVendite);
                    else
                    {
                        var data = sal.Data;
                        totaleVendite = GetTotaleFattureVendita(clienti, data.Value);
                    }
                }
                return totaleVendite;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleAcquisti(SALDto sal, CommessaDto commessa)
        {
            try
            {
                decimal totaleAcquisti = 0;
                if (commessa != null)
                {
                    var fornitori = commessa.Fornitores;
                    var statoCommessa = commessa.Stato;
                    if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                        totaleAcquisti = UtilityValidation.GetDecimal(sal.TotaleAcquisti);
                    else
                    {
                        var data = sal.Data;
                        totaleAcquisti = GetTotaleFattureAcquisto(fornitori, data.Value);
                    }
                }
                return totaleAcquisti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
    }
}
