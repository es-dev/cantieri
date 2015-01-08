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
                view.Title = "GESTIONE COMMESSE";
                view.Version = "rev. beta1";
                view.LogoAziendale = "Images.logoAziendale.png";
                view.LogoESD = "Images.logoESD.png";
                view.BackgroundImage = "Images.background.png";
                
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
    }
}