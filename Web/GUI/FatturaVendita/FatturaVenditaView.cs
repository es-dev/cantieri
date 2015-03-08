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
        private ClienteDto cliente = null;

        public FatturaVenditaView()
		{ 
			InitializeComponent();
		}

        public FatturaVenditaView(ClienteDto cliente)
        {
            InitializeComponent();
            try
            {
                this.cliente = cliente;
                var viewModel = (FatturaVendita.FatturaVenditaViewModel)ViewModel;
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
                ViewModel = new FatturaVenditaViewModel(this);
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
                var space = new FatturaVenditaModel(cliente);
                space.Title = "NUOVA FATTURA DI VENDITA";
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
