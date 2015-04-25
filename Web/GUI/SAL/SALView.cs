using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WcfService.Dto;

namespace Web.GUI.SAL
{
	public partial class SALView : TemplateView
	{
    private CommessaDto commessa = null;
        public SALView()
		{ 
			InitializeComponent();
		}

        public SALView(WcfService.Dto.CommessaDto commessa)
        {
            InitializeComponent();
            try
            {
                this.commessa = commessa;
                var viewModel = (SAL.SALViewModel)ViewModel;
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
                ViewModel = new SALViewModel();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void AddNewModel()
        {
            try
            {
                var space = new SALModel(commessa);
                space.Model = new SALDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
