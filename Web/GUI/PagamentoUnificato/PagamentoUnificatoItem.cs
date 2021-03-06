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

namespace Web.GUI.PagamentoUnificato
{
	public partial class PagamentoUnificatoItem : TemplateItem
	{
        public PagamentoUnificatoItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (PagamentoUnificatoDto)model;
                    var importo = UtilityValidation.GetEuro(obj.Importo);
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var data = UtilityValidation.GetDataND(obj.Data);

                    infoPagamento.Text = "Pagamento " + BusinessLogic.PagamentoUnificato.GetCodifica(obj);
                    infoData.Text = "Pagato il " + data;
                    infoImage.Image = "Images.dashboard.pagamentounificato.png";
                    infoCodice.Text = "PU-"+codice;
                    infoImporto.Text = "Totale di " + (importo!=null? importo:"N/D");
                    infoTipoPagamento.Text = obj.TipoPagamento;
                    infoFornitore.Text = BusinessLogic.Fornitore.GetCodifica(obj.AnagraficaFornitore);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
       

      
	}
}
