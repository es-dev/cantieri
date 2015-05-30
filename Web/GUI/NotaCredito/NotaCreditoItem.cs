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

namespace Web.GUI.NotaCredito
{
	public partial class NotaCreditoItem : TemplateItem
	{
        public NotaCreditoItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (NotaCreditoDto)model;
                    var totale = UtilityValidation.GetEuro(obj.Totale);
                    var numero = UtilityValidation.GetStringND(obj.Numero);
                    var data = UtilityValidation.GetDataND(obj.Data);

                    infoNotaCredito.Text = "Nota credito " + BusinessLogic.Fattura.GetCodifica(obj);
                    infoData.Text = "Resa il " + data;
                    infoImage.Image = "Images.dashboard.notacredito.png";
                    infoCodice.Text = "NC-"+numero;
                    infoImporto.Text = "Totale di " + (totale!=null?totale:"N/D");
                 
                    BindViewFornitore(obj.Fornitore);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewFornitore(FornitoreDto fornitore)
        {
            try
            {
                var anagraficaFornitore = fornitore.AnagraficaFornitore;
                infoFornitore.Text = (fornitore!=null? anagraficaFornitore.RagioneSociale:"N/D");
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
         
        }

      
	}
}
