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

namespace Web.GUI.FatturaVendita
{
	public partial class FatturaVenditaView : TemplateView
	{
        private CommittenteDto committente = null;

        public FatturaVenditaView()
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

        public FatturaVenditaView(CommittenteDto committente)
        {
            InitializeComponent();
            try
            {
                this.committente = committente;
                var viewModel = (FatturaVendita.FatturaVenditaViewModel)ViewModel;
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

        public override void Init()
        {
            try
            {
                ViewModel = new FatturaVenditaViewModel();
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
                var space = new FatturaVenditaModel(committente);
                space.Model = new FatturaVenditaDto();
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
                var obj = (DataLayer.FatturaVendita)model;

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
                var filterCommittente = true;
                if (committentiAnagraficaId != null)
                    filterCommittente = committentiAnagraficaId.Contains(obj.CommittenteId);

                //4° filtro
                var filterCommessa = true;
                if (committentiCommessaId != null)
                    filterCommessa = committentiCommessaId.Contains(obj.CommittenteId);

                //filtro globale
                var filter = (filterStato && filterData && filterCommittente && filterCommessa); 
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
                committentiAnagraficaId = null;
                committentiCommessaId = null;
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
                var obj = (DataLayer.FatturaVendita)model;

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

        private void editCommittente_ComboClick()
        {
            try
            {
                var view = new AnagraficaCommittente.AnagraficaCommittenteView();
                view.Title = "SELEZIONA UN COMMITTENTE";
                editCommittente.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private IList<int> committentiAnagraficaId = null;
        private IList<int> committentiCommessaId = null;

        private void editCommittente_ComboConfirm(object model)
        {
            try
            {
                var anagraficaCommittente = (AnagraficaCommittenteDto)model;
                BindViewAnagraficaCommittente(anagraficaCommittente);
                
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewAnagraficaCommittente(AnagraficaCommittenteDto anagraficaCommittente)
        {
            try
            {
                editCommittente.Model = anagraficaCommittente;
                if (anagraficaCommittente != null)
                {
                    editCommittente.Value = BusinessLogic.Committente.GetCodifica(anagraficaCommittente);
                    var viewModel = new Committente.CommittenteViewModel();
                    var committenti = viewModel.ReadCommittenti(anagraficaCommittente);
                    committentiAnagraficaId = (from q in committenti select q.Id).ToList();
                } 

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
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
                BindViewCommittenti(commessa);
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

        private void BindViewCommittenti(CommessaDto commessa)
        {
            try
            {
                if (commessa != null)
                {
                    editCommessa.Value = BusinessLogic.Commessa.GetCodifica(commessa);
                    var viewModel = new Committente.CommittenteViewModel();
                    var committenti = viewModel.ReadCommittenti(commessa);
                    committentiCommessaId = (from q in committenti select q.Id).ToList();
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            
        }

	}
}
