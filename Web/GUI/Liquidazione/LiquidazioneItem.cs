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

namespace Web.GUI.Liquidazione
{
	public partial class LiquidazioneItem : TemplateItem
	{
        public LiquidazioneItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.LiquidazioneDto)model;
                    infoCodice.Text = "LIQ";
                    infoModalita.Text = obj.Modalita;
                    infoImporto.Text = obj.Importo.ToString();
                    var fatturaVendita = obj.FatturaVendita;
                    if (fatturaVendita != null)
                        infoFattura.Text = "Fattura N. " + fatturaVendita.Numero;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void LiquidazioneItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new LiquidazioneModel();
                    space.Title = "DETTAGLI LIQUIDAZIONE";
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
