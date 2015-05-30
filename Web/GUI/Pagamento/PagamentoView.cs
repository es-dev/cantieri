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

namespace Web.GUI.Pagamento
{
	public partial class PagamentoView : TemplateView
	{
        private WcfService.Dto.FatturaAcquistoDto fatturaAcquisto;

        public PagamentoView()
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

        public PagamentoView(WcfService.Dto.FatturaAcquistoDto fatturaAcquisto)
        {
            InitializeComponent();
            try
            {
                this.fatturaAcquisto = fatturaAcquisto;
                var viewModel = (Pagamento.PagamentoViewModel)ViewModel;
                if (viewModel != null)
                {
                    viewModel.FatturaAcquisto = fatturaAcquisto;
                }

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private WcfService.Dto.FornitoreDto fornitore;
        public PagamentoView(WcfService.Dto.FornitoreDto fornitore)
        {
            InitializeComponent();
            try
            {
                this.fornitore = fornitore;
                var viewModel = (Pagamento.PagamentoViewModel)ViewModel;
                if (viewModel != null)
                {
                    viewModel.Fornitore = fornitore;
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
                ViewModel = new PagamentoViewModel();
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
                var space = new PagamentoModel(fatturaAcquisto);
                space.Model = new WcfService.Dto.PagamentoDto();
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
                var obj = (DataLayer.Pagamento)model;

                //1° filtro
                var filterStato = true;
                var tipoTransazione = editTipoTransazione.Value;
                if (tipoTransazione != null && tipoTransazione.Length > 0)
                    filterStato = (obj.TransazionePagamento != null && obj.TransazionePagamento.StartsWith(tipoTransazione));

                //2° filtro
                var filterData = true;
                var inizio = editDataInizio.Value;
                var fine = editDataFine.Value;
                if (inizio != null && fine != null)
                    filterData = (inizio <= obj.Data && obj.Data <= fine);

                //3° filtro
                var filterFatturaAcquisto = true;
                var fatturaAcquisto = (FatturaAcquistoDto)editFatturaAcquisto.Model;
                if (fatturaAcquisto != null)
                    filterFatturaAcquisto = (obj.FatturaAcquistoId == fatturaAcquisto.Id);

                //filtro globale
                var filter = (filterStato && filterData && filterFatturaAcquisto);
                return filter;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return true;
        }

        public override object QueryOrderBy(object model)
        {
            try
            {
                var obj = (DataLayer.Pagamento)model;

                object orderBy = null;
                if (optCodice.Value)
                    orderBy = obj.Codice;
                else if (optData.Value)
                    orderBy = obj.Data;
                else if (optTipoTransazione.Value)
                    orderBy = obj.TransazionePagamento;

                return orderBy;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private void InitCombo()
        {
            try
            {
                editTipoTransazione.DisplayValues = UtilityEnum.GetDisplayValues<Tipi.TransazionePagamento>();
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
                var fornitore = fatturaAcquisto.Fornitore;
                editFatturaAcquisto.Model = fatturaAcquisto;
                editFatturaAcquisto.Value = (fatturaAcquisto != null ? BusinessLogic.Fattura.GetCodifica(fatturaAcquisto) : null) + " - " +
                    (fornitore != null ? fornitore.AnagraficaFornitore.RagioneSociale : null);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
          
	}
}
