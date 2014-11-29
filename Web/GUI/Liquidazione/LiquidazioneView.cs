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
        public LiquidazioneView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new LiquidazioneViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "LIQUIDAZIONI";
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
                space.Title = "NUOVA LIQUIDAZIONE";
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