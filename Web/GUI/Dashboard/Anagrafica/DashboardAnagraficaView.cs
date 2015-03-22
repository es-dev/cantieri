using Library.Code;
using Library.Interfaces;
using Library.Template.MVVM;
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
        public DashboardAnagraficaView()
		{
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new DashboardAnagraficaViewModel(this);
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
                    var model = (DashboardAnagrafica)item.Model;
                    var type = model.TypeSpace;
                    var space = (ISpace)Activator.CreateInstance(type);
                    var viewModel = space.ViewModel;
                    if (viewModel != null)
                    {
                        item.Count = viewModel.GetCount();
                        item.CountVisible = model.CountVisible;
                    }
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

        private void DashboardAnagraficheView_Opened()
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