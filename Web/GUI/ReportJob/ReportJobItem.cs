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
                    var obj = (WcfService.Dto.ReportJobDto)model;
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var codiceFornitore = UtilityValidation.GetStringND(obj.CodiceFornitore);
                    var tipo = UtilityValidation.GetStringND(obj.Tipo);
                    var elaborazione = UtilityValidation.GetDataND(obj.Elaborazione);
                    var fileName = obj.NomeFile;
                    infoElaborazione.Text = "Elaborato il " + elaborazione;
                    infoImage.Image = "Images.dashboard.reportjob.png";
                    infoCodice.Text = "RPT-"+codice;
                    infoCodiceReport.Text = "REPORT N. " + codice;
                    infoTipo.Text = "Tipo report: " + tipo;
                    var descrizione = GetDescrizione(obj);
                    infoFornitore.Text = descrizione;

                    BindViewReport(fileName);

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewReport(string fileName)
        {
            try
            {
                if (fileName != null && fileName.Length > 0)
                {
                    var url = UtilityWeb.GetRootUrl(Context) + "/Resources/Reports/" + fileName;
                    lnkReport.Visible = true;
                    lnkReport.RegisterClientAction("open", url);
                }
                else
                {
                    lnkReport.UnregisterClientAction();
                    lnkReport.Visible = false;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            
        }

        //todo: portare in BL

        private string GetDescrizione(WcfService.Dto.ReportJobDto obj)
        {
            try
            {
                if (obj != null)
                {
                    var tipo = obj.Tipo;
                    string descrizione = null;
                    if (tipo == Tipi.TipoReport.Fornitore.ToString())
                    {
                        var codiceFornitore = obj.CodiceFornitore;
                        var viewModel = new AnagraficaFornitore.AnagraficaFornitoreViewModel(this);
                        var anagraficaFornitore=viewModel.ReadAnagraficaFornitore(codiceFornitore);
                        if(anagraficaFornitore!=null)
                        {
                            descrizione = anagraficaFornitore.Codice + " - " + anagraficaFornitore.RagioneSociale;
                        }
                    }

                    return descrizione;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private void ReportJobItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var model = item.Model;
                    var obj = (WcfService.Dto.ReportJobDto)model;
                    var tipo = UtilityValidation.GetStringND(obj.Tipo);
                    ISpace space = null;
                    if (tipo == Tipi.TipoReport.Fornitore.ToString())
                        space = new ReportJobFornitoreModel();
                    else if (tipo == Tipi.TipoReport.Fornitori.ToString())
                        space = new ReportJobFornitoriModel();
                    else if (tipo == Tipi.TipoReport.Committente.ToString())
                        space = new ReportJobCommittenteModel();
                    
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
