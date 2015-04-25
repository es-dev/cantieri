using Library.Code;
using Library.Interfaces;
using Library.Template.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Dashboard
{
	public partial class DashboardView : TemplateView
	{
        public DashboardView() : base()
		{
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                ViewModel = new DashboardViewModel();
                Title = "DASHBOARD";
                Adding = false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
	}
}
