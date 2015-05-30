using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class Articolo
    {

        public static decimal GetImporto(decimal quantita, decimal prezzoUnitario)
        {
            try
            {
                decimal importo = quantita * prezzoUnitario;
                return importo;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetCosto(decimal importo, decimal sconto)
        {
            try
            {
                decimal costo = importo * (1 - sconto/ (decimal)100);
                return costo;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotale(decimal costo, decimal iva)
        {
            try
            {
                decimal totale = costo + iva;
                return totale;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static string GetCodifica(ArticoloDto articolo)
        {
            try
            {
                if(articolo!=null)
                {
                    var anagraficaArticolo = articolo.AnagraficaArticolo;
                    if(anagraficaArticolo!=null)
                    {
                        var codifica = anagraficaArticolo.Codice + " - " + anagraficaArticolo.Descrizione;
                        return codifica;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}
