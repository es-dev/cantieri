using BusinessLogic;
using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using WcfService.Dto;

namespace Web.GUI.NotaCredito
{
	public partial class NotaCreditoView : TemplateView
	{

        public NotaCreditoView()
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

        private WcfService.Dto.FornitoreDto fornitore;
        public NotaCreditoView(WcfService.Dto.FornitoreDto fornitore)
        {
            InitializeComponent();
            try
            {
                this.fornitore = fornitore;
                var viewModel = (NotaCredito.NotaCreditoViewModel)ViewModel;
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
                ViewModel = new NotaCreditoViewModel();
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
                var space = new NotaCreditoModel(fornitore);
                space.Model = new WcfService.Dto.NotaCreditoDto();
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
                var obj = (DataLayer.NotaCredito)model;

                //1° filtro
                var filterStato = true;
                var stato = editStato.Value;
                if (stato != null && stato.Length > 0)
                    filterStato = (obj.Stato != null && obj.Stato.StartsWith(stato));

                //2° filtro
                var filterData = true;
                var inizio = editDataInizio.Value;
                var fine = editDataFine.Value;
                if (inizio != null && fine != null)
                    filterData = (inizio <= obj.Data && obj.Data <= fine);

                //3° filtro
                var filterFornitore = true;
                if (fornitoriIds != null)
                    filterFornitore = fornitoriIds.Contains(obj.FornitoreId);

                //filtro globale
                var filter = (filterStato && filterData && filterFornitore);
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
                fornitoriIds = null;
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
                var obj = (DataLayer.NotaCredito)model;

                object orderBy = null;
                if (optNumero.Value)
                    orderBy = obj.Numero;
                else if (optData.Value)
                    orderBy = obj.Data;
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

        private IList<int> fornitoriIds = null;

        private void editFornitore_ComboConfirm(object model)
        {
            try
            {
                var anagraficaFornitore = (WcfService.Dto.AnagraficaFornitoreDto)model;
                if (anagraficaFornitore != null)
                {
                    editFornitore.Value = anagraficaFornitore.Codice + " - " + anagraficaFornitore.RagioneSociale;
                    var viewModelFornitore = new Fornitore.FornitoreViewModel();
                    var fornitori = (IEnumerable<FornitoreDto>)viewModelFornitore.ReadFornitori(anagraficaFornitore);
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
