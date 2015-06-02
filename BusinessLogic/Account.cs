using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class Account
    {
        public static string GetCodifica(AccountDto account)
        {
            try
            {
                if(account!=null)
                {
                    var codifica = account.Nickname + " - " + account.Ruolo;
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
