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

namespace Web.GUI.Fornitore
{
	public partial class FornitoreView : TemplateView
	{
        private CommessaDto commessa = null;

        public FornitoreView()
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

        public FornitoreView(WcfService.Dto.CommessaDto commessa)
        {
            InitializeComponent();
            try
            {
                this.commessa = commessa;
                var viewModel = (Fornitore.FornitoreViewModel)ViewModel;
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
                ViewModel = new FornitoreViewModel();
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
                var obj = (DataLayer.Fornitore)model;

                //1� filtro
                var filterStato = true;
                var stato = editStato.Value;
                if (stato != null && stato.Length > 0)
                    filterStato = (obj.Stato != null && obj.Stato.StartsWith(stato));

                //2� filtro
                var filterCommessa = true;
                var commessa = (WcfService.Dto.CommessaDto)editCommessa.Model;
                if (commessa!=null)
                    filterCommessa = (obj.CommessaId == commessa.Id);

                //filtro globale
                var filter = (filterCommessa);  //filterStato &&
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
                var obj = (DataLayer.Fornitore)model;

                object orderBy = null;
                if (optRagioneSociale.Value)
                    orderBy = obj.RagioneSociale;
                else if (optCommessa.Value)
                    orderBy = obj.Commessa.Denominazione;
                //else if (optStato.Value)
                //{
                //    var stato = BusinessLogic.Fornitore.GetStato(obj);    //vuole dto
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


        public override void AddNewModel()
        {
            try
            {
                var space = new FornitoreModel(commessa);
                space.Model = new WcfService.Dto.FornitoreDto();
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
                var commessa = (WcfService.Dto.CommessaDto)model;
                if (commessa != null)
                {
                    editCommessa.Value = commessa.Codice + " - " + commessa.Denominazione;
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
                editStato.DisplayValues = UtilityEnum.GetDisplayValues<Tipi.StatoFornitore>();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
