using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.FatturaVendita
{
	public partial class FatturaVenditaView : TemplateView
	{
        public FatturaVenditaView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new FatturaVenditaViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "FATTURE VENDITE";
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
                var space = new FatturaVenditaModel();
                space.Title = "NUOVA FATTURA VENDITA";
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
