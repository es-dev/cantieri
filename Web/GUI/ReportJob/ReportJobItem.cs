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
                    infoImage.Image = "Images.dashboard.reportjob.png";
                    infoCodice.Text = "RPT-"+codice;
                    infoCodiceReport.Text = "REPORT N. " + codice;
                    infoTipo.Text = "Tipo report: " + tipo;
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
                    var codiceFornitore = obj.CodiceFornitore;
                    var viewModel = new AnagraficaFornitore.AnagraficaFornitoreViewModel(this);
                    var anagraficaFornitore = viewModel.ReadAnagraficaFornitore(codiceFornitore);
                    var ragioneSociale = (anagraficaFornitore != null ? anagraficaFornitore.RagioneSociale : "N/D");
                    var codice = (obj.Codice != null ? obj.Codice : "N/D");
                    var tipoReport = BusinessLogic.Tipi.TipoReport.Fornitore;
                    var space = new ReportJobFornitoreModel(tipoReport);
                    space.Title = "REPORT " + codice + " - " + ragioneSociale;
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
