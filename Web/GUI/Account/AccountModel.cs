using BusinessLogic;
using Library.Code;
using Library.Controls;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;
using WcfService.Dto;

namespace Web.GUI.Account
{
	public partial class AccountModel : TemplateModel
	{
        public AccountModel()
		{
			InitializeComponent();
            try
            {
                InitCombo();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
		}

        private void InitCombo()
        {
            try
            {
                editRuolo.DisplayValues = UtilityEnum.GetDisplayValues<Tipi.TipoAccount>(); 
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindViewTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (AccountDto)model;
                    infoSubtitle.Text = BusinessLogic.Account.GetCodifica(obj);
                    infoSubtitleImage.Image = "Images.dashboard.account.png";
                    infoTitle.Text = (obj.Id!=0? "ACCOUNT " + BusinessLogic.Account.GetCodifica(obj): "NUOVO ACCOUNT");
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindView(object model)  
        {
            try
            {
                if (model != null)
                {
                    var obj = (AccountDto)model;
                    editUsername.Value = obj.Username;
                    editNickname.Value = obj.Nickname;
                    editRuolo.Value = obj.Ruolo;
                    editPassword.Value = obj.Password;
                    editAbilitato.Value = obj.Abilitato;
                    editNote.Value = obj.Note;
                    editCreazione.Value = obj.Creazione;

                    BindViewAzienda(obj.Azienda);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewAzienda(AziendaDto azienda)
        {
            try
            {
                editAzienda.Model = azienda;
                editAzienda.Value = BusinessLogic.Azienda.GetCodifica(azienda);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            
        }

        public override void BindModel(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.AccountDto)model;
                    obj.Username = editUsername.Value;
                    obj.Nickname = editNickname.Value;
                    obj.Ruolo = editRuolo.Value;
                    obj.Password = editPassword.Value;
                    obj.Abilitato = editAbilitato.Value;
                    obj.Note = editNote.Value;
                    if(obj.Creazione==null)
                        obj.Creazione = editCreazione.Value;

                    var azienda = (WcfService.Dto.AziendaDto)editAzienda.Model;
                    if (azienda != null)
                        obj.AziendaId = azienda.Id;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editAzienda_ComboClick()
        {
            try
            {
                var view = new Azienda.AziendaView();
                view.Title = "SELEZIONA UN'AZIENDA";
                editAzienda.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editAzienda_ComboConfirm(object model)
        {
            try
            {
                var azienda = (WcfService.Dto.AziendaDto)model;
                BindViewAzienda(azienda);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void SetNewValue(object model)
        {
            try
            {
                editCreazione.Value = DateTime.Now;
                editAbilitato.Value = true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
   
	}
}
