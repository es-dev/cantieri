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
                    infoImage.Image = "Images.dashboard.reportjob.png";
                    infoCodice.Text = "RPT";
                    infoCodiceReport.Text = "REPORT N. " + obj.Codice;
                    infoTipo.Text = "Tipo report: " + UtilityValidation.GetStringND(obj.Tipo);
                    var descrizione = GetDescrizione(obj);
                    infoFornitore.Text = descrizione;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

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
                    var obj = (WcfService.Dto.ReportJobDto)Model;
                    var tipoReport = BusinessLogic.Tipi.TipoReport.Fornitore;
                    var space = new ReportJobFornitoreModel(tipoReport);
                    space.Title = "REPORT " + obj.Codice.ToUpper();
                    if (obj.CodiceFornitore!=null)
                        space.Title += "FORNITORE " + (obj.CodiceFornitore!=null? obj.CodiceFornitore.ToUpper():"N/D");
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
