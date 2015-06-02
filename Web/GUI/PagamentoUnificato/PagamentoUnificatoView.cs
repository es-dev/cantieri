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
                var anagraficaFornitore = (AnagraficaFornitoreDto)editAnagraficaFornitore.Model;
                if (anagraficaFornitore != null)
                    filterFornitore = (obj.AnagraficaFornitoreId==anagraficaFornitore.Id);

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

        private void editAnagraficaFornitore_ComboClick()
        {
            try
            {
                var view = new AnagraficaFornitore.AnagraficaFornitoreView();
                view.Title = "SELEZIONA UN FORNITORE";
                editAnagraficaFornitore.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


        private void editAnagraficaFornitore_ComboConfirm(object model)
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
                editAnagraficaFornitore.Model = anagraficaFornitore;
                editAnagraficaFornitore.Value = BusinessLogic.Fornitore.GetCodifica(anagraficaFornitore);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            
        }
	}
}
