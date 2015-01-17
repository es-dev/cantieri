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
            this.editData = new Library.Template.Controls.TemplateEditData();
            this.editNumero = new Library.Template.Controls.TemplateEditText();
            this.editDescrizione = new Library.Template.Controls.TemplateEditText();
            this.editImponibile = new Library.Template.Controls.TemplateEditDecimal();
            this.editIVA = new Library.Template.Controls.TemplateEditDecimal();
            this.editTotale = new Library.Template.Controls.TemplateEditDecimal();
            this.editSaldo = new Library.Template.Controls.TemplateEditDecimal();
            this.editTipoPagamento = new Library.Template.Controls.TemplateEditDropDown();
            this.editScadenzaPagamento = new Library.Template.Controls.TemplateEditDropDown();
            this.editCentroCosto = new Library.Template.Controls.TemplateEditCombo();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editCentroCosto);
            this.container.Controls.Add(this.editScadenzaPagamento);
            this.container.Controls.Add(this.editTipoPagamento);
            this.container.Controls.Add(this.editSaldo);
            this.container.Controls.Add(this.editTotale);
            this.container.Controls.Add(this.editIVA);
            this.container.Controls.Add(this.editImponibile);
            this.container.Controls.Add(this.editDescrizione);
            this.container.Controls.Add(this.editNumero);
            this.container.Controls.Add(this.editData);
            this.container.Controls.Add(this.editFornitore);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editFornitore, 0);
            this.container.Controls.SetChildIndex(this.editData, 0);
            this.container.Controls.SetChildIndex(this.editNumero, 0);
            this.container.Controls.SetChildIndex(this.editDescrizione, 0);
            this.container.Controls.SetChildIndex(this.editImponibile, 0);
            this.container.Controls.SetChildIndex(this.editIVA, 0);
            this.container.Controls.SetChildIndex(this.editTotale, 0);
            this.container.Controls.SetChildIndex(this.editSaldo, 0);
            this.container.Controls.SetChildIndex(this.editTipoPagamento, 0);
            this.container.Controls.SetChildIndex(this.editScadenzaPagamento, 0);
            this.container.Controls.SetChildIndex(this.editCentroCosto, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(666, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(610, 3);
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
            this.editFornitore.Required = false;
            this.editFornitore.Size = new System.Drawing.Size(800, 30);
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
            this.editData.Location = new System.Drawing.Point(25, 119);
            this.editData.Name = "editData";
            this.editData.ReadOnly = false;
            this.editData.Required = false;
            this.editData.Size = new System.Drawing.Size(798, 30);
            this.editData.TabIndex = 1;
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
            this.editNumero.Location = new System.Drawing.Point(25, 163);
            this.editNumero.Name = "editNumero";
            this.editNumero.ReadOnly = false;
            this.editNumero.Required = false;
            this.editNumero.Size = new System.Drawing.Size(798, 30);
            this.editNumero.TabIndex = 2;
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
            this.editDescrizione.Location = new System.Drawing.Point(25, 295);
            this.editDescrizione.Name = "editDescrizione";
            this.editDescrizione.ReadOnly = false;
            this.editDescrizione.Required = false;
            this.editDescrizione.Size = new System.Drawing.Size(798, 30);
            this.editDescrizione.TabIndex = 5;
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
            this.editImponibile.Location = new System.Drawing.Point(25, 339);
            this.editImponibile.Name = "editImponibile";
            this.editImponibile.ReadOnly = false;
            this.editImponibile.Required = false;
            this.editImponibile.Size = new System.Drawing.Size(798, 30);
            this.editImponibile.TabIndex = 6;
            this.editImponibile.Text = "TemplateEditNumeric";
            this.editImponibile.Value = null;
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
            this.editIVA.Location = new System.Drawing.Point(25, 383);
            this.editIVA.Name = "editIVA";
            this.editIVA.ReadOnly = false;
            this.editIVA.Required = false;
            this.editIVA.Size = new System.Drawing.Size(798, 30);
            this.editIVA.TabIndex = 7;
            this.editIVA.Text = "TemplateEditNumeric";
            this.editIVA.Value = null;
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
            this.editTotale.Location = new System.Drawing.Point(25, 427);
            this.editTotale.Name = "editTotale";
            this.editTotale.ReadOnly = false;
            this.editTotale.Required = false;
            this.editTotale.Size = new System.Drawing.Size(798, 30);
            this.editTotale.TabIndex = 8;
            this.editTotale.Text = "TemplateEditNumeric";
            this.editTotale.Value = null;
            // 
            // editSaldo
            // 
            this.editSaldo.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editSaldo.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editSaldo.BackColor = System.Drawing.Color.Transparent;
            this.editSaldo.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editSaldo.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editSaldo.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editSaldo.Changed = true;
            this.editSaldo.Editing = false;
            this.editSaldo.Label = "Saldo";
            this.editSaldo.LabelWidth = 175;
            this.editSaldo.Location = new System.Drawing.Point(25, 471);
            this.editSaldo.Name = "editSaldo";
            this.editSaldo.ReadOnly = false;
            this.editSaldo.Required = false;
            this.editSaldo.Size = new System.Drawing.Size(798, 30);
            this.editSaldo.TabIndex = 9;
            this.editSaldo.Text = "TemplateEditNumeric";
            this.editSaldo.Value = null;
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
            this.editTipoPagamento.Editing = false;
            this.editTipoPagamento.Items = null;
            this.editTipoPagamento.Label = "Tipo pagamento";
            this.editTipoPagamento.LabelWidth = 175;
            this.editTipoPagamento.Location = new System.Drawing.Point(25, 207);
            this.editTipoPagamento.Name = "editTipoPagamento";
            this.editTipoPagamento.ReadOnly = false;
            this.editTipoPagamento.Required = false;
            this.editTipoPagamento.Size = new System.Drawing.Size(798, 30);
            this.editTipoPagamento.TabIndex = 3;
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
            this.editScadenzaPagamento.Editing = false;
            this.editScadenzaPagamento.Items = null;
            this.editScadenzaPagamento.Label = "Scadenza pagamento";
            this.editScadenzaPagamento.LabelWidth = 175;
            this.editScadenzaPagamento.Location = new System.Drawing.Point(25, 250);
            this.editScadenzaPagamento.Name = "editScadenzaPagamento";
            this.editScadenzaPagamento.ReadOnly = false;
            this.editScadenzaPagamento.Required = false;
            this.editScadenzaPagamento.Size = new System.Drawing.Size(798, 30);
            this.editScadenzaPagamento.TabIndex = 4;
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
            this.editCentroCosto.Location = new System.Drawing.Point(21, 513);
            this.editCentroCosto.Model = null;
            this.editCentroCosto.Name = "editCentroCosto";
            this.editCentroCosto.ReadOnly = false;
            this.editCentroCosto.Required = false;
            this.editCentroCosto.Size = new System.Drawing.Size(800, 30);
            this.editCentroCosto.TabIndex = 1;
            this.editCentroCosto.Text = "EditControl";
            this.editCentroCosto.Value = null;
            this.editCentroCosto.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editCentroCosto_ComboConfirm);
            this.editCentroCosto.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editCentroCosto_ComboClick);
            this.Controls.SetChildIndex(this.container, 0);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditText editDescrizione;
        private Library.Template.Controls.TemplateEditText editNumero;
        private Library.Template.Controls.TemplateEditData editData;
        private Library.Template.Controls.TemplateEditCombo editFornitore;
        private Library.Template.Controls.TemplateEditDecimal editSaldo;
        private Library.Template.Controls.TemplateEditDecimal editTotale;
        private Library.Template.Controls.TemplateEditDecimal editIVA;
        private Library.Template.Controls.TemplateEditDecimal editImponibile;
        private Library.Template.Controls.TemplateEditDropDown editTipoPagamento;
        private Library.Template.Controls.TemplateEditDropDown editScadenzaPagamento;
        private Library.Template.Controls.TemplateEditCombo editCentroCosto;


    }
}
