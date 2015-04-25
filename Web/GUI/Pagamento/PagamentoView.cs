using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Pagamento
{
	public partial class PagamentoView : TemplateView
	{
        private WcfService.Dto.FatturaAcquistoDto fatturaAcquisto;

        public PagamentoView()
		{ 
			InitializeComponent();
		}

        public PagamentoView(WcfService.Dto.FatturaAcquistoDto fatturaAcquisto)
        {
            InitializeComponent();
            try
            {
                this.fatturaAcquisto = fatturaAcquisto;
                var viewModel = (Pagamento.PagamentoViewModel)ViewModel;
                if (viewModel != null)
                {
                    viewModel.FatturaAcquisto = fatturaAcquisto;
                }

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private WcfService.Dto.FornitoreDto fornitore;
        public PagamentoView(WcfService.Dto.FornitoreDto fornitore)
        {
            InitializeComponent();
            try
            {
                this.fornitore = fornitore;
                var viewModel = (Pagamento.PagamentoViewModel)ViewModel;
                if (viewModel != null)
                {
                    viewModel.Fornitore = fornitore;
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
                ViewModel = new PagamentoViewModel();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void AddNewModel()
        {
            try
            {
                var space = new PagamentoModel(fatturaAcquisto);
                space.Model = new WcfService.Dto.PagamentoDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

     
       
	}
}
