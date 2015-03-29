using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WcfService.Dto;

namespace Web.GUI.Committente
{
	public partial class CommittenteView : TemplateView
	{
        private CommessaDto commessa = null;

        public CommittenteView()
		{ 
			InitializeComponent();
		}

        public CommittenteView(WcfService.Dto.CommessaDto commessa)
        {
            InitializeComponent();
            try
            {
                this.commessa = commessa;
                var viewModel = (Committente.CommittenteViewModel)ViewModel;
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
                ViewModel = new CommittenteViewModel(this);
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
                var space = new CommittenteModel(commessa);
                space.Title = "NUOVO COMMITTENTE";
                space.Model = new WcfService.Dto.CommittenteDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
