using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.PagamentoUnificatoFatturaAcquisto
{
	public partial class PagamentoUnificatoFatturaAcquistoView : TemplateView
	{
        public PagamentoUnificatoFatturaAcquistoView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new PagamentoUnificatoFatturaAcquistoViewModel(this);
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
                var space = new PagamentoUnificatoFatturaAcquistoModel();
                space.Title = "ASSOCIA IL PAGAMENTO UNIFICATO ALLE FATTURE DI ACQUISTO";
                space.Model = new WcfService.Dto.PagamentoUnificatoFatturaAcquistoDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
