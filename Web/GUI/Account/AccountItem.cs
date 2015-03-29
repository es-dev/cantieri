using Library.Code;
using Library.Interfaces;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.Account
{
	public partial class AccountItem : TemplateItem
	{
        public AccountItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.AccountDto)model;
                    var creazione = UtilityValidation.GetDataND(obj.Creazione);
                    var nickname = UtilityValidation.GetStringND(obj.Nickname);
                    var ruolo = UtilityValidation.GetStringND(obj.Ruolo);

                    infoImage.Image = "Images.dashboard.account.png";
                    infoNickname.Text = nickname;
                    infoCreazione.Text = creazione;
                    infoRuolo.Text = ruolo;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void AccountItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var obj = (WcfService.Dto.AccountDto)Model;
                    var space = new AccountModel();
                    space.Title = "ACCOUNT " + obj.Nickname;
                    AddSpace(space);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }
	}
}
