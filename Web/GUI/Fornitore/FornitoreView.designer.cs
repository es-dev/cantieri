using System.Drawing;

namespace Web.GUI.Fornitore
{
    partial class FornitoreView
	{
	        /// <summary>
	        /// Required designer variable.
	        /// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
	        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Visual WebGui Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.optStato = new Library.Template.Controls.TemplateEditOption();
            this.optCommessa = new Library.Template.Controls.TemplateEditOption();
            this.optRagioneSociale = new Library.Template.Controls.TemplateEditOption();
            this.editStato = new Library.Template.Controls.TemplateEditDropDown();
            this.editCommessa = new Library.Template.Controls.TemplateEditCombo();
            this.panelCommands.SuspendLayout();
            this.panelAdvancedSearch.SuspendLayout();
            this.panelOrderBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdvancedSearch
            // 
            this.panelAdvancedSearch.Controls.Add(this.editCommessa);
            this.panelAdvancedSearch.Controls.Add(this.editStato);
            this.panelAdvancedSearch.Location = new System.Drawing.Point(244, 68);
            this.panelAdvancedSearch.Size = new System.Drawing.Size(622, 249);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnConfirmAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnCloseAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnCancelAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.lblTitleAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editStato, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editCommessa, 0);
            // 
            // panelOrderBy
            // 
            this.panelOrderBy.Controls.Add(this.optRagioneSociale);
            this.panelOrderBy.Controls.Add(this.optCommessa);
            this.panelOrderBy.Controls.Add(this.optStato);
            this.panelOrderBy.Controls.SetChildIndex(this.optAscending, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optDescending, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.btnConfirmOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.btnCloseOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.btnCancelOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.lblTitleOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optStato, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optCommessa, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optRagioneSociale, 0);
            // 
            // btnCloseAdvancedSearch
            // 
            this.btnCloseAdvancedSearch.Location = new System.Drawing.Point(590, 2);
            // 
            // btnConfirmAdvancedSearch
            // 
            this.btnConfirmAdvancedSearch.Location = new System.Drawing.Point(485, 206);
            // 
            // btnCancelAdvancedSearch
            // 
            this.btnCancelAdvancedSearch.Location = new System.Drawing.Point(319, 206);
            // 
            // lblTitleAdvancedSearch
            // 
            this.lblTitleAdvancedSearch.Size = new System.Drawing.Size(582, 44);
            // 
            // optStato
            // 
            this.optStato.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.optStato.BackColor = System.Drawing.Color.Transparent;
            this.optStato.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.optStato.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.optStato.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.optStato.Changed = true;
            this.optStato.Editing = true;
            this.optStato.Group = "Option1";
            this.optStato.Label = "";
            this.optStato.LabelWidth = 0;
            this.optStato.Location = new System.Drawing.Point(19, 143);
            this.optStato.Name = "optStato";
            this.optStato.ReadOnly = false;
            this.optStato.Required = false;
            this.optStato.Size = new System.Drawing.Size(440, 30);
            this.optStato.TabIndex = 2;
            this.optStato.Text = "Stato";
            this.optStato.Value = false;
            // 
            // optCommessa
            // 
            this.optCommessa.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.optCommessa.BackColor = System.Drawing.Color.Transparent;
            this.optCommessa.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.optCommessa.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.optCommessa.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.optCommessa.Changed = true;
            this.optCommessa.Editing = true;
            this.optCommessa.Group = "Option1";
            this.optCommessa.Label = "";
            this.optCommessa.LabelWidth = 0;
            this.optCommessa.Location = new System.Drawing.Point(19, 101);
            this.optCommessa.Name = "optCommessa";
            this.optCommessa.ReadOnly = false;
            this.optCommessa.Required = false;
            this.optCommessa.Size = new System.Drawing.Size(440, 30);
            this.optCommessa.TabIndex = 2;
            this.optCommessa.Text = "Commessa";
            this.optCommessa.Value = false;
            // 
            // optRagioneSociale
            // 
            this.optRagioneSociale.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.optRagioneSociale.BackColor = System.Drawing.Color.Transparent;
            this.optRagioneSociale.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.optRagioneSociale.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.optRagioneSociale.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.optRagioneSociale.Changed = true;
            this.optRagioneSociale.Editing = true;
            this.optRagioneSociale.Group = "Option1";
            this.optRagioneSociale.Label = "";
            this.optRagioneSociale.LabelWidth = 0;
            this.optRagioneSociale.Location = new System.Drawing.Point(19, 59);
            this.optRagioneSociale.Name = "optRagioneSociale";
            this.optRagioneSociale.ReadOnly = false;
            this.optRagioneSociale.Required = false;
            this.optRagioneSociale.Size = new System.Drawing.Size(440, 30);
            this.optRagioneSociale.TabIndex = 2;
            this.optRagioneSociale.Text = "Ragione sociale";
            this.optRagioneSociale.Value = false;
            // 
            // editStato
            // 
            this.editStato.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editStato.BackColor = System.Drawing.Color.Transparent;
            this.editStato.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editStato.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editStato.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editStato.Changed = false;
            this.editStato.DisplayValues = null;
            this.editStato.Editing = true;
            this.editStato.Items = null;
            this.editStato.Label = "Stato";
            this.editStato.LabelWidth = 100;
            this.editStato.Location = new System.Drawing.Point(19, 102);
            this.editStato.Name = "editStato";
            this.editStato.ReadOnly = false;
            this.editStato.Required = false;
            this.editStato.Size = new System.Drawing.Size(572, 30);
            this.editStato.TabIndex = 6;
            this.editStato.Value = null;
            // 
            // editCommessa
            // 
            this.editCommessa.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editCommessa.BackColor = System.Drawing.Color.Transparent;
            this.editCommessa.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editCommessa.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editCommessa.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editCommessa.Changed = false;
            this.editCommessa.Editing = true;
            this.editCommessa.Label = "Commessa";
            this.editCommessa.LabelWidth = 100;
            this.editCommessa.Location = new System.Drawing.Point(19, 60);
            this.editCommessa.Model = null;
            this.editCommessa.Name = "editCommessa";
            this.editCommessa.ReadOnly = false;
            this.editCommessa.Required = false;
            this.editCommessa.Size = new System.Drawing.Size(572, 30);
            this.editCommessa.TabIndex = 7;
            this.editCommessa.Value = null;
            this.editCommessa.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editCommessa_ComboConfirm);
            this.editCommessa.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editCommessa_ComboClick);
            this.Controls.SetChildIndex(this.panelAdvancedSearch, 0);
            this.Controls.SetChildIndex(this.panelOrderBy, 0);
            this.Controls.SetChildIndex(this.panelCommands, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnOrderBy, 0);
            this.Controls.SetChildIndex(this.btnAdvancedSearch, 0);
            this.panelCommands.ResumeLayout(false);
            this.panelAdvancedSearch.ResumeLayout(false);
            this.panelOrderBy.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditOption optRagioneSociale;
        private Library.Template.Controls.TemplateEditOption optCommessa;
        private Library.Template.Controls.TemplateEditOption optStato;
        private Library.Template.Controls.TemplateEditDropDown editStato;
        private Library.Template.Controls.TemplateEditCombo editCommessa;
	}
}
