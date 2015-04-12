using System.Drawing;

namespace Web.GUI.FatturaAcquisto
{
    partial class FatturaAcquistoModel
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
            this.editFornitore = new Library.Template.Controls.TemplateEditCombo();
            this.editData = new Library.Template.Controls.TemplateEditDate();
            this.editNumero = new Library.Template.Controls.TemplateEditText();
            this.editDescrizione = new Library.Template.Controls.TemplateEditText();
            this.editImponibile = new Library.Template.Controls.TemplateEditDecimal();
            this.editIVA = new Library.Template.Controls.TemplateEditDecimal();
            this.editTotale = new Library.Template.Controls.TemplateEditDecimal();
            this.editTipoPagamento = new Library.Template.Controls.TemplateEditDropDown();
            this.editScadenzaPagamento = new Library.Template.Controls.TemplateEditDropDown();
            this.editCentroCosto = new Library.Template.Controls.TemplateEditCombo();
            this.editStato = new Library.Template.Controls.TemplateEditState();
            this.lblAndamento = new Gizmox.WebGUI.Forms.Label();
            this.editTotalePagamenti = new Library.Template.Controls.TemplateEditDecimal();
            this.btnCalcoloTotali = new Library.Controls.ButtonSeparatorV();
            this.editNote = new Library.Template.Controls.TemplateEditText();
            this.btnPagamenti = new Library.Controls.ButtonSeparatorV();
            this.editSconto = new Library.Template.Controls.TemplateEditDecimal();
            this.editTotaleResi = new Library.Template.Controls.TemplateEditDecimal();
            this.btnResi = new Library.Controls.ButtonSeparatorV();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editTotaleResi);
            this.container.Controls.Add(this.editSconto);
            this.container.Controls.Add(this.editNote);
            this.container.Controls.Add(this.editTotalePagamenti);
            this.container.Controls.Add(this.lblAndamento);
            this.container.Controls.Add(this.editStato);
            this.container.Controls.Add(this.editCentroCosto);
            this.container.Controls.Add(this.editScadenzaPagamento);
            this.container.Controls.Add(this.editTipoPagamento);
            this.container.Controls.Add(this.editTotale);
            this.container.Controls.Add(this.editIVA);
            this.container.Controls.Add(this.editImponibile);
            this.container.Controls.Add(this.editDescrizione);
            this.container.Controls.Add(this.editNumero);
            this.container.Controls.Add(this.editData);
            this.container.Controls.Add(this.editFornitore);
            this.container.Size = new System.Drawing.Size(923, 686);
            this.container.TabIndex = 0;
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editFornitore, 0);
            this.container.Controls.SetChildIndex(this.editData, 0);
            this.container.Controls.SetChildIndex(this.editNumero, 0);
            this.container.Controls.SetChildIndex(this.editDescrizione, 0);
            this.container.Controls.SetChildIndex(this.editImponibile, 0);
            this.container.Controls.SetChildIndex(this.editIVA, 0);
            this.container.Controls.SetChildIndex(this.editTotale, 0);
            this.container.Controls.SetChildIndex(this.editTipoPagamento, 0);
            this.container.Controls.SetChildIndex(this.editScadenzaPagamento, 0);
            this.container.Controls.SetChildIndex(this.editCentroCosto, 0);
            this.container.Controls.SetChildIndex(this.editStato, 0);
            this.container.Controls.SetChildIndex(this.lblAndamento, 0);
            this.container.Controls.SetChildIndex(this.editTotalePagamenti, 0);
            this.container.Controls.SetChildIndex(this.editNote, 0);
            this.container.Controls.SetChildIndex(this.editSconto, 0);
            this.container.Controls.SetChildIndex(this.editTotaleResi, 0);
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
            this.panelCommands.Controls.Add(this.btnResi);
            this.panelCommands.Controls.Add(this.btnPagamenti);
            this.panelCommands.Controls.Add(this.btnCalcoloTotali);
            this.panelCommands.Size = new System.Drawing.Size(101, 733);
            this.panelCommands.Controls.SetChildIndex(this.btnHome, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnClose, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnSave, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnUpdateCancel, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnDelete, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnCalcoloTotali, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnPagamenti, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnResi, 0);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 661);
            // 
            // editFornitore
            // 
            this.editFornitore.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editFornitore.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editFornitore.BackColor = System.Drawing.Color.Transparent;
            this.editFornitore.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editFornitore.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editFornitore.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editFornitore.Changed = true;
            this.editFornitore.Editing = false;
            this.editFornitore.Label = "Fornitore";
            this.editFornitore.LabelWidth = 175;
            this.editFornitore.Location = new System.Drawing.Point(25, 75);
            this.editFornitore.Model = null;
            this.editFornitore.Name = "editFornitore";
            this.editFornitore.ReadOnly = false;
            this.editFornitore.Required = true;
            this.editFornitore.Size = new System.Drawing.Size(796, 30);
            this.editFornitore.TabIndex = 0;
            this.editFornitore.Text = "EditControl";
            this.editFornitore.Value = null;
            this.editFornitore.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editFornitore_ComboConfirm);
            this.editFornitore.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editFornitore_ComboClick);
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
            this.editData.Location = new System.Drawing.Point(25, 147);
            this.editData.Name = "editData";
            this.editData.ReadOnly = false;
            this.editData.Required = true;
            this.editData.Size = new System.Drawing.Size(796, 30);
            this.editData.TabIndex = 2;
            this.editData.Text = "EditControl";
            this.editData.Value = null;
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
            this.editNumero.Location = new System.Drawing.Point(25, 183);
            this.editNumero.Name = "editNumero";
            this.editNumero.ReadOnly = false;
            this.editNumero.Required = true;
            this.editNumero.Size = new System.Drawing.Size(796, 30);
            this.editNumero.TabIndex = 3;
            this.editNumero.Text = "EditControl";
            this.editNumero.Value = null;
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
            this.editDescrizione.Location = new System.Drawing.Point(25, 291);
            this.editDescrizione.Name = "editDescrizione";
            this.editDescrizione.ReadOnly = false;
            this.editDescrizione.Required = false;
            this.editDescrizione.Size = new System.Drawing.Size(796, 30);
            this.editDescrizione.TabIndex = 6;
            this.editDescrizione.Text = "EditControl";
            this.editDescrizione.Value = null;
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
            this.editImponibile.Location = new System.Drawing.Point(25, 327);
            this.editImponibile.Name = "editImponibile";
            this.editImponibile.ReadOnly = false;
            this.editImponibile.Required = true;
            this.editImponibile.Size = new System.Drawing.Size(796, 30);
            this.editImponibile.TabIndex = 7;
            this.editImponibile.Text = "TemplateEditNumeric";
            this.editImponibile.Value = null;
            this.editImponibile.Leave += new System.EventHandler(this.editImponibileIVA_Leave);
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
            this.editIVA.Location = new System.Drawing.Point(25, 363);
            this.editIVA.Name = "editIVA";
            this.editIVA.ReadOnly = false;
            this.editIVA.Required = true;
            this.editIVA.Size = new System.Drawing.Size(796, 30);
            this.editIVA.TabIndex = 8;
            this.editIVA.Text = "TemplateEditNumeric";
            this.editIVA.Value = null;
            this.editIVA.Leave += new System.EventHandler(this.editImponibileIVA_Leave);
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
            this.editTotale.Location = new System.Drawing.Point(25, 399);
            this.editTotale.Name = "editTotale";
            this.editTotale.ReadOnly = false;
            this.editTotale.Required = false;
            this.editTotale.Size = new System.Drawing.Size(796, 30);
            this.editTotale.TabIndex = 9;
            this.editTotale.Text = "TemplateEditNumeric";
            this.editTotale.Value = null;
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
            this.editTipoPagamento.Location = new System.Drawing.Point(25, 219);
            this.editTipoPagamento.Name = "editTipoPagamento";
            this.editTipoPagamento.ReadOnly = false;
            this.editTipoPagamento.Required = true;
            this.editTipoPagamento.Size = new System.Drawing.Size(796, 30);
            this.editTipoPagamento.TabIndex = 4;
            this.editTipoPagamento.Text = "EditControl";
            this.editTipoPagamento.Value = null;
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
            this.editScadenzaPagamento.Label = "Scadenza";
            this.editScadenzaPagamento.LabelWidth = 175;
            this.editScadenzaPagamento.Location = new System.Drawing.Point(25, 255);
            this.editScadenzaPagamento.Name = "editScadenzaPagamento";
            this.editScadenzaPagamento.ReadOnly = false;
            this.editScadenzaPagamento.Required = true;
            this.editScadenzaPagamento.Size = new System.Drawing.Size(796, 30);
            this.editScadenzaPagamento.TabIndex = 5;
            this.editScadenzaPagamento.Text = "EditControl";
            this.editScadenzaPagamento.Value = null;
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
            this.editCentroCosto.Changed = true;
            this.editCentroCosto.Editing = false;
            this.editCentroCosto.Label = "Centro di Costo";
            this.editCentroCosto.LabelWidth = 175;
            this.editCentroCosto.Location = new System.Drawing.Point(25, 111);
            this.editCentroCosto.Model = null;
            this.editCentroCosto.Name = "editCentroCosto";
            this.editCentroCosto.ReadOnly = false;
            this.editCentroCosto.Required = true;
            this.editCentroCosto.Size = new System.Drawing.Size(796, 30);
            this.editCentroCosto.TabIndex = 1;
            this.editCentroCosto.Text = "EditControl";
            this.editCentroCosto.Value = null;
            this.editCentroCosto.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editCentroCosto_ComboConfirm);
            this.editCentroCosto.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editCentroCosto_ComboClick);
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
            this.editStato.Location = new System.Drawing.Point(25, 623);
            this.editStato.Name = "editStato";
            this.editStato.ReadOnly = false;
            this.editStato.Required = false;
            this.editStato.Size = new System.Drawing.Size(796, 50);
            this.editStato.TabIndex = 14;
            this.editStato.Text = "TemplateEditNumeric";
            this.editStato.Value = "None{;}";
            // 
            // lblAndamento
            // 
            this.lblAndamento.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblAndamento.BackColor = System.Drawing.Color.Gainsboro;
            this.lblAndamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAndamento.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAndamento.Location = new System.Drawing.Point(25, 507);
            this.lblAndamento.Name = "lblAndamento";
            this.lblAndamento.Size = new System.Drawing.Size(887, 30);
            this.lblAndamento.TabIndex = 1001;
            this.lblAndamento.Text = "SITUAZIONE PAGAMENTI";
            this.lblAndamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.editTotalePagamenti.Location = new System.Drawing.Point(25, 545);
            this.editTotalePagamenti.Name = "templateEditDecimal1";
            this.editTotalePagamenti.ReadOnly = false;
            this.editTotalePagamenti.Required = false;
            this.editTotalePagamenti.Size = new System.Drawing.Size(796, 30);
            this.editTotalePagamenti.TabIndex = 12;
            this.editTotalePagamenti.Text = "TemplateEditNumeric";
            this.editTotalePagamenti.Value = null;
            // 
            // btnCalcoloTotali
            // 
            this.btnCalcoloTotali.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnCalcoloTotali.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcoloTotali.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnCalcoloTotali.ImageButton = "";
            this.btnCalcoloTotali.ImageSeparator = "Images.separator_ht_small.png";
            this.btnCalcoloTotali.Location = new System.Drawing.Point(0, 432);
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
            this.editNote.Location = new System.Drawing.Point(25, 476);
            this.editNote.Name = "editNote";
            this.editNote.ReadOnly = false;
            this.editNote.Required = false;
            this.editNote.Size = new System.Drawing.Size(796, 30);
            this.editNote.TabIndex = 11;
            this.editNote.Text = "EditControl";
            this.editNote.Value = null;
            // 
            // btnPagamenti
            // 
            this.btnPagamenti.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnPagamenti.BackColor = System.Drawing.Color.Transparent;
            this.btnPagamenti.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnPagamenti.ImageButton = "";
            this.btnPagamenti.ImageSeparator = "Images.separator_ht_small.png";
            this.btnPagamenti.Location = new System.Drawing.Point(0, 288);
            this.btnPagamenti.Name = "btnPagamenti";
            this.btnPagamenti.Size = new System.Drawing.Size(100, 72);
            this.btnPagamenti.TabIndex = 1002;
            this.btnPagamenti.TextButton = "Pagamenti";
            this.btnPagamenti.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnPagamenti_Click);
            // 
            // editSconto
            // 
            this.editSconto.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editSconto.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editSconto.BackColor = System.Drawing.Color.Transparent;
            this.editSconto.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editSconto.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editSconto.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editSconto.Changed = true;
            this.editSconto.Editing = false;
            this.editSconto.Label = "Sconto";
            this.editSconto.LabelWidth = 175;
            this.editSconto.Location = new System.Drawing.Point(25, 435);
            this.editSconto.Name = "editSconto";
            this.editSconto.ReadOnly = false;
            this.editSconto.Required = false;
            this.editSconto.Size = new System.Drawing.Size(798, 30);
            this.editSconto.TabIndex = 10;
            this.editSconto.Text = "TemplateEditNumeric";
            this.editSconto.Value = null;
            // 
            // editTotaleResi
            // 
            this.editTotaleResi.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTotaleResi.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTotaleResi.BackColor = System.Drawing.Color.Transparent;
            this.editTotaleResi.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTotaleResi.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTotaleResi.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTotaleResi.Changed = true;
            this.editTotaleResi.Editing = false;
            this.editTotaleResi.Label = "Totale resi";
            this.editTotaleResi.LabelWidth = 175;
            this.editTotaleResi.Location = new System.Drawing.Point(25, 582);
            this.editTotaleResi.Name = "editTotaleResi";
            this.editTotaleResi.ReadOnly = false;
            this.editTotaleResi.Required = false;
            this.editTotaleResi.Size = new System.Drawing.Size(796, 30);
            this.editTotaleResi.TabIndex = 13;
            this.editTotaleResi.Text = "TemplateEditNumeric";
            this.editTotaleResi.Value = null;
            // 
            // btnResi
            // 
            this.btnResi.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnResi.BackColor = System.Drawing.Color.Transparent;
            this.btnResi.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnResi.ImageButton = "";
            this.btnResi.ImageSeparator = "Images.separator_ht_small.png";
            this.btnResi.Location = new System.Drawing.Point(0, 360);
            this.btnResi.Name = "btnResi";
            this.btnResi.Size = new System.Drawing.Size(100, 72);
            this.btnResi.TabIndex = 1002;
            this.btnResi.TextButton = "Resi";
            this.btnResi.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnResi_Click);
            // 
            // FatturaAcquistoModel
            // 
            this.Size = new System.Drawing.Size(1024, 733);
            this.Load += new System.EventHandler(this.FatturaAcquistoModel_Load);
            this.Controls.SetChildIndex(this.panelCommands, 0);
            this.Controls.SetChildIndex(this.container, 0);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditText editDescrizione;
        private Library.Template.Controls.TemplateEditText editNumero;
        private Library.Template.Controls.TemplateEditDate editData;
        private Library.Template.Controls.TemplateEditCombo editFornitore;
        private Library.Template.Controls.TemplateEditDecimal editTotale;
        private Library.Template.Controls.TemplateEditDecimal editIVA;
        private Library.Template.Controls.TemplateEditDecimal editImponibile;
        private Library.Template.Controls.TemplateEditDropDown editTipoPagamento;
        private Library.Template.Controls.TemplateEditDropDown editScadenzaPagamento;
        private Library.Template.Controls.TemplateEditCombo editCentroCosto;
        private Library.Template.Controls.TemplateEditState editStato;
        private Gizmox.WebGUI.Forms.Label lblAndamento;
        private Library.Template.Controls.TemplateEditDecimal editTotalePagamenti;
        private Library.Controls.ButtonSeparatorV btnCalcoloTotali;
        private Library.Template.Controls.TemplateEditText editNote;
        private Library.Controls.ButtonSeparatorV btnPagamenti;
        private Library.Template.Controls.TemplateEditDecimal editSconto;
        private Library.Template.Controls.TemplateEditDecimal editTotaleResi;
        private Library.Controls.ButtonSeparatorV btnResi;


    }
}
