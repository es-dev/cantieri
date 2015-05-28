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
            this.editCommessa = new Library.Template.Controls.TemplateEditCombo();
            this.editRagioneSociale = new Library.Template.Controls.TemplateEditText();
            this.editIndirizzo = new Library.Template.Controls.TemplateEditText();
            this.editCAP = new Library.Template.Controls.TemplateEditCap();
            this.editTelefono = new Library.Template.Controls.TemplateEditText();
            this.editFAX = new Library.Template.Controls.TemplateEditText();
            this.editMobile = new Library.Template.Controls.TemplateEditText();
            this.editCodiceFornitore = new Library.Template.Controls.TemplateEditCombo();
            this.editEmail = new Library.Template.Controls.TemplateEditEmail();
            this.editPartitaIVA = new Library.Template.Controls.TemplateEditPartitaIva();
            this.editComune = new Library.Template.Controls.TemplateEditCountry();
            this.editTotaleFattureAcquisto = new Library.Template.Controls.TemplateEditDecimal();
            this.lblAndamento = new Gizmox.WebGUI.Forms.Label();
            this.editStato = new Library.Template.Controls.TemplateEditState();
            this.btnCalcoloTotali = new Library.Controls.ButtonSeparatorV();
            this.editTotalePagamenti = new Library.Template.Controls.TemplateEditDecimal();
            this.editLocalita = new Library.Template.Controls.TemplateEditText();
            this.editNote = new Library.Template.Controls.TemplateEditText();
            this.btnFattureAcquisto = new Library.Controls.ButtonSeparatorV();
            this.btnPagamenti = new Library.Controls.ButtonSeparatorV();
            this.editTotaleNoteCredito = new Library.Template.Controls.TemplateEditDecimal();
            this.btnNoteCredito = new Library.Controls.ButtonSeparatorV();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editTotaleNoteCredito);
            this.container.Controls.Add(this.editNote);
            this.container.Controls.Add(this.editLocalita);
            this.container.Controls.Add(this.editTotalePagamenti);
            this.container.Controls.Add(this.editStato);
            this.container.Controls.Add(this.lblAndamento);
            this.container.Controls.Add(this.editTotaleFattureAcquisto);
            this.container.Controls.Add(this.editComune);
            this.container.Controls.Add(this.editPartitaIVA);
            this.container.Controls.Add(this.editEmail);
            this.container.Controls.Add(this.editCodiceFornitore);
            this.container.Controls.Add(this.editMobile);
            this.container.Controls.Add(this.editFAX);
            this.container.Controls.Add(this.editTelefono);
            this.container.Controls.Add(this.editCAP);
            this.container.Controls.Add(this.editIndirizzo);
            this.container.Controls.Add(this.editRagioneSociale);
            this.container.Controls.Add(this.editCommessa);
            this.container.Size = new System.Drawing.Size(923, 752);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editCommessa, 0);
            this.container.Controls.SetChildIndex(this.editRagioneSociale, 0);
            this.container.Controls.SetChildIndex(this.editIndirizzo, 0);
            this.container.Controls.SetChildIndex(this.editCAP, 0);
            this.container.Controls.SetChildIndex(this.editTelefono, 0);
            this.container.Controls.SetChildIndex(this.editFAX, 0);
            this.container.Controls.SetChildIndex(this.editMobile, 0);
            this.container.Controls.SetChildIndex(this.editCodiceFornitore, 0);
            this.container.Controls.SetChildIndex(this.editEmail, 0);
            this.container.Controls.SetChildIndex(this.editPartitaIVA, 0);
            this.container.Controls.SetChildIndex(this.editComune, 0);
            this.container.Controls.SetChildIndex(this.editTotaleFattureAcquisto, 0);
            this.container.Controls.SetChildIndex(this.lblAndamento, 0);
            this.container.Controls.SetChildIndex(this.editStato, 0);
            this.container.Controls.SetChildIndex(this.editTotalePagamenti, 0);
            this.container.Controls.SetChildIndex(this.editLocalita, 0);
            this.container.Controls.SetChildIndex(this.editNote, 0);
            this.container.Controls.SetChildIndex(this.editTotaleNoteCredito, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(641, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(585, 3);
            // 
            // panelCommands
            // 
            this.panelCommands.Controls.Add(this.btnNoteCredito);
            this.panelCommands.Controls.Add(this.btnPagamenti);
            this.panelCommands.Controls.Add(this.btnFattureAcquisto);
            this.panelCommands.Controls.Add(this.btnCalcoloTotali);
            this.panelCommands.Size = new System.Drawing.Size(101, 799);
            this.panelCommands.Controls.SetChildIndex(this.btnHome, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnClose, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnSave, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnUpdateCancel, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnDelete, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnCalcoloTotali, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnFattureAcquisto, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnPagamenti, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnNoteCredito, 0);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 727);
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
            this.editCommessa.Changed = true;
            this.editCommessa.Editing = false;
            this.editCommessa.Label = "Commessa";
            this.editCommessa.LabelWidth = 175;
            this.editCommessa.Location = new System.Drawing.Point(20, 65);
            this.editCommessa.Model = null;
            this.editCommessa.Name = "editCommessa";
            this.editCommessa.ReadOnly = false;
            this.editCommessa.Required = true;
            this.editCommessa.Size = new System.Drawing.Size(815, 30);
            this.editCommessa.TabIndex = 0;
            this.editCommessa.Text = "EditControl";
            this.editCommessa.Value = null;
            this.editCommessa.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editCommessa_ComboConfirm);
            this.editCommessa.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editCommessa_ComboClick);
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
            this.editRagioneSociale.Location = new System.Drawing.Point(20, 139);
            this.editRagioneSociale.Name = "editRagioneSociale";
            this.editRagioneSociale.ReadOnly = false;
            this.editRagioneSociale.Required = true;
            this.editRagioneSociale.Size = new System.Drawing.Size(813, 30);
            this.editRagioneSociale.TabIndex = 2;
            this.editRagioneSociale.Text = "EditControl";
            this.editRagioneSociale.Value = null;
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
            this.editIndirizzo.Location = new System.Drawing.Point(20, 176);
            this.editIndirizzo.Name = "editIndirizzo";
            this.editIndirizzo.ReadOnly = false;
            this.editIndirizzo.Required = true;
            this.editIndirizzo.Size = new System.Drawing.Size(813, 30);
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
            this.editCAP.Location = new System.Drawing.Point(20, 213);
            this.editCAP.Name = "editCAP";
            this.editCAP.ReadOnly = false;
            this.editCAP.Required = true;
            this.editCAP.Size = new System.Drawing.Size(813, 30);
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
            this.editTelefono.Location = new System.Drawing.Point(20, 324);
            this.editTelefono.Name = "editTelefono";
            this.editTelefono.ReadOnly = false;
            this.editTelefono.Required = false;
            this.editTelefono.Size = new System.Drawing.Size(813, 30);
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
            this.editFAX.Location = new System.Drawing.Point(20, 361);
            this.editFAX.Name = "editFAX";
            this.editFAX.ReadOnly = false;
            this.editFAX.Required = false;
            this.editFAX.Size = new System.Drawing.Size(813, 30);
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
            this.editMobile.Location = new System.Drawing.Point(20, 398);
            this.editMobile.Name = "editMobile";
            this.editMobile.ReadOnly = false;
            this.editMobile.Required = false;
            this.editMobile.Size = new System.Drawing.Size(813, 30);
            this.editMobile.TabIndex = 9;
            this.editMobile.Text = "EditControl";
            this.editMobile.Value = null;
            // 
            // editCodiceFornitore
            // 
            this.editCodiceFornitore.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editCodiceFornitore.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editCodiceFornitore.BackColor = System.Drawing.Color.Transparent;
            this.editCodiceFornitore.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editCodiceFornitore.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editCodiceFornitore.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editCodiceFornitore.Changed = true;
            this.editCodiceFornitore.Editing = false;
            this.editCodiceFornitore.Label = "Codice fornitore";
            this.editCodiceFornitore.LabelWidth = 175;
            this.editCodiceFornitore.Location = new System.Drawing.Point(20, 102);
            this.editCodiceFornitore.Model = null;
            this.editCodiceFornitore.Name = "editCodiceFornitore";
            this.editCodiceFornitore.ReadOnly = false;
            this.editCodiceFornitore.Required = true;
            this.editCodiceFornitore.Size = new System.Drawing.Size(813, 30);
            this.editCodiceFornitore.TabIndex = 1;
            this.editCodiceFornitore.Text = "EditControl";
            this.editCodiceFornitore.Value = null;
            this.editCodiceFornitore.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editCodiceFornitore_ComboConfirm);
            this.editCodiceFornitore.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editCodiceFornitore_ComboClick);
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
            this.editEmail.Location = new System.Drawing.Point(20, 435);
            this.editEmail.Name = "editEmail";
            this.editEmail.ReadOnly = false;
            this.editEmail.Required = false;
            this.editEmail.Size = new System.Drawing.Size(813, 30);
            this.editEmail.TabIndex = 10;
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
            this.editPartitaIVA.Location = new System.Drawing.Point(20, 472);
            this.editPartitaIVA.Name = "editPartitaIVA";
            this.editPartitaIVA.ReadOnly = false;
            this.editPartitaIVA.Required = true;
            this.editPartitaIVA.Size = new System.Drawing.Size(813, 30);
            this.editPartitaIVA.TabIndex = 11;
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
            this.editComune.Location = new System.Drawing.Point(20, 250);
            this.editComune.Name = "editComune";
            this.editComune.ReadOnly = false;
            this.editComune.Required = true;
            this.editComune.Size = new System.Drawing.Size(813, 30);
            this.editComune.TabIndex = 5;
            this.editComune.Text = "EditControl";
            this.editComune.Value = null;
            // 
            // editTotaleFattureAcquisto
            // 
            this.editTotaleFattureAcquisto.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTotaleFattureAcquisto.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTotaleFattureAcquisto.BackColor = System.Drawing.Color.Transparent;
            this.editTotaleFattureAcquisto.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTotaleFattureAcquisto.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTotaleFattureAcquisto.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTotaleFattureAcquisto.Changed = true;
            this.editTotaleFattureAcquisto.Editing = false;
            this.editTotaleFattureAcquisto.Label = "Totale fatture";
            this.editTotaleFattureAcquisto.LabelWidth = 175;
            this.editTotaleFattureAcquisto.Location = new System.Drawing.Point(20, 583);
            this.editTotaleFattureAcquisto.Name = "editTotaleFattureAcquisto";
            this.editTotaleFattureAcquisto.ReadOnly = false;
            this.editTotaleFattureAcquisto.Required = false;
            this.editTotaleFattureAcquisto.Size = new System.Drawing.Size(813, 30);
            this.editTotaleFattureAcquisto.TabIndex = 13;
            this.editTotaleFattureAcquisto.Text = "TemplateEditNumeric";
            this.editTotaleFattureAcquisto.Value = null;
            // 
            // lblAndamento
            // 
            this.lblAndamento.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblAndamento.BackColor = System.Drawing.Color.Gainsboro;
            this.lblAndamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAndamento.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAndamento.Location = new System.Drawing.Point(13, 546);
            this.lblAndamento.Name = "lblAndamento";
            this.lblAndamento.Size = new System.Drawing.Size(876, 30);
            this.lblAndamento.TabIndex = 1001;
            this.lblAndamento.Text = "SITUAZIONE PAGAMENTI FATTURE";
            this.lblAndamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editStato
            // 
            this.editStato.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editStato.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editStato.BackColor = System.Drawing.Color.Transparent;
            this.editStato.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editStato.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editStato.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editStato.Changed = true;
            this.editStato.Editing = false;
            this.editStato.Label = "Stato";
            this.editStato.LabelWidth = 175;
            this.editStato.Location = new System.Drawing.Point(20, 694);
            this.editStato.Name = "editStato";
            this.editStato.ReadOnly = false;
            this.editStato.Required = false;
            this.editStato.Size = new System.Drawing.Size(813, 50);
            this.editStato.TabIndex = 15;
            this.editStato.Text = "TemplateEditNumeric";
            this.editStato.Value = "None{;}";
            // 
            // btnCalcoloTotali
            // 
            this.btnCalcoloTotali.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnCalcoloTotali.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcoloTotali.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnCalcoloTotali.ImageButton = "";
            this.btnCalcoloTotali.ImageSeparator = "Images.separator_ht_small.png";
            this.btnCalcoloTotali.Location = new System.Drawing.Point(0, 504);
            this.btnCalcoloTotali.Name = "btnCalcoloTotali";
            this.btnCalcoloTotali.Size = new System.Drawing.Size(100, 72);
            this.btnCalcoloTotali.TabIndex = 1002;
            this.btnCalcoloTotali.TextButton = "Calcolo totali";
            this.btnCalcoloTotali.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnCalcoloTotali_Click);
            // 
            // editTotalePagamenti
            // 
            this.editTotalePagamenti.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTotalePagamenti.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTotalePagamenti.BackColor = System.Drawing.Color.Transparent;
            this.editTotalePagamenti.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTotalePagamenti.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTotalePagamenti.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTotalePagamenti.Changed = true;
            this.editTotalePagamenti.Editing = false;
            this.editTotalePagamenti.Label = "Totale pagamenti";
            this.editTotalePagamenti.LabelWidth = 175;
            this.editTotalePagamenti.Location = new System.Drawing.Point(20, 620);
            this.editTotalePagamenti.Name = "editTotalePagamenti";
            this.editTotalePagamenti.ReadOnly = false;
            this.editTotalePagamenti.Required = false;
            this.editTotalePagamenti.Size = new System.Drawing.Size(813, 30);
            this.editTotalePagamenti.TabIndex = 14;
            this.editTotalePagamenti.Text = "TemplateEditNumeric";
            this.editTotalePagamenti.Value = null;
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
            this.editLocalita.Label = "Località";
            this.editLocalita.LabelWidth = 175;
            this.editLocalita.Location = new System.Drawing.Point(20, 287);
            this.editLocalita.Name = "editLocalita";
            this.editLocalita.ReadOnly = false;
            this.editLocalita.Required = false;
            this.editLocalita.Size = new System.Drawing.Size(813, 30);
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
            this.editNote.Location = new System.Drawing.Point(20, 509);
            this.editNote.Name = "editNote";
            this.editNote.ReadOnly = false;
            this.editNote.Required = false;
            this.editNote.Size = new System.Drawing.Size(813, 30);
            this.editNote.TabIndex = 12;
            this.editNote.Text = "EditControl";
            this.editNote.Value = null;
            // 
            // btnFattureAcquisto
            // 
            this.btnFattureAcquisto.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnFattureAcquisto.BackColor = System.Drawing.Color.Transparent;
            this.btnFattureAcquisto.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnFattureAcquisto.ImageButton = "";
            this.btnFattureAcquisto.ImageSeparator = "Images.separator_ht_small.png";
            this.btnFattureAcquisto.Location = new System.Drawing.Point(0, 288);
            this.btnFattureAcquisto.Name = "btnFattureAcquisto";
            this.btnFattureAcquisto.Size = new System.Drawing.Size(100, 72);
            this.btnFattureAcquisto.TabIndex = 1002;
            this.btnFattureAcquisto.TextButton = "Fatture di acquisto";
            this.btnFattureAcquisto.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnFattureAcquisto_Click);
            // 
            // btnPagamenti
            // 
            this.btnPagamenti.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnPagamenti.BackColor = System.Drawing.Color.Transparent;
            this.btnPagamenti.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnPagamenti.ImageButton = "";
            this.btnPagamenti.ImageSeparator = "Images.separator_ht_small.png";
            this.btnPagamenti.Location = new System.Drawing.Point(0, 432);
            this.btnPagamenti.Name = "btnPagamenti";
            this.btnPagamenti.Size = new System.Drawing.Size(100, 72);
            this.btnPagamenti.TabIndex = 1002;
            this.btnPagamenti.TextButton = "Pagamenti";
            this.btnPagamenti.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnPagamenti_Click);
            // 
            // editTotaleNoteCredito
            // 
            this.editTotaleNoteCredito.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTotaleNoteCredito.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTotaleNoteCredito.BackColor = System.Drawing.Color.Transparent;
            this.editTotaleNoteCredito.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTotaleNoteCredito.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTotaleNoteCredito.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTotaleNoteCredito.Changed = true;
            this.editTotaleNoteCredito.Editing = false;
            this.editTotaleNoteCredito.Label = "Totale note credito";
            this.editTotaleNoteCredito.LabelWidth = 175;
            this.editTotaleNoteCredito.Location = new System.Drawing.Point(20, 657);
            this.editTotaleNoteCredito.Name = "editTotaleNoteCredito";
            this.editTotaleNoteCredito.ReadOnly = false;
            this.editTotaleNoteCredito.Required = false;
            this.editTotaleNoteCredito.Size = new System.Drawing.Size(813, 30);
            this.editTotaleNoteCredito.TabIndex = 11;
            this.editTotaleNoteCredito.Text = "TemplateEditNumeric";
            this.editTotaleNoteCredito.Value = null;
            // 
            // btnNoteCredito
            // 
            this.btnNoteCredito.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnNoteCredito.BackColor = System.Drawing.Color.Transparent;
            this.btnNoteCredito.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnNoteCredito.ImageButton = "";
            this.btnNoteCredito.ImageSeparator = "Images.separator_ht_small.png";
            this.btnNoteCredito.Location = new System.Drawing.Point(0, 360);
            this.btnNoteCredito.Name = "btnNoteCredito";
            this.btnNoteCredito.Size = new System.Drawing.Size(100, 72);
            this.btnNoteCredito.TabIndex = 1002;
            this.btnNoteCredito.TextButton = "Note di Credito";
            this.btnNoteCredito.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnNoteCredito_Click);
            // 
            // FornitoreModel
            // 
            this.Size = new System.Drawing.Size(1024, 799);
            this.Controls.SetChildIndex(this.panelCommands, 0);
            this.Controls.SetChildIndex(this.container, 0);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditCombo editCommessa;
        private Library.Template.Controls.TemplateEditText editRagioneSociale;
        private Library.Template.Controls.TemplateEditText editIndirizzo;
        private Library.Template.Controls.TemplateEditText editMobile;
        private Library.Template.Controls.TemplateEditText editFAX;
        private Library.Template.Controls.TemplateEditText editTelefono;
        private Library.Template.Controls.TemplateEditCap editCAP;
        private Library.Template.Controls.TemplateEditCombo editCodiceFornitore;
        private Library.Template.Controls.TemplateEditPartitaIva editPartitaIVA;
        private Library.Template.Controls.TemplateEditEmail editEmail;
        private Library.Template.Controls.TemplateEditCountry editComune;
        private Library.Template.Controls.TemplateEditState editStato;
        private Gizmox.WebGUI.Forms.Label lblAndamento;
        private Library.Template.Controls.TemplateEditDecimal editTotaleFattureAcquisto;
        private Library.Controls.ButtonSeparatorV btnCalcoloTotali;
        private Library.Template.Controls.TemplateEditDecimal editTotalePagamenti;
        private Library.Template.Controls.TemplateEditText editLocalita;
        private Library.Template.Controls.TemplateEditText editNote;
        private Library.Controls.ButtonSeparatorV btnFattureAcquisto;
        private Library.Controls.ButtonSeparatorV btnPagamenti;
        private Library.Template.Controls.TemplateEditDecimal editTotaleNoteCredito;
        private Library.Controls.ButtonSeparatorV btnNoteCredito;


    }
}
