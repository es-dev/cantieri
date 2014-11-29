using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.SAL
{
	public partial class SALView : TemplateView
	{
        public SALView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new SALViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "SAL";
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
                var space = new SALModel();
                space.Title = "NUOVO SAL";
                space.Model = new WcfService.Dto.SALDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}