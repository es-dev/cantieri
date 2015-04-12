using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.ReportJob
{
	public partial class ReportJobView : TemplateView
	{
        public ReportJobView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new ReportJobViewModel(this);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)    //todo: parametrizzare per tipo report (pannello di selezione con descrizione)
        {
            try
            {
                var tipoReport = BusinessLogic.Tipi.TipoReport.Fornitore;
                var space = new ReportJobFornitoreModel(tipoReport);
                space.Model = new WcfService.Dto.ReportJobDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
