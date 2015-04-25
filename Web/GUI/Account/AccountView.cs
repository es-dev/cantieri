using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Account
{
	public partial class AccountView : TemplateView
	{
        public AccountView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                ViewModel = new AccountViewModel();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var space = new AccountModel();
        //        space.Model = new WcfService.Dto.AccountDto();
        //        AddSpace(space);
        //    }
        //    catch (Exception ex)
        //    {
        //        UtilityError.Write(ex);
        //    } 
        //}

	}
}
