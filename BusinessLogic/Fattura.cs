﻿using Library.Code;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Fattura
    {
        public static decimal GetTotale(decimal imponibile, decimal iva)
        {
            try
            {
                decimal totale = imponibile + iva;
                return totale;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleIncassi(WcfService.Dto.FatturaVenditaDto fatturaVendita, DateTime data)
        {
            try
            {
                decimal totale = 0;
                if (fatturaVendita != null)
                {
                    var incassi = fatturaVendita.Liquidaziones;
                    if (incassi != null)
                    {
                        var totaleIncassi = (from q in incassi where q.Data <= data select q.Importo).Sum();
                        totale = UtilityValidation.GetDecimal(totaleIncassi);
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

        public static decimal GetTotalePagamenti(WcfService.Dto.FatturaAcquistoDto fatturaAcquisto, DateTime data)
        {
            try
            {
                decimal totale = 0;
                if (fatturaAcquisto != null)
                {
                    var pagamenti = fatturaAcquisto.Pagamentos;
                    if (pagamenti != null)
                    {
                        var totalePagamenti = (from q in pagamenti where q.Data <= data select q.Importo).Sum();
                        totale = UtilityValidation.GetDecimal(totalePagamenti);
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

        public static DateTime GetScadenza(DateTime data, BusinessLogic.Tipi.ScadenzaPagamento scadenzaPagamento)
        {
            try
            {
                var giorni = GetGiorni(scadenzaPagamento);
                var scadenza= data.AddDays(giorni);
                return scadenza;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return DateTime.MinValue;
        }

        private static int GetGiorni(BusinessLogic.Tipi.ScadenzaPagamento tipoScadenzaPagamento)
        {
            try
            {
                var giorni = 0;
                if (tipoScadenzaPagamento == Tipi.ScadenzaPagamento.GG120)
                    giorni = 120;
                else if (tipoScadenzaPagamento == Tipi.ScadenzaPagamento.GG90)
                    giorni = 90;
                else if (tipoScadenzaPagamento == Tipi.ScadenzaPagamento.GG60)
                    giorni = 60;
                else if (tipoScadenzaPagamento == Tipi.ScadenzaPagamento.GG30)
                    giorni = 30;
                return giorni;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static string GetRitardo(DateTime data, DateTime scadenza)
        {
            try
            {
                string ritardo = null;
                var giorniRitardo = data.Subtract(scadenza).TotalDays;
                if (0 <= giorniRitardo && giorniRitardo <= 120)
                    ritardo = giorniRitardo.ToString() + " giorni";
                else if (120 < giorniRitardo && giorniRitardo <= 365)
                {
                    var mesiRitardo = (int)(giorniRitardo / 30) + 1;
                    ritardo = mesiRitardo.ToString() + " mesi";    
                }
                else if (giorniRitardo > 365)
                {
                    var anniRitardo = (int)(giorniRitardo / 365);
                    ritardo = anniRitardo.ToString() + " anni"; 
                }
                return ritardo;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetRitardo(WcfService.Dto.FatturaAcquistoDto fattura)
        {
            try
            {
                var today = DateTime.Today;
                var scadenzaPagamento = fattura.ScadenzaPagamento;
                var data = fattura.Data;
                var _scadenzaPagamento = (Tipi.ScadenzaPagamento)Enum.Parse(typeof(Tipi.ScadenzaPagamento), scadenzaPagamento);
                var scadenza = BusinessLogic.Fattura.GetScadenza(data.Value, _scadenzaPagamento);
                var ritardo = GetRitardo(today, scadenza);
                return ritardo;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static Tipi.StatoFattura GetStato(WcfService.Dto.FatturaAcquistoDto fattura)
        {
            try
            {
                var today = DateTime.Today;
                var data = fattura.Data;
                var scadenzaPagamento = fattura.ScadenzaPagamento;
                var _scadenzaPagamento = (Tipi.ScadenzaPagamento)Enum.Parse(typeof(Tipi.ScadenzaPagamento), scadenzaPagamento);
                var scadenza = GetScadenza(data.Value, _scadenzaPagamento);
                var totaleFattura = UtilityValidation.GetDecimal(fattura.Totale);
                var totalePagamenti = GetTotalePagamenti(fattura, today);

                var stato = GetStato(today, scadenza, totaleFattura, totalePagamenti);
                return stato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return Tipi.StatoFattura.None;
        }

        private static Tipi.StatoFattura GetStato(DateTime today, DateTime scadenza, decimal totaleFattura, decimal totalePagamentiIncassi)
        {
            try
            {
                var stato = Tipi.StatoFattura.None;
                var insoluta = (today > scadenza);
                if (totalePagamentiIncassi < totaleFattura)
                {
                    if (insoluta)
                        stato = Tipi.StatoFattura.Insoluta;
                    else
                        stato = Tipi.StatoFattura.NonPagata;
                }
                else if (totalePagamentiIncassi >= totaleFattura)
                    stato = Tipi.StatoFattura.Pagata;
                return stato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return Tipi.StatoFattura.None;
            
        }


        public static Tipi.StatoFattura GetStato(WcfService.Dto.FatturaVenditaDto fattura)
        {
            try
            {
                var today = DateTime.Today;
                var data = fattura.Data;
                var scadenzaPagamento = fattura.ScadenzaPagamento;
                var _scadenzaPagamento = (Tipi.ScadenzaPagamento)Enum.Parse(typeof(Tipi.ScadenzaPagamento), scadenzaPagamento);
                var scadenza = GetScadenza(data.Value, _scadenzaPagamento);
                var totaleFattura = UtilityValidation.GetDecimal(fattura.Totale);
                var totaleIncassi = GetTotaleIncassi(fattura, today);

                var stato = GetStato(today, scadenza, totaleFattura, totaleIncassi);
                return stato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return Tipi.StatoFattura.None;
        }

        public static string GetLista(IList<WcfService.Dto.FatturaAcquistoDto> fatture)
        {
            try
            {
                var listaFatture = "";
                foreach (var fattura in fatture)
                {
                    if (listaFatture.Length >= 1)
                        listaFatture += ", ";
                    var _fattura = fattura.Numero + "/" + fattura.Data.Value.Year.ToString();
                    listaFatture += _fattura;
                }
                return listaFatture;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetLista(IList<WcfService.Dto.FatturaVenditaDto> fatture)
        {
            try
            {
                var listaFatture = "";
                foreach (var fattura in fatture)
                {
                    if (listaFatture.Length >= 1)
                        listaFatture += ", ";
                    var _fattura = fattura.Numero + "/" + fattura.Data.Value.Year.ToString();
                    listaFatture += _fattura;
                }
                return listaFatture;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        

    }
}
