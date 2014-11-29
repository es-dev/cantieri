using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Statistica
{
	public partial class StatisticaView : TemplateView
	{
        public StatisticaView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new StatisticaViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "STATISTICHE";
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
                var space = new StatisticaModel();
                space.Title = "NUOVA STATISTICA";
                space.Model = new WcfService.Dto.StatisticaDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
