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

namespace Web.GUI.Pagamento
{
	public partial class PagamentoItem : TemplateItem
	{
        public PagamentoItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (PagamentoDto)model;
                    var importo = UtilityValidation.GetEuro(obj.Importo);
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var data = UtilityValidation.GetDataND(obj.Data);

                    infoData.Text = "Pagato il " + data;
                    infoImage.Image = "Images.dashboard.pagamento.png";
                    infoCodice.Text = "PAG-" + codice;
                    infoTransazionePagamento.Text = obj.TransazionePagamento;
                    infoImporto.Text = "Importo: " + importo;
                    infoPagamento.Text = "Pagamento " + codice;
                    var fatturaAcquisto = obj.FatturaAcquisto;
                    infoFatturaAcquisto.Text = "Fattura " + BusinessLogic.Fattura.GetCodifica(fatturaAcquisto);
                    if (fatturaAcquisto != null)
                        infoFornitore.Text = BusinessLogic.Fornitore.GetCodifica(fatturaAcquisto.Fornitore);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

      
	}
}
