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

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new ArticoloViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "ARTICOLI";
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
                var space = new ArticoloModel();
                space.Title = "NUOVO ARTICOLO";
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
