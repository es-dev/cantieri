using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WcfService.Dto;

namespace Web.GUI.FatturaVendita
{
	public partial class FatturaVenditaView : TemplateView
	{
        private CommittenteDto committente = null;

        public FatturaVenditaView()
		{ 
			InitializeComponent();
		}

        public FatturaVenditaView(CommittenteDto committente)
        {
            InitializeComponent();
            try
            {
                this.committente = committente;
                var viewModel = (FatturaVendita.FatturaVenditaViewModel)ViewModel;
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

        public override void Init()
        {
            try
            {
                ViewModel = new FatturaVenditaViewModel();
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
                var space = new FatturaVenditaModel(committente);
                space.Model = new WcfService.Dto.FatturaVenditaDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
