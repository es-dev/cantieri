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
                    var denominazione = UtilityValidation.GetStringND(obj.Denominazione);
                    var tipo = UtilityValidation.GetStringND(obj.Tipo);
                    var fornitore = obj.CodiceFornitore;
                    infoImage.Image = "Images.dashboard.articolo.png";
                    infoCodice.Text = "";
                    infoFornitore.Text = "Fornitore: " + fornitore;
                    infoTipo.Text = tipo;
                    infoCodiceReport.Text = codice;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void ReportJobItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new ReportJobFornitoreModel();
                    space.Title = "DETTAGLI REPORT";
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
