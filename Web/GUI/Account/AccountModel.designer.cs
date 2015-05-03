using System.Drawing;

namespace Web.GUI.Account
{
    partial class AccountModel
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
            this.editUsername = new Library.Template.Controls.TemplateEditText();
            this.editNote = new Library.Template.Controls.TemplateEditText();
            this.editAzienda = new Library.Template.Controls.TemplateEditCombo();
            this.editCreazione = new Library.Template.Controls.TemplateEditDate();
            this.editRuolo = new Library.Template.Controls.TemplateEditDropDown();
            this.editNickname = new Library.Template.Controls.TemplateEditText();
            this.editPassword = new Library.Template.Controls.TemplateEditPassword();
            this.editAbilitato = new Library.Template.Controls.TemplateEditSwitch();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editAbilitato);
            this.container.Controls.Add(this.editPassword);
            this.container.Controls.Add(this.editNickname);
            this.container.Controls.Add(this.editRuolo);
            this.container.Controls.Add(this.editCreazione);
            this.container.Controls.Add(this.editAzienda);
            this.container.Controls.Add(this.editNote);
            this.container.Controls.Add(this.editUsername);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editUsername, 0);
            this.container.Controls.SetChildIndex(this.editNote, 0);
            this.container.Controls.SetChildIndex(this.editAzienda, 0);
            this.container.Controls.SetChildIndex(this.editCreazione, 0);
            this.container.Controls.SetChildIndex(this.editRuolo, 0);
            this.container.Controls.SetChildIndex(this.editNickname, 0);
            this.container.Controls.SetChildIndex(this.editPassword, 0);
            this.container.Controls.SetChildIndex(this.editAbilitato, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(666, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(610, 3);
            // 
            // editUsername
            // 
            this.editUsername.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editUsername.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editUsername.BackColor = System.Drawing.Color.Transparent;
            this.editUsername.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editUsername.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editUsername.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editUsername.Changed = true;
            this.editUsername.Editing = false;
            this.editUsername.Label = "Username";
            this.editUsername.LabelWidth = 175;
            this.editUsername.Location = new System.Drawing.Point(25, 122);
            this.editUsername.Name = "editUsername";
            this.editUsername.ReadOnly = false;
            this.editUsername.Required = true;
            this.editUsername.Size = new System.Drawing.Size(792, 30);
            this.editUsername.TabIndex = 1;
            this.editUsername.Text = "EditControl";
            this.editUsername.Value = null;
            // 
            // editNote
            // 
            this.editNote.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editNote.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editNote.BackColor = System.Drawing.Color.Transparent;
            this.editNote.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editNote.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editNote.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editNote.Changed = true;
            this.editNote.Editing = false;
            this.editNote.Label = "Note";
            this.editNote.LabelWidth = 175;
            this.editNote.Location = new System.Drawing.Point(25, 310);
            this.editNote.Name = "editNote";
            this.editNote.ReadOnly = false;
            this.editNote.Required = false;
            this.editNote.Size = new System.Drawing.Size(792, 30);
            this.editNote.TabIndex = 5;
            this.editNote.Text = "EditControl";
            this.editNote.Value = null;
            // 
            // editAzienda
            // 
            this.editAzienda.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editAzienda.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editAzienda.BackColor = System.Drawing.Color.Transparent;
            this.editAzienda.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editAzienda.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editAzienda.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editAzienda.Changed = true;
            this.editAzienda.Editing = false;
            this.editAzienda.Label = "Azienda";
            this.editAzienda.LabelWidth = 175;
            this.editAzienda.Location = new System.Drawing.Point(25, 75);
            this.editAzienda.Model = null;
            this.editAzienda.Name = "editAzienda";
            this.editAzienda.ReadOnly = false;
            this.editAzienda.Required = true;
            this.editAzienda.Size = new System.Drawing.Size(794, 30);
            this.editAzienda.TabIndex = 0;
            this.editAzienda.Text = "EditControl";
            this.editAzienda.Value = null;
            this.editAzienda.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editAzienda_ComboConfirm);
            this.editAzienda.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editAzienda_ComboClick);
            // 
            // editCreazione
            // 
            this.editCreazione.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editCreazione.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editCreazione.BackColor = System.Drawing.Color.Transparent;
            this.editCreazione.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editCreazione.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editCreazione.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editCreazione.Changed = true;
            this.editCreazione.Editing = false;
            this.editCreazione.Label = "Creazione";
            this.editCreazione.LabelWidth = 175;
            this.editCreazione.Location = new System.Drawing.Point(25, 357);
            this.editCreazione.Name = "editCreazione";
            this.editCreazione.ReadOnly = false;
            this.editCreazione.Required = false;
            this.editCreazione.Size = new System.Drawing.Size(792, 30);
            this.editCreazione.TabIndex = 6;
            this.editCreazione.Value = null;
            // 
            // editRuolo
            // 
            this.editRuolo.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editRuolo.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editRuolo.BackColor = System.Drawing.Color.Transparent;
            this.editRuolo.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editRuolo.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editRuolo.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editRuolo.Changed = true;
            this.editRuolo.DisplayValues = null;
            this.editRuolo.Editing = false;
            this.editRuolo.Items = null;
            this.editRuolo.Label = "Ruolo";
            this.editRuolo.LabelWidth = 175;
            this.editRuolo.Location = new System.Drawing.Point(25, 263);
            this.editRuolo.Name = "editRuolo";
            this.editRuolo.ReadOnly = false;
            this.editRuolo.Required = true;
            this.editRuolo.Size = new System.Drawing.Size(792, 30);
            this.editRuolo.TabIndex = 4;
            this.editRuolo.Value = null;
            // 
            // editNickname
            // 
            this.editNickname.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editNickname.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editNickname.BackColor = System.Drawing.Color.Transparent;
            this.editNickname.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editNickname.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editNickname.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editNickname.Changed = true;
            this.editNickname.Editing = false;
            this.editNickname.Label = "Nickname";
            this.editNickname.LabelWidth = 175;
            this.editNickname.Location = new System.Drawing.Point(25, 216);
            this.editNickname.Name = "templateEditText1";
            this.editNickname.ReadOnly = false;
            this.editNickname.Required = true;
            this.editNickname.Size = new System.Drawing.Size(792, 30);
            this.editNickname.TabIndex = 3;
            this.editNickname.Text = "EditControl";
            this.editNickname.Value = null;
            // 
            // editPassword
            // 
            this.editPassword.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editPassword.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editPassword.BackColor = System.Drawing.Color.Transparent;
            this.editPassword.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editPassword.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editPassword.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editPassword.Changed = true;
            this.editPassword.Editing = false;
            this.editPassword.Label = "Password";
            this.editPassword.LabelWidth = 175;
            this.editPassword.Location = new System.Drawing.Point(25, 169);
            this.editPassword.Name = "editPassword";
            this.editPassword.ReadOnly = false;
            this.editPassword.Required = true;
            this.editPassword.Size = new System.Drawing.Size(792, 30);
            this.editPassword.TabIndex = 2;
            this.editPassword.Value = "---";
            // 
            // editAbilitato
            // 
            this.editAbilitato.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editAbilitato.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editAbilitato.BackColor = System.Drawing.Color.Transparent;
            this.editAbilitato.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editAbilitato.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editAbilitato.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editAbilitato.Changed = false;
            this.editAbilitato.Editing = false;
            this.editAbilitato.Group = "SwitchGroup1";
            this.editAbilitato.Label = "Abilitato";
            this.editAbilitato.LabelWidth = 175;
            this.editAbilitato.Location = new System.Drawing.Point(25, 404);
            this.editAbilitato.Name = "editAbilitato";
            this.editAbilitato.ReadOnly = false;
            this.editAbilitato.Required = false;
            this.editAbilitato.Size = new System.Drawing.Size(792, 30);
            this.editAbilitato.TabIndex = 7;
            this.editAbilitato.Value = false;
            // 
            // AccountModel
            // 
            this.Load += new System.EventHandler(this.AccountModel_Load);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditText editUsername;
        private Library.Template.Controls.TemplateEditText editNote;
        private Library.Template.Controls.TemplateEditCombo editAzienda;
        private Library.Template.Controls.TemplateEditDate editCreazione;
        private Library.Template.Controls.TemplateEditDropDown editRuolo;
        private Library.Template.Controls.TemplateEditText editNickname;
        private Library.Template.Controls.TemplateEditPassword editPassword;
        private Library.Template.Controls.TemplateEditSwitch editAbilitato;


    }
}
