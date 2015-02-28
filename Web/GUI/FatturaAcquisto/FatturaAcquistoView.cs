using BusinessLogic;
using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.FatturaAcquisto
{
	public partial class FatturaAcquistoView : TemplateView
	{
        public FatturaAcquistoView()
		{ 
			InitializeComponent();
		}

        public FatturaAcquistoView(WcfService.Dto.AnagraficaFornitoreDto anagraficaFornitore, Tipi.StatoFattura statoFattura)
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

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new FatturaAcquistoViewModel(this);
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
                var space = new FatturaAcquistoModel();
                space.Title = "NUOVA FATTURA DI ACQUISTO";
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
