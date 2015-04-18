using Library.Code;
using Library.Interfaces;
using Library.Template.Dashboard;
using Library.Template.MVVM;
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
        public DashboardPagamentoView()
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

        private void RefreshCount()
        {
            try
            {
                var items = Items;
                foreach(TemplateItem item in items)
                {
                    RefreshCount(item);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static void RefreshCount(TemplateItem item)
        {
            try
            {
                var model = (DashboardDto)item.Model;
                var type = model.TypeSpace;
                var space = (ISpace)Activator.CreateInstance(type);
                var viewModel = space.ViewModel;
                if (viewModel != null)
                {
                    item.CountVisible = model.CountVisible;
                    if (item.CountVisible)
                        item.Count = viewModel.GetCount();
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void RefreshItems()
        {
            try
            {
                base.RefreshItems();
                RefreshCount();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void DashboardPagamentoView_Opened()
        {
            try
            {
                RefreshCount();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
	}
}
