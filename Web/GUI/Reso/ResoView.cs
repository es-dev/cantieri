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

namespace Web.GUI.Reso
{
	public partial class ResoView : TemplateView
	{
        private WcfService.Dto.NotaCreditoDto notaCredito;

        public ResoView()
		{ 
			InitializeComponent();
		}

        public ResoView(WcfService.Dto.NotaCreditoDto notaCredito)
        {
            InitializeComponent();
            try
            {
                this.notaCredito = notaCredito;
                var viewModel = (Reso.ResoViewModel)ViewModel;
                if (viewModel != null)
                {
                    viewModel.NotaCredito = notaCredito;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private WcfService.Dto.FatturaAcquistoDto fatturaAcquisto;
        public ResoView(WcfService.Dto.FatturaAcquistoDto fatturaAcquisto)
        {
            InitializeComponent();
            try
            {
                this.fatturaAcquisto = fatturaAcquisto;
                var viewModel = (Reso.ResoViewModel)ViewModel;
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

        public override void Init()
        {
            try
            {
                ViewModel = new ResoViewModel();
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
                var space = new ResoModel(notaCredito);
                space.Model = new WcfService.Dto.ResoDto();
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
                var obj = (DataLayer.Reso)model;

                var filterNotaCredito = true;
                var notaCredito = (NotaCreditoDto)editNotaCredito.Model;
                if (notaCredito != null)
                    filterNotaCredito = (obj.NotaCreditoId == notaCredito.Id);

                var filterData = true;
                var inizio = editDataInizio.Value;
                var fine = editDataFine.Value;
                if (inizio != null && fine != null)
                    filterData = (inizio <= obj.Data && obj.Data <= fine);

                var filterFatturaAcquisto = true;
                var fatturaAcquisto = (FatturaAcquistoDto)editFatturaAcquisto.Model;
                if (fatturaAcquisto != null)
                    filterFatturaAcquisto = (obj.FatturaAcquistoId == fatturaAcquisto.Id);

                var filter = (filterNotaCredito && filterData && filterFatturaAcquisto);
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
                var obj = (DataLayer.Reso)model;

                object orderBy = null;
                if (optCodice.Value)
                    orderBy = obj.Codice;
                else if (optData.Value)
                    orderBy = obj.Data;

                return orderBy;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
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
                editFatturaAcquisto.Value = BusinessLogic.Fattura.GetCodifica(fatturaAcquisto);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editNotaCredito_ComboClick()
        {
            try
            {
                var view = new NotaCredito.NotaCreditoView();
                view.Title = "SELEZIONA LA NOTA DI CREDITO";
                editNotaCredito.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editNotaCredito_ComboConfirm(object model)
        {
            try
            {
                var notaCredito = (NotaCreditoDto)model;
                BindViewNotaCredito(notaCredito);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewNotaCredito(NotaCreditoDto notaCredito)
        {
            try
            {
                editNotaCredito.Model = notaCredito;
                editNotaCredito.Value = BusinessLogic.Fattura.GetCodifica(notaCredito);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
