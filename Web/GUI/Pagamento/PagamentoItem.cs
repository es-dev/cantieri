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
                    infoImage.Image = "Images.dashboard.pagamento.png";
                    infoCodice.Text = "PAG";
                    infoNote.Text = obj.Note;
                    var importo = "N/D";
                    if (obj.Importo != null)
                        importo = obj.Importo.Value.ToString("0.00");
                    infoImporto.Text = "Importo: " + importo + "€";
                    infoPagamento.Text = "Pagamento N." + obj.Codice;
                    var data = "N/D";
                    if (obj.Data != null)
                        data = "Pagato il " + obj.Data.Value.ToString("dd/MM/yyyy");
                    infoData.Text = data;
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
