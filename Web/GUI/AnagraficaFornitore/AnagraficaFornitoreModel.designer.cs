using System.Drawing;

namespace Web.GUI.AnagraficaFornitore
{
    partial class AnagraficaFornitoreModel
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
            this.editMobile = new Library.Template.Controls.TemplateEditText();
            this.editFAX = new Library.Template.Controls.TemplateEditText();
            this.editTelefono = new Library.Template.Controls.TemplateEditText();
            this.editCAP = new Library.Template.Controls.TemplateEditCap();
            this.editIndirizzo = new Library.Template.Controls.TemplateEditText();
            this.editRagioneSociale = new Library.Template.Controls.TemplateEditText();
            this.editCodice = new Library.Template.Controls.TemplateEditText();
            this.editEmail = new Library.Template.Controls.TemplateEditEmail();
            this.editPartitaIVA = new Library.Template.Controls.TemplateEditPartitaIVA();
            this.editComune = new Library.Template.Controls.TemplateEditComune();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editComune);
            this.container.Controls.Add(this.editPartitaIVA);
            this.container.Controls.Add(this.editEmail);
            this.container.Controls.Add(this.editCodice);
            this.container.Controls.Add(this.editRagioneSociale);
            this.container.Controls.Add(this.editIndirizzo);
            this.container.Controls.Add(this.editCAP);
            this.container.Controls.Add(this.editTelefono);
            this.container.Controls.Add(this.editFAX);
            this.container.Controls.Add(this.editMobile);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editMobile, 0);
            this.container.Controls.SetChildIndex(this.editFAX, 0);
            this.container.Controls.SetChildIndex(this.editTelefono, 0);
            this.container.Controls.SetChildIndex(this.editCAP, 0);
            this.container.Controls.SetChildIndex(this.editIndirizzo, 0);
            this.container.Controls.SetChildIndex(this.editRagioneSociale, 0);
            this.container.Controls.SetChildIndex(this.editCodice, 0);
            this.container.Controls.SetChildIndex(this.editEmail, 0);
            this.container.Controls.SetChildIndex(this.editPartitaIVA, 0);
            this.container.Controls.SetChildIndex(this.editComune, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(666, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(610, 3);
            // 
            // editMobile
            // 
            this.editMobile.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editMobile.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editMobile.BackColor = System.Drawing.Color.Transparent;
            this.editMobile.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editMobile.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editMobile.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editMobile.Changed = true;
            this.editMobile.Editing = false;
            this.editMobile.Label = "Mobile";
            this.editMobile.LabelWidth = 175;
            this.editMobile.Location = new System.Drawing.Point(25, 390);
            this.editMobile.Name = "editMobile";
            this.editMobile.ReadOnly = false;
            this.editMobile.Required = false;
            this.editMobile.Size = new System.Drawing.Size(815, 30);
            this.editMobile.TabIndex = 8;
            this.editMobile.Text = "EditControl";
            this.editMobile.Value = null;
            // 
            // editFAX
            // 
            this.editFAX.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editFAX.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editFAX.BackColor = System.Drawing.Color.Transparent;
            this.editFAX.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editFAX.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editFAX.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editFAX.Changed = true;
            this.editFAX.Editing = false;
            this.editFAX.Label = "FAX";
            this.editFAX.LabelWidth = 175;
            this.editFAX.Location = new System.Drawing.Point(25, 345);
            this.editFAX.Name = "editFAX";
            this.editFAX.ReadOnly = false;
            this.editFAX.Required = false;
            this.editFAX.Size = new System.Drawing.Size(815, 30);
            this.editFAX.TabIndex = 7;
            this.editFAX.Text = "EditControl";
            this.editFAX.Value = null;
            // 
            // editTelefono
            // 
            this.editTelefono.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTelefono.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTelefono.BackColor = System.Drawing.Color.Transparent;
            this.editTelefono.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTelefono.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTelefono.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTelefono.Changed = true;
            this.editTelefono.Editing = false;
            this.editTelefono.Label = "Telefono";
            this.editTelefono.LabelWidth = 175;
            this.editTelefono.Location = new System.Drawing.Point(25, 300);
            this.editTelefono.Name = "editTelefono";
            this.editTelefono.ReadOnly = false;
            this.editTelefono.Required = false;
            this.editTelefono.Size = new System.Drawing.Size(815, 30);
            this.editTelefono.TabIndex = 6;
            this.editTelefono.Text = "EditControl";
            this.editTelefono.Value = null;
            // 
            // editCAP
            // 
            this.editCAP.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editCAP.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editCAP.BackColor = System.Drawing.Color.Transparent;
            this.editCAP.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editCAP.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editCAP.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editCAP.Changed = true;
            this.editCAP.Editing = false;
            this.editCAP.Label = "CAP";
            this.editCAP.LabelWidth = 175;
            this.editCAP.Location = new System.Drawing.Point(25, 210);
            this.editCAP.Name = "editCAP";
            this.editCAP.ReadOnly = false;
            this.editCAP.Required = false;
            this.editCAP.Size = new System.Drawing.Size(815, 30);
            this.editCAP.TabIndex = 3;
            this.editCAP.Text = "EditControl";
            this.editCAP.Value = null;
            // 
            // editIndirizzo
            // 
            this.editIndirizzo.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editIndirizzo.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editIndirizzo.BackColor = System.Drawing.Color.Transparent;
            this.editIndirizzo.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editIndirizzo.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editIndirizzo.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editIndirizzo.Changed = true;
            this.editIndirizzo.Editing = false;
            this.editIndirizzo.Label = "Indirizzo";
            this.editIndirizzo.LabelWidth = 175;
            this.editIndirizzo.Location = new System.Drawing.Point(25, 165);
            this.editIndirizzo.Name = "editIndirizzo";
            this.editIndirizzo.ReadOnly = false;
            this.editIndirizzo.Required = false;
            this.editIndirizzo.Size = new System.Drawing.Size(815, 30);
            this.editIndirizzo.TabIndex = 2;
            this.editIndirizzo.Text = "EditControl";
            this.editIndirizzo.Value = null;
            // 
            // editRagioneSociale
            // 
            this.editRagioneSociale.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editRagioneSociale.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editRagioneSociale.BackColor = System.Drawing.Color.Transparent;
            this.editRagioneSociale.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editRagioneSociale.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editRagioneSociale.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editRagioneSociale.Changed = true;
            this.editRagioneSociale.Editing = false;
            this.editRagioneSociale.Label = "Ragione sociale";
            this.editRagioneSociale.LabelWidth = 175;
            this.editRagioneSociale.Location = new System.Drawing.Point(25, 120);
            this.editRagioneSociale.Name = "editRagioneSociale";
            this.editRagioneSociale.ReadOnly = false;
            this.editRagioneSociale.Required = false;
            this.editRagioneSociale.Size = new System.Drawing.Size(815, 30);
            this.editRagioneSociale.TabIndex = 1;
            this.editRagioneSociale.Text = "EditControl";
            this.editRagioneSociale.Value = null;
            // 
            // editCodice
            // 
            this.editCodice.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editCodice.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editCodice.BackColor = System.Drawing.Color.Transparent;
            this.editCodice.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editCodice.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editCodice.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editCodice.Changed = true;
            this.editCodice.Editing = false;
            this.editCodice.Label = "Codice";
            this.editCodice.LabelWidth = 175;
            this.editCodice.Location = new System.Drawing.Point(25, 75);
            this.editCodice.Name = "templateEditText1";
            this.editCodice.ReadOnly = false;
            this.editCodice.Required = false;
            this.editCodice.Size = new System.Drawing.Size(815, 30);
            this.editCodice.TabIndex = 0;
            this.editCodice.Text = "EditControl";
            this.editCodice.Value = null;
            // 
            // editEmail
            // 
            this.editEmail.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editEmail.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editEmail.BackColor = System.Drawing.Color.Transparent;
            this.editEmail.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editEmail.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editEmail.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editEmail.Changed = true;
            this.editEmail.Editing = false;
            this.editEmail.Label = "Email";
            this.editEmail.LabelWidth = 175;
            this.editEmail.Location = new System.Drawing.Point(25, 435);
            this.editEmail.Name = "editEmail";
            this.editEmail.ReadOnly = false;
            this.editEmail.Required = false;
            this.editEmail.Size = new System.Drawing.Size(815, 30);
            this.editEmail.TabIndex = 9;
            this.editEmail.Text = "TemplateEditEmail";
            this.editEmail.Value = null;
            // 
            // editPartitaIVA
            // 
            this.editPartitaIVA.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editPartitaIVA.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editPartitaIVA.BackColor = System.Drawing.Color.Transparent;
            this.editPartitaIVA.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editPartitaIVA.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editPartitaIVA.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editPartitaIVA.Changed = true;
            this.editPartitaIVA.Editing = false;
            this.editPartitaIVA.Label = "Partita IVA";
            this.editPartitaIVA.LabelWidth = 175;
            this.editPartitaIVA.Location = new System.Drawing.Point(25, 480);
            this.editPartitaIVA.Name = "editPartitaIVA";
            this.editPartitaIVA.ReadOnly = false;
            this.editPartitaIVA.Required = false;
            this.editPartitaIVA.Size = new System.Drawing.Size(815, 30);
            this.editPartitaIVA.TabIndex = 10;
            this.editPartitaIVA.Text = "TemplateEditPartitaIva";
            this.editPartitaIVA.Value = "---";
            // 
            // editComune
            // 
            this.editComune.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editComune.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editComune.BackColor = System.Drawing.Color.Transparent;
            this.editComune.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editComune.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editComune.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editComune.Changed = true;
            this.editComune.Editing = false;
            this.editComune.Label = "Comune";
            this.editComune.LabelWidth = 175;
            this.editComune.Location = new System.Drawing.Point(25, 255);
            this.editComune.Name = "editComune";
            this.editComune.ReadOnly = false;
            this.editComune.Required = false;
            this.editComune.Size = new System.Drawing.Size(815, 30);
            this.editComune.TabIndex = 4;
            this.editComune.Text = "EditControl";
            this.editComune.Value = null;
            this.Controls.SetChildIndex(this.panelCommands, 0);
            this.Controls.SetChildIndex(this.container, 0);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditText editRagioneSociale;
        private Library.Template.Controls.TemplateEditText editIndirizzo;
        private Library.Template.Controls.TemplateEditCap editCAP;
        private Library.Template.Controls.TemplateEditText editTelefono;
        private Library.Template.Controls.TemplateEditText editFAX;
        private Library.Template.Controls.TemplateEditText editMobile;
        private Library.Template.Controls.TemplateEditText editCodice;
        private Library.Template.Controls.TemplateEditPartitaIVA editPartitaIVA;
        private Library.Template.Controls.TemplateEditEmail editEmail;
        private Library.Template.Controls.TemplateEditComune editComune;


    }
}
