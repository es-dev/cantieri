using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class Pagamento
    {
        public static string GetCodice(FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                if (fatturaAcquisto != null)
                {
                    var numeroFattura = fatturaAcquisto.Numero;
                    var progressivo = 1;
                    var pagamenti = fatturaAcquisto.Pagamentos;
                    if (pagamenti != null)
                        progressivo = pagamenti.Count + 1;
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
