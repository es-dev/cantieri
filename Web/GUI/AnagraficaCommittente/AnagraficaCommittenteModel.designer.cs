using System.Drawing;

namespace Web.GUI.AnagraficaCommittente
{
    partial class AnagraficaCommittenteModel
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
            this.editIndirizzo = new Library.Template.Controls.TemplateEditText();
            this.editCAP = new Library.Template.Controls.TemplateEditCap();
            this.editTelefono = new Library.Template.Controls.TemplateEditText();
            this.editFAX = new Library.Template.Controls.TemplateEditText();
            this.editMobile = new Library.Template.Controls.TemplateEditText();
            this.editRagioneSociale = new Library.Template.Controls.TemplateEditText();
            this.editCodice = new Library.Template.Controls.TemplateEditText();
            this.editPartitaIVA = new Library.Template.Controls.TemplateEditPartitaIva();
            this.editEmail = new Library.Template.Controls.TemplateEditEmail();
            this.editComune = new Library.Template.Controls.TemplateEditCountry();
            this.editLocalita = new Library.Template.Controls.TemplateEditText();
            this.editNote = new Library.Template.Controls.TemplateEditText();
            this.editAzienda = new Library.Template.Controls.TemplateEditCombo();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editAzienda);
            this.container.Controls.Add(this.editNote);
            this.container.Controls.Add(this.editLocalita);
            this.container.Controls.Add(this.editComune);
            this.container.Controls.Add(this.editEmail);
            this.container.Controls.Add(this.editPartitaIVA);
            this.container.Controls.Add(this.editCodice);
            this.container.Controls.Add(this.editRagioneSociale);
            this.container.Controls.Add(this.editMobile);
            this.container.Controls.Add(this.editFAX);
            this.container.Controls.Add(this.editTelefono);
            this.container.Controls.Add(this.editCAP);
            this.container.Controls.Add(this.editIndirizzo);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editIndirizzo, 0);
            this.container.Controls.SetChildIndex(this.editCAP, 0);
            this.container.Controls.SetChildIndex(this.editTelefono, 0);
            this.container.Controls.SetChildIndex(this.editFAX, 0);
            this.container.Controls.SetChildIndex(this.editMobile, 0);
            this.container.Controls.SetChildIndex(this.editRagioneSociale, 0);
            this.container.Controls.SetChildIndex(this.editCodice, 0);
            this.container.Controls.SetChildIndex(this.editPartitaIVA, 0);
            this.container.Controls.SetChildIndex(this.editEmail, 0);
            this.container.Controls.SetChildIndex(this.editComune, 0);
            this.container.Controls.SetChildIndex(this.editLocalita, 0);
            this.container.Controls.SetChildIndex(this.editNote, 0);
            this.container.Controls.SetChildIndex(this.editAzienda, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(666, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(610, 3);
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
            this.editIndirizzo.Location = new System.Drawing.Point(24, 189);
            this.editIndirizzo.Name = "editIndirizzo";
            this.editIndirizzo.ReadOnly = false;
            this.editIndirizzo.Required = true;
            this.editIndirizzo.Size = new System.Drawing.Size(794, 30);
            this.editIndirizzo.TabIndex = 3;
            this.editIndirizzo.Text = "EditControl";
            this.editIndirizzo.Value = null;
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
            this.editCAP.Location = new System.Drawing.Point(24, 230);
            this.editCAP.Name = "editCAP";
            this.editCAP.ReadOnly = false;
            this.editCAP.Required = true;
            this.editCAP.Size = new System.Drawing.Size(794, 30);
            this.editCAP.TabIndex = 4;
            this.editCAP.Text = "EditControl";
            this.editCAP.Value = null;
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
            this.editTelefono.Location = new System.Drawing.Point(24, 353);
            this.editTelefono.Name = "editTelefono";
            this.editTelefono.ReadOnly = false;
            this.editTelefono.Required = false;
            this.editTelefono.Size = new System.Drawing.Size(794, 30);
            this.editTelefono.TabIndex = 7;
            this.editTelefono.Text = "EditControl";
            this.editTelefono.Value = null;
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
            this.editFAX.Location = new System.Drawing.Point(24, 394);
            this.editFAX.Name = "editFAX";
            this.editFAX.ReadOnly = false;
            this.editFAX.Required = false;
            this.editFAX.Size = new System.Drawing.Size(794, 30);
            this.editFAX.TabIndex = 8;
            this.editFAX.Text = "EditControl";
            this.editFAX.Value = null;
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
            this.editMobile.Location = new System.Drawing.Point(24, 435);
            this.editMobile.Name = "editMobile";
            this.editMobile.ReadOnly = false;
            this.editMobile.Required = false;
            this.editMobile.Size = new System.Drawing.Size(794, 30);
            this.editMobile.TabIndex = 9;
            this.editMobile.Text = "EditControl";
            this.editMobile.Value = null;
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
            this.editRagioneSociale.Location = new System.Drawing.Point(24, 148);
            this.editRagioneSociale.Name = "editRagioneSociale";
            this.editRagioneSociale.ReadOnly = false;
            this.editRagioneSociale.Required = true;
            this.editRagioneSociale.Size = new System.Drawing.Size(794, 30);
            this.editRagioneSociale.TabIndex = 2;
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
            this.editCodice.Location = new System.Drawing.Point(24, 107);
            this.editCodice.Name = "editCodice";
            this.editCodice.ReadOnly = false;
            this.editCodice.Required = true;
            this.editCodice.Size = new System.Drawing.Size(794, 30);
            this.editCodice.TabIndex = 1;
            this.editCodice.Text = "EditControl";
            this.editCodice.Value = null;
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
            this.editPartitaIVA.Location = new System.Drawing.Point(24, 517);
            this.editPartitaIVA.Name = "editPartitaIVA";
            this.editPartitaIVA.ReadOnly = false;
            this.editPartitaIVA.Required = true;
            this.editPartitaIVA.Size = new System.Drawing.Size(794, 30);
            this.editPartitaIVA.TabIndex = 11;
            this.editPartitaIVA.Text = "TemplateEditPartitaIva";
            this.editPartitaIVA.Value = "---";
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
            this.editEmail.Location = new System.Drawing.Point(24, 476);
            this.editEmail.Name = "editEmail";
            this.editEmail.ReadOnly = false;
            this.editEmail.Required = false;
            this.editEmail.Size = new System.Drawing.Size(794, 30);
            this.editEmail.TabIndex = 10;
            this.editEmail.Text = "TemplateEditEmail";
            this.editEmail.Value = null;
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
            this.editComune.Location = new System.Drawing.Point(24, 271);
            this.editComune.Name = "editComune";
            this.editComune.ReadOnly = false;
            this.editComune.Required = true;
            this.editComune.Size = new System.Drawing.Size(794, 30);
            this.editComune.TabIndex = 5;
            this.editComune.Text = "EditControl";
            this.editComune.Value = null;
            // 
            // editLocalita
            // 
            this.editLocalita.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editLocalita.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editLocalita.BackColor = System.Drawing.Color.Transparent;
            this.editLocalita.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editLocalita.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editLocalita.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editLocalita.Changed = true;
            this.editLocalita.Editing = false;
            this.editLocalita.Label = "Localit�";
            this.editLocalita.LabelWidth = 175;
            this.editLocalita.Location = new System.Drawing.Point(24, 312);
            this.editLocalita.Name = "editLocalita";
            this.editLocalita.ReadOnly = false;
            this.editLocalita.Required = false;
            this.editLocalita.Size = new System.Drawing.Size(794, 30);
            this.editLocalita.TabIndex = 6;
            this.editLocalita.Text = "EditControl";
            this.editLocalita.Value = null;
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
            this.editNote.Location = new System.Drawing.Point(24, 558);
            this.editNote.Name = "editNote";
            this.editNote.ReadOnly = false;
            this.editNote.Required = false;
            this.editNote.Size = new System.Drawing.Size(794, 30);
            this.editNote.TabIndex = 12;
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
            this.editAzienda.Location = new System.Drawing.Point(24, 66);
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
            this.Controls.SetChildIndex(this.panelCommands, 0);
            this.Controls.SetChildIndex(this.container, 0);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditText editMobile;
        private Library.Template.Controls.TemplateEditText editFAX;
        private Library.Template.Controls.TemplateEditText editTelefono;
        private Library.Template.Controls.TemplateEditCap editCAP;
        private Library.Template.Controls.TemplateEditText editIndirizzo;
        private Library.Template.Controls.TemplateEditText editRagioneSociale;
        private Library.Template.Controls.TemplateEditText editCodice;
        private Library.Template.Controls.TemplateEditPartitaIva editPartitaIVA;
        private Library.Template.Controls.TemplateEditEmail editEmail;
        private Library.Template.Controls.TemplateEditCountry editComune;
        private Library.Template.Controls.TemplateEditText editLocalita;
        private Library.Template.Controls.TemplateEditText editNote;
        private Library.Template.Controls.TemplateEditCombo editAzienda;


    }
}
