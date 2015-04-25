using BusinessLogic;
using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WcfService.Dto;
using System.Linq;

namespace Web.GUI.Commessa
{
	public partial class CommessaView : TemplateView
	{
 
        public CommessaView()
        {
            InitializeComponent();
        }

        public override void Init()
        {
            try
            {
                ViewModel = new CommessaViewModel();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


	}
}
