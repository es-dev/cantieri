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

namespace Web.GUI.PagamentoUnificatoFatturaAcquisto
{
	public partial class PagamentoUnificatoFatturaAcquistoModel : TemplateModel
	{
        private PagamentoUnificatoDto pagamentoUnificato = null;
        private PagamentoUnificatoDto pagamentoUnificatoOld = null;
        private FatturaAcquistoDto fatturaAcquistoOld = null;
      
        public PagamentoUnificatoFatturaAcquistoModel()
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

        public PagamentoUnificatoFatturaAcquistoModel(PagamentoUnificatoDto pagamentoUnificato)
        {
            InitializeComponent();
            try
            {
                this.pagamentoUnificato = pagamentoUnificato;
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
                editTransazionePagamento.DisplayValues = UtilityEnum.GetDisplayValues<Tipi.TransazionePagamento>();
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
                var obj = (PagamentoUnificatoFatturaAcquistoDto)model;
                var fatturaAcquisto = obj.FatturaAcquisto;
                infoSubtitle.Text = "PU/FA - " + BusinessLogic.PagamentoUnificato.GetCodifica(obj);
                infoSubtitleImage.Image = "Images.dashboard.pagamentounificatofatturaacquisto.png";
                infoTitle.Text = (obj.Id != 0 ? "PAGAMENTO FATTURA ACQUISTO " + BusinessLogic.PagamentoUnificato.GetCodifica(obj) : "NUOVO PAGAMENTO FATTURA ACQUISTO") + " / FORNITORE " + BusinessLogic.Fornitore.GetCodifica(fatturaAcquisto);
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
                    var obj = (PagamentoUnificatoFatturaAcquistoDto)model;
                    editNote.Value = obj.Note;
                    editSaldo.Value = obj.Saldo;
                    editTransazionePagamento.Value = obj.TransazionePagamento;
                    
                    BindViewFatturaAcquisto(obj.FatturaAcquisto);
                    BindViewPagamentoUnificato(obj.PagamentoUnificato);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewPagamentoUnificato(PagamentoUnificatoDto pagamentoUnificato)
        {
            try
            {
                editPagamentoUnificato.Model = pagamentoUnificato;
                editPagamentoUnificato.Value = BusinessLogic.PagamentoUnificato.GetCodifica(pagamentoUnificato);
                pagamentoUnificatoOld = pagamentoUnificato;
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
                editFatturaAcquisto.Value = BusinessLogic.Fattura.GetCodifica(fatturaAcquisto);
                fatturaAcquistoOld = fatturaAcquisto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            
        }

        private void BindViewSaldo(FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                if (fatturaAcquisto != null)
                {
                    var today = DateTime.Today;
                    var saldo = BusinessLogic.Fattura.GetTotalePagamentiDare(fatturaAcquisto, today);
                    editSaldo.Value = saldo;
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
                    var obj = (PagamentoUnificatoFatturaAcquistoDto)model;
                    obj.Note = editNote.Value;
                    obj.Saldo = editSaldo.Value;
                    obj.TransazionePagamento = editTransazionePagamento.Value;

                    var fatturaAcquisto = (FatturaAcquistoDto)editFatturaAcquisto.Model;
                    if(fatturaAcquisto!=null)
                        obj.FatturaAcquistoId = fatturaAcquisto.Id;

                    var pagamentoUnificato = (PagamentoUnificatoDto)editPagamentoUnificato.Model;
                    if (pagamentoUnificato != null)
                        obj.PagamentoUnificatoId = pagamentoUnificato.Id;
                   
                    var viewModel = (PagamentoUnificatoFatturaAcquistoViewModel)ViewModel;
                    viewModel.PagamentoUnificatoOld = pagamentoUnificatoOld;
                    viewModel.FatturaAcquistoOld = fatturaAcquistoOld;
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
                var pagamentoUnificato = (PagamentoUnificatoDto)editPagamentoUnificato.Model;
                if (pagamentoUnificato != null)
                {
                    var anagraficaFornitore = pagamentoUnificato.AnagraficaFornitore;
                    var view = new FatturaAcquisto.FatturaAcquistoView(anagraficaFornitore, Tipi.StatoFattura.NonPagata | Tipi.StatoFattura.Insoluta);
                    view.Title = "SELEZIONA UNA FATTURA DI ACQUISTO";
                    editFatturaAcquisto.Show(view);
                }
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
                var fatturaAcquisto = (FatturaAcquistoDto)model;
                BindViewFatturaAcquisto(fatturaAcquisto);
                BindViewSaldo(fatturaAcquisto);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editPagamentoUnificato_ComboClick()
        {
            try
            {
                var view = new PagamentoUnificato.PagamentoUnificatoView();
                view.Title = "SELEZIONA UN PAGAMENTO UNIFICATO";
                editPagamentoUnificato.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editPagamentoUnificato_ComboConfirm(object model)
        {
            try
            {
                var pagamentoUnificato = (PagamentoUnificatoDto)model;
                BindViewPagamentoUnificato(pagamentoUnificato);
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
                BindViewPagamentoUnificato(pagamentoUnificato);

                editTransazionePagamento.Value = Tipi.TransazionePagamento.Acconto.ToString();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


	}
}
