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

namespace Web.GUI.Commessa
{
	public partial class CommessaView : TemplateView
	{
 
        public CommessaView()
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

        private void InitCombo()
        {
            try
            {
                editStato.DisplayValues = UtilityEnum.GetDisplayValues<Tipi.StatoCommessa>();
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
                ViewModel = new CommessaViewModel();
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
                var obj = (DataLayer.Commessa)model;

                //1° filtro
                var filterStato = true;
                var stato = editStato.Value;
                if (stato != null && stato.Length > 0)
                    filterStato = (obj.Stato!=null && obj.Stato.StartsWith(stato));

                //2° filtro
                var filterData = true;
                var inizio = editScadenzaInizio.Value;
                var fine = editScadenzaFine.Value;
                if (inizio != null && fine != null)
                    filterData = (inizio <= obj.Scadenza && obj.Scadenza <= fine);

                //filtro globale
                var filter = (filterStato && filterData);
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
                var obj = (DataLayer.Commessa)model;

                object orderBy = null;
                if (optDenominazione.Value)
                    orderBy = obj.Denominazione;
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

	}
}
