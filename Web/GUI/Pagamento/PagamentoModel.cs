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
using Web.GUI.FatturaAcquisto;

namespace Web.GUI.Pagamento
{
	public partial class PagamentoModel : TemplateModel
	{
        private FatturaAcquistoDto fatturaAcquisto = null;
        public PagamentoModel()
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

        public PagamentoModel(FatturaAcquistoDto fatturaAcquisto)
        {
            InitializeComponent();
            try
            {
                InitCombo();
                this.fatturaAcquisto = fatturaAcquisto;
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
                editTransazionePagamento.DisplayValues = UtilityEnum.GetDisplayValues<Tipi.TransazionePagamento>();
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
                var obj = (PagamentoDto)model;
                var codice = UtilityValidation.GetStringND(obj.Codice);
                var descrizione = UtilityValidation.GetStringND(obj.Descrizione);
                infoSubtitle.Text = "N."+ codice + " - " + descrizione;
                infoSubtitleImage.Image = "Images.dashboard.pagamento.png";
                var fatturaAcquisto = obj.FatturaAcquisto;
                string title = "PAGAMENTO " + obj.Codice + " - FATTURA N." + fatturaAcquisto.Numero;
                var pagamentoUnificato = obj.PagamentoUnificato;
                if (pagamentoUnificato != null)
                    title += " - PAGAMENTO UNIFICATO " + pagamentoUnificato.Codice;
                infoTitle.Text = (obj.Id!=0? title: "NUOVO PAGAMENTO");
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
                    var obj = (PagamentoDto)model;
                    editCodice.Value = obj.Codice;
                    editData.Value = obj.Data;
                    editNote.Value = obj.Note;
                    editImporto.Value = obj.Importo;
                    editTipoPagamento.Value = obj.TipoPagamento;
                    editDescrizione.Value = obj.Descrizione;
                    editTransazionePagamento.Value = obj.TransazionePagamento;
                    BindViewFatturaAcquisto(obj.FatturaAcquisto);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewFatturaAcquisto(FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                editFatturaAcquisto.Model = fatturaAcquisto;
                var viewModelFatturaAcquisto = new FatturaAcquisto.FatturaAcquistoViewModel(this);
                var fatturaAcquistoId = fatturaAcquisto.Id;
                var _fatturaAcquisto = (FatturaAcquistoDto)viewModelFatturaAcquisto.Read(fatturaAcquistoId);
                var fornitore = _fatturaAcquisto.Fornitore;
                editFatturaAcquisto.Value = (fatturaAcquisto != null ? fatturaAcquisto.Numero + " del " + fatturaAcquisto.Data.Value.ToString("dd/MM/yyyy") : null) + " del fornitore: " + fornitore.Codice +" - " + fornitore.RagioneSociale;
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
                    var obj = (PagamentoDto)model;
                    obj.Codice = editCodice.Value;
                    obj.Data = editData.Value;
                    obj.Importo = editImporto.Value;
                    obj.Note = editNote.Value;
                    obj.Descrizione = editDescrizione.Value;
                    obj.TipoPagamento = editTipoPagamento.Value;
                    obj.TransazionePagamento = editTransazionePagamento.Value;
                    var fatturaAcquisto = (FatturaAcquistoDto)editFatturaAcquisto.Model;
                    if(fatturaAcquisto!=null)
                        obj.FatturaAcquistoId = fatturaAcquisto.Id;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editFatturaAcquisto_ComboClick()
        {
            try
            {
                var view = new FatturaAcquisto.FatturaAcquistoView();
                view.Title = "SELEZIONA LA FATTURA DI ACQUISTO";
                editFatturaAcquisto.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editFatturaAcquisto_ComboConfirm(object model)
        {
            try
            {
                SetFatturaAcquisto(model);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetFatturaAcquisto(object model)
        {
            try
            {
                var fatturaAcquisto = (FatturaAcquistoDto)model;
                if (fatturaAcquisto != null)
                {
                    var viewModelFatturaAcquisto = new FatturaAcquisto.FatturaAcquistoViewModel(this);
                    var fatturaAcquistoId = fatturaAcquisto.Id;
                    var _fatturaAcquisto = (FatturaAcquistoDto)viewModelFatturaAcquisto.Read(fatturaAcquistoId);
                    var fornitore = _fatturaAcquisto.Fornitore;
                    editFatturaAcquisto.Value = (fatturaAcquisto != null ? fatturaAcquisto.Numero + " del " + fatturaAcquisto.Data.Value.ToString("dd/MM/yyyy") : null) + " del fornitore: " + fornitore.Codice + " - " + fornitore.RagioneSociale;
                    var obj = (PagamentoDto)Model;
                    if (obj != null && obj.Id == 0)
                    {
                        var codice = BusinessLogic.Pagamento.GetCodice(fatturaAcquisto);
                        editCodice.Value = codice;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void PagamentoModel_Load(object sender, EventArgs e)
        {
            try
            {
                var obj = (PagamentoDto)Model;
                if (obj != null && obj.Id == 0)
                    SetNewValue(obj);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private void SetNewValue(object model)
        {
            try
            {
                SetFatturaAcquisto(model);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
