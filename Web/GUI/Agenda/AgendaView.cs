using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Library.Template.MVVM;
using Library.Code;

namespace Web.GUI.Agenda
{
	public partial class AgendaView : TemplateSchedulerView
	{
		public AgendaView()
		{
			InitializeComponent();
		}		

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new AgendaViewModel(this);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
	}
}
