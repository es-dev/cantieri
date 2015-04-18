using Library.Code;
using Library.Interfaces;
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

                space.Model = new WcfService.Dto.ReportJobDto();
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
