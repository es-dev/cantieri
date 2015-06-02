using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class Azienda
    {
        public static string GetCodifica(AziendaDto azienda)
        {
            try
            {
                if(azienda!=null)
                {
                    var codifica = azienda.Codice + " - " + azienda.RagioneSociale;
                    return codifica;
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
