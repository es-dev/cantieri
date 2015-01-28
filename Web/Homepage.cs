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
                if(!logged)
                    Logout();
                AddDefaultSpace();
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

        private void btnAccount_Click(object sender, EventArgs e)
        {
            try
            {
                panelAccount.Visible = !panelAccount.Visible;
                panelAccount.BringToFront();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCloseAccount_Click(object sender, EventArgs e)
        {
            try
            {
                panelAccount.Visible = false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                Logout();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private void Logout()
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