using Gizmox.WebGUI.Common.Interfaces;
using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.Code
{
    public class SessionManager
    {

        internal static void Login(IContext context, AccountDto account)
        {
            try
            {
                context.Session["account"] = account; 
                context.Session.IsLoggedOn = true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        internal static void Logout(IContext context)
        {
            try
            {
                context.Session["account"] = null;
                context.Session.IsLoggedOn = false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        internal static bool IsLogged(IContext context)
        {
            try
            {
                bool logged = (context.Session["account"] != null);
                return logged;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        internal static AccountDto GetAccount(IContext context)
        {
            try
            {
                var account = (AccountDto)context.Session["account"];
                return account;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}