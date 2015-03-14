using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.NotaCredito
{
	public partial class NotaCreditoView : TemplateView
	{

        public NotaCreditoView()
		{ 
			InitializeComponent();
		}

        private WcfService.Dto.FornitoreDto fornitore;
        public NotaCreditoView(WcfService.Dto.FornitoreDto fornitore)
        {
            InitializeComponent();
            try
            {
                this.fornitore = fornitore;
                var viewModel = (NotaCredito.NotaCreditoViewModel)ViewModel;
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
                Take = 10;
                ViewModel = new NotaCreditoViewModel(this);
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
                var space = new NotaCreditoModel(fornitore);
                space.Title = "NUOVA NOTA DI CREDITO";
                space.Model = new WcfService.Dto.NotaCreditoDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
