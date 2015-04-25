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

namespace Web.GUI.FatturaAcquisto
{
    public partial class FatturaAcquistoView : TemplateView
    {
        private FornitoreDto fornitore = null;

        public FatturaAcquistoView()
        {
            InitializeComponent();
        }

        public FatturaAcquistoView(AnagraficaFornitoreDto anagraficaFornitore, Tipi.StatoFattura statoFattura)
        {
            InitializeComponent();
            try
            {
                var viewModel = (FatturaAcquisto.FatturaAcquistoViewModel)ViewModel;
                if (viewModel != null)
                {
                    viewModel.AnagraficaFornitore = anagraficaFornitore;
                    viewModel.StatoFattura = statoFattura;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public FatturaAcquistoView(FornitoreDto fornitore)
        {
            InitializeComponent();
            try
            {
                this.fornitore = fornitore;
                var viewModel = (FatturaAcquisto.FatturaAcquistoViewModel)ViewModel;
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
                ViewModel = new FatturaAcquistoViewModel();
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
                var space = new FatturaAcquistoModel(fornitore);
                space.Model = new WcfService.Dto.FatturaAcquistoDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }
    }
}
