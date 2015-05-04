using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.AnagraficaFornitore
{
	public partial class AnagraficaFornitoreView : TemplateView
	{
        public AnagraficaFornitoreView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                ViewModel = new AnagraficaFornitoreViewModel();
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
                var obj = (DataLayer.AnagraficaFornitore)model;

                object orderBy = null;
                if (optRagioneSociale.Value)
                    orderBy = obj.RagioneSociale;

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
