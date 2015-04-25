using Library.Code;
using Library.Interfaces;
using Library.Template.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Dashboard.Anagrafica
{
	public partial class DashboardAnagraficaView : TemplateView
	{
        public DashboardAnagraficaView() : base()
		{
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                ViewModel = new DashboardAnagraficaViewModel();
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
