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

namespace Web.GUI.CentroCosto
{
	public partial class CentroCostoItem : TemplateItem
	{
        public CentroCostoItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (CentroCostoDto)model;
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                
                    infoImage.Image = "Images.dashboard.centrocosto.png";
                    infoCodice.Text = "CC-"+codice;
                    infoCodiceCentroCosto.Text = "CENTRO DI COSTO "+ codice;
                    infoDenominazione.Text = obj.Denominazione;
                    infoNote.Text = obj.Note;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
	}
}
