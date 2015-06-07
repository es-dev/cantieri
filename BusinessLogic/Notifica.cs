using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class Notifica
    {
        private static string applicazione = "ES.Cantieri";

        internal static NotificaDto GetNewNotifica(FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                if(fatturaAcquisto!=null)
                {
                    var notifica = new NotificaDto();
                    notifica.Applicazione = applicazione;
                    notifica.Codice = "Id="+fatturaAcquisto.Id;
                    notifica.Tipo = Tipi.TipoNotifica.FatturaAcquisto.ToString();
                    notifica.Data = DateTime.Now;

                    return notifica;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal static NotificaDto GetNewNotifica(FatturaVenditaDto fatturaVendita)
        {
            try
            {
                if (fatturaVendita != null)
                {
                    var notifica = new NotificaDto();
                    notifica.Applicazione = applicazione;
                    notifica.Codice = "Id=" + fatturaVendita.Id;
                    notifica.Tipo = Tipi.TipoNotifica.FatturaVendita.ToString();
                    notifica.Data = DateTime.Now;

                    return notifica;
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
