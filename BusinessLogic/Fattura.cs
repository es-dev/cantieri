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

        public static string GetRitardo(DateTime today, DateTime scadenza)
        {
            try
            {
                string ritardo = null;
                var giorniRitardo = today.Subtract(scadenza).TotalDays;
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

        public static Tipi.StatoFattura GetStato(DateTime today, DateTime scadenza, decimal totaleFattura, decimal totalePagamenti)
        {
            try
            {
                var stato = Tipi.StatoFattura.None;
                if (totalePagamenti < totaleFattura && today > scadenza)
                    stato = Tipi.StatoFattura.Insoluta;
                else if (totalePagamenti < totaleFattura && today <= scadenza)
                    stato = Tipi.StatoFattura.NonPagata;
                else if (totalePagamenti >= totaleFattura)
                    stato = Tipi.StatoFattura.Pagata;
                
                return stato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return Tipi.StatoFattura.None;
        }



    }
}
