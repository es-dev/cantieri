using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.AnagraficaArticolo
{
	public partial class AnagraficaArticoloView : TemplateView
	{
        public AnagraficaArticoloView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                ViewModel = new AnagraficaArticoloViewModel();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
