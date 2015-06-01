using BusinessLogic;
using Library.Code;
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

        public override void SetNewValue(object model)
        {
            try
            {
                var azienda = SessionManager.GetAzienda(Context);
                BindViewAzienda(azienda);

                var viewModel = (PagamentoUnificatoViewModel)ViewModel;
                var codice = viewModel.Count() + 1;
                editCodice.Value = codice.ToString("000");
                editData.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindViewTitle(object model)
        {
            try
            {
                var obj = (PagamentoUnificatoDto)model;
                infoSubtitle.Text = BusinessLogic.PagamentoUnificato.GetCodifica(obj);
                infoSubtitleImage.Image = "Images.dashboard.pagamentounificato.png";
                infoTitle.Text = (obj.Id!=0? "PAGAMENTO UNIFICATO " + BusinessLogic.PagamentoUnificato.GetCodifica(obj):"NUOVO PAGAMENTO UNIFICATO") + " | FORNITORE " + 
                    BusinessLogic.Fornitore.GetCodifica(obj.AnagraficaFornitore);
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
                    
                    BindViewAzienda(obj.Azienda);
                    BindViewAnagraficaFornitore(obj.AnagraficaFornitore);
                    BindViewPagamentoUnificatoFattureAcquisto(obj.PagamentoUnificatoFatturaAcquistos);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewPagamentoUnificatoFattureAcquisto(IList<PagamentoUnificatoFatturaAcquistoDto> pagamentoUnificatofattureAcquisto)
        {
            try
            {
                btnPagamentoUnificatoFattureAcquisto.TextButton = "Fatture acquisto (" + (pagamentoUnificatofattureAcquisto != null ? pagamentoUnificatofattureAcquisto.Count : 0) + ")";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewAzienda(AziendaDto azienda)
        {
            try
            {
                editAzienda.Model = azienda;
                editAzienda.Value = (azienda != null ? azienda.Codice + " - " + azienda.RagioneSociale : null);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


        private void BindViewAnagraficaFornitore(AnagraficaFornitoreDto anagraficaFornitore)
        {
            try
            {
                editAnagraficaFornitore.Model = anagraficaFornitore;
                editAnagraficaFornitore.Value = BusinessLogic.Fornitore.GetCodifica(anagraficaFornitore);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            
        }

        private void BindViewTotali()
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

                    var anagraficaFornitore = (AnagraficaFornitoreDto)editAnagraficaFornitore.Model;
                    if (anagraficaFornitore != null)
                        obj.AnagraficaFornitoreId = anagraficaFornitore.Id;

                    var azienda = (AziendaDto)editAzienda.Model;
                    if (azienda != null)
                        obj.AziendaId = azienda.Id;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editAnagraficaFornitore_ComboClick()
        {
            try
            {
                var view = new AnagraficaFornitore.AnagraficaFornitoreView();
                view.Title = "SELEZIONA UN FORNITORE";
                editAnagraficaFornitore.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editanagraficaFornitore_ComboConfirm(object model)
        {
            try
            {
                var anagraficaFornitore = (AnagraficaFornitoreDto)model;
                BindViewAnagraficaFornitore(anagraficaFornitore);
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
                bool saved = Save();
                if (saved)
                {
                    BindViewTotali();
                }
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
                btnPagamentoUnificatoFattureAcquisto.Enabled = !editing;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnPagamentoUnificatoFattureAcquisto_Click(object sender, EventArgs e)
        {
            try
            {
                bool saved = Save();
                if (saved)
                {
                    var obj = (PagamentoUnificatoDto)Model;
                    var space = new PagamentoUnificatoFatturaAcquisto.PagamentoUnificatoFatturaAcquistoView(obj);
                    space.Title = "FATTURE ACQUISTO | PAGAMENTO UNIFICATO " + BusinessLogic.PagamentoUnificato.GetCodifica(obj) + " | FORNITORE " + 
                        BusinessLogic.Fornitore.GetCodifica(obj.AnagraficaFornitore);
                    Workspace.AddSpace(space);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private void editAzienda_ComboClick()
        {
            try
            {
                var view = new Azienda.AziendaView();
                view.Title = "SELEZIONA UN'AZIENDA";
                editAzienda.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editAzienda_ComboConfirm(object model)
        {
            try
            {
                var azienda = (AziendaDto)model;
                BindViewAzienda(azienda);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
