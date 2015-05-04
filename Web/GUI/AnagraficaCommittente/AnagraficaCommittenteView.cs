using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.AnagraficaCommittente
{
	public partial class AnagraficaCommittenteView : TemplateView
	{
        public AnagraficaCommittenteView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                ViewModel = new AnagraficaCommittenteViewModel();
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
                var obj = (DataLayer.AnagraficaCommittente)model;

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
