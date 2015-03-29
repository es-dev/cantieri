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

namespace Web.GUI.Incasso
{
	public partial class IncassoItem : TemplateItem
	{
        public IncassoItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.IncassoDto)model;
                 
                    var importo = UtilityValidation.GetEuro(obj.Importo);
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var data = UtilityValidation.GetDataND(obj.Data);
                    
                    infoData.Text = "Incassato il " + data;
                    infoImage.Image = "Images.dashboard.incasso.png";
                    infoCodice.Text = "LIQ";
                    infoTransazionePagamento.Text = "Tipo transazione: " + obj.TransazionePagamento;
                    infoNote.Text = obj.Note;
                    infoImporto.Text = "Importo: " + importo;
                    infoIncasso.Text = "Incasso N." + codice;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void IncassoItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var obj = (WcfService.Dto.IncassoDto)Model;
                    var space = new IncassoModel();
                    var fatturaVendita= obj.FatturaVendita;
                    space.Title = "INCASSO " + obj.Codice + " - FATTURA N." + fatturaVendita.Numero;
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
