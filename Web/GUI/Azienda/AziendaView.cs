using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Azienda
{
	public partial class AziendaView : TemplateView
	{
        public AziendaView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                ViewModel = new AziendaViewModel();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
