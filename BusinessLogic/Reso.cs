using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class Reso
    {
        public static string GetCodice(NotaCreditoDto notaCredito)
        {
            try
            {
                if (notaCredito != null)
                {
                    var numeroNotaCredito = notaCredito.Numero;
                    var progressivo = 1;
                    var resi = notaCredito.Resos;
                    if (resi != null)
                        progressivo = resi.Count + 1;
                    var codice = numeroNotaCredito + "/" + DateTime.Today.Year.ToString() + "/" + progressivo.ToString("000");  //numerofattura/anno/progressivo
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
