using BusinessLogic;
using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Commessa
{
	public partial class CommessaView : TemplateView
	{
        public CommessaView(Tipi.FiltroCommessa filtroCommessa = Tipi.FiltroCommessa.None)
		{ 
			InitializeComponent();
            try
            {
                var viewModel = (Commessa.CommessaViewModel)ViewModel;
                if(viewModel!=null)
                    viewModel.FiltroCommessa = filtroCommessa;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
		}

        public CommessaView()
        {
            InitializeComponent();
        }

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new CommessaViewModel(this);
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
                var space = new CommessaModel();
                space.Title = "NUOVA COMMESSA";
                space.Model = new WcfService.Dto.CommessaDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
