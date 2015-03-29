using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Incasso
{
	public partial class IncassoView : TemplateView
	{
        private WcfService.Dto.CommittenteDto committente;
        private WcfService.Dto.FatturaVenditaDto fatturaVendita;

        public IncassoView()
		{ 
			InitializeComponent();
		}

        public IncassoView(WcfService.Dto.CommittenteDto committente)
        {
            InitializeComponent();
            try
            {
                this.committente = committente;
                var viewModel = (Incasso.IncassoViewModel)ViewModel;
                if (viewModel != null)
                {
                    viewModel.Committente = committente;
                }

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public IncassoView(WcfService.Dto.FatturaVenditaDto fatturaVendita)
        {
            InitializeComponent();
            try
            {
                this.fatturaVendita = fatturaVendita;
                var viewModel = (Incasso.IncassoViewModel)ViewModel;
                if (viewModel != null)
                {
                    viewModel.FatturaVendita = fatturaVendita;
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
                ViewModel = new IncassoViewModel(this);
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
                var space = new IncassoModel(fatturaVendita);
                space.Title = "NUOVO INCASSO";
                space.Model = new WcfService.Dto.IncassoDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
