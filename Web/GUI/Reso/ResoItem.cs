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

namespace Web.GUI.Reso
{
	public partial class ResoItem : TemplateItem
	{
        public ResoItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (ResoDto)model;
                    var totale = UtilityValidation.GetEuro(obj.Totale);
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var data = UtilityValidation.GetDataND(obj.Data);
                    var fatturaAcquisto = obj.FatturaAcquisto;
                    var notaCredito = obj.NotaCredito;
                    
                    infoData.Text = "Reso il " + data;
                    infoImage.Image = "Images.dashboard.reso.png";
                    infoCodice.Text = "RES";
                    infoDescrizione.Text = "Rif. " + BusinessLogic.Fattura.GetCodifica(notaCredito) + " - " + BusinessLogic.Fattura.GetCodifica(fatturaAcquisto);
                    infoImporto.Text = "Totale: " + totale;
                    infoReso.Text = "Reso N." + codice;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

      
	}
}
