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

                var filterData = true;
                var inizio = editDataInizio.Value;
                var fine = editDataFine.Value;
                if (inizio != null && fine != null)
                    filterData = (inizio <= obj.Data && obj.Data <= fine);

                var filterFornitore = true;
                if (fornitoriAnagraficaId != null)
                    filterFornitore = fornitoriAnagraficaId.Contains(obj.FornitoreId);

                var filterCommessa = true;
                if (fornitoriCommessaId != null)
                    filterCommessa = fornitoriCommessaId.Contains(obj.FornitoreId);

                var filter = (filterData && filterFornitore && filterCommessa);
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
                var obj = (DataLayer.NotaCredito)model;

                object orderBy = null;
                if (optNumero.Value)
                    orderBy = obj.Numero;
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
                var anagraficaFornitore = (WcfService.Dto.AnagraficaFornitoreDto)model;
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
                    var viewModelFornitore = new Fornitore.FornitoreViewModel();
                    var fornitori = viewModelFornitore.ReadFornitori(anagraficaFornitore);
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
                if (commessa != null)
                {
                    editCommessa.Value = BusinessLogic.Commessa.GetCodifica(commessa);
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
	}
}
