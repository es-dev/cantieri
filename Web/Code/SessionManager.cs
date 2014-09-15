using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Code
{
    public class SessionManager
    {

        internal static void Login(Gizmox.WebGUI.Common.Interfaces.IContext context)
        {
            try
            {
                context.Session["account"] = ""; //passare parametro da funzione
                context.Session.IsLoggedOn = true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        internal static void Logout(Gizmox.WebGUI.Common.Interfaces.IContext context)
        {
            try
            {
                context.Session.IsLoggedOn = false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        internal static bool IsLogged(Gizmox.WebGUI.Common.Interfaces.IContext Context)
        {
            try
            {
                bool logged = (Context.Session["account"] != null);
                return logged;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }
    }
}