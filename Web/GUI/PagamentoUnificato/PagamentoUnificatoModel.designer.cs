using System.Drawing;

namespace Web.GUI.PagamentoUnificato
{
    partial class PagamentoUnificatoModel
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
            this.editAnagraficaFornitore = new Library.Template.Controls.TemplateEditCombo();
            this.editData = new Library.Template.Controls.TemplateEditDate();
            this.editImporto = new Library.Template.Controls.TemplateEditDecimal();
            this.editNote = new Library.Template.Controls.TemplateEditText();
            this.editCodice = new Library.Template.Controls.TemplateEditText();
            this.editTipoPagamento = new Library.Template.Controls.TemplateEditDropDown();
            this.editDescrizione = new Library.Template.Controls.TemplateEditText();
            this.btnCalcoloSaldoImporto = new Library.Controls.ButtonSeparatorV();
            this.btnPagamentoUnificatoFattureAcquisto = new Library.Controls.ButtonSeparatorV();
            this.editAzienda = new Library.Template.Controls.TemplateEditCombo();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editAzienda);
            this.container.Controls.Add(this.editDescrizione);
            this.container.Controls.Add(this.editTipoPagamento);
            this.container.Controls.Add(this.editCodice);
            this.container.Controls.Add(this.editNote);
            this.container.Controls.Add(this.editImporto);
            this.container.Controls.Add(this.editData);
            this.container.Controls.Add(this.editAnagraficaFornitore);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editAnagraficaFornitore, 0);
            this.container.Controls.SetChildIndex(this.editData, 0);
            this.container.Controls.SetChildIndex(this.editImporto, 0);
            this.container.Controls.SetChildIndex(this.editNote, 0);
            this.container.Controls.SetChildIndex(this.editCodice, 0);
            this.container.Controls.SetChildIndex(this.editTipoPagamento, 0);
            this.container.Controls.SetChildIndex(this.editDescrizione, 0);
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
            // panelCommands
            // 
            this.panelCommands.Controls.Add(this.btnPagamentoUnificatoFattureAcquisto);
            this.panelCommands.Controls.Add(this.btnCalcoloSaldoImporto);
            this.panelCommands.Controls.SetChildIndex(this.btnHome, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnClose, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnSave, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnUpdateCancel, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnDelete, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnCalcoloSaldoImporto, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnPagamentoUnificatoFattureAcquisto, 0);
            // 
            // editAnagraficaFornitore
            // 
            this.editAnagraficaFornitore.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editAnagraficaFornitore.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editAnagraficaFornitore.BackColor = System.Drawing.Color.Transparent;
            this.editAnagraficaFornitore.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editAnagraficaFornitore.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editAnagraficaFornitore.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editAnagraficaFornitore.Changed = true;
            this.editAnagraficaFornitore.Editing = false;
            this.editAnagraficaFornitore.Label = "Fornitore";
            this.editAnagraficaFornitore.LabelWidth = 175;
            this.editAnagraficaFornitore.Location = new System.Drawing.Point(33, 119);
            this.editAnagraficaFornitore.Model = null;
            this.editAnagraficaFornitore.Name = "editAnagraficaFornitore";
            this.editAnagraficaFornitore.ReadOnly = false;
            this.editAnagraficaFornitore.Required = true;
            this.editAnagraficaFornitore.Size = new System.Drawing.Size(824, 30);
            this.editAnagraficaFornitore.TabIndex = 1;
            this.editAnagraficaFornitore.Text = "EditControl";
            this.editAnagraficaFornitore.Value = null;
            this.editAnagraficaFornitore.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editanagraficaFornitore_ComboConfirm);
            this.editAnagraficaFornitore.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editAnagraficaFornitore_ComboClick);
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
            this.editData.Location = new System.Drawing.Point(33, 203);
            this.editData.Name = "editData";
            this.editData.ReadOnly = false;
            this.editData.Required = true;
            this.editData.Size = new System.Drawing.Size(824, 30);
            this.editData.TabIndex = 3;
            this.editData.Text = "EditControl";
            this.editData.Value = null;
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
            this.editImporto.Location = new System.Drawing.Point(33, 287);
            this.editImporto.Name = "editImporto";
            this.editImporto.ReadOnly = true;
            this.editImporto.Required = false;
            this.editImporto.Size = new System.Drawing.Size(824, 30);
            this.editImporto.TabIndex = 5;
            this.editImporto.Text = "TemplateEditNumeric";
            this.editImporto.Value = null;
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
            this.editNote.Location = new System.Drawing.Point(33, 371);
            this.editNote.Name = "editNote";
            this.editNote.ReadOnly = false;
            this.editNote.Required = false;
            this.editNote.Size = new System.Drawing.Size(824, 30);
            this.editNote.TabIndex = 7;
            this.editNote.Text = "EditControl";
            this.editNote.Value = null;
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
            this.editCodice.Location = new System.Drawing.Point(33, 161);
            this.editCodice.Name = "editCodice";
            this.editCodice.ReadOnly = false;
            this.editCodice.Required = true;
            this.editCodice.Size = new System.Drawing.Size(824, 30);
            this.editCodice.TabIndex = 2;
            this.editCodice.Text = "EditControl";
            this.editCodice.Value = null;
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
            this.editTipoPagamento.Location = new System.Drawing.Point(33, 245);
            this.editTipoPagamento.Name = "editTipoPagamento";
            this.editTipoPagamento.ReadOnly = false;
            this.editTipoPagamento.Required = true;
            this.editTipoPagamento.Size = new System.Drawing.Size(824, 30);
            this.editTipoPagamento.TabIndex = 4;
            this.editTipoPagamento.Text = "EditControl";
            this.editTipoPagamento.Value = null;
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
            this.editDescrizione.Location = new System.Drawing.Point(33, 329);
            this.editDescrizione.Name = "editDescrizione";
            this.editDescrizione.ReadOnly = false;
            this.editDescrizione.Required = false;
            this.editDescrizione.Size = new System.Drawing.Size(824, 30);
            this.editDescrizione.TabIndex = 6;
            this.editDescrizione.Text = "EditControl";
            this.editDescrizione.Value = null;
            // 
            // btnCalcoloSaldoImporto
            // 
            this.btnCalcoloSaldoImporto.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnCalcoloSaldoImporto.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcoloSaldoImporto.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnCalcoloSaldoImporto.ImageButton = "";
            this.btnCalcoloSaldoImporto.ImageSeparator = "Images.separator_ht_small.png";
            this.btnCalcoloSaldoImporto.Location = new System.Drawing.Point(1, 360);
            this.btnCalcoloSaldoImporto.Name = "btnCalcoloSaldoImporto";
            this.btnCalcoloSaldoImporto.Size = new System.Drawing.Size(100, 72);
            this.btnCalcoloSaldoImporto.TabIndex = 1002;
            this.btnCalcoloSaldoImporto.TextButton = "Calcolo saldo importo";
            this.btnCalcoloSaldoImporto.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnCalcoloSaldoImporto_Click);
            // 
            // btnPagamentoUnificatoFattureAcquisto
            // 
            this.btnPagamentoUnificatoFattureAcquisto.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnPagamentoUnificatoFattureAcquisto.BackColor = System.Drawing.Color.Transparent;
            this.btnPagamentoUnificatoFattureAcquisto.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnPagamentoUnificatoFattureAcquisto.ImageButton = "";
            this.btnPagamentoUnificatoFattureAcquisto.ImageSeparator = "Images.separator_ht_small.png";
            this.btnPagamentoUnificatoFattureAcquisto.Location = new System.Drawing.Point(1, 288);
            this.btnPagamentoUnificatoFattureAcquisto.Name = "btnPagamentoUnificatoFattureAcquisto";
            this.btnPagamentoUnificatoFattureAcquisto.Size = new System.Drawing.Size(100, 72);
            this.btnPagamentoUnificatoFattureAcquisto.TabIndex = 1002;
            this.btnPagamentoUnificatoFattureAcquisto.TextButton = "Fatture acquisto";
            this.btnPagamentoUnificatoFattureAcquisto.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnPagamentoUnificatoFattureAcquisto_Click);
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
            this.editAzienda.Location = new System.Drawing.Point(33, 77);
            this.editAzienda.Model = null;
            this.editAzienda.Name = "editAzienda";
            this.editAzienda.ReadOnly = false;
            this.editAzienda.Required = true;
            this.editAzienda.Size = new System.Drawing.Size(824, 30);
            this.editAzienda.TabIndex = 0;
            this.editAzienda.Text = "EditControl";
            this.editAzienda.Value = null;
            this.editAzienda.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editAzienda_ComboConfirm);
            this.editAzienda.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editAzienda_ComboClick);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditDate editData;
        private Library.Template.Controls.TemplateEditCombo editAnagraficaFornitore;
        private Library.Template.Controls.TemplateEditDecimal editImporto;
        private Library.Template.Controls.TemplateEditText editNote;
        private Library.Template.Controls.TemplateEditText editCodice;
        private Library.Template.Controls.TemplateEditText editDescrizione;
        private Library.Template.Controls.TemplateEditDropDown editTipoPagamento;
        private Library.Controls.ButtonSeparatorV btnCalcoloSaldoImporto;
        private Library.Controls.ButtonSeparatorV btnPagamentoUnificatoFattureAcquisto;
        private Library.Template.Controls.TemplateEditCombo editAzienda;


    }
}
