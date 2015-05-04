using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;

namespace Web.GUI.PagamentoUnificato
{
	public partial class PagamentoUnificatoView : TemplateView
	{
        public PagamentoUnificatoView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                ViewModel = new PagamentoUnificatoViewModel();
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
                var obj = (DataLayer.PagamentoUnificato)model;

                //2° filtro
                var filterData = true;
                var inizio = editDataInizio.Value;
                var fine = editDataFine.Value;
                if (inizio != null && fine != null)
                    filterData = (inizio <= obj.Data && obj.Data <= fine);

                //3° filtro
                var filterFornitore = true;
                if (fornitoriCodici != null)
                    filterFornitore = fornitoriCodici.Contains(obj.CodiceFornitore);

                //filtro globale
                var filter = (filterData && filterFornitore);
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
                var obj = (DataLayer.PagamentoUnificato)model;

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

        private IList<string> fornitoriCodici= null;

        private void editFornitore_ComboConfirm(object model)
        {
            try
            {
                var anagraficaFornitore = (WcfService.Dto.AnagraficaFornitoreDto)model;
                if (anagraficaFornitore != null)
                {
                    editFornitore.Value = anagraficaFornitore.Codice + " - " + anagraficaFornitore.RagioneSociale;
                    var viewModel = (PagamentoUnificatoViewModel)ViewModel;
                    var fornitori = viewModel.ReadFornitoriAnagraficaFornitore(anagraficaFornitore);
                    fornitoriCodici = (from q in fornitori select q.Codice).ToList();
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
	}
}
