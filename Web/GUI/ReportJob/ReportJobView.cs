using Library.Code;
using Library.Interfaces;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WcfService.Dto;

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
                ViewModel = new ReportJobViewModel();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void AddNewModel()    
        {
            try
            {
                panelTipoReport.Visible = true;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private void btnConfirmTipoReport_Click(object sender, EventArgs e)
        {
            try
            {
                IModel space = null;
                if (optSituazioneFornitore.Checked)
                    space = new ReportJobFornitoreModel();
                else if(optResocontoFornitori.Checked)
                    space = new ReportJobFornitoriModel();
                else if (optSituazioneCommittente.Checked)
                    space = new ReportJobCommittenteModel();
                else if (optResocontoCommittenti.Checked)
                    space = new ReportJobCommittentiModel();

                space.Model = new ReportJobDto();
                AddSpace(space);
                panelTipoReport.Visible = false;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCancelTipoReport_Click(object sender, EventArgs e)
        {
            try
            {
                panelTipoReport.Visible = false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
