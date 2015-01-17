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
            this.editNumero = new Library.Template.Controls.TemplateEditText();
            this.editCreazione = new Library.Template.Controls.TemplateEditData();
            this.editScadenza = new Library.Template.Controls.TemplateEditData();
            this.editProvincia = new Library.Template.Controls.TemplateEditText();
            this.editComune = new Library.Template.Controls.TemplateEditText();
            this.editCAP = new Library.Template.Controls.TemplateEditCap();
            this.editIndirizzo = new Library.Template.Controls.TemplateEditText();
            this.editDenominazione = new Library.Template.Controls.TemplateEditText();
            this.editDescrizione = new Library.Template.Controls.TemplateEditText();
            this.editRiferimento = new Library.Template.Controls.TemplateEditText();
            this.editImporto = new Library.Template.Controls.TemplateEditDecimal();
            this.editCodice = new Library.Template.Controls.TemplateEditText();
            this.editStato = new Library.Template.Controls.TemplateEditDropDown();
            this.orientationTabControl1 = new Gizmox.WebGUI.Forms.OrientationTabControl();
            this.tabPage1 = new Gizmox.WebGUI.Forms.TabPage();
            this.tabPage2 = new Gizmox.WebGUI.Forms.TabPage();
            this.editInizioLavori = new Library.Template.Controls.TemplateEditData();
            this.editFineLavori = new Library.Template.Controls.TemplateEditData();
            this.editEstremiContratto = new Library.Template.Controls.TemplateEditText();
            this.tabPage3 = new Gizmox.WebGUI.Forms.TabPage();
            this.editPercentualeAvanzamento = new Library.Template.Controls.TemplateEditDecimal();
            this.editMargine = new Library.Template.Controls.TemplateEditDecimal();
            this.editImportoAvanzamentoLavori = new Library.Template.Controls.TemplateEditDecimal();
            this.tabPage4 = new Gizmox.WebGUI.Forms.TabPage();
            this.editImportoPerizie = new Library.Template.Controls.TemplateEditDecimal();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orientationTabControl1)).BeginInit();
            this.orientationTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.orientationTabControl1);
            this.container.Controls.Add(this.editStato);
            this.container.Controls.Add(this.editCodice);
            this.container.Controls.Add(this.editDescrizione);
            this.container.Controls.Add(this.editDenominazione);
            this.container.Controls.Add(this.editCreazione);
            this.container.Controls.Add(this.editNumero);
            this.container.Controls.Add(this.editAzienda);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editAzienda, 0);
            this.container.Controls.SetChildIndex(this.editNumero, 0);
            this.container.Controls.SetChildIndex(this.editCreazione, 0);
            this.container.Controls.SetChildIndex(this.editDenominazione, 0);
            this.container.Controls.SetChildIndex(this.editDescrizione, 0);
            this.container.Controls.SetChildIndex(this.editCodice, 0);
            this.container.Controls.SetChildIndex(this.editStato, 0);
            this.container.Controls.SetChildIndex(this.orientationTabControl1, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(664, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(608, 3);
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
            this.editAzienda.Required = false;
            this.editAzienda.Size = new System.Drawing.Size(775, 30);
            this.editAzienda.TabIndex = 0;
            this.editAzienda.Text = "EditControl";
            this.editAzienda.Value = null;
            this.editAzienda.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editAzienda_ComboConfirm);
            this.editAzienda.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editAzienda_ComboClick);
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
            this.editNumero.Location = new System.Drawing.Point(22, 149);
            this.editNumero.Name = "editNumero";
            this.editNumero.ReadOnly = false;
            this.editNumero.Required = false;
            this.editNumero.Size = new System.Drawing.Size(773, 30);
            this.editNumero.TabIndex = 2;
            this.editNumero.Text = "EditControl";
            this.editNumero.Value = null;
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
            this.editCreazione.Location = new System.Drawing.Point(22, 186);
            this.editCreazione.Name = "editCreazione";
            this.editCreazione.ReadOnly = false;
            this.editCreazione.Required = false;
            this.editCreazione.Size = new System.Drawing.Size(773, 30);
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
            this.editScadenza.Location = new System.Drawing.Point(10, 180);
            this.editScadenza.Name = "editScadenza";
            this.editScadenza.ReadOnly = false;
            this.editScadenza.Required = false;
            this.editScadenza.Size = new System.Drawing.Size(752, 30);
            this.editScadenza.TabIndex = 4;
            this.editScadenza.Text = "TemplateEditData";
            this.editScadenza.Value = null;
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
            this.editProvincia.Changed = true;
            this.editProvincia.Editing = false;
            this.editProvincia.Label = "Provincia";
            this.editProvincia.LabelWidth = 175;
            this.editProvincia.Location = new System.Drawing.Point(10, 121);
            this.editProvincia.Name = "editProvincia";
            this.editProvincia.ReadOnly = false;
            this.editProvincia.Required = false;
            this.editProvincia.Size = new System.Drawing.Size(756, 30);
            this.editProvincia.TabIndex = 10;
            this.editProvincia.Text = "EditControl";
            this.editProvincia.Value = null;
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
            this.editComune.Location = new System.Drawing.Point(10, 84);
            this.editComune.Name = "editComune";
            this.editComune.ReadOnly = false;
            this.editComune.Required = false;
            this.editComune.Size = new System.Drawing.Size(756, 30);
            this.editComune.TabIndex = 9;
            this.editComune.Text = "EditControl";
            this.editComune.Value = null;
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
            this.editCAP.Location = new System.Drawing.Point(10, 47);
            this.editCAP.Name = "editCAP";
            this.editCAP.ReadOnly = false;
            this.editCAP.Required = false;
            this.editCAP.Size = new System.Drawing.Size(756, 30);
            this.editCAP.TabIndex = 8;
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
            this.editIndirizzo.Location = new System.Drawing.Point(10, 10);
            this.editIndirizzo.Name = "editIndirizzo";
            this.editIndirizzo.ReadOnly = false;
            this.editIndirizzo.Required = false;
            this.editIndirizzo.Size = new System.Drawing.Size(756, 30);
            this.editIndirizzo.TabIndex = 7;
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
            this.editDenominazione.Location = new System.Drawing.Point(22, 223);
            this.editDenominazione.Name = "editDenominazione";
            this.editDenominazione.ReadOnly = false;
            this.editDenominazione.Required = false;
            this.editDenominazione.Size = new System.Drawing.Size(773, 30);
            this.editDenominazione.TabIndex = 5;
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
            this.editDescrizione.Location = new System.Drawing.Point(20, 260);
            this.editDescrizione.Name = "editDescrizione";
            this.editDescrizione.ReadOnly = false;
            this.editDescrizione.Required = false;
            this.editDescrizione.Size = new System.Drawing.Size(773, 30);
            this.editDescrizione.TabIndex = 6;
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
            this.editRiferimento.Location = new System.Drawing.Point(10, 10);
            this.editRiferimento.Name = "editRiferimento";
            this.editRiferimento.ReadOnly = false;
            this.editRiferimento.Required = false;
            this.editRiferimento.Size = new System.Drawing.Size(754, 30);
            this.editRiferimento.TabIndex = 11;
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
            this.editImporto.Label = "Importo";
            this.editImporto.LabelWidth = 175;
            this.editImporto.Location = new System.Drawing.Point(10, 44);
            this.editImporto.Name = "editImporto";
            this.editImporto.ReadOnly = false;
            this.editImporto.Required = false;
            this.editImporto.Size = new System.Drawing.Size(754, 30);
            this.editImporto.TabIndex = 13;
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
            this.editCodice.Location = new System.Drawing.Point(22, 112);
            this.editCodice.Name = "editCodice";
            this.editCodice.ReadOnly = false;
            this.editCodice.Required = false;
            this.editCodice.Size = new System.Drawing.Size(773, 30);
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
            this.editStato.Editing = false;
            this.editStato.Items = null;
            this.editStato.Label = "Stato";
            this.editStato.LabelWidth = 175;
            this.editStato.Location = new System.Drawing.Point(22, 297);
            this.editStato.Name = "editStato";
            this.editStato.ReadOnly = false;
            this.editStato.Required = false;
            this.editStato.Size = new System.Drawing.Size(773, 30);
            this.editStato.TabIndex = 12;
            this.editStato.Text = "EditControl";
            this.editStato.Value = null;
            // 
            // orientationTabControl1
            // 
            this.orientationTabControl1.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.orientationTabControl1.Controls.Add(this.tabPage1);
            this.orientationTabControl1.Controls.Add(this.tabPage2);
            this.orientationTabControl1.Controls.Add(this.tabPage3);
            this.orientationTabControl1.Controls.Add(this.tabPage4);
            this.orientationTabControl1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orientationTabControl1.Location = new System.Drawing.Point(20, 344);
            this.orientationTabControl1.Name = "orientationTabControl1";
            this.orientationTabControl1.SelectedIndex = 0;
            this.orientationTabControl1.Size = new System.Drawing.Size(893, 250);
            this.orientationTabControl1.TabIndex = 1001;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.editIndirizzo);
            this.tabPage1.Controls.Add(this.editCAP);
            this.tabPage1.Controls.Add(this.editComune);
            this.tabPage1.Controls.Add(this.editProvincia);
            this.tabPage1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(883, 217);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Luogo di esecuzione";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.editInizioLavori);
            this.tabPage2.Controls.Add(this.editFineLavori);
            this.tabPage2.Controls.Add(this.editEstremiContratto);
            this.tabPage2.Controls.Add(this.editRiferimento);
            this.tabPage2.Controls.Add(this.editImporto);
            this.tabPage2.Controls.Add(this.editScadenza);
            this.tabPage2.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(883, 217);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dati contrattuali";
            // 
            // editInizioLavori
            // 
            this.editInizioLavori.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editInizioLavori.BackColor = System.Drawing.Color.Transparent;
            this.editInizioLavori.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editInizioLavori.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editInizioLavori.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editInizioLavori.Changed = true;
            this.editInizioLavori.Editing = false;
            this.editInizioLavori.Label = "Inizio lavori";
            this.editInizioLavori.LabelWidth = 175;
            this.editInizioLavori.Location = new System.Drawing.Point(10, 112);
            this.editInizioLavori.Name = "editInizioLavori";
            this.editInizioLavori.ReadOnly = false;
            this.editInizioLavori.Required = false;
            this.editInizioLavori.Size = new System.Drawing.Size(481, 30);
            this.editInizioLavori.TabIndex = 16;
            this.editInizioLavori.Text = "EditControl";
            this.editInizioLavori.Value = null;
            // 
            // editFineLavori
            // 
            this.editFineLavori.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editFineLavori.BackColor = System.Drawing.Color.Transparent;
            this.editFineLavori.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editFineLavori.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editFineLavori.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editFineLavori.Changed = true;
            this.editFineLavori.Editing = false;
            this.editFineLavori.Label = "Fine lavori";
            this.editFineLavori.LabelWidth = 175;
            this.editFineLavori.Location = new System.Drawing.Point(10, 146);
            this.editFineLavori.Name = "editFineLavori";
            this.editFineLavori.ReadOnly = false;
            this.editFineLavori.Required = false;
            this.editFineLavori.Size = new System.Drawing.Size(481, 30);
            this.editFineLavori.TabIndex = 15;
            this.editFineLavori.Text = "EditControl";
            this.editFineLavori.Value = null;
            // 
            // editEstremiContratto
            // 
            this.editEstremiContratto.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editEstremiContratto.BackColor = System.Drawing.Color.Transparent;
            this.editEstremiContratto.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editEstremiContratto.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editEstremiContratto.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editEstremiContratto.Changed = true;
            this.editEstremiContratto.Editing = false;
            this.editEstremiContratto.Label = "Estremi del contratto";
            this.editEstremiContratto.LabelWidth = 175;
            this.editEstremiContratto.Location = new System.Drawing.Point(10, 78);
            this.editEstremiContratto.Name = "editEstremiContratto";
            this.editEstremiContratto.ReadOnly = false;
            this.editEstremiContratto.Required = false;
            this.editEstremiContratto.Size = new System.Drawing.Size(756, 30);
            this.editEstremiContratto.TabIndex = 14;
            this.editEstremiContratto.Text = "EditControl";
            this.editEstremiContratto.Value = null;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.editPercentualeAvanzamento);
            this.tabPage3.Controls.Add(this.editMargine);
            this.tabPage3.Controls.Add(this.editImportoAvanzamentoLavori);
            this.tabPage3.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(883, 217);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Stato avanzamento lavori";
            // 
            // editPercentualeAvanzamento
            // 
            this.editPercentualeAvanzamento.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editPercentualeAvanzamento.BackColor = System.Drawing.Color.Transparent;
            this.editPercentualeAvanzamento.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editPercentualeAvanzamento.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editPercentualeAvanzamento.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editPercentualeAvanzamento.Changed = true;
            this.editPercentualeAvanzamento.Editing = false;
            this.editPercentualeAvanzamento.Label = "Percentuale avanzamento";
            this.editPercentualeAvanzamento.LabelWidth = 175;
            this.editPercentualeAvanzamento.Location = new System.Drawing.Point(10, 46);
            this.editPercentualeAvanzamento.Name = "editPercentualeAvanzamento";
            this.editPercentualeAvanzamento.ReadOnly = false;
            this.editPercentualeAvanzamento.Required = false;
            this.editPercentualeAvanzamento.Size = new System.Drawing.Size(481, 30);
            this.editPercentualeAvanzamento.TabIndex = 1001;
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
            this.editMargine.Location = new System.Drawing.Point(10, 82);
            this.editMargine.Name = "editMargine";
            this.editMargine.ReadOnly = false;
            this.editMargine.Required = false;
            this.editMargine.Size = new System.Drawing.Size(754, 30);
            this.editMargine.TabIndex = 14;
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
            this.editImportoAvanzamentoLavori.Label = "Importo avanzamento lavori";
            this.editImportoAvanzamentoLavori.LabelWidth = 175;
            this.editImportoAvanzamentoLavori.Location = new System.Drawing.Point(10, 10);
            this.editImportoAvanzamentoLavori.Name = "editImportoAvanzamentoLavori";
            this.editImportoAvanzamentoLavori.ReadOnly = false;
            this.editImportoAvanzamentoLavori.Required = false;
            this.editImportoAvanzamentoLavori.Size = new System.Drawing.Size(754, 30);
            this.editImportoAvanzamentoLavori.TabIndex = 1000;
            this.editImportoAvanzamentoLavori.Text = "TemplateEditNumeric";
            this.editImportoAvanzamentoLavori.Value = null;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.editImportoPerizie);
            this.tabPage4.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabPage4.Location = new System.Drawing.Point(0, 0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(883, 217);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Spese generali";
            // 
            // editImportoPerizie
            // 
            this.editImportoPerizie.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editImportoPerizie.BackColor = System.Drawing.Color.Transparent;
            this.editImportoPerizie.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editImportoPerizie.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editImportoPerizie.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editImportoPerizie.Changed = true;
            this.editImportoPerizie.Editing = false;
            this.editImportoPerizie.Label = "Importo perizie";
            this.editImportoPerizie.LabelWidth = 175;
            this.editImportoPerizie.Location = new System.Drawing.Point(10, 10);
            this.editImportoPerizie.Name = "editImportoPerizie";
            this.editImportoPerizie.ReadOnly = false;
            this.editImportoPerizie.Required = false;
            this.editImportoPerizie.Size = new System.Drawing.Size(800, 30);
            this.editImportoPerizie.TabIndex = 0;
            this.editImportoPerizie.Text = "TemplateEditNumeric";
            this.editImportoPerizie.Value = null;
            this.Controls.SetChildIndex(this.panelCommands, 0);
            this.Controls.SetChildIndex(this.container, 0);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orientationTabControl1)).EndInit();
            this.orientationTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditText editNumero;
        private Library.Template.Controls.TemplateEditCombo editAzienda;
        private Library.Template.Controls.TemplateEditData editScadenza;
        private Library.Template.Controls.TemplateEditData editCreazione;
        private Library.Template.Controls.TemplateEditText editRiferimento;
        private Library.Template.Controls.TemplateEditText editDescrizione;
        private Library.Template.Controls.TemplateEditText editDenominazione;
        private Library.Template.Controls.TemplateEditText editIndirizzo;
        private Library.Template.Controls.TemplateEditCap editCAP;
        private Library.Template.Controls.TemplateEditText editComune;
        private Library.Template.Controls.TemplateEditText editProvincia;
        private Library.Template.Controls.TemplateEditDecimal editImporto;
        private Library.Template.Controls.TemplateEditText editCodice;
        private Library.Template.Controls.TemplateEditDropDown editStato;
        private Gizmox.WebGUI.Forms.OrientationTabControl orientationTabControl1;
        private Gizmox.WebGUI.Forms.TabPage tabPage1;
        private Gizmox.WebGUI.Forms.TabPage tabPage2;
        private Gizmox.WebGUI.Forms.TabPage tabPage3;
        private Gizmox.WebGUI.Forms.TabPage tabPage4;
        private Library.Template.Controls.TemplateEditDecimal editMargine;
        private Library.Template.Controls.TemplateEditDecimal editImportoAvanzamentoLavori;
        private Library.Template.Controls.TemplateEditText editEstremiContratto;
        private Library.Template.Controls.TemplateEditData editInizioLavori;
        private Library.Template.Controls.TemplateEditData editFineLavori;
        private Library.Template.Controls.TemplateEditDecimal editPercentualeAvanzamento;
        private Library.Template.Controls.TemplateEditDecimal editImportoPerizie;


    }
}
