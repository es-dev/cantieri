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
                    var abilitato = UtilityValidation.GetBoolean(obj.Abilitato);

                    infoCodice.Text = "ACC-" + obj.Id;
                    infoImage.Image = "Images.dashboard.account.png";
                    infoNickname.Text = nickname;
                    infoCreazione.Text = "Creato il "+ creazione;
                    infoRuolo.Text = ruolo;
                    infoAbilitato.Text = (abilitato?"Abilitato":"Non abilitato");
                    infoAbilitato.ForeColor = (abilitato ? Color.Blue : Color.Gray);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
	}
}
