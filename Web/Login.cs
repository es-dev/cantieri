using Library.Code;
using Library.Template.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WcfService.Dto;
using Web.Code;
using Web.GUI.Account;

namespace Web
{
	public partial class Login : TemplateBase
	{
		public Login()
		{
			InitializeComponent();
            try
            {
                ESApplication.Init(this);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
		}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LoginApplication();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void LoginApplication()
        {
            try
            {
                var username = editUsername.Text;
                var password = editPassword.Text;
                
                var account = new AccountDto(); 
                account.Username = username;
                account.Password = password;
                var viewModel = new AccountViewModel();
                var accountAuthenticated = viewModel.Authenticate(account);
                if (accountAuthenticated!=null)
                {
                    SessionManager.Login(Context, accountAuthenticated);
                    Context.Redirect("cantieri-homepage.aspx");
                }
                else
                {
                    lblLoginFault.Visible = true;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            
        }

        private void btnRegistrazione_Click(object sender, EventArgs e)
        {
            try
            {
                panelRegistrazione.Visible = !panelRegistrazione.Visible;
                if (panelRegistrazione.Visible)
                    panelRegistrazione.BringToFront();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCloseRegistrazione_Click(object sender, EventArgs e)
        {
            try
            {
                panelRegistrazione.Visible = false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnSendRegistrazione_Click(object sender, EventArgs e)
        {
            try
            {
                //raccoglie i dati e invia email all'amministratore del sistema
                panelRegistrazione.Visible = false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            try
            {
                panelForgotPassword.Visible = !panelForgotPassword.Visible;
                if (panelForgotPassword.Visible)
                    panelForgotPassword.BringToFront();       
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCloseForgotPassword_Click(object sender, EventArgs e)
        {
            try
            {
                panelForgotPassword.Visible = false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnSendForgotPassword_Click(object sender, EventArgs e)
        {
            try
            {
                //inviare email per nome utente con password resettata...
                panelForgotPassword.Visible = false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnManualEnterpriseManager_Click(object sender, EventArgs e)
        {
            try
            {
                //context redirect su manuale PDF o HTML

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private void editPassword_EnterKeyDown(object objSender, Gizmox.WebGUI.Forms.KeyEventArgs objArgs)
        {
            try
            {
                LoginApplication();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                if (editUsername.CanFocus)
                    editUsername.Focus();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }		
	}
}
