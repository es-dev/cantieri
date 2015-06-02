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

                var filterStato = true;
                var stato = editStato.Value;
                if (stato != null && stato.Length > 0)
                    filterStato = (obj.Stato != null && obj.Stato.StartsWith(stato));

                var filterScadenza = true;
                var scadenzaInizio = editScadenzaInizio.Value;
                var scadenzaFine = editScadenzaFine.Value;
                if (scadenzaInizio != null && scadenzaFine != null)
                    filterScadenza = (scadenzaInizio <= obj.Scadenza && obj.Scadenza <= scadenzaFine);

                var filterFornitore = true;
                if (fornitoriAnagraficaId!=null)
                    filterFornitore = fornitoriAnagraficaId.Contains(obj.FornitoreId);

                var filterCommessa = true;
                if (fornitoriCommessaId != null)
                    filterCommessa = fornitoriCommessaId.Contains(obj.FornitoreId);

                var filterNumero = true;
                var numero = editNumero.Value;
                if (numero != null && numero.Length > 0)
                    filterNumero = (obj.Numero == numero);

                var filterData = true;
                var dataInizio = editDataInizio.Value;
                var dataFine = editDataFine.Value;
                if (dataInizio != null && dataFine != null)
                    filterData = (dataInizio <= obj.Data && obj.Data <= dataFine);

                var filter = (filterStato && filterScadenza && filterFornitore && filterCommessa && filterNumero && filterData); 
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
                fornitoriAnagraficaId = null;
                fornitoriCommessaId = null;
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
                else if (optData.Value)
                    orderBy = obj.Data;
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

        private IList<int> fornitoriAnagraficaId = null;
        private IList<int> fornitoriCommessaId = null;

        private void editFornitore_ComboConfirm(object model)
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

        private void BindViewAnagraficaFornitore(AnagraficaFornitoreDto anagraficaFornitore)
        {
            try
            {
                editFornitore.Model = anagraficaFornitore;
                if (anagraficaFornitore != null)
                {
                    editFornitore.Value = BusinessLogic.Fornitore.GetCodifica(anagraficaFornitore);
                    var viewModel = new Fornitore.FornitoreViewModel();
                    var fornitori = viewModel.ReadFornitori(anagraficaFornitore);
                    fornitoriAnagraficaId = (from q in fornitori select q.Id).ToList();
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
                BindViewCommessa(commessa);
                BindViewFornitori(commessa);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewFornitori(CommessaDto commessa)
        {
            try
            {
                if (commessa != null)
                {
                    var viewModelFornitore = new Fornitore.FornitoreViewModel();
                    var fornitori = viewModelFornitore.ReadFornitori(commessa);
                    fornitoriCommessaId = (from q in fornitori select q.Id).ToList();
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            
        }

        private void BindViewCommessa(CommessaDto commessa)
        {
            try
            {
                editCommessa.Model = commessa;
                editCommessa.Value = BusinessLogic.Commessa.GetCodifica(commessa);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

    }
}
