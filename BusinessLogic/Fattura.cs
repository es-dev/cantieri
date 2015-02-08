using Library.Code;
using System;
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

        internal static decimal GetTotaleIncassi(WcfService.Dto.FatturaVenditaDto fatturaVendita, DateTime data)
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
                        totale = (decimal)totaleIncassi;
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
                        totale = (decimal)totalePagamenti;
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

        public static string GetRitardo(DateTime today, DateTime scadenza)
        {
            try
            {
                //definire la variabile della funzione ed inizializzarla al valore indefinito o nullo
                string ritardo = null;

                //devi analizzare i parametri passati alla funzione e ricavare la variabile di funzione (è consigliabile progettare al contrario se possibile

                var giorniRitardo = today.Subtract(scadenza).TotalDays;


                if (0 <= giorniRitardo && giorniRitardo <= 120)
                    ritardo = giorniRitardo + " giorni";
                else if (121 <= giorniRitardo && giorniRitardo <= 365)
                    ritardo = giorniRitardo + " giorni"; // mesi???????? e come li ricavo?????mostro solo mesi?
                else if (giorniRitardo > 365)
                    ritardo = giorniRitardo + " giorni"; // anni???????? e come li ricavo?????mostro solo anni?

                    //etc... finita la condizione mi preoccupo di ricavare i giorniRitardo procedendo indietro a salire


                //devi ritornare la variabile della funzione
                return ritardo;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}
