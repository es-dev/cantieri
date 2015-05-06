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
                space.Model = new FatturaAcquistoDto();
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
                if (fornitoriAnagraficaIds!=null)
                    filterFornitore = fornitoriAnagraficaIds.Contains(obj.FornitoreId);

                //4° filtro
                var filterCommessa = true;
                if (fornitoriCommessaIds != null)
                    filterCommessa = fornitoriCommessaIds.Contains(obj.FornitoreId);

                //filtro globale
                var filter = (filterStato && filterData && filterFornitore && filterCommessa); 
                return filter;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return true;
        }

        public override void ClearAdvancedSearch()
        {
            try
            {
                fornitoriAnagraficaIds = null;
                fornitoriCommessaIds = null;
                base.ClearAdvancedSearch();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
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
                else if (optStato.Value)
                    orderBy = obj.Stato;

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

        private IList<int> fornitoriAnagraficaIds = null;
        private IList<int> fornitoriCommessaIds = null;

        private void editFornitore_ComboConfirm(object model)
        {
            try
            {
                var anagraficaFornitore = (AnagraficaFornitoreDto)model;
                if (anagraficaFornitore != null)
                {
                    editFornitore.Value = anagraficaFornitore.Codice + " - " + anagraficaFornitore.RagioneSociale;
                    var viewModelFornitore = new Fornitore.FornitoreViewModel();
                    var fornitori = viewModelFornitore.ReadFornitori(anagraficaFornitore);
                    fornitoriAnagraficaIds = (from q in fornitori select q.Id).ToList();
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCommessa_ComboClick()
        {
            try
            {
                var view = new Commessa.CommessaView();
                view.Title = "SELEZIONA UNA COMMESSA";
                editCommessa.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCommessa_ComboConfirm(object model)
        {
            try
            {
                var commessa = (CommessaDto)model;
                if (commessa != null)
                {
                    editCommessa.Value = commessa.Codice + " - " + commessa.Denominazione;
                    var viewModelFornitore = new Fornitore.FornitoreViewModel();
                    var fornitori = viewModelFornitore.ReadFornitori(commessa);
                    fornitoriCommessaIds = (from q in fornitori select q.Id).ToList();
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
    }
}
