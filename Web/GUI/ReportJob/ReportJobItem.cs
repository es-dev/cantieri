using BusinessLogic;
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
using Web.Code;

namespace Web.GUI.ReportJob
{
	public partial class ReportJobItem : TemplateItem
	{
        public ReportJobItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (ReportJobDto)model;
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var tipo = UtilityValidation.GetStringND(obj.Tipo);
                    var elaborazione = UtilityValidation.GetDataND(obj.Elaborazione);
                    infoElaborazione.Text = "Elaborato il " + elaborazione;
                    infoImage.Image = "Images.dashboard.reportjob.png";
                    infoCodice.Text = "RPT-"+codice;
                    infoCodiceReport.Text = "REPORT " + codice;
                    infoTipo.Text = "Tipo report: " + tipo;
                    var descrizione = BusinessLogic.ReportJob.GetDescrizione(obj);
                    infoFornitore.Text = descrizione;

                    var fileName = obj.NomeFile;
                    if (fileName != null && fileName.Length > 0)
                    {
                        var url = UtilityWeb.GetRootUrl(Context) + "/Resources/Reports/" + fileName;
                        lnkReport.Visible = true;
                        lnkReport.RegisterClientAction("open", url);
                    }
                    else
                    {
                        lnkReport.Visible = false;
                        lnkReport.UnregisterClientAction();
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
        

        public override void ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var model = item.Model;
                    var obj = (WcfService.Dto.ReportJobDto)model;
                    var tipo = UtilityValidation.GetStringND(obj.Tipo);
                    var viewModel = (ReportJob.ReportJobViewModel)ViewModel;
                    ISpace space = null;
                    if (tipo == Tipi.TipoReport.Fornitore.ToString())
                        space = viewModel.GetModel<ReportJobFornitoreModel>(model);
                    else if (tipo == Tipi.TipoReport.Fornitori.ToString())
                        space = viewModel.GetModel<ReportJobFornitoriModel>(model);
                    else if (tipo == Tipi.TipoReport.Committente.ToString())
                        space = viewModel.GetModel<ReportJobCommittenteModel>(model);
                    else if (tipo == Tipi.TipoReport.Committenti.ToString())
                        space = viewModel.GetModel<ReportJobCommittentiModel>(model);

                    AddSpace(space);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }
	}
}
