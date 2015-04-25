using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Articolo
{
	public partial class ArticoloView : TemplateView
	{
        public ArticoloView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                ViewModel = new ArticoloViewModel();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
