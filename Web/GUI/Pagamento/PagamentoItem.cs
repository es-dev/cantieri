using Library.Code;
using Library.Interfaces;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
                    var obj = (WcfService.Dto.PagamentoDto)model;
                    infoCodice.Text = "PAG";
                    infoModalita.Text = obj.Modalita;
                    infoImporto.Text = (obj.Importo != null ? obj.Importo.Value.ToString("0.00") : "Non Impostata"); //oppure ti fai una funzione GetData
                    var fatturaAcquisto = obj.FatturaAcquisto;
                    if (fatturaAcquisto != null)
                        infoFattura.Text = "Fattura N. " + fatturaAcquisto.Numero;
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
                    var space = new PagamentoModel();
                    space.Title = "DETTAGLI PAGAMENTO";
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
