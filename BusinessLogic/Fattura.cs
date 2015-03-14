using Library.Code;
using Library.Code.Enum;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

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

        public static decimal GetTotale(FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                if (fatturaAcquisto != null)
                {
                    var imponibile = UtilityValidation.GetDecimal(fatturaAcquisto.Imponibile);
                    var iva = UtilityValidation.GetDecimal(fatturaAcquisto.IVA);
                    decimal totale = GetTotale(imponibile, iva);
                    return totale;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotale(FatturaVenditaDto fatturaVendita)
        {
            try
            {
                if (fatturaVendita != null)
                {
                    var imponibile = UtilityValidation.GetDecimal(fatturaVendita.Imponibile);
                    var iva = UtilityValidation.GetDecimal(fatturaVendita.IVA);
                    decimal totale = GetTotale(imponibile, iva);
                    return totale;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleLiquidazioni(FatturaVenditaDto fatturaVendita, DateTime data)
        {
            try
            {
                decimal totale = 0;
                if (fatturaVendita != null)
                {
                    var liquidazioni = fatturaVendita.Liquidaziones;
                    if (liquidazioni != null)
                    {
                        var totaleLiquidazioni = (from q in liquidazioni where q.Data <= data select q.Importo).Sum();
                        totale = UtilityValidation.GetDecimal(totaleLiquidazioni);
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

        public static decimal GetTotalePagamenti(FatturaAcquistoDto fatturaAcquisto, DateTime data)
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

        public static decimal GetTotaleNoteCredito(FatturaAcquistoDto fatturaAcquisto, DateTime data)
        {
            try
            {
                decimal totale = 0;
                if (fatturaAcquisto != null)
                {
                    var noteCredito = fatturaAcquisto.NotaCreditos;
                    if (noteCredito != null)
                    {
                        var totaleNoteCredito = (from q in noteCredito where q.Data <= data select q.Importo).Sum();
                        totale = UtilityValidation.GetDecimal(totaleNoteCredito);
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

        public static DateTime GetScadenza(FatturaAcquistoDto fattura)
        {
            try
            {
                var data = UtilityValidation.GetData(fattura.Data);
                var scadenzaPagamento = UtilityEnum.GetValue<Tipi.ScadenzaPagamento>(fattura.ScadenzaPagamento);
                var scadenza = GetScadenza(data, scadenzaPagamento);
                return scadenza;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return DateTime.MinValue;
        }

        public static DateTime GetScadenza(FatturaVenditaDto fattura)
        {
            try
            {
                var data = UtilityValidation.GetData(fattura.Data);
                var scadenzaPagamento = UtilityEnum.GetValue<Tipi.ScadenzaPagamento>(fattura.ScadenzaPagamento);
                var scadenza = GetScadenza(data, scadenzaPagamento);
                return scadenza;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return DateTime.MinValue;
        }

        private static DateTime GetScadenza(DateTime dataFattura, Tipi.ScadenzaPagamento scadenzaPagamento)
        {
            try
            {
                var giorni = GetGiorniScadenzaPagamento(scadenzaPagamento);
                var scadenza= dataFattura.AddDays(giorni);
                return scadenza;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return DateTime.MinValue;
        }

        private static int GetGiorniScadenzaPagamento(Tipi.ScadenzaPagamento tipoScadenzaPagamento)
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
                var giorni = data.Subtract(scadenza).TotalDays;
                if (0 <= giorni && giorni <= 120)
                    ritardo = giorni.ToString() + " giorni";
                else if (120 < giorni && giorni <= 365)
                {
                    var mesi = (int)(giorni / 30) + 1;
                    ritardo = mesi.ToString() + " mesi";
                }
                else if (giorni > 365)
                {
                    var anni = (int)(giorni / 365);
                    ritardo = anni.ToString() + " anni";
                }
                return ritardo;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetRitardo(FatturaAcquistoDto fattura)
        {
            try
            {
                var today = DateTime.Today;
                var scadenza = GetScadenza(fattura);
                var ritardo = GetRitardo(today, scadenza);
                return ritardo;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetRitardo(FatturaVenditaDto fattura)
        {
            try
            {
                var today = DateTime.Today;
                var scadenza = GetScadenza(fattura);
                var ritardo = GetRitardo(today, scadenza);
                return ritardo;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static Tipi.StatoFattura GetStato(FatturaAcquistoDto fattura)
        {
            try
            {
                var today = DateTime.Today;
                var scadenza = GetScadenza(fattura);
                var sconto = UtilityValidation.GetDecimal(fattura.Sconto);
                var totale = UtilityValidation.GetDecimal(fattura.Totale);
                var totaleFattura = totale - sconto;
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

        public static Tipi.StatoFattura GetStato(FatturaVenditaDto fattura)
        {
            try
            {
                var today = DateTime.Today;
                var scadenza = GetScadenza(fattura);
                var totaleFattura = UtilityValidation.GetDecimal(fattura.Totale);
                var totaleLiquidazioni = GetTotaleLiquidazioni(fattura, today);
                var stato = GetStato(today, scadenza, totaleFattura, totaleLiquidazioni);
                return stato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return Tipi.StatoFattura.None;
        }

        private static Tipi.StatoFattura GetStato(DateTime today, DateTime scadenza, decimal totaleFattura, decimal totalePagamentiLiquidazioni)
        {
            try
            {
                var stato = Tipi.StatoFattura.None;
                var insoluta = (today > scadenza);
                if (totalePagamentiLiquidazioni < totaleFattura)
                {
                    if (insoluta)
                        stato = Tipi.StatoFattura.Insoluta;
                    else
                        stato = Tipi.StatoFattura.NonPagata;
                }
                else if (totalePagamentiLiquidazioni >= totaleFattura)
                    stato = Tipi.StatoFattura.Pagata;

                return stato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return Tipi.StatoFattura.None;

        }


        public static string GetLista(IList<FatturaAcquistoDto> fatture)
        {
            try
            {
                string  listaFatture = null;
                foreach (var fattura in fatture)
                {
                    if (listaFatture!=null)
                        listaFatture += ", ";
                    var numero = UtilityValidation.GetStringND(fattura.Numero);
                    var data = UtilityValidation.GetData(fattura.Data);
                    var anno = data.Year.ToString();
                    var _fattura = numero + "/" + anno;
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

        public static string GetLista(IList<FatturaVenditaDto> fatture)
        {
            try
            {
                string listaFatture = null;
                foreach (var fattura in fatture)
                {
                    if (listaFatture != null)
                        listaFatture += ", ";
                    var numero = UtilityValidation.GetStringND(fattura.Numero);
                    var data = UtilityValidation.GetData(fattura.Data);
                    var anno = data.Year.ToString();
                    var _fattura = numero + "/" + anno;
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


        public static decimal GetTotalePagamentiDare(FatturaAcquistoDto fatturaAcquisto, DateTime data)
        {
            try
            {
                var totaleFatture = GetTotale(fatturaAcquisto);
                var totalePagamentiDato = GetTotalePagamenti(fatturaAcquisto, data);
                var totalePagamentiDare = totaleFatture - totalePagamentiDato;
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
