using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.CentroCosto
{
	public partial class CentroCostoView : TemplateView
	{
        public CentroCostoView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new CentroCostoViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "CENTRI DI COSTO";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var space = new CentroCostoModel();
                space.Title = "NUOVO CENTRO DI COSTO";
                space.Model = new WcfService.Dto.CentroCostoDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
