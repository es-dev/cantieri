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
                    var fatturaAcquisto = obj.FatturaAcquisto;
                    var pagamentoUnificato = obj.PagamentoUnificato;
                    infoImage.Image = "Images.dashboard.pagamentounificatofatturaacquisto.png";
                    infoCodice.Text = "PU/FA-"+ fatturaAcquisto.Numero;
                    infoNote.Text = obj.Note;
                    infoImporto.Text = "Importo: " + saldo;
                    infoPagamento.Text="Pagamento: " + pagamentoUnificato.Codice  + " - Fattura: " + fatturaAcquisto.Numero;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void PagamentoUnificatoFatturaAcquistoItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new PagamentoUnificatoFatturaAcquistoModel();
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
