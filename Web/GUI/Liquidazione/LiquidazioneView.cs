using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Liquidazione
{
	public partial class LiquidazioneView : TemplateView
	{
        private WcfService.Dto.ClienteDto cliente;

        public LiquidazioneView()
		{ 
			InitializeComponent();
		}

        public LiquidazioneView(WcfService.Dto.ClienteDto cliente)
        {
            InitializeComponent();
            try
            {
                this.cliente = cliente;
                var viewModel = (Liquidazione.LiquidazioneViewModel)ViewModel;
                if (viewModel != null)
                {
                    viewModel.Cliente = cliente;
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
                ViewModel = new LiquidazioneViewModel(this);
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
                var space = new LiquidazioneModel();
                space.Title = "NUOVO INCASSO";
                space.Model = new WcfService.Dto.LiquidazioneDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
