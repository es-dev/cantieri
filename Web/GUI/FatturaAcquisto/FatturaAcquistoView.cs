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

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new FatturaAcquistoViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "FATTURE ACQUISTI";
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
                space.Title = "NUOVA FATTURA ACQUISTO";
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
