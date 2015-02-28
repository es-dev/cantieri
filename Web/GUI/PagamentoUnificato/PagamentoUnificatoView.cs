using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

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
                Take = 10;
                ViewModel = new PagamentoUnificatoViewModel(this);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var space = new PagamentoUnificatoModel();
                space.Title = "NUOVO PAGAMENTO UNIFICATO";
                space.Model = new WcfService.Dto.PagamentoUnificatoDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
