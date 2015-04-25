using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Library.Template.Scheduler;
using Library.Code;

namespace Web.GUI.Agenda
{
	public partial class SchedulerView : TemplateView
	{
		public SchedulerView()
		{
			InitializeComponent();
		}		

        public override void Init()
        {
            try
            {
                ViewModel = new SchedulerViewModel();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
	}
}
