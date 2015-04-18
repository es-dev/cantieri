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
                Take = 10;
                ViewModel = new DashboardPagamentoViewModel(this);
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
