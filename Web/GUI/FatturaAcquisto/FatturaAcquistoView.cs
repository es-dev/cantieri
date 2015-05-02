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
using System.Linq;


namespace Web.GUI.FatturaAcquisto
{
    public partial class FatturaAcquistoView : TemplateView
    {
        private FornitoreDto fornitore = null;

        public FatturaAcquistoView()
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

        public FatturaAcquistoView(AnagraficaFornitoreDto anagraficaFornitore, Tipi.StatoFattura statoFattura)
        {
            InitializeComponent();
            try
            {
                var viewModel = (FatturaAcquisto.FatturaAcquistoViewModel)ViewModel;
                if (viewModel != null)
                {
                    viewModel.AnagraficaFornitore = anagraficaFornitore;
                    viewModel.StatoFattura = statoFattura;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public FatturaAcquistoView(FornitoreDto fornitore)
        {
            InitializeComponent();
            try
            {
                this.fornitore = fornitore;
                var viewModel = (FatturaAcquisto.FatturaAcquistoViewModel)ViewModel;
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
                ViewModel = new FatturaAcquistoViewModel();
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
                var space = new FatturaAcquistoModel(fornitore);
                space.Model = new WcfService.Dto.FatturaAcquistoDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private IList<int> fornitoriIds = null;
        public override bool QueryAdvancedSearch(object model)
        {
            try
            {
                var obj = (DataLayer.FatturaAcquisto)model;

                //1° filtro
                var filterStato = true;
                var stato = editStato.Value;
                if (stato != null && stato.Length > 0)
                    filterStato = (obj.Stato != null && obj.Stato.StartsWith(stato));

                //2° filtro
                var filterData = true;
                var inizio = editScadenzaInizio.Value;
                var fine = editScadenzaFine.Value;
                if (inizio != null && fine != null)
                    filterData = (inizio <= obj.Scadenza && obj.Scadenza <= fine);

                //3° filtro
                var filterFornitore = true;
                if (fornitoriIds!=null)
                    filterFornitore = fornitoriIds.Contains(obj.FornitoreId);

                //filtro globale
                var filter = (filterData && filterFornitore); //filterStato &&
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
                var obj = (DataLayer.FatturaAcquisto)model;

                object orderBy = null;
                if (optNumero.Value)
                    orderBy = obj.Numero;
                else if (optScadenza.Value)
                    orderBy = obj.Scadenza;
                //else if (optStato.Value)
                //{
                //    var stato = BusinessLogic.Fattura.GetStato(obj);    //vuole dto
                //    orderBy = stato;
                //}

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
                editStato.DisplayValues = UtilityEnum.GetDisplayValues<Tipi.StatoFattura>();
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
                    var viewModel = (FatturaAcquistoViewModel)ViewModel;
                    var fornitori = viewModel.ReadFornitoriAnagraficaFornitore(anagraficaFornitore);
                    fornitoriIds = (from q in fornitori select q.Id).ToList();
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
    }
}
