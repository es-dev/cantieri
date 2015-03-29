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
                    infoCodice.Text = "PAG";
                    infoNote.Text = obj.Note;
                    infoImporto.Text = "Importo: " + importo;
                    infoPagamento.Text = "Pagamento N." + codice;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void PagamentoItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var obj = (PagamentoDto)Model;
                    var space = new PagamentoModel();
                    var fatturaAcquisto = obj.FatturaAcquisto;
                    space.Title = "PAGAMENTO " + obj.Codice + " - FATTURA N." + fatturaAcquisto.Numero;
                    var pagamentoUnificato = obj.PagamentoUnificato;
                    if (pagamentoUnificato != null)
                        space.Title += " - PAGAMENTO UNIFICATO " + pagamentoUnificato.Codice;
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
