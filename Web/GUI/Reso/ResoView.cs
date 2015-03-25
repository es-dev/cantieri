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
                Take = 10;
                ViewModel = new ResoViewModel(this);
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
                var space = new ResoModel(notaCredito);
                space.Title = "NUOVO RESO";
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
