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

namespace Web.GUI.Dashboard.Configurazione
{
	public partial class DashboardConfigurazioneView : TemplateView
	{
        public DashboardConfigurazioneView()
		{
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new DashboardConfigurazioneViewModel(this);
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
                foreach (TemplateItem item in items)
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

        private void DashboardConfigurazioneView_Opened()
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
