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
                var advancedSearch = (Func<DataLayer.Commessa, bool>)(q => q.Denominazione.StartsWith("C"));
                return advancedSearch;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
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
