using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WcfService.Dto;

namespace Web.GUI.Fornitore
{
	public partial class FornitoreView : TemplateView
	{
        private CommessaDto commessa = null;

        public FornitoreView()
		{ 
			InitializeComponent();
		}

        public FornitoreView(WcfService.Dto.CommessaDto commessa)
        {
            InitializeComponent();
            try
            {
                this.commessa = commessa;
                var viewModel = (Fornitore.FornitoreViewModel)ViewModel;
                if (viewModel != null)
                {
                    viewModel.Commessa = commessa;
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
                ViewModel = new FornitoreViewModel(this);
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
                var space = new FornitoreModel(commessa);
                space.Title = "NUOVO FORNITORE";
                space.Model = new WcfService.Dto.FornitoreDto() ;
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
