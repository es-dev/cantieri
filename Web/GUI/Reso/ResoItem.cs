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
                    
                    infoData.Text = "Reso il " + data;
                    infoImage.Image = "Images.dashboard.reso.png";
                    infoCodice.Text = "RES";
                    infoImporto.Text = "Totale: " + totale;
                    infoReso.Text = "Reso " + codice;

                    var fatturaAcquisto = obj.FatturaAcquisto;
                    var notaCredito = obj.NotaCredito;

                    infoNotaCredito.Text = "Nota credito " + BusinessLogic.Fattura.GetCodifica(notaCredito);
                    var fatturaAcquistoFornitore = "Fattura acquisto " + BusinessLogic.Fattura.GetCodifica(fatturaAcquisto);
                    if(fatturaAcquisto!=null)
                    {
                        var fornitore = fatturaAcquisto.Fornitore;
                        fatturaAcquistoFornitore += " | FORNITORE " + BusinessLogic.Fornitore.GetCodifica(fornitore);
                    }
                    infoFatturaAcquistoFornitore.Text = fatturaAcquistoFornitore;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

      
	}
}
