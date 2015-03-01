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

namespace Web.GUI.PagamentoUnificato
{
	public partial class PagamentoUnificatoModel : TemplateModel
	{
        public PagamentoUnificatoModel()
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
                var obj = (PagamentoUnificatoDto)model;
                var codice = UtilityValidation.GetStringND(obj.Codice);
                var descrizione = UtilityValidation.GetStringND(obj.Descrizione);
                infoSubtitle.Text = codice + " - " + descrizione;
                infoSubtitleImage.Image = "Images.dashboard.pagamentounificato.png";
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
                    var obj = (PagamentoUnificatoDto)model;
                    editCodice.Value = obj.Codice;
                    editData.Value = obj.Data;
                    editNote.Value = obj.Note;
                    editImporto.Value = obj.Importo;
                    editTipoPagamento.Value = obj.TipoPagamento;
                    editDescrizione.Value = obj.Descrizione;
                    var codiceFornitore = obj.CodiceFornitore;
                    var viewModelAnagraficaFornitore = new AnagraficaFornitore.AnagraficaFornitoreViewModel(this);
                    var anagraficaFornitore = viewModelAnagraficaFornitore.ReadAnagraficaFornitore(codiceFornitore);
                    if (anagraficaFornitore != null)
                    {
                        editFornitore.Model = anagraficaFornitore;
                        editFornitore.Value = anagraficaFornitore.Codice + " - " + anagraficaFornitore.RagioneSociale;
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
                    var obj = (PagamentoUnificatoDto)model;
                    obj.Codice = editCodice.Value;
                    obj.Data = editData.Value;
                    obj.Importo = editImporto.Value;
                    obj.Note = editNote.Value;
                    obj.Descrizione = editDescrizione.Value;
                    obj.TipoPagamento = editTipoPagamento.Value;
                    var anagraficaFornitore = (AnagraficaFornitoreDto)editFornitore.Model;
                    if (anagraficaFornitore != null)
                        obj.CodiceFornitore = anagraficaFornitore.Codice;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editFornitore_ComboClick()
        {
            try
            {
                var view = new AnagraficaFornitore.AnagraficaFornitoreView();
                view.Title = "SELEZIONA UN FORNITORE";
                editFornitore.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editFornitore_ComboConfirm(object model)
        {
            try
            {
                var anagraficaFornitore = (WcfService.Dto.AnagraficaFornitoreDto)model;
                if (anagraficaFornitore != null)
                {
                    editFornitore.Value = anagraficaFornitore.Codice + " - " + anagraficaFornitore.RagioneSociale;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


        private void CalcolaTotalePagamentoUnificato()
        {
            try
            {
                var obj = (PagamentoUnificatoDto)Model;
                var importoPagamento = BusinessLogic.PagamentoUnificato.GetTotalePagamentoUnificato(obj);
                editImporto.Value = importoPagamento;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCalcoloSaldoImporto_Click(object sender, EventArgs e)
        {
            try
            {
                CalcolaTotalePagamentoUnificato();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


        public override void SetEditing(bool editing, bool deleting)
        {
            try
            {
                base.SetEditing(editing, deleting);
                btnCalcoloSaldoImporto.Enabled = editing;
                btnFatture.Enabled = editing;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnFatture_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = (PagamentoUnificatoDto)Model;
                var space = new PagamentoUnificatoFatturaAcquisto.PagamentoUnificatoFatturaAcquistoView(obj);
                space.Title = "FATTURE PAGAMENTO UNIFICATO " + obj.Codice;
                Workspace.AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

	}
}
