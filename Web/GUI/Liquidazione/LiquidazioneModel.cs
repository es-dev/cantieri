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
                if (model != null)
                {

                    infoSubtitleImage.Image = "Images.dashboard.liquidazione.png";
                }
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
                    editCodice.Value = obj.Codice;
                    editData.Value = obj.Data;
                    editImporto.Value = obj.Importo;
                    editNote.Value = obj.Note;
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
                if (model != null)
                {
                    var obj = (WcfService.Dto.LiquidazioneDto)model;
                    obj.Codice = editCodice.Value;
                    obj.Data = editData.Value;
                    obj.Importo = editImporto.Value;
                    obj.Note = editNote.Value;
                    var fatturaVendita = (WcfService.Dto.FatturaVenditaDto)editFatturaVendita.Model;
                    if(fatturaVendita!=null)
                        obj.FatturaVenditaId = fatturaVendita.Id;
                }
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
                view.Title = "SELEZIONA LA FATTURA DI VENDITA";
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
                {
                    editFatturaVendita.Value = fatturaVendita.Numero;
                    var obj = (WcfService.Dto.LiquidazioneDto)Model;
                    if (obj != null && obj.Id == 0)
                    {
                        var codice = GetCodice(fatturaVendita);
                        editCodice.Value = codice;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private string GetCodice(WcfService.Dto.FatturaVenditaDto fatturaVendita)
        {
            try
            {
                if (fatturaVendita != null)
                {
                    var numeroFattura = fatturaVendita.Numero;
                    var progressivo = 1;
                    var liquidazioni = fatturaVendita.Liquidaziones;
                    if (liquidazioni != null)
                        progressivo = liquidazioni.Count + 1;
                    var codice = numeroFattura + "/" + DateTime.Today.Year.ToString() + "/" + progressivo.ToString("000");  //numerofattura/anno/progressivo
                    return codice;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

	}
}
