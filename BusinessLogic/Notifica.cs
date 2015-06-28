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
        internal static NotificaDto GetNewNotifica(FatturaAcquistoDto fatturaAcquisto, string applicazione)
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

        internal static NotificaDto GetNewNotifica(FatturaVenditaDto fatturaVendita, string applicazione)
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

        internal static NotificaDto GetNewNotifica(AziendaDto azienda, Tipi.TipoReport tipoReport, string applicazione)
        {
            try
            {
                if (azienda != null)
                {
                    var notifica = new NotificaDto();
                    notifica.Applicazione = applicazione;
                    notifica.Codice = "Id=Report";
                    notifica.Tipo = tipoReport.ToString();
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
