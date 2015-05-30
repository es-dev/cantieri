using System.Drawing;

namespace Web.GUI.Commessa
{
    partial class CommessaModel
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
            this.editAzienda = new Library.Template.Controls.TemplateEditCombo();
            this.editCreazione = new Library.Template.Controls.TemplateEditDate();
            this.editScadenza = new Library.Template.Controls.TemplateEditDate();
            this.editCAP = new Library.Template.Controls.TemplateEditCap();
            this.editIndirizzo = new Library.Template.Controls.TemplateEditText();
            this.editDenominazione = new Library.Template.Controls.TemplateEditText();
            this.editDescrizione = new Library.Template.Controls.TemplateEditText();
            this.editRiferimento = new Library.Template.Controls.TemplateEditText();
            this.editImporto = new Library.Template.Controls.TemplateEditDecimal();
            this.editCodice = new Library.Template.Controls.TemplateEditText();
            this.editStato = new Library.Template.Controls.TemplateEditDropDown();
            this.editInizioLavori = new Library.Template.Controls.TemplateEditDate();
            this.editFineLavori = new Library.Template.Controls.TemplateEditDate();
            this.editEstremiContratto = new Library.Template.Controls.TemplateEditText();
            this.editPercentualeAvanzamento = new Library.Template.Controls.TemplateEditProgress();
            this.editMargine = new Library.Template.Controls.TemplateEditDecimal();
            this.editImportoAvanzamentoLavori = new Library.Template.Controls.TemplateEditDecimal();
            this.editImportoPerizie = new Library.Template.Controls.TemplateEditDecimal();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.editOggetto = new Library.Template.Controls.TemplateEditText();
            this.btnFornitori = new Library.Controls.ButtonSeparatorV();
            this.btnSAL = new Library.Controls.ButtonSeparatorV();
            this.editComune = new Library.Template.Controls.TemplateEditCountry();
            this.editLocalita = new Library.Template.Controls.TemplateEditText();
            this.editNote = new Library.Template.Controls.TemplateEditText();
            this.btnCalcoloAvanzamentoLavori = new Library.Controls.ButtonSeparatorV();
            this.btnCommittenti = new Library.Controls.ButtonSeparatorV();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editNote);
            this.container.Controls.Add(this.editLocalita);
            this.container.Controls.Add(this.editComune);
            this.container.Controls.Add(this.editOggetto);
            this.container.Controls.Add(this.label4);
            this.container.Controls.Add(this.editImportoPerizie);
            this.container.Controls.Add(this.editPercentualeAvanzamento);
            this.container.Controls.Add(this.label3);
            this.container.Controls.Add(this.editMargine);
            this.container.Controls.Add(this.editInizioLavori);
            this.container.Controls.Add(this.editImportoAvanzamentoLavori);
            this.container.Controls.Add(this.label2);
            this.container.Controls.Add(this.editFineLavori);
            this.container.Controls.Add(this.editIndirizzo);
            this.container.Controls.Add(this.editEstremiContratto);
            this.container.Controls.Add(this.editCAP);
            this.container.Controls.Add(this.editRiferimento);
            this.container.Controls.Add(this.editImporto);
            this.container.Controls.Add(this.label1);
            this.container.Controls.Add(this.editScadenza);
            this.container.Controls.Add(this.editStato);
            this.container.Controls.Add(this.editCodice);
            this.container.Controls.Add(this.editDescrizione);
            this.container.Controls.Add(this.editDenominazione);
            this.container.Controls.Add(this.editCreazione);
            this.container.Controls.Add(this.editAzienda);
            this.container.Size = new System.Drawing.Size(923, 1040);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editAzienda, 0);
            this.container.Controls.SetChildIndex(this.editCreazione, 0);
            this.container.Controls.SetChildIndex(this.editDenominazione, 0);
            this.container.Controls.SetChildIndex(this.editDescrizione, 0);
            this.container.Controls.SetChildIndex(this.editCodice, 0);
            this.container.Controls.SetChildIndex(this.editStato, 0);
            this.container.Controls.SetChildIndex(this.editScadenza, 0);
            this.container.Controls.SetChildIndex(this.label1, 0);
            this.container.Controls.SetChildIndex(this.editImporto, 0);
            this.container.Controls.SetChildIndex(this.editRiferimento, 0);
            this.container.Controls.SetChildIndex(this.editCAP, 0);
            this.container.Controls.SetChildIndex(this.editEstremiContratto, 0);
            this.container.Controls.SetChildIndex(this.editIndirizzo, 0);
            this.container.Controls.SetChildIndex(this.editFineLavori, 0);
            this.container.Controls.SetChildIndex(this.label2, 0);
            this.container.Controls.SetChildIndex(this.editImportoAvanzamentoLavori, 0);
            this.container.Controls.SetChildIndex(this.editInizioLavori, 0);
            this.container.Controls.SetChildIndex(this.editMargine, 0);
            this.container.Controls.SetChildIndex(this.label3, 0);
            this.container.Controls.SetChildIndex(this.editPercentualeAvanzamento, 0);
            this.container.Controls.SetChildIndex(this.editImportoPerizie, 0);
            this.container.Controls.SetChildIndex(this.label4, 0);
            this.container.Controls.SetChildIndex(this.editOggetto, 0);
            this.container.Controls.SetChildIndex(this.editComune, 0);
            this.container.Controls.SetChildIndex(this.editLocalita, 0);
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
            this.panelCommands.Controls.Add(this.btnCommittenti);
            this.panelCommands.Controls.Add(this.btnCalcoloAvanzamentoLavori);
            this.panelCommands.Controls.Add(this.btnSAL);
            this.panelCommands.Controls.Add(this.btnFornitori);
            this.panelCommands.Size = new System.Drawing.Size(101, 1087);
            this.panelCommands.Controls.SetChildIndex(this.btnHome, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnClose, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnSave, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnUpdateCancel, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnDelete, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnFornitori, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnSAL, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnCalcoloAvanzamentoLavori, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnCommittenti, 0);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 1015);
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(1, 216);
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
            this.editAzienda.Location = new System.Drawing.Point(25, 62);
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
            this.editCreazione.Location = new System.Drawing.Point(25, 138);
            this.editCreazione.Name = "editCreazione";
            this.editCreazione.ReadOnly = false;
            this.editCreazione.Required = true;
            this.editCreazione.Size = new System.Drawing.Size(792, 30);
            this.editCreazione.TabIndex = 3;
            this.editCreazione.Text = "TemplateEditData";
            this.editCreazione.Value = null;
            // 
            // editScadenza
            // 
            this.editScadenza.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editScadenza.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editScadenza.BackColor = System.Drawing.Color.Transparent;
            this.editScadenza.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editScadenza.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editScadenza.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editScadenza.Changed = true;
            this.editScadenza.Editing = false;
            this.editScadenza.Label = "Scadenza";
            this.editScadenza.LabelWidth = 175;
            this.editScadenza.Location = new System.Drawing.Point(25, 718);
            this.editScadenza.Name = "editScadenza";
            this.editScadenza.ReadOnly = false;
            this.editScadenza.Required = true;
            this.editScadenza.Size = new System.Drawing.Size(792, 30);
            this.editScadenza.TabIndex = 17;
            this.editScadenza.Text = "TemplateEditData";
            this.editScadenza.Value = null;
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
            this.editCAP.Location = new System.Drawing.Point(25, 394);
            this.editCAP.Name = "editCAP";
            this.editCAP.ReadOnly = false;
            this.editCAP.Required = false;
            this.editCAP.Size = new System.Drawing.Size(792, 30);
            this.editCAP.TabIndex = 9;
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
            this.editIndirizzo.Location = new System.Drawing.Point(25, 358);
            this.editIndirizzo.Name = "editIndirizzo";
            this.editIndirizzo.ReadOnly = false;
            this.editIndirizzo.Required = false;
            this.editIndirizzo.Size = new System.Drawing.Size(792, 30);
            this.editIndirizzo.TabIndex = 8;
            this.editIndirizzo.Text = "EditControl";
            this.editIndirizzo.Value = null;
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
            this.editDenominazione.Location = new System.Drawing.Point(25, 174);
            this.editDenominazione.Name = "editDenominazione";
            this.editDenominazione.ReadOnly = false;
            this.editDenominazione.Required = true;
            this.editDenominazione.Size = new System.Drawing.Size(792, 30);
            this.editDenominazione.TabIndex = 4;
            this.editDenominazione.Text = "EditControl";
            this.editDenominazione.Value = null;
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
            this.editDescrizione.Location = new System.Drawing.Point(25, 210);
            this.editDescrizione.Name = "editDescrizione";
            this.editDescrizione.ReadOnly = false;
            this.editDescrizione.Required = false;
            this.editDescrizione.Size = new System.Drawing.Size(792, 30);
            this.editDescrizione.TabIndex = 5;
            this.editDescrizione.Text = "EditControl";
            this.editDescrizione.Value = null;
            // 
            // editRiferimento
            // 
            this.editRiferimento.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editRiferimento.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editRiferimento.BackColor = System.Drawing.Color.Transparent;
            this.editRiferimento.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editRiferimento.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editRiferimento.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editRiferimento.Changed = true;
            this.editRiferimento.Editing = false;
            this.editRiferimento.Label = "Riferimento";
            this.editRiferimento.LabelWidth = 175;
            this.editRiferimento.Location = new System.Drawing.Point(25, 538);
            this.editRiferimento.Name = "editRiferimento";
            this.editRiferimento.ReadOnly = false;
            this.editRiferimento.Required = false;
            this.editRiferimento.Size = new System.Drawing.Size(792, 30);
            this.editRiferimento.TabIndex = 12;
            this.editRiferimento.Text = "EditControl";
            this.editRiferimento.Value = null;
            // 
            // editImporto
            // 
            this.editImporto.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editImporto.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editImporto.BackColor = System.Drawing.Color.Transparent;
            this.editImporto.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editImporto.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editImporto.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editImporto.Changed = true;
            this.editImporto.Editing = false;
            this.editImporto.Label = "Importo lavori";
            this.editImporto.LabelWidth = 175;
            this.editImporto.Location = new System.Drawing.Point(25, 790);
            this.editImporto.Name = "editImporto";
            this.editImporto.ReadOnly = false;
            this.editImporto.Required = true;
            this.editImporto.Size = new System.Drawing.Size(792, 30);
            this.editImporto.TabIndex = 18;
            this.editImporto.Text = "TemplateEditNumeric";
            this.editImporto.Value = null;
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
            this.editCodice.Location = new System.Drawing.Point(25, 98);
            this.editCodice.Name = "editCodice";
            this.editCodice.ReadOnly = false;
            this.editCodice.Required = true;
            this.editCodice.Size = new System.Drawing.Size(792, 30);
            this.editCodice.TabIndex = 1;
            this.editCodice.Text = "EditControl";
            this.editCodice.Value = null;
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
            this.editStato.DisplayValues = null;
            this.editStato.Editing = false;
            this.editStato.Items = null;
            this.editStato.Label = "Stato";
            this.editStato.LabelWidth = 175;
            this.editStato.Location = new System.Drawing.Point(25, 246);
            this.editStato.Name = "editStato";
            this.editStato.ReadOnly = false;
            this.editStato.Required = false;
            this.editStato.Size = new System.Drawing.Size(792, 30);
            this.editStato.TabIndex = 6;
            this.editStato.Text = "EditControl";
            this.editStato.Value = null;
            // 
            // editInizioLavori
            // 
            this.editInizioLavori.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editInizioLavori.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editInizioLavori.BackColor = System.Drawing.Color.Transparent;
            this.editInizioLavori.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editInizioLavori.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editInizioLavori.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editInizioLavori.Changed = true;
            this.editInizioLavori.Editing = false;
            this.editInizioLavori.Label = "Inizio lavori";
            this.editInizioLavori.LabelWidth = 175;
            this.editInizioLavori.Location = new System.Drawing.Point(25, 646);
            this.editInizioLavori.Name = "editInizioLavori";
            this.editInizioLavori.ReadOnly = false;
            this.editInizioLavori.Required = false;
            this.editInizioLavori.Size = new System.Drawing.Size(792, 30);
            this.editInizioLavori.TabIndex = 15;
            this.editInizioLavori.Text = "EditControl";
            this.editInizioLavori.Value = null;
            // 
            // editFineLavori
            // 
            this.editFineLavori.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editFineLavori.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editFineLavori.BackColor = System.Drawing.Color.Transparent;
            this.editFineLavori.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editFineLavori.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editFineLavori.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editFineLavori.Changed = true;
            this.editFineLavori.Editing = false;
            this.editFineLavori.Label = "Fine lavori";
            this.editFineLavori.LabelWidth = 175;
            this.editFineLavori.Location = new System.Drawing.Point(25, 682);
            this.editFineLavori.Name = "editFineLavori";
            this.editFineLavori.ReadOnly = false;
            this.editFineLavori.Required = false;
            this.editFineLavori.Size = new System.Drawing.Size(792, 30);
            this.editFineLavori.TabIndex = 16;
            this.editFineLavori.Text = "EditControl";
            this.editFineLavori.Value = null;
            // 
            // editEstremiContratto
            // 
            this.editEstremiContratto.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editEstremiContratto.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editEstremiContratto.BackColor = System.Drawing.Color.Transparent;
            this.editEstremiContratto.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editEstremiContratto.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editEstremiContratto.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editEstremiContratto.Changed = true;
            this.editEstremiContratto.Editing = false;
            this.editEstremiContratto.Label = "Estremi del contratto";
            this.editEstremiContratto.LabelWidth = 175;
            this.editEstremiContratto.Location = new System.Drawing.Point(25, 574);
            this.editEstremiContratto.Name = "editEstremiContratto";
            this.editEstremiContratto.ReadOnly = false;
            this.editEstremiContratto.Required = false;
            this.editEstremiContratto.Size = new System.Drawing.Size(792, 30);
            this.editEstremiContratto.TabIndex = 13;
            this.editEstremiContratto.Text = "EditControl";
            this.editEstremiContratto.Value = null;
            // 
            // editPercentualeAvanzamento
            // 
            this.editPercentualeAvanzamento.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editPercentualeAvanzamento.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editPercentualeAvanzamento.BackColor = System.Drawing.Color.Transparent;
            this.editPercentualeAvanzamento.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editPercentualeAvanzamento.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editPercentualeAvanzamento.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editPercentualeAvanzamento.Changed = true;
            this.editPercentualeAvanzamento.Editing = false;
            this.editPercentualeAvanzamento.Label = "Percentuale";
            this.editPercentualeAvanzamento.LabelWidth = 175;
            this.editPercentualeAvanzamento.Location = new System.Drawing.Point(25, 862);
            this.editPercentualeAvanzamento.Name = "editPercentualeAvanzamento";
            this.editPercentualeAvanzamento.ReadOnly = true;
            this.editPercentualeAvanzamento.Required = false;
            this.editPercentualeAvanzamento.Size = new System.Drawing.Size(792, 30);
            this.editPercentualeAvanzamento.TabIndex = 20;
            this.editPercentualeAvanzamento.Text = "TemplateEditNumeric";
            this.editPercentualeAvanzamento.Value = null;
            // 
            // editMargine
            // 
            this.editMargine.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editMargine.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editMargine.BackColor = System.Drawing.Color.Transparent;
            this.editMargine.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editMargine.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editMargine.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editMargine.Changed = true;
            this.editMargine.Editing = false;
            this.editMargine.Label = "Margine";
            this.editMargine.LabelWidth = 175;
            this.editMargine.Location = new System.Drawing.Point(25, 898);
            this.editMargine.Name = "editMargine";
            this.editMargine.ReadOnly = false;
            this.editMargine.Required = false;
            this.editMargine.Size = new System.Drawing.Size(792, 30);
            this.editMargine.TabIndex = 21;
            this.editMargine.Text = "TemplateEditNumeric";
            this.editMargine.Value = null;
            // 
            // editImportoAvanzamentoLavori
            // 
            this.editImportoAvanzamentoLavori.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editImportoAvanzamentoLavori.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editImportoAvanzamentoLavori.BackColor = System.Drawing.Color.Transparent;
            this.editImportoAvanzamentoLavori.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editImportoAvanzamentoLavori.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editImportoAvanzamentoLavori.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editImportoAvanzamentoLavori.Changed = true;
            this.editImportoAvanzamentoLavori.Editing = false;
            this.editImportoAvanzamentoLavori.Label = "Importo avanzamento";
            this.editImportoAvanzamentoLavori.LabelWidth = 175;
            this.editImportoAvanzamentoLavori.Location = new System.Drawing.Point(25, 826);
            this.editImportoAvanzamentoLavori.Name = "editImportoAvanzamentoLavori";
            this.editImportoAvanzamentoLavori.ReadOnly = true;
            this.editImportoAvanzamentoLavori.Required = false;
            this.editImportoAvanzamentoLavori.Size = new System.Drawing.Size(792, 30);
            this.editImportoAvanzamentoLavori.TabIndex = 19;
            this.editImportoAvanzamentoLavori.Text = "TemplateEditNumeric";
            this.editImportoAvanzamentoLavori.Value = null;
            // 
            // editImportoPerizie
            // 
            this.editImportoPerizie.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editImportoPerizie.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editImportoPerizie.BackColor = System.Drawing.Color.Transparent;
            this.editImportoPerizie.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editImportoPerizie.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editImportoPerizie.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editImportoPerizie.Changed = true;
            this.editImportoPerizie.Editing = false;
            this.editImportoPerizie.Label = "Importo perizie";
            this.editImportoPerizie.LabelWidth = 175;
            this.editImportoPerizie.Location = new System.Drawing.Point(25, 970);
            this.editImportoPerizie.Name = "editImportoPerizie";
            this.editImportoPerizie.ReadOnly = false;
            this.editImportoPerizie.Required = false;
            this.editImportoPerizie.Size = new System.Drawing.Size(792, 30);
            this.editImportoPerizie.TabIndex = 22;
            this.editImportoPerizie.Text = "TemplateEditNumeric";
            this.editImportoPerizie.Value = null;
            // 
            // label1
            // 
            this.label1.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(887, 30);
            this.label1.TabIndex = 1001;
            this.label1.Text = "LUOGO DI ESECUZIONE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(12, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(887, 30);
            this.label2.TabIndex = 1001;
            this.label2.Text = "DATI CONTRATTUALI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(12, 754);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(887, 30);
            this.label3.TabIndex = 1001;
            this.label3.Text = "STATO AVANZAMENTO LAVORI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(12, 934);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(887, 30);
            this.label4.TabIndex = 1001;
            this.label4.Text = "SPESE GENERALI";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editOggetto
            // 
            this.editOggetto.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editOggetto.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editOggetto.BackColor = System.Drawing.Color.Transparent;
            this.editOggetto.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editOggetto.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editOggetto.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editOggetto.Changed = true;
            this.editOggetto.Editing = false;
            this.editOggetto.Label = "Oggetto";
            this.editOggetto.LabelWidth = 175;
            this.editOggetto.Location = new System.Drawing.Point(25, 610);
            this.editOggetto.Name = "editOggetto";
            this.editOggetto.ReadOnly = false;
            this.editOggetto.Required = false;
            this.editOggetto.Size = new System.Drawing.Size(792, 30);
            this.editOggetto.TabIndex = 14;
            this.editOggetto.Text = "EditControl";
            this.editOggetto.Value = null;
            // 
            // btnFornitori
            // 
            this.btnFornitori.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnFornitori.BackColor = System.Drawing.Color.Transparent;
            this.btnFornitori.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnFornitori.ImageButton = "";
            this.btnFornitori.ImageSeparator = "Images.separator_ht_small.png";
            this.btnFornitori.Location = new System.Drawing.Point(0, 360);
            this.btnFornitori.Name = "btnFornitori";
            this.btnFornitori.Size = new System.Drawing.Size(100, 72);
            this.btnFornitori.TabIndex = 1002;
            this.btnFornitori.TextButton = "Fornitori";
            this.btnFornitori.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnFornitori_Click);
            // 
            // btnSAL
            // 
            this.btnSAL.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnSAL.BackColor = System.Drawing.Color.Transparent;
            this.btnSAL.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnSAL.ImageButton = "";
            this.btnSAL.ImageSeparator = "Images.separator_ht_small.png";
            this.btnSAL.Location = new System.Drawing.Point(0, 504);
            this.btnSAL.Name = "btnSAL";
            this.btnSAL.Size = new System.Drawing.Size(100, 72);
            this.btnSAL.TabIndex = 1002;
            this.btnSAL.TextButton = "SAL";
            this.btnSAL.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnSAL_Click);
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
            this.editComune.Location = new System.Drawing.Point(25, 430);
            this.editComune.Name = "templateEditComune1";
            this.editComune.ReadOnly = false;
            this.editComune.Required = false;
            this.editComune.Size = new System.Drawing.Size(792, 30);
            this.editComune.TabIndex = 10;
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
            this.editLocalita.Label = "Località";
            this.editLocalita.LabelWidth = 175;
            this.editLocalita.Location = new System.Drawing.Point(25, 466);
            this.editLocalita.Name = "editLocalita";
            this.editLocalita.ReadOnly = false;
            this.editLocalita.Required = false;
            this.editLocalita.Size = new System.Drawing.Size(792, 30);
            this.editLocalita.TabIndex = 11;
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
            this.editNote.Location = new System.Drawing.Point(25, 283);
            this.editNote.Name = "editNote";
            this.editNote.ReadOnly = false;
            this.editNote.Required = false;
            this.editNote.Size = new System.Drawing.Size(792, 30);
            this.editNote.TabIndex = 7;
            this.editNote.Text = "EditControl";
            this.editNote.Value = null;
            // 
            // btnCalcoloAvanzamentoLavori
            // 
            this.btnCalcoloAvanzamentoLavori.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnCalcoloAvanzamentoLavori.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcoloAvanzamentoLavori.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnCalcoloAvanzamentoLavori.ImageButton = "";
            this.btnCalcoloAvanzamentoLavori.ImageSeparator = "Images.separator_ht_small.png";
            this.btnCalcoloAvanzamentoLavori.Location = new System.Drawing.Point(0, 288);
            this.btnCalcoloAvanzamentoLavori.Name = "btnCalcoloAvanzamentoLavori";
            this.btnCalcoloAvanzamentoLavori.Size = new System.Drawing.Size(100, 72);
            this.btnCalcoloAvanzamentoLavori.TabIndex = 1002;
            this.btnCalcoloAvanzamentoLavori.TextButton = "Calcolo stato lavori";
            this.btnCalcoloAvanzamentoLavori.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnCalcoloAvanzamentoLavori_Click);
            // 
            // btnCommittenti
            // 
            this.btnCommittenti.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnCommittenti.BackColor = System.Drawing.Color.Transparent;
            this.btnCommittenti.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnCommittenti.ImageButton = "";
            this.btnCommittenti.ImageSeparator = "Images.separator_ht_small.png";
            this.btnCommittenti.Location = new System.Drawing.Point(0, 432);
            this.btnCommittenti.Name = "btnCommittenti";
            this.btnCommittenti.Size = new System.Drawing.Size(100, 72);
            this.btnCommittenti.TabIndex = 1002;
            this.btnCommittenti.TextButton = "Committenti";
            this.btnCommittenti.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnCommittenti_Click);
            // 
            // CommessaModel
            // 
            this.Location = new System.Drawing.Point(0, -168);
            this.Size = new System.Drawing.Size(1024, 1087);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditCombo editAzienda;
        private Library.Template.Controls.TemplateEditDate editScadenza;
        private Library.Template.Controls.TemplateEditDate editCreazione;
        private Library.Template.Controls.TemplateEditText editRiferimento;
        private Library.Template.Controls.TemplateEditText editDescrizione;
        private Library.Template.Controls.TemplateEditText editDenominazione;
        private Library.Template.Controls.TemplateEditText editIndirizzo;
        private Library.Template.Controls.TemplateEditCap editCAP;
        private Library.Template.Controls.TemplateEditDecimal editImporto;
        private Library.Template.Controls.TemplateEditText editCodice;
        private Library.Template.Controls.TemplateEditDropDown editStato;
        private Library.Template.Controls.TemplateEditDecimal editMargine;
        private Library.Template.Controls.TemplateEditDecimal editImportoAvanzamentoLavori;
        private Library.Template.Controls.TemplateEditText editEstremiContratto;
        private Library.Template.Controls.TemplateEditDate editInizioLavori;
        private Library.Template.Controls.TemplateEditDate editFineLavori;
        private Library.Template.Controls.TemplateEditProgress editPercentualeAvanzamento;
        private Library.Template.Controls.TemplateEditDecimal editImportoPerizie;
        private Gizmox.WebGUI.Forms.Label label4;
        private Gizmox.WebGUI.Forms.Label label3;
        private Gizmox.WebGUI.Forms.Label label2;
        private Gizmox.WebGUI.Forms.Label label1;
        private Library.Template.Controls.TemplateEditText editOggetto;
        private Library.Controls.ButtonSeparatorV btnFornitori;
        private Library.Controls.ButtonSeparatorV btnSAL;
        private Library.Template.Controls.TemplateEditCountry editComune;
        private Library.Template.Controls.TemplateEditText editLocalita;
        private Library.Template.Controls.TemplateEditText editNote;
        private Library.Controls.ButtonSeparatorV btnCalcoloAvanzamentoLavori;
        private Library.Controls.ButtonSeparatorV btnCommittenti;


    }
}
