using System.Drawing;

namespace Web.GUI.FatturaVendita
{
    partial class FatturaVenditaModel
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
            this.editDescrizione = new Library.Template.Controls.TemplateEditText();
            this.editNumero = new Library.Template.Controls.TemplateEditText();
            this.editData = new Library.Template.Controls.TemplateEditDate();
            this.editCommittente = new Library.Template.Controls.TemplateEditCombo();
            this.editTotale = new Library.Template.Controls.TemplateEditDecimal();
            this.editIVA = new Library.Template.Controls.TemplateEditDecimal();
            this.editImponibile = new Library.Template.Controls.TemplateEditDecimal();
            this.editScadenzaPagamento = new Library.Template.Controls.TemplateEditDropDown();
            this.editTipoPagamento = new Library.Template.Controls.TemplateEditDropDown();
            this.editTotaleIncassi = new Library.Template.Controls.TemplateEditDecimal();
            this.lblAndamento = new Gizmox.WebGUI.Forms.Label();
            this.editStato = new Library.Template.Controls.TemplateEditState();
            this.btnCalcoloTotali = new Library.Controls.ButtonSeparatorV();
            this.editNote = new Library.Template.Controls.TemplateEditText();
            this.btnIncassi = new Library.Controls.ButtonSeparatorV();
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
            this.container.Controls.Add(this.editTipoPagamento);
            this.container.Controls.Add(this.editScadenzaPagamento);
            this.container.Controls.Add(this.editImponibile);
            this.container.Controls.Add(this.editIVA);
            this.container.Controls.Add(this.editTotale);
            this.container.Controls.Add(this.editCommittente);
            this.container.Controls.Add(this.editData);
            this.container.Controls.Add(this.editNumero);
            this.container.Controls.Add(this.editDescrizione);
            this.container.Size = new System.Drawing.Size(923, 677);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editDescrizione, 0);
            this.container.Controls.SetChildIndex(this.editNumero, 0);
            this.container.Controls.SetChildIndex(this.editData, 0);
            this.container.Controls.SetChildIndex(this.editCommittente, 0);
            this.container.Controls.SetChildIndex(this.editTotale, 0);
            this.container.Controls.SetChildIndex(this.editIVA, 0);
            this.container.Controls.SetChildIndex(this.editImponibile, 0);
            this.container.Controls.SetChildIndex(this.editScadenzaPagamento, 0);
            this.container.Controls.SetChildIndex(this.editTipoPagamento, 0);
            this.container.Controls.SetChildIndex(this.editTotaleIncassi, 0);
            this.container.Controls.SetChildIndex(this.lblAndamento, 0);
            this.container.Controls.SetChildIndex(this.editStato, 0);
            this.container.Controls.SetChildIndex(this.editNote, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(664, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(608, 3);
            // 
            // panelCommands
            // 
            this.panelCommands.Controls.Add(this.btnIncassi);
            this.panelCommands.Controls.Add(this.btnCalcoloTotali);
            this.panelCommands.Size = new System.Drawing.Size(101, 724);
            this.panelCommands.Controls.SetChildIndex(this.btnClose, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnSave, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnUpdateCancel, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnDelete, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnCalcoloTotali, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnIncassi, 0);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 652);
            // 
            // editDescrizione
            // 
            this.editDescrizione.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editDescrizione.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editDescrizione.BackColor = System.Drawing.Color.Transparent;
            this.editDescrizione.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editDescrizione.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editDescrizione.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editDescrizione.Changed = true;
            this.editDescrizione.Editing = false;
            this.editDescrizione.Label = "Descrizione";
            this.editDescrizione.LabelWidth = 175;
            this.editDescrizione.Location = new System.Drawing.Point(25, 280);
            this.editDescrizione.Name = "editDescrizione";
            this.editDescrizione.ReadOnly = false;
            this.editDescrizione.Required = false;
            this.editDescrizione.Size = new System.Drawing.Size(796, 30);
            this.editDescrizione.TabIndex = 4;
            this.editDescrizione.Text = "EditControl";
            this.editDescrizione.Value = null;
            // 
            // editNumero
            // 
            this.editNumero.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editNumero.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editNumero.BackColor = System.Drawing.Color.Transparent;
            this.editNumero.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editNumero.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editNumero.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editNumero.Changed = true;
            this.editNumero.Editing = false;
            this.editNumero.Label = "Numero";
            this.editNumero.LabelWidth = 175;
            this.editNumero.Location = new System.Drawing.Point(25, 157);
            this.editNumero.Name = "editNumero";
            this.editNumero.ReadOnly = false;
            this.editNumero.Required = false;
            this.editNumero.Size = new System.Drawing.Size(796, 30);
            this.editNumero.TabIndex = 2;
            this.editNumero.Text = "EditControl";
            this.editNumero.Value = null;
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
            this.editData.Location = new System.Drawing.Point(25, 116);
            this.editData.Name = "editData";
            this.editData.ReadOnly = false;
            this.editData.Required = false;
            this.editData.Size = new System.Drawing.Size(796, 30);
            this.editData.TabIndex = 1;
            this.editData.Text = "EditControl";
            this.editData.Value = null;
            // 
            // editCommittente
            // 
            this.editCommittente.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editCommittente.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editCommittente.BackColor = System.Drawing.Color.Transparent;
            this.editCommittente.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editCommittente.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editCommittente.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editCommittente.Changed = true;
            this.editCommittente.Editing = false;
            this.editCommittente.Label = "Committente";
            this.editCommittente.LabelWidth = 175;
            this.editCommittente.Location = new System.Drawing.Point(25, 75);
            this.editCommittente.Model = null;
            this.editCommittente.Name = "editCommittente";
            this.editCommittente.ReadOnly = false;
            this.editCommittente.Required = false;
            this.editCommittente.Size = new System.Drawing.Size(798, 30);
            this.editCommittente.TabIndex = 0;
            this.editCommittente.Text = "EditControl";
            this.editCommittente.Value = null;
            this.editCommittente.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editCommittente_ComboConfirm);
            this.editCommittente.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editCommittente_ComboClick);
            // 
            // editTotale
            // 
            this.editTotale.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTotale.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTotale.BackColor = System.Drawing.Color.Transparent;
            this.editTotale.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTotale.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTotale.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTotale.Changed = true;
            this.editTotale.Editing = false;
            this.editTotale.Label = "Totale";
            this.editTotale.LabelWidth = 175;
            this.editTotale.Location = new System.Drawing.Point(25, 403);
            this.editTotale.Name = "editTotale";
            this.editTotale.ReadOnly = false;
            this.editTotale.Required = false;
            this.editTotale.Size = new System.Drawing.Size(796, 30);
            this.editTotale.TabIndex = 7;
            this.editTotale.Text = "TemplateEditNumeric";
            this.editTotale.Value = null;
            // 
            // editIVA
            // 
            this.editIVA.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editIVA.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editIVA.BackColor = System.Drawing.Color.Transparent;
            this.editIVA.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editIVA.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editIVA.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editIVA.Changed = true;
            this.editIVA.Editing = false;
            this.editIVA.Label = "IVA";
            this.editIVA.LabelWidth = 175;
            this.editIVA.Location = new System.Drawing.Point(25, 362);
            this.editIVA.Name = "editIVA";
            this.editIVA.ReadOnly = false;
            this.editIVA.Required = false;
            this.editIVA.Size = new System.Drawing.Size(796, 30);
            this.editIVA.TabIndex = 6;
            this.editIVA.Text = "TemplateEditNumeric";
            this.editIVA.Value = null;
            this.editIVA.Leave += new System.EventHandler(this.editImponibileIVA_Leave);
            // 
            // editImponibile
            // 
            this.editImponibile.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editImponibile.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editImponibile.BackColor = System.Drawing.Color.Transparent;
            this.editImponibile.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editImponibile.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editImponibile.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editImponibile.Changed = true;
            this.editImponibile.Editing = false;
            this.editImponibile.Label = "Imponibile";
            this.editImponibile.LabelWidth = 175;
            this.editImponibile.Location = new System.Drawing.Point(25, 321);
            this.editImponibile.Name = "editImponibile";
            this.editImponibile.ReadOnly = false;
            this.editImponibile.Required = false;
            this.editImponibile.Size = new System.Drawing.Size(796, 30);
            this.editImponibile.TabIndex = 5;
            this.editImponibile.Text = "TemplateEditNumeric";
            this.editImponibile.Value = null;
            this.editImponibile.Leave += new System.EventHandler(this.editImponibileIVA_Leave);
            // 
            // editScadenzaPagamento
            // 
            this.editScadenzaPagamento.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editScadenzaPagamento.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editScadenzaPagamento.BackColor = System.Drawing.Color.Transparent;
            this.editScadenzaPagamento.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editScadenzaPagamento.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editScadenzaPagamento.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editScadenzaPagamento.Changed = true;
            this.editScadenzaPagamento.DisplayValues = null;
            this.editScadenzaPagamento.Editing = false;
            this.editScadenzaPagamento.Items = null;
            this.editScadenzaPagamento.Label = "Scadenza pagamento";
            this.editScadenzaPagamento.LabelWidth = 175;
            this.editScadenzaPagamento.Location = new System.Drawing.Point(25, 239);
            this.editScadenzaPagamento.Name = "editScadenzaPagamento";
            this.editScadenzaPagamento.ReadOnly = false;
            this.editScadenzaPagamento.Required = false;
            this.editScadenzaPagamento.Size = new System.Drawing.Size(796, 30);
            this.editScadenzaPagamento.TabIndex = 4;
            this.editScadenzaPagamento.Text = "EditControl";
            this.editScadenzaPagamento.Value = null;
            // 
            // editTipoPagamento
            // 
            this.editTipoPagamento.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTipoPagamento.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTipoPagamento.BackColor = System.Drawing.Color.Transparent;
            this.editTipoPagamento.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTipoPagamento.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTipoPagamento.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTipoPagamento.Changed = true;
            this.editTipoPagamento.DisplayValues = null;
            this.editTipoPagamento.Editing = false;
            this.editTipoPagamento.Items = null;
            this.editTipoPagamento.Label = "Tipo pagamento";
            this.editTipoPagamento.LabelWidth = 175;
            this.editTipoPagamento.Location = new System.Drawing.Point(25, 198);
            this.editTipoPagamento.Name = "editTipoPagamento";
            this.editTipoPagamento.ReadOnly = false;
            this.editTipoPagamento.Required = false;
            this.editTipoPagamento.Size = new System.Drawing.Size(796, 30);
            this.editTipoPagamento.TabIndex = 3;
            this.editTipoPagamento.Text = "EditControl";
            this.editTipoPagamento.Value = null;
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
            this.editTotaleIncassi.Label = "Totale incassi";
            this.editTotaleIncassi.LabelWidth = 175;
            this.editTotaleIncassi.Location = new System.Drawing.Point(25, 526);
            this.editTotaleIncassi.Name = "editTotaleIncassi";
            this.editTotaleIncassi.ReadOnly = false;
            this.editTotaleIncassi.Required = false;
            this.editTotaleIncassi.Size = new System.Drawing.Size(796, 30);
            this.editTotaleIncassi.TabIndex = 11;
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
            this.lblAndamento.Location = new System.Drawing.Point(13, 485);
            this.lblAndamento.Name = "lblAndamento";
            this.lblAndamento.Size = new System.Drawing.Size(885, 30);
            this.lblAndamento.TabIndex = 1001;
            this.lblAndamento.Text = "SITUAZIONE INCASSI";
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
            this.editStato.Location = new System.Drawing.Point(25, 567);
            this.editStato.Name = "editStato";
            this.editStato.ReadOnly = false;
            this.editStato.Required = false;
            this.editStato.Size = new System.Drawing.Size(796, 50);
            this.editStato.TabIndex = 12;
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
            this.btnCalcoloTotali.Location = new System.Drawing.Point(0, 360);
            this.btnCalcoloTotali.Name = "btnCalcoloTotali";
            this.btnCalcoloTotali.Size = new System.Drawing.Size(100, 72);
            this.btnCalcoloTotali.TabIndex = 1002;
            this.btnCalcoloTotali.TextButton = "Calcolo Totali";
            this.btnCalcoloTotali.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnCalcoloTotali_Click);
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
            this.editNote.Location = new System.Drawing.Point(25, 444);
            this.editNote.Name = "editNote";
            this.editNote.ReadOnly = false;
            this.editNote.Required = false;
            this.editNote.Size = new System.Drawing.Size(796, 30);
            this.editNote.TabIndex = 10;
            this.editNote.Text = "EditControl";
            this.editNote.Value = null;
            // 
            // btnIncassi
            // 
            this.btnIncassi.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnIncassi.BackColor = System.Drawing.Color.Transparent;
            this.btnIncassi.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnIncassi.ImageButton = "";
            this.btnIncassi.ImageSeparator = "Images.separator_ht_small.png";
            this.btnIncassi.Location = new System.Drawing.Point(0, 288);
            this.btnIncassi.Name = "btnIncassi";
            this.btnIncassi.Size = new System.Drawing.Size(100, 72);
            this.btnIncassi.TabIndex = 1002;
            this.btnIncassi.TextButton = "Incassi";
            this.btnIncassi.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnIncassi_Click);
            // 
            // FatturaVenditaModel
            // 
            this.Size = new System.Drawing.Size(1024, 724);
            this.Load += new System.EventHandler(this.FatturaVenditaModel_Load);
            this.Controls.SetChildIndex(this.panelCommands, 0);
            this.Controls.SetChildIndex(this.container, 0);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditCombo editCommittente;
        private Library.Template.Controls.TemplateEditDate editData;
        private Library.Template.Controls.TemplateEditText editNumero;
        private Library.Template.Controls.TemplateEditText editDescrizione;
        private Library.Template.Controls.TemplateEditDecimal editImponibile;
        private Library.Template.Controls.TemplateEditDecimal editIVA;
        private Library.Template.Controls.TemplateEditDecimal editTotale;
        private Library.Template.Controls.TemplateEditDropDown editTipoPagamento;
        private Library.Template.Controls.TemplateEditDropDown editScadenzaPagamento;
        private Library.Template.Controls.TemplateEditState editStato;
        private Gizmox.WebGUI.Forms.Label lblAndamento;
        private Library.Template.Controls.TemplateEditDecimal editTotaleIncassi;
        private Library.Controls.ButtonSeparatorV btnCalcoloTotali;
        private Library.Template.Controls.TemplateEditText editNote;
        private Library.Controls.ButtonSeparatorV btnIncassi;


    }
}
