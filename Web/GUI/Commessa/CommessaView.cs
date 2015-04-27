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

        public override object QueryAdvancedSearch()
        {
            try
            {
                var advancedSearch = (Func<DataLayer.Commessa, bool>)(q => WhereStato(q) && WhereData(q));
                return advancedSearch;
                
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private bool WhereStato(DataLayer.Commessa q)
        {
            try
            {
                var stato = comboBox1.Text;
                if(stato!=null && stato.Length>0)
                {
                    var condition = q.Stato.StartsWith(stato);
                    return condition;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return true;
        }

        private bool WhereData(DataLayer.Commessa q)
        {
            try
            {
                DateTime? dal = DateTime.Today;
                DateTime? al = dal.Value.AddDays(7);
                if (dal!=null && al !=null)
                {
                    var condition = (dal<=q.Scadenza && q.Scadenza<=al);
                    return condition;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return true;
        }
       
       
        public override object QueryOrderBy()
        {
            try
            {
                var orderBy = (Func<DataLayer.Commessa, object>)(q => q.Denominazione);
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
