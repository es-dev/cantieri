using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.AnagraficaArticolo
{
	public partial class AnagraficaArticoloView : TemplateView
	{
        public AnagraficaArticoloView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new AnagraficaArticoloViewModel(this);
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
                var space = new AnagraficaArticoloModel();
                space.Title = "NUOVA ANAGRAFICA ARTICOLO";
                space.Model = new WcfService.Dto.AnagraficaArticoloDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
