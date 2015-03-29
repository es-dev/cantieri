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
    public class Cliente
    {
        public static decimal GetTotaleFattureVendita(ClienteDto cliente, DateTime data)
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

        public static decimal GetTotaleFattureVendita(ClienteDto cliente)
        {
            try
            {
                decimal totaleFattureVendita = 0;
                if (cliente != null)
                {
                    var today = DateTime.Today;
                    var commessa = cliente.Commessa;
                    if (commessa != null)
                    {
                        var statoCommessa = commessa.Stato;
                        if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                            totaleFattureVendita = UtilityValidation.GetDecimal(cliente.TotaleFattureVendita);
                        else
                            totaleFattureVendita = GetTotaleFattureVendita(cliente, today);
                    }
                }
                return totaleFattureVendita;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleLiquidazioni(ClienteDto cliente, DateTime data)
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

        public static decimal GetTotaleLiquidazioni(ClienteDto cliente)
        {
            try
            {
                decimal totaleLiquidazioni = 0;
                if (cliente != null)
                {
                    var today = DateTime.Today;
                    var commessa = cliente.Commessa;
                    if (commessa != null)
                    {
                        var statoCommessa = commessa.Stato;
                        if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                            totaleLiquidazioni = UtilityValidation.GetDecimal(cliente.TotaleLiquidazioni);
                        else
                            totaleLiquidazioni = BusinessLogic.Cliente.GetTotaleLiquidazioni(cliente, today);
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

        public static IList<FatturaVenditaDto> GetFattureInsolute(IList<FatturaVenditaDto> fattureVendita)
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

        public static IList<FatturaVenditaDto> GetFattureNonLiquidate(IList<FatturaVenditaDto> fattureVendita)
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

        private static IList<FatturaVenditaDto> GetFatture(IList<FatturaVenditaDto> fattureVendita, Tipi.StatoFattura stato)
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

        public static Tipi.StatoCliente GetStato(ClienteDto cliente)
        {
            try
            {
                if (cliente != null)
                {
                    var today = DateTime.Today;
                    var totaleFatture = GetTotaleFattureVendita(cliente, today);
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
                            stato = Tipi.StatoCliente.NonIncassato;
                    }
                    else if (totaleLiquidazioni >= totaleFatture)
                        stato = Tipi.StatoCliente.Incassato;

                    return stato;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return Tipi.StatoCliente.None;
        }

        public static string GetStatoDescrizione(ClienteDto cliente)
        {
            try
            {
                var statoDescrizione = "N/D";
                if (cliente != null)
                {
                    var commessa = cliente.Commessa;
                    if (commessa != null)
                    {
                        var statoCommessa = commessa.Stato;
                        if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                            statoDescrizione = cliente.Stato;
                        else
                        {
                            var today = DateTime.Today;
                            var fatture = cliente.FatturaVenditas;
                            var totaleFatture = GetTotaleFattureVendita(cliente, today);
                            var totaleLiquidazioni = GetTotaleLiquidazioni(cliente, today);
                            var fattureInsolute = GetFattureInsolute(fatture);
                            var fattureNonLiquidate = GetFattureNonLiquidate(fatture);
                            var statoCliente = GetStato(cliente);
                            var _statoDescrizione = GetStatoDescrizione(totaleFatture, totaleLiquidazioni, fattureInsolute, fattureNonLiquidate, statoCliente);
                            statoDescrizione = _statoDescrizione.ToString();
                        }
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

        //todo: da modificare
        private static StateDescriptionImage GetStatoDescrizione(decimal totaleFatture, decimal totaleLiquidazioni, IList<FatturaVenditaDto> fattureInsolute,
           IList<FatturaVenditaDto> fattureNonLiquidate, Tipi.StatoCliente statoCliente)
        {
            try
            {
                var descrizione = "";
                var stato = TypeState.None;
                var existFattureInsolute = (fattureInsolute.Count >= 1);
                var existFattureNonLiquidate = (fattureNonLiquidate.Count >= 1);
                var listaFattureInsolute = BusinessLogic.Fattura.GetLista(fattureInsolute);
                var listaFattureNonLiquidate = BusinessLogic.Fattura.GetLista(fattureNonLiquidate);
                var _totaleLiquidazioni = UtilityValidation.GetEuro(totaleLiquidazioni);
                var _totaleFatture = UtilityValidation.GetEuro(totaleFatture);

                if (statoCliente == Tipi.StatoCliente.Insoluto) //condizione di non soluzione delle fatture, segalo le fatture insolute ed eventualmente quelle non pagate
                {
                    descrizione = "Il committente risulta insoluto. Il totale incassi pari a " + _totaleLiquidazioni + " è inferiore al totale delle fatture pari a " + _totaleFatture + ". Le fatture insolute sono " + listaFattureInsolute;
                    if (existFattureNonLiquidate)
                        descrizione += " Le fatture non incassate sono " + listaFattureNonLiquidate;
                    stato = TypeState.Critical;
                }
                else if (statoCliente == Tipi.StatoCliente.NonIncassato) //condizione di non pagamento (pagamenti nulli o non completi, se non completi segnalo le fatture non pagate)
                {
                    descrizione = "Il committente risulta non incassato. Il totale incassi pari a " + _totaleLiquidazioni + " è inferiore al totale delle fatture pari a " + _totaleFatture;
                    if (existFattureNonLiquidate)
                        descrizione += " Le fatture non pagate sono " + listaFattureNonLiquidate;
                    stato = TypeState.Warning;
                }
                else if (statoCliente == Tipi.StatoCliente.Incassato)
                {
                    descrizione = "Il committente risulta incassato. Tutte le fatture sono state liquidate";  //non so se ha senso indicargli anche insolute o no!!!!! per ora NO
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
    
    
    }

}
