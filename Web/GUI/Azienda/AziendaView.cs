using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Comune
{
	public partial class AziendaView : TemplateView
	{
        public AziendaView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new AziendaViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "COMUNI";
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
                var space = new AziendaModel();
                space.Title = "NUOVO COMUNE";
                space.Model = new WcfService.Dto.ComuneDto() ;
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
