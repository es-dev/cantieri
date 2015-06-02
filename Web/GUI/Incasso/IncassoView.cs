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

namespace Web.GUI.Incasso
{
	public partial class IncassoView : TemplateView
	{
        private WcfService.Dto.CommittenteDto committente;
        private WcfService.Dto.FatturaVenditaDto fatturaVendita;

        public IncassoView()
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

        public IncassoView(WcfService.Dto.CommittenteDto committente)
        {
            InitializeComponent();
            try
            {
                this.committente = committente;
                var viewModel = (Incasso.IncassoViewModel)ViewModel;
                if (viewModel != null)
                {
                    viewModel.Committente = committente;
                }

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public IncassoView(WcfService.Dto.FatturaVenditaDto fatturaVendita)
        {
            InitializeComponent();
            try
            {
                this.fatturaVendita = fatturaVendita;
                var viewModel = (Incasso.IncassoViewModel)ViewModel;
                if (viewModel != null)
                {
                    viewModel.FatturaVendita = fatturaVendita;
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
                ViewModel = new IncassoViewModel();
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
                var space = new IncassoModel(fatturaVendita);
                space.Model = new WcfService.Dto.IncassoDto();
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
                var obj = (DataLayer.Incasso)model;

                var filterStato = true;
                var tipoTransazione = editTipoTransazione.Value;
                if (tipoTransazione != null && tipoTransazione.Length > 0)
                    filterStato = (obj.TransazionePagamento != null && obj.TransazionePagamento.StartsWith(tipoTransazione));

                var filterData = true;
                var inizio = editDataInizio.Value;
                var fine = editDataFine.Value;
                if (inizio != null && fine != null)
                    filterData = (inizio <= obj.Data && obj.Data <= fine);

                var filterFatturaVendita= true;
                var fatturaVendita = (FatturaVenditaDto)editFatturaVendita.Model;
                if (fatturaVendita != null)
                    filterFatturaVendita = (obj.FatturaVenditaId == fatturaVendita.Id);

                var filter = (filterStato && filterData && filterFatturaVendita);
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
                var obj = (DataLayer.Incasso)model;

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
                var fatturaVendita = (FatturaVenditaDto)model;
                BindViewFatturaVendita(fatturaVendita);
                
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private void BindViewFatturaVendita(FatturaVenditaDto fatturaVendita)
        {
            try
            {
                    editFatturaVendita.Model = fatturaVendita;
                    editFatturaVendita.Value = BusinessLogic.Fattura.GetCodifica(fatturaVendita)  + 
                        (fatturaVendita!=null?" | COMMITTENTE " + BusinessLogic.Committente.GetCodifica(fatturaVendita.Committente):null);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
