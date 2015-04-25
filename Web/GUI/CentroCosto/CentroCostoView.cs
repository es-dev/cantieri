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
                ViewModel = new CentroCostoViewModel();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
