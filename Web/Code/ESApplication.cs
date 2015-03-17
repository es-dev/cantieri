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
                view.Title = "ES | GESTIONE CANTIERI";
                view.Version = "rev. beta2f";
                view.LogoSoftware = "Images.logoSoftware.png";
                view.LogoESD = "Images.logoESD.png";
                view.BackgroundImage = "Images.background.png";
                view.UrlHomePortal = "http://www.3gcostruzioni.it";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
    }
}