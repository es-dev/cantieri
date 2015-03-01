using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WcfService.Dto;

namespace Web.GUI.PagamentoUnificatoFatturaAcquisto
{
	public partial class PagamentoUnificatoFatturaAcquistoView : TemplateView
	{
        private PagamentoUnificatoDto pagamentoUnificato = null;

        public PagamentoUnificatoFatturaAcquistoView()
		{ 
			InitializeComponent();
		}

        public PagamentoUnificatoFatturaAcquistoView(PagamentoUnificatoDto pagamentoUnificato)
        {
            InitializeComponent();
            try
            {
                this.pagamentoUnificato = pagamentoUnificato;
                var viewModel = (PagamentoUnificatoFatturaAcquisto.PagamentoUnificatoFatturaAcquistoViewModel)ViewModel;
                if (viewModel != null)
                {
                    viewModel.PagamentoUnificato = pagamentoUnificato;
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
                var space = new PagamentoUnificatoFatturaAcquistoModel(pagamentoUnificato);
                space.Title = "FATTURA DI ACQUISTO PER PAGAMENTO UNIFICATO";
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
