using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.AnagraficaCliente
{
	public partial class AnagraficaClienteView : TemplateView
	{
        public AnagraficaClienteView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new AnagraficaClienteViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "ANAGRAFICHE CLIENTI";
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
                var space = new AnagraficaClienteModel();
                space.Title = "NUOVA ANAGRAFICA CLIENTE";
                space.Model = new WcfService.Dto.AnagraficaClienteDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
