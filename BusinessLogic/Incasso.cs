using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class Incasso
    {
        public static string GetCodice(FatturaVenditaDto fatturaVendita)
        {
            try
            {
                if (fatturaVendita != null)
                {
                    var numeroFattura = fatturaVendita.Numero;
                    var progressivo = 1;
                    var incassi = fatturaVendita.Incassos;
                    if (incassi != null)
                        progressivo = incassi.Count + 1;
                    var codice = numeroFattura + "/" + DateTime.Today.Year.ToString() + "/" + progressivo.ToString("000");  //numerofattura/anno/progressivo
                    return codice;
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
