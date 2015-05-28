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

namespace Web.GUI.Committente
{
	public partial class CommittenteView : TemplateView
	{
        private CommessaDto commessa = null;

        public CommittenteView()
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

        public CommittenteView(CommessaDto commessa)
        {
            InitializeComponent();
            try
            {
                this.commessa = commessa;
                var viewModel = (Committente.CommittenteViewModel)ViewModel;
                if (viewModel != null)
                {
                    viewModel.Commessa = commessa;
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
                ViewModel = new CommittenteViewModel();
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
                var obj = (DataLayer.Committente)model;

                //1° filtro
                var filterStato = true;
                var stato = editStato.Value;
                if (stato != null && stato.Length > 0)
                    filterStato = (obj.Stato != null && obj.Stato.StartsWith(stato));

                //2° filtro
                var filterCommessa = true;
                var commessa = (CommessaDto)editCommessa.Model;
                if (commessa != null)
                    filterCommessa = (obj.CommessaId == commessa.Id);

                //filtro globale
                var filter = (filterStato && filterCommessa);
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
                var obj = (DataLayer.Committente)model;

                object orderBy = null;
                if (optRagioneSociale.Value)
                    orderBy = obj.AnagraficaCommittente.RagioneSociale;
                else if (optCommessa.Value)
                    orderBy = obj.Commessa.Denominazione;
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
        public override void AddNewModel()
        {
            try
            {
                var space = new CommittenteModel(commessa);
                space.Model = new CommittenteDto();
                AddSpace(space);
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
                editCommessa.Value = (commessa != null ? commessa.Codice + " - " + commessa.Denominazione : null);
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
                editStato.DisplayValues = UtilityEnum.GetDisplayValues<Tipi.StatoCommittente>();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
	}
}
