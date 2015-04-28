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
                var stato = "InLavorazione";
                if (stato != null && stato.Length > 0)
                    filterStato = obj.Stato.StartsWith(stato);

                //2° filtro
                var filterData = true;
                DateTime? dal = DateTime.Today;
                DateTime? al = dal.Value.AddDays(7);
                if (dal != null && al != null)
                    filterData = (dal <= obj.Scadenza && obj.Scadenza <= al);

                //filtro globale
                var filter = filterStato && filterData;
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
                return obj.Codice;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

      

	}
}
