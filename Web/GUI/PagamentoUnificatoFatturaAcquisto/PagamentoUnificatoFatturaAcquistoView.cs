using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WcfService.Dto;

namespace Web.GUI.PagamentoUnificatoFatturaAcquisto
{
	public partial class PagamentoUnificatoFatturaAcquistoView : TemplateView
	{
        private PagamentoUnificatoDto pagamentoUnificato = null;

        public PagamentoUnificatoFatturaAcquistoView()
		{ 
			InitializeComponent();
		}

        public PagamentoUnificatoFatturaAcquistoView(PagamentoUnificatoDto pagamentoUnificato)
        {
            InitializeComponent();
            try
            {
                this.pagamentoUnificato = pagamentoUnificato;
                var viewModel = (PagamentoUnificatoFatturaAcquisto.PagamentoUnificatoFatturaAcquistoViewModel)ViewModel;
                if (viewModel != null)
                {
                    viewModel.PagamentoUnificato = pagamentoUnificato;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


        public override void Init()
        {
            try
            {
                ViewModel = new PagamentoUnificatoFatturaAcquistoViewModel();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void AddNewModel()
        {
            try
            {
                var space = new PagamentoUnificatoFatturaAcquistoModel(pagamentoUnificato);
                space.Model = new WcfService.Dto.PagamentoUnificatoFatturaAcquistoDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override bool QueryAdvancedSearch(object model)
        {
            try
            {
                var obj = (DataLayer.PagamentoUnificatoFatturaAcquisto)model;

                //2° filtro
                var filterPagamentoUnificato = true;
                var pagamentoUnificato = (PagamentoUnificatoDto)editPagamentoUnificato.Model;
                if (pagamentoUnificato != null)
                    filterPagamentoUnificato = (obj.PagamentoUnificatoId == pagamentoUnificato.Id);

                //3° filtro
                var filterFatturaAcquisto = true;
                var fatturaAcquisto = (FatturaAcquistoDto)editFatturaAcquisto.Model;
                if (fatturaAcquisto != null)
                    filterFatturaAcquisto = (obj.FatturaAcquistoId == fatturaAcquisto.Id);

                //filtro globale
                var filter = (filterPagamentoUnificato && filterFatturaAcquisto);
                return filter;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return true;
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
                var fatturaAcquisto = (FatturaAcquistoDto)model;
                BindViewFatturaAcquisto(fatturaAcquisto);
                
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
                editFatturaAcquisto.Value = BusinessLogic.Fattura.GetCodifica(fatturaAcquisto)  + 
                    " | FORNITORE " + (fatturaAcquisto!=null?BusinessLogic.Fornitore.GetCodifica(fatturaAcquisto.Fornitore):null);
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
                view.Title = "SELEZIONA IL PAGAMENTO UNIFICATO";
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

        private void BindViewPagamentoUnificato(PagamentoUnificatoDto pagamentoUnificato)
        {
            try
            {
                editPagamentoUnificato.Model = pagamentoUnificato;
                editPagamentoUnificato.Value = (pagamentoUnificato != null ? pagamentoUnificato.Codice + "/" + pagamentoUnificato.Data.Value.Year.ToString() : null);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }
    }
}
