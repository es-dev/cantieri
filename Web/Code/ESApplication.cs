using Library.Code;
using Library.Template.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Code
{
    public class ESApplication
    {
        internal static void Init(TemplateBase view)
        {
            try
            {
                view.Title = "ES.CANTIERI - GESTIONE COMMESSE";
                view.Version = "rev. beta1";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
    }
}