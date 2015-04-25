using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.PagamentoUnificato
{
	public partial class PagamentoUnificatoView : TemplateView
	{
        public PagamentoUnificatoView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                ViewModel = new PagamentoUnificatoViewModel();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

      

	}
}
