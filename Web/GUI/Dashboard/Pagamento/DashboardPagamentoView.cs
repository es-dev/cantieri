using Library.Code;
using Library.Interfaces;
using Library.Template.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Dashboard.Pagamento
{
	public partial class DashboardPagamentoView : TemplateView
	{
        public DashboardPagamentoView() : base()
		{
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                ViewModel = new DashboardPagamentoViewModel();
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
