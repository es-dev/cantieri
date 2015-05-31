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

namespace Web.GUI.PagamentoUnificatoFatturaAcquisto
{
	public partial class PagamentoUnificatoFatturaAcquistoItem : TemplateItem
	{
        public PagamentoUnificatoFatturaAcquistoItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (PagamentoUnificatoFatturaAcquistoDto)model;
                    var saldo = UtilityValidation.GetEuro(obj.Saldo);
                    infoImage.Image = "Images.dashboard.pagamentounificatofatturaacquisto.png";
                    infoFornitore.Text = obj.Note;
                    infoImporto.Text = "Importo: " + saldo;
                    infoPagamento.Text = "Pagamento " + BusinessLogic.PagamentoUnificato.GetCodifica(obj);

                    var fatturaAcquisto = obj.FatturaAcquisto;
                    if (fatturaAcquisto != null)
                    {
                        infoCodice.Text = "PU/FA-" + fatturaAcquisto.Numero;
                        infoFornitore.Text = BusinessLogic.Fornitore.GetCodifica(fatturaAcquisto.Fornitore);
                        infoFatturaAcquisto.Text = "Fattura " + BusinessLogic.Fattura.GetCodifica(fatturaAcquisto);
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
	}
}
