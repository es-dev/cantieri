using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.CentroCosto
{
	public partial class CentroCostoModel : TemplateModel
	{
        public CentroCostoModel()
		{
			InitializeComponent();
		}

        public override void BindViewSubTitle(object model)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindView(object model)  
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.CentroCostoDto)model;
                    editCodice.Value = obj.Codice;
                    editDenominazione.Value = obj.Denominazione;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindModel(object model)
        {
            try
            {
                var obj = (WcfService.Dto.CentroCostoDto)model;
                obj.Denominazione = editDenominazione.Value;
                obj.Codice = editCodice.Value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
