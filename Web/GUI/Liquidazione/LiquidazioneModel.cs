using Library.Code;
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
	public partial class LiquidazioneModel : TemplateModel
	{
        public LiquidazioneModel()
		{
			InitializeComponent();
		}

        public override void BindViewSubTitle(object model)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindView(object model)  
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.LiquidazioneDto)model;
                    editData.Value = obj.Data;
                    editEseguito.Value = obj.Eseguito;
                    //editImporto.Value = obj.Importo;
                    editModalita.Value = obj.Modalita;
                    editScadenza.Value = obj.Scadenza;
                    var fatturaVendita = obj.FatturaVendita;
                    if (fatturaVendita != null)
                    {
                        editFatturaVendita.Model = fatturaVendita;
                        editFatturaVendita.Value = fatturaVendita.Numero;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindModel(object model)
        {
            try
            {
                var obj = (WcfService.Dto.LiquidazioneDto)model;
                obj.Data = editData.Value;
                //obj.Eseguito = editEseguito.Value;
                //obj.Importo = editImporto.Value;
                obj.Modalita = editModalita.Value;
                obj.Scadenza = editScadenza.Value;
                obj.FatturaVenditaId = (int)editFatturaVendita.Id;
                obj.FatturaVendita = (WcfService.Dto.FatturaVenditaDto)editFatturaVendita.Model;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editFatturaVendita_ComboClick()
        {
            try
            {
                var view = new FatturaVendita.FatturaVenditaView();
                editFatturaVendita.Show(view);

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editFatturaVendita_ComboConfirm(object model)
        {
            try
            {
                var fatturaVendita = (WcfService.Dto.FatturaVenditaDto)model;
                if (fatturaVendita != null)
                    editFatturaVendita.Value = fatturaVendita.Numero;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
