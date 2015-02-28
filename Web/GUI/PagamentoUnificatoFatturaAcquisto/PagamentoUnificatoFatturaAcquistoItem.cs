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

        private void PagamentoUnificatoFatturaAcquistoItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new PagamentoUnificatoFatturaAcquistoModel();
                    space.Title = "DETTAGLI PAGAMENTO UNIFICATO - FATTURA ACQUISTO";
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