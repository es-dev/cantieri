using BusinessLogic;
using Library.Code;
using Library.Code.Enum;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WcfService.Dto;
using Web.Code;

namespace Web.GUI.Liquidazione
{
	public partial class LiquidazioneModel : TemplateModel
	{
        private FatturaVenditaDto fatturaVendita = null;

        public LiquidazioneModel()
		{
			InitializeComponent();
            try
            {
                InitCombo();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public LiquidazioneModel(FatturaVenditaDto fatturaVendita)
        {
            InitializeComponent();
            try
            {
                this.fatturaVendita = fatturaVendita;
                InitCombo();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void InitCombo()
        {
            try
            {
                editTipoPagamento.DisplayValues = UtilityEnum.GetDisplayValues<Tipi.TipoPagamento>();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindViewSubTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (LiquidazioneDto)model;
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var descrizione = UtilityValidation.GetStringND(obj.Descrizione);
                    infoSubtitle.Text = codice + " - " + descrizione;
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
                    editTipoPagamento.Value = obj.TipoPagamento;
                    editDescrizione.Value = obj.Descrizione;
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
                    obj.Descrizione = editDescrizione.Value;
                    obj.TipoPagamento = editTipoPagamento.Value;
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
                    editFatturaVendita.Value = fatturaVendita.Numero + " del " + fatturaVendita.Data.Value.ToString("dd/MM/yyyy");
                    var obj = (WcfService.Dto.LiquidazioneDto)Model;
                    if (obj != null && obj.Id == 0)
                    {
                        var codice = BusinessLogic.Liquidazione.GetCodice(fatturaVendita);
                        editCodice.Value = codice;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void LiquidazioneModel_Load(object sender, EventArgs e)
        {
            try
            {
                var obj = (LiquidazioneDto)Model;
                if (obj != null && obj.Id == 0)
                    SetNewValue();

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetNewValue()
        {
            try
            {
                if (fatturaVendita != null)
                {
                    editFatturaVendita.Model = fatturaVendita;
                    editFatturaVendita.Value = fatturaVendita.Numero + " del " + fatturaVendita.Data.Value.ToString("dd/MM/yyyy");
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
