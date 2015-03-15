using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.GUI.Dashboard.Fatturazione
{
    public class DashboardFatturazione
    {
        public string Title = null;
        public string SubTitle = null;
        public string Description = null;
        public string Image = null;
        public string Group = null;
        public Type TypeSpace = null;
        public bool CountVisible = false;

        public DashboardFatturazione(string title, string subTitle, string description, string image, string group, Type typeSpace, bool countVisible = true)
        {
            try
            {
                this.Title = title;
                this.SubTitle = subTitle;
                this.Description = description;
                this.Image = image;
                this.Group = group;
                this.TypeSpace = typeSpace;
                this.CountVisible = countVisible;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
    }
}