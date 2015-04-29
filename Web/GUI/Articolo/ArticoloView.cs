using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Articolo
{
    public partial class ArticoloView : TemplateView
    {
        public ArticoloView()
        {
            InitializeComponent();
        }

        private WcfService.Dto.FatturaAcquistoDto fatturaAcquisto;
        public ArticoloView(WcfService.Dto.FatturaAcquistoDto fatturaAcquisto)
        {
            InitializeComponent();
            try
            {
                this.fatturaAcquisto = fatturaAcquisto;
                var viewModel = (Articolo.ArticoloViewModel)ViewModel;
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
                ViewModel = new ArticoloViewModel();
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
                var space = new ArticoloModel(fatturaAcquisto);
                space.Model = new WcfService.Dto.ArticoloDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

    }
}
