using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Reso
{
	public partial class ResoView : TemplateView
	{
        private WcfService.Dto.NotaCreditoDto notaCredito;

        public ResoView()
		{ 
			InitializeComponent();
		}

        public ResoView(WcfService.Dto.NotaCreditoDto notaCredito)
        {
            InitializeComponent();
            try
            {
                this.notaCredito = notaCredito;
                var viewModel = (Reso.ResoViewModel)ViewModel;
                if (viewModel != null)
                {
                    viewModel.NotaCredito = notaCredito;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private WcfService.Dto.FatturaAcquistoDto fatturaAcquisto;
        public ResoView(WcfService.Dto.FatturaAcquistoDto fatturaAcquisto)
        {
            InitializeComponent();
            try
            {
                this.fatturaAcquisto = fatturaAcquisto;
                var viewModel = (Reso.ResoViewModel)ViewModel;
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

        public override void Init()
        {
            try
            {
                ViewModel = new ResoViewModel();
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
                var space = new ResoModel(notaCredito);
                space.Model = new WcfService.Dto.ResoDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
