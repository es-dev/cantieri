using System.Drawing;

namespace Web.GUI.SAL
{
    partial class SALModel
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
            this.editData = new Library.Template.Controls.TemplateEditDate();
            this.editDenominazione = new Library.Template.Controls.TemplateEditText();
            this.editTotaleFattureAcquisto = new Library.Template.Controls.TemplateEditDecimal();
            this.editTotaleFattureVendita = new Library.Template.Controls.TemplateEditDecimal();
            this.editCodice = new Library.Template.Controls.TemplateEditText();
            this.lblFatturato = new Gizmox.WebGUI.Forms.Label();
            this.lblPagamenti = new Gizmox.WebGUI.Forms.Label();
            this.editTotalePagamenti = new Library.Template.Controls.TemplateEditDecimal();
            this.editTotaleIncassi = new Library.Template.Controls.TemplateEditDecimal();
            this.lblAndamento = new Gizmox.WebGUI.Forms.Label();
            this.btnCalcoloSAL = new Library.Controls.ButtonSeparatorV();
            this.editStato = new Library.Template.Controls.TemplateEditState();
            this.editNote = new Library.Template.Controls.TemplateEditText();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editNote);
            this.container.Controls.Add(this.editStato);
            this.container.Controls.Add(this.lblAndamento);
            this.container.Controls.Add(this.editTotaleIncassi);
            this.container.Controls.Add(this.editTotalePagamenti);
            this.container.Controls.Add(this.lblPagamenti);
            this.container.Controls.Add(this.lblFatturato);
            this.container.Controls.Add(this.editCodice);
            this.container.Controls.Add(this.editTotaleFattureVendita);
            this.container.Controls.Add(this.editTotaleFattureAcquisto);
            this.container.Controls.Add(this.editDenominazione);
            this.container.Controls.Add(this.editData);
            this.container.Controls.Add(this.editCommessa);
            this.container.Size = new System.Drawing.Size(923, 680);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editCommessa, 0);
            this.container.Controls.SetChildIndex(this.editData, 0);
            this.container.Controls.SetChildIndex(this.editDenominazione, 0);
            this.container.Controls.SetChildIndex(this.editTotaleFattureAcquisto, 0);
            this.container.Controls.SetChildIndex(this.editTotaleFattureVendita, 0);
            this.container.Controls.SetChildIndex(this.editCodice, 0);
            this.container.Controls.SetChildIndex(this.lblFatturato, 0);
            this.container.Controls.SetChildIndex(this.lblPagamenti, 0);
            this.container.Controls.SetChildIndex(this.editTotalePagamenti, 0);
            this.container.Controls.SetChildIndex(this.editTotaleIncassi, 0);
            this.container.Controls.SetChildIndex(this.lblAndamento, 0);
            this.container.Controls.SetChildIndex(this.editStato, 0);
            this.container.Controls.SetChildIndex(this.editNote, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(666, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(610, 3);
            // 
            // panelCommands
            // 
            this.panelCommands.Controls.Add(this.btnCalcoloSAL);
            this.panelCommands.Size = new System.Drawing.Size(101, 727);
            this.panelCommands.Controls.SetChildIndex(this.btnHome, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnClose, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnSave, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnUpdateCancel, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnDelete, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnCalcoloSAL, 0);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 655);
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
            this.editCommessa.Location = new System.Drawing.Point(25, 75);
            this.editCommessa.Model = null;
            this.editCommessa.Name = "editCommessa";
            this.editCommessa.ReadOnly = false;
            this.editCommessa.Required = true;
            this.editCommessa.Size = new System.Drawing.Size(800, 30);
            this.editCommessa.TabIndex = 0;
            this.editCommessa.Text = "EditControl";
            this.editCommessa.Value = null;
            this.editCommessa.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editCommessa_ComboConfirm);
            this.editCommessa.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editCommessa_ComboClick);
            // 
            // editData
            // 
            this.editData.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editData.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editData.BackColor = System.Drawing.Color.Transparent;
            this.editData.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editData.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editData.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editData.Changed = true;
            this.editData.Editing = false;
            this.editData.Label = "Data";
            this.editData.LabelWidth = 175;
            this.editData.Location = new System.Drawing.Point(25, 201);
            this.editData.Name = "editData";
            this.editData.ReadOnly = false;
            this.editData.Required = true;
            this.editData.Size = new System.Drawing.Size(798, 30);
            this.editData.TabIndex = 2;
            this.editData.Text = "EditControl";
            this.editData.Value = null;
            this.editData.Confirm += new Library.Template.Controls.TemplateEditDate.ConfirmHanlder(this.editData_Confirm);
            // 
            // editDenominazione
            // 
            this.editDenominazione.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editDenominazione.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editDenominazione.BackColor = System.Drawing.Color.Transparent;
            this.editDenominazione.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editDenominazione.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editDenominazione.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editDenominazione.Changed = true;
            this.editDenominazione.Editing = false;
            this.editDenominazione.Label = "Denominazione";
            this.editDenominazione.LabelWidth = 175;
            this.editDenominazione.Location = new System.Drawing.Point(25, 159);
            this.editDenominazione.Name = "editDenominazione";
            this.editDenominazione.ReadOnly = false;
            this.editDenominazione.Required = true;
            this.editDenominazione.Size = new System.Drawing.Size(798, 30);
            this.editDenominazione.TabIndex = 6;
            this.editDenominazione.Text = "EditControl";
            this.editDenominazione.Value = null;
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
            this.editTotaleFattureAcquisto.Label = "Fatture fornitori";
            this.editTotaleFattureAcquisto.LabelWidth = 175;
            this.editTotaleFattureAcquisto.Location = new System.Drawing.Point(25, 327);
            this.editTotaleFattureAcquisto.Name = "editTotaleFattureAcquisto";
            this.editTotaleFattureAcquisto.ReadOnly = false;
            this.editTotaleFattureAcquisto.Required = false;
            this.editTotaleFattureAcquisto.Size = new System.Drawing.Size(798, 30);
            this.editTotaleFattureAcquisto.TabIndex = 3;
            this.editTotaleFattureAcquisto.Text = "TemplateEditNumeric";
            this.editTotaleFattureAcquisto.Value = null;
            // 
            // editTotaleFattureVendita
            // 
            this.editTotaleFattureVendita.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTotaleFattureVendita.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTotaleFattureVendita.BackColor = System.Drawing.Color.Transparent;
            this.editTotaleFattureVendita.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTotaleFattureVendita.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTotaleFattureVendita.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTotaleFattureVendita.Changed = true;
            this.editTotaleFattureVendita.Editing = false;
            this.editTotaleFattureVendita.Label = "Fatture committente";
            this.editTotaleFattureVendita.LabelWidth = 175;
            this.editTotaleFattureVendita.Location = new System.Drawing.Point(25, 369);
            this.editTotaleFattureVendita.Name = "editTotaleFattureVendite";
            this.editTotaleFattureVendita.ReadOnly = false;
            this.editTotaleFattureVendita.Required = false;
            this.editTotaleFattureVendita.Size = new System.Drawing.Size(798, 30);
            this.editTotaleFattureVendita.TabIndex = 4;
            this.editTotaleFattureVendita.Text = "TemplateEditNumeric";
            this.editTotaleFattureVendita.Value = null;
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
            this.editCodice.Location = new System.Drawing.Point(25, 117);
            this.editCodice.Name = "editCodice";
            this.editCodice.ReadOnly = false;
            this.editCodice.Required = true;
            this.editCodice.Size = new System.Drawing.Size(798, 30);
            this.editCodice.TabIndex = 1000;
            this.editCodice.Text = "EditControl";
            this.editCodice.Value = null;
            // 
            // lblFatturato
            // 
            this.lblFatturato.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblFatturato.BackColor = System.Drawing.Color.Gainsboro;
            this.lblFatturato.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatturato.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFatturato.Location = new System.Drawing.Point(13, 285);
            this.lblFatturato.Name = "lblFatturato";
            this.lblFatturato.Size = new System.Drawing.Size(887, 30);
            this.lblFatturato.TabIndex = 1001;
            this.lblFatturato.Text = "TOTALE FATTURATO";
            this.lblFatturato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPagamenti
            // 
            this.lblPagamenti.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblPagamenti.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPagamenti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagamenti.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPagamenti.Location = new System.Drawing.Point(13, 411);
            this.lblPagamenti.Name = "lblPagamenti";
            this.lblPagamenti.Size = new System.Drawing.Size(887, 30);
            this.lblPagamenti.TabIndex = 1001;
            this.lblPagamenti.Text = "TOTALE  PAGAMENTI";
            this.lblPagamenti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.editTotalePagamenti.Label = "Pagamenti fornitori";
            this.editTotalePagamenti.LabelWidth = 175;
            this.editTotalePagamenti.Location = new System.Drawing.Point(25, 453);
            this.editTotalePagamenti.Name = "editTotalePagamenti";
            this.editTotalePagamenti.ReadOnly = false;
            this.editTotalePagamenti.Required = false;
            this.editTotalePagamenti.Size = new System.Drawing.Size(798, 30);
            this.editTotalePagamenti.TabIndex = 3;
            this.editTotalePagamenti.Text = "TemplateEditNumeric";
            this.editTotalePagamenti.Value = null;
            // 
            // editTotaleIncassi
            // 
            this.editTotaleIncassi.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTotaleIncassi.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTotaleIncassi.BackColor = System.Drawing.Color.Transparent;
            this.editTotaleIncassi.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTotaleIncassi.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTotaleIncassi.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTotaleIncassi.Changed = true;
            this.editTotaleIncassi.Editing = false;
            this.editTotaleIncassi.Label = "Incassi committente";
            this.editTotaleIncassi.LabelWidth = 175;
            this.editTotaleIncassi.Location = new System.Drawing.Point(25, 495);
            this.editTotaleIncassi.Name = "editTotaleIncassi";
            this.editTotaleIncassi.ReadOnly = false;
            this.editTotaleIncassi.Required = false;
            this.editTotaleIncassi.Size = new System.Drawing.Size(798, 30);
            this.editTotaleIncassi.TabIndex = 3;
            this.editTotaleIncassi.Text = "TemplateEditNumeric";
            this.editTotaleIncassi.Value = null;
            // 
            // lblAndamento
            // 
            this.lblAndamento.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblAndamento.BackColor = System.Drawing.Color.Gainsboro;
            this.lblAndamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAndamento.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAndamento.Location = new System.Drawing.Point(13, 537);
            this.lblAndamento.Name = "lblAndamento";
            this.lblAndamento.Size = new System.Drawing.Size(887, 30);
            this.lblAndamento.TabIndex = 1001;
            this.lblAndamento.Text = "ANDAMENTO DEL LAVORO";
            this.lblAndamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalcoloSAL
            // 
            this.btnCalcoloSAL.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnCalcoloSAL.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcoloSAL.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnCalcoloSAL.ImageButton = "";
            this.btnCalcoloSAL.ImageSeparator = "Images.separator_ht_small.png";
            this.btnCalcoloSAL.Location = new System.Drawing.Point(0, 288);
            this.btnCalcoloSAL.Name = "btnCalcoloSAL";
            this.btnCalcoloSAL.Size = new System.Drawing.Size(100, 72);
            this.btnCalcoloSAL.TabIndex = 1002;
            this.btnCalcoloSAL.TextButton = "Calcolo SAL";
            this.btnCalcoloSAL.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnCalcoloSAL_Click);
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
            this.editStato.Location = new System.Drawing.Point(25, 579);
            this.editStato.Name = "editStato";
            this.editStato.ReadOnly = false;
            this.editStato.Required = false;
            this.editStato.Size = new System.Drawing.Size(798, 49);
            this.editStato.TabIndex = 1002;
            this.editStato.Text = "TemplateEditNumeric";
            this.editStato.Value = "None{;}";
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
            this.editNote.Location = new System.Drawing.Point(25, 243);
            this.editNote.Name = "editNote";
            this.editNote.ReadOnly = false;
            this.editNote.Required = false;
            this.editNote.Size = new System.Drawing.Size(798, 30);
            this.editNote.TabIndex = 2;
            this.editNote.Text = "EditControl";
            this.editNote.Value = null;
            // 
            // SALModel
            // 
            this.Size = new System.Drawing.Size(1024, 727);
            this.Load += new System.EventHandler(this.SALModel_Load);
            this.Controls.SetChildIndex(this.panelCommands, 0);
            this.Controls.SetChildIndex(this.container, 0);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditText editDenominazione;
        private Library.Template.Controls.TemplateEditDate editData;
        private Library.Template.Controls.TemplateEditCombo editCommessa;
        private Library.Template.Controls.TemplateEditDecimal editTotaleFattureVendita;
        private Library.Template.Controls.TemplateEditDecimal editTotaleFattureAcquisto;
        private Library.Template.Controls.TemplateEditText editCodice;
        private Gizmox.WebGUI.Forms.Label lblPagamenti;
        private Gizmox.WebGUI.Forms.Label lblFatturato;
        private Library.Template.Controls.TemplateEditDecimal editTotaleIncassi;
        private Library.Template.Controls.TemplateEditDecimal editTotalePagamenti;
        private Gizmox.WebGUI.Forms.Label lblAndamento;
        private Library.Controls.ButtonSeparatorV btnCalcoloSAL;
        private Library.Template.Controls.TemplateEditState editStato;
        private Library.Template.Controls.TemplateEditText editNote;


    }
}
