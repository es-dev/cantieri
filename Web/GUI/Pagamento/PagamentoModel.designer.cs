using System.Drawing;

namespace Web.GUI.Pagamento
{
    partial class PagamentoModel
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
            this.editFatturaAcquisto = new Library.Template.Controls.TemplateEditCombo();
            this.editData = new Library.Template.Controls.TemplateEditDate();
            this.editImporto = new Library.Template.Controls.TemplateEditDecimal();
            this.editNote = new Library.Template.Controls.TemplateEditText();
            this.editCodice = new Library.Template.Controls.TemplateEditText();
            this.editTipoPagamento = new Library.Template.Controls.TemplateEditDropDown();
            this.editDescrizione = new Library.Template.Controls.TemplateEditText();
            this.editTransazionePagamento = new Library.Template.Controls.TemplateEditDropDown();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editTransazionePagamento);
            this.container.Controls.Add(this.editDescrizione);
            this.container.Controls.Add(this.editTipoPagamento);
            this.container.Controls.Add(this.editCodice);
            this.container.Controls.Add(this.editNote);
            this.container.Controls.Add(this.editImporto);
            this.container.Controls.Add(this.editData);
            this.container.Controls.Add(this.editFatturaAcquisto);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editFatturaAcquisto, 0);
            this.container.Controls.SetChildIndex(this.editData, 0);
            this.container.Controls.SetChildIndex(this.editImporto, 0);
            this.container.Controls.SetChildIndex(this.editNote, 0);
            this.container.Controls.SetChildIndex(this.editCodice, 0);
            this.container.Controls.SetChildIndex(this.editTipoPagamento, 0);
            this.container.Controls.SetChildIndex(this.editDescrizione, 0);
            this.container.Controls.SetChildIndex(this.editTransazionePagamento, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(666, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(610, 3);
            // 
            // editFatturaAcquisto
            // 
            this.editFatturaAcquisto.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editFatturaAcquisto.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editFatturaAcquisto.BackColor = System.Drawing.Color.Transparent;
            this.editFatturaAcquisto.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editFatturaAcquisto.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editFatturaAcquisto.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editFatturaAcquisto.Changed = true;
            this.editFatturaAcquisto.Editing = false;
            this.editFatturaAcquisto.Label = "Fattura di acquisto";
            this.editFatturaAcquisto.LabelWidth = 175;
            this.editFatturaAcquisto.Location = new System.Drawing.Point(25, 75);
            this.editFatturaAcquisto.Model = null;
            this.editFatturaAcquisto.Name = "editFatturaAcquisto";
            this.editFatturaAcquisto.ReadOnly = false;
            this.editFatturaAcquisto.Required = true;
            this.editFatturaAcquisto.Size = new System.Drawing.Size(796, 30);
            this.editFatturaAcquisto.TabIndex = 0;
            this.editFatturaAcquisto.Text = "EditControl";
            this.editFatturaAcquisto.Value = null;
            this.editFatturaAcquisto.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editFatturaAcquisto_ComboConfirm);
            this.editFatturaAcquisto.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editFatturaAcquisto_ComboClick);
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
            this.editData.Size = new System.Drawing.Size(796, 30);
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
            this.editImporto.Location = new System.Drawing.Point(25, 243);
            this.editImporto.Name = "editImporto";
            this.editImporto.ReadOnly = false;
            this.editImporto.Required = true;
            this.editImporto.Size = new System.Drawing.Size(796, 30);
            this.editImporto.TabIndex = 4;
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
            this.editNote.Location = new System.Drawing.Point(25, 369);
            this.editNote.Name = "editNote";
            this.editNote.ReadOnly = false;
            this.editNote.Required = false;
            this.editNote.Size = new System.Drawing.Size(796, 30);
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
            this.editCodice.Location = new System.Drawing.Point(25, 159);
            this.editCodice.Name = "editCodice";
            this.editCodice.ReadOnly = false;
            this.editCodice.Required = true;
            this.editCodice.Size = new System.Drawing.Size(796, 30);
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
            this.editTipoPagamento.Location = new System.Drawing.Point(25, 285);
            this.editTipoPagamento.Name = "editTipoPagamento";
            this.editTipoPagamento.ReadOnly = false;
            this.editTipoPagamento.Required = true;
            this.editTipoPagamento.Size = new System.Drawing.Size(796, 30);
            this.editTipoPagamento.TabIndex = 5;
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
            this.editDescrizione.Location = new System.Drawing.Point(25, 327);
            this.editDescrizione.Name = "editDescrizione";
            this.editDescrizione.ReadOnly = false;
            this.editDescrizione.Required = false;
            this.editDescrizione.Size = new System.Drawing.Size(796, 30);
            this.editDescrizione.TabIndex = 6;
            this.editDescrizione.Text = "EditControl";
            this.editDescrizione.Value = null;
            // 
            // editTransazionePagamento
            // 
            this.editTransazionePagamento.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTransazionePagamento.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTransazionePagamento.BackColor = System.Drawing.Color.Transparent;
            this.editTransazionePagamento.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTransazionePagamento.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTransazionePagamento.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTransazionePagamento.Changed = true;
            this.editTransazionePagamento.DisplayValues = null;
            this.editTransazionePagamento.Editing = false;
            this.editTransazionePagamento.Items = null;
            this.editTransazionePagamento.Label = "Tipo transazione";
            this.editTransazionePagamento.LabelWidth = 175;
            this.editTransazionePagamento.Location = new System.Drawing.Point(25, 117);
            this.editTransazionePagamento.Name = "editTransazionePagamento";
            this.editTransazionePagamento.ReadOnly = false;
            this.editTransazionePagamento.Required = true;
            this.editTransazionePagamento.Size = new System.Drawing.Size(798, 30);
            this.editTransazionePagamento.TabIndex = 1;
            this.editTransazionePagamento.Text = "EditControl";
            this.editTransazionePagamento.Value = null;
            // 
            // PagamentoModel
            // 
            this.Controls.SetChildIndex(this.panelCommands, 0);
            this.Controls.SetChildIndex(this.container, 0);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditDate editData;
        private Library.Template.Controls.TemplateEditCombo editFatturaAcquisto;
        private Library.Template.Controls.TemplateEditDecimal editImporto;
        private Library.Template.Controls.TemplateEditText editNote;
        private Library.Template.Controls.TemplateEditText editCodice;
        private Library.Template.Controls.TemplateEditText editDescrizione;
        private Library.Template.Controls.TemplateEditDropDown editTipoPagamento;
        private Library.Template.Controls.TemplateEditDropDown editTransazionePagamento;


    }
}
