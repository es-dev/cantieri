using System.Drawing;

namespace Web.GUI.Fornitore
{
    partial class FornitoreModel
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
            this.clientStorage1 = new Gizmox.WebGUI.Forms.Client.ClientStorage();
            this.editCommessa = new Library.Template.Controls.TemplateEditCombo();
            this.editCentroCosto = new Library.Template.Controls.TemplateEditCombo();
            this.editRagioneSociale = new Library.Template.Controls.TemplateEditText();
            this.editIndirizzo = new Library.Template.Controls.TemplateEditText();
            this.editPartitaIVA = new Library.Template.Controls.TemplateEditText();
            this.editProvincia = new Library.Template.Controls.TemplateEditText();
            this.editComune = new Library.Template.Controls.TemplateEditText();
            this.editCAP = new Library.Template.Controls.TemplateEditText();
            this.editTelefono = new Library.Template.Controls.TemplateEditText();
            this.editFAX = new Library.Template.Controls.TemplateEditText();
            this.editMobile = new Library.Template.Controls.TemplateEditText();
            this.editEmail = new Library.Template.Controls.TemplateEditText();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editEmail);
            this.container.Controls.Add(this.editMobile);
            this.container.Controls.Add(this.editFAX);
            this.container.Controls.Add(this.editTelefono);
            this.container.Controls.Add(this.editCAP);
            this.container.Controls.Add(this.editComune);
            this.container.Controls.Add(this.editProvincia);
            this.container.Controls.Add(this.editPartitaIVA);
            this.container.Controls.Add(this.editIndirizzo);
            this.container.Controls.Add(this.editRagioneSociale);
            this.container.Controls.Add(this.editCentroCosto);
            this.container.Controls.Add(this.editCommessa);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editCommessa, 0);
            this.container.Controls.SetChildIndex(this.editCentroCosto, 0);
            this.container.Controls.SetChildIndex(this.editRagioneSociale, 0);
            this.container.Controls.SetChildIndex(this.editIndirizzo, 0);
            this.container.Controls.SetChildIndex(this.editPartitaIVA, 0);
            this.container.Controls.SetChildIndex(this.editProvincia, 0);
            this.container.Controls.SetChildIndex(this.editComune, 0);
            this.container.Controls.SetChildIndex(this.editCAP, 0);
            this.container.Controls.SetChildIndex(this.editTelefono, 0);
            this.container.Controls.SetChildIndex(this.editFAX, 0);
            this.container.Controls.SetChildIndex(this.editMobile, 0);
            this.container.Controls.SetChildIndex(this.editEmail, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(666, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(610, 3);
            // 
            // clientStorage1
            // 
            this.clientStorage1.Description = "";
            this.clientStorage1.MajorVersion = ((ushort)(1));
            this.clientStorage1.MinorVersion = ((ushort)(0));
            // 
            // editCommessa
            // 
            this.editCommessa.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editCommessa.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editCommessa.BackColor = System.Drawing.Color.Transparent;
            this.editCommessa.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editCommessa.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editCommessa.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editCommessa.Changed = false;
            this.editCommessa.Editing = false;
            this.editCommessa.Label = "Commessa";
            this.editCommessa.LabelWidth = 175;
            this.editCommessa.Location = new System.Drawing.Point(20, 75);
            this.editCommessa.Model = null;
            this.editCommessa.Name = "editCommessa";
            this.editCommessa.ReadOnly = false;
            this.editCommessa.Required = false;
            this.editCommessa.Size = new System.Drawing.Size(800, 30);
            this.editCommessa.TabIndex = 2;
            this.editCommessa.Text = "EditControl";
            this.editCommessa.Value = "";
            this.editCommessa.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editCommessa_ComboConfirm);
            this.editCommessa.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editCommessa_ComboClick);
            // 
            // editCentroCosto
            // 
            this.editCentroCosto.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editCentroCosto.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editCentroCosto.BackColor = System.Drawing.Color.Transparent;
            this.editCentroCosto.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editCentroCosto.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editCentroCosto.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editCentroCosto.Changed = false;
            this.editCentroCosto.Editing = false;
            this.editCentroCosto.Label = "Centro di Costo";
            this.editCentroCosto.LabelWidth = 175;
            this.editCentroCosto.Location = new System.Drawing.Point(20, 119);
            this.editCentroCosto.Model = null;
            this.editCentroCosto.Name = "editCentroCosto";
            this.editCentroCosto.ReadOnly = false;
            this.editCentroCosto.Required = false;
            this.editCentroCosto.Size = new System.Drawing.Size(800, 30);
            this.editCentroCosto.TabIndex = 3;
            this.editCentroCosto.Text = "EditControl";
            this.editCentroCosto.Value = "";
            this.editCentroCosto.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editCentroCosto_ComboConfirm);
            this.editCentroCosto.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editCentroCosto_ComboClick);
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
            this.editRagioneSociale.Changed = false;
            this.editRagioneSociale.Editing = false;
            this.editRagioneSociale.Label = "Ragione sociale";
            this.editRagioneSociale.LabelWidth = 175;
            this.editRagioneSociale.Location = new System.Drawing.Point(20, 163);
            this.editRagioneSociale.Name = "editRagioneSociale";
            this.editRagioneSociale.ReadOnly = false;
            this.editRagioneSociale.Required = false;
            this.editRagioneSociale.Size = new System.Drawing.Size(800, 30);
            this.editRagioneSociale.TabIndex = 4;
            this.editRagioneSociale.Text = "EditControl";
            this.editRagioneSociale.Value = "";
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
            this.editIndirizzo.Changed = false;
            this.editIndirizzo.Editing = false;
            this.editIndirizzo.Label = "Indirizzo";
            this.editIndirizzo.LabelWidth = 175;
            this.editIndirizzo.Location = new System.Drawing.Point(20, 207);
            this.editIndirizzo.Name = "editIndirizzo";
            this.editIndirizzo.ReadOnly = false;
            this.editIndirizzo.Required = false;
            this.editIndirizzo.Size = new System.Drawing.Size(800, 30);
            this.editIndirizzo.TabIndex = 5;
            this.editIndirizzo.Text = "EditControl";
            this.editIndirizzo.Value = "";
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
            this.editPartitaIVA.Changed = false;
            this.editPartitaIVA.Editing = false;
            this.editPartitaIVA.Label = "Partita IVA";
            this.editPartitaIVA.LabelWidth = 175;
            this.editPartitaIVA.Location = new System.Drawing.Point(20, 559);
            this.editPartitaIVA.Name = "editPartitaIVA";
            this.editPartitaIVA.ReadOnly = false;
            this.editPartitaIVA.Required = false;
            this.editPartitaIVA.Size = new System.Drawing.Size(800, 30);
            this.editPartitaIVA.TabIndex = 7;
            this.editPartitaIVA.Text = "EditControl";
            this.editPartitaIVA.Value = "";
            // 
            // editProvincia
            // 
            this.editProvincia.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editProvincia.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editProvincia.BackColor = System.Drawing.Color.Transparent;
            this.editProvincia.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editProvincia.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editProvincia.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editProvincia.Changed = false;
            this.editProvincia.Editing = false;
            this.editProvincia.Label = "Provincia";
            this.editProvincia.LabelWidth = 175;
            this.editProvincia.Location = new System.Drawing.Point(20, 339);
            this.editProvincia.Name = "editProvincia";
            this.editProvincia.ReadOnly = false;
            this.editProvincia.Required = false;
            this.editProvincia.Size = new System.Drawing.Size(800, 30);
            this.editProvincia.TabIndex = 6;
            this.editProvincia.Text = "EditControl";
            this.editProvincia.Value = "";
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
            this.editComune.Changed = false;
            this.editComune.Editing = false;
            this.editComune.Label = "Comune";
            this.editComune.LabelWidth = 175;
            this.editComune.Location = new System.Drawing.Point(20, 295);
            this.editComune.Name = "editComune";
            this.editComune.ReadOnly = false;
            this.editComune.Required = false;
            this.editComune.Size = new System.Drawing.Size(800, 30);
            this.editComune.TabIndex = 5;
            this.editComune.Text = "EditControl";
            this.editComune.Value = "";
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
            this.editCAP.Changed = false;
            this.editCAP.Editing = false;
            this.editCAP.Label = "CAP";
            this.editCAP.LabelWidth = 175;
            this.editCAP.Location = new System.Drawing.Point(20, 251);
            this.editCAP.Name = "editCAP";
            this.editCAP.ReadOnly = false;
            this.editCAP.Required = false;
            this.editCAP.Size = new System.Drawing.Size(800, 30);
            this.editCAP.TabIndex = 4;
            this.editCAP.Text = "EditControl";
            this.editCAP.Value = "";
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
            this.editTelefono.Changed = false;
            this.editTelefono.Editing = false;
            this.editTelefono.Label = "Telefono";
            this.editTelefono.LabelWidth = 175;
            this.editTelefono.Location = new System.Drawing.Point(20, 383);
            this.editTelefono.Name = "editTelefono";
            this.editTelefono.ReadOnly = false;
            this.editTelefono.Required = false;
            this.editTelefono.Size = new System.Drawing.Size(800, 30);
            this.editTelefono.TabIndex = 8;
            this.editTelefono.Text = "EditControl";
            this.editTelefono.Value = "";
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
            this.editFAX.Changed = false;
            this.editFAX.Editing = false;
            this.editFAX.Label = "FAX";
            this.editFAX.LabelWidth = 175;
            this.editFAX.Location = new System.Drawing.Point(20, 427);
            this.editFAX.Name = "editFAX";
            this.editFAX.ReadOnly = false;
            this.editFAX.Required = false;
            this.editFAX.Size = new System.Drawing.Size(800, 30);
            this.editFAX.TabIndex = 9;
            this.editFAX.Text = "EditControl";
            this.editFAX.Value = "";
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
            this.editMobile.Changed = false;
            this.editMobile.Editing = false;
            this.editMobile.Label = "Mobile";
            this.editMobile.LabelWidth = 175;
            this.editMobile.Location = new System.Drawing.Point(20, 471);
            this.editMobile.Name = "editMobile";
            this.editMobile.ReadOnly = false;
            this.editMobile.Required = false;
            this.editMobile.Size = new System.Drawing.Size(800, 30);
            this.editMobile.TabIndex = 10;
            this.editMobile.Text = "EditControl";
            this.editMobile.Value = "";
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
            this.editEmail.Changed = false;
            this.editEmail.Editing = false;
            this.editEmail.Label = "Email";
            this.editEmail.LabelWidth = 175;
            this.editEmail.Location = new System.Drawing.Point(20, 515);
            this.editEmail.Name = "editEmail";
            this.editEmail.ReadOnly = false;
            this.editEmail.Required = false;
            this.editEmail.Size = new System.Drawing.Size(800, 30);
            this.editEmail.TabIndex = 11;
            this.editEmail.Text = "EditControl";
            this.editEmail.Value = "";
            this.Controls.SetChildIndex(this.container, 0);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Gizmox.WebGUI.Forms.Client.ClientStorage clientStorage1;
        private Library.Template.Controls.TemplateEditCombo editCommessa;
        private Library.Template.Controls.TemplateEditText editRagioneSociale;
        private Library.Template.Controls.TemplateEditCombo editCentroCosto;
        private Library.Template.Controls.TemplateEditText editIndirizzo;
        private Library.Template.Controls.TemplateEditText editEmail;
        private Library.Template.Controls.TemplateEditText editMobile;
        private Library.Template.Controls.TemplateEditText editFAX;
        private Library.Template.Controls.TemplateEditText editTelefono;
        private Library.Template.Controls.TemplateEditText editCAP;
        private Library.Template.Controls.TemplateEditText editComune;
        private Library.Template.Controls.TemplateEditText editProvincia;
        private Library.Template.Controls.TemplateEditText editPartitaIVA;


    }
}
