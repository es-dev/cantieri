#region Using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using Web.Code;
using Web.GUI.Dashboard;
using Library.Code;
using Library.Template.Forms;

#endregion

namespace Web
{
    public partial class Homepage : TemplateWorkspace
    {
        public Homepage()
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

        private void Homepage_Load(object sender, EventArgs e)
        {
            try 
            {
                bool logged = SessionManager.IsLogged(Context);
                if (!logged)
                    Logout();
                else
                    BindView();

                AddDefaultSpace();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private void BindView()
        {
            try
            {
                var account = SessionManager.GetAccount(Context);
                if(account!=null)
                {
                    Livello = account.Ruolo;
                    StatoConnessione = "Connesso";
                    Nickname= account.Nickname;

                    RagioneSociale = "Tutte le aziende";
                    var azienda = account.Azienda;
                    if (azienda != null)
                        RagioneSociale = azienda.RagioneSociale;
                }
               
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void AddDefaultSpace()
        {
            try
            {
                var space = new DashboardView();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }	

        public override void Logout()
        {
            try
            {
                SessionManager.Logout(Context);
                Context.Redirect("cantieri-login.aspx");
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }
        	
     }
}