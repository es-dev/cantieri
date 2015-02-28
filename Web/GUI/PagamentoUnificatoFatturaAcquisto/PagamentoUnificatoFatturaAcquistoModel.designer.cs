using System.Drawing;

namespace Web.GUI.PagamentoUnificatoFatturaAcquisto
{
    partial class PagamentoUnificatoFatturaAcquistoModel
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
            this.editSaldo = new Library.Template.Controls.TemplateEditDecimal();
            this.editNote = new Library.Template.Controls.TemplateEditText();
            this.editPagamentoUnificato = new Library.Template.Controls.TemplateEditCombo();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editPagamentoUnificato);
            this.container.Controls.Add(this.editNote);
            this.container.Controls.Add(this.editSaldo);
            this.container.Controls.Add(this.editFatturaAcquisto);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editFatturaAcquisto, 0);
            this.container.Controls.SetChildIndex(this.editSaldo, 0);
            this.container.Controls.SetChildIndex(this.editNote, 0);
            this.container.Controls.SetChildIndex(this.editPagamentoUnificato, 0);
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
            this.editFatturaAcquisto.Required = false;
            this.editFatturaAcquisto.Size = new System.Drawing.Size(800, 30);
            this.editFatturaAcquisto.TabIndex = 0;
            this.editFatturaAcquisto.Text = "EditControl";
            this.editFatturaAcquisto.Value = null;
            this.editFatturaAcquisto.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editFatturaAcquisto_ComboConfirm);
            this.editFatturaAcquisto.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editFatturaAcquisto_ComboClick);
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
            this.editSaldo.Location = new System.Drawing.Point(27, 165);
            this.editSaldo.Name = "editSaldo";
            this.editSaldo.ReadOnly = false;
            this.editSaldo.Required = false;
            this.editSaldo.Size = new System.Drawing.Size(798, 30);
            this.editSaldo.TabIndex = 3;
            this.editSaldo.Text = "TemplateEditNumeric";
            this.editSaldo.Value = null;
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
            this.editNote.Location = new System.Drawing.Point(29, 207);
            this.editNote.Name = "editNote";
            this.editNote.ReadOnly = false;
            this.editNote.Required = false;
            this.editNote.Size = new System.Drawing.Size(798, 30);
            this.editNote.TabIndex = 6;
            this.editNote.Text = "EditControl";
            this.editNote.Value = null;
            // 
            // editPagamentoUnificato
            // 
            this.editPagamentoUnificato.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editPagamentoUnificato.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editPagamentoUnificato.BackColor = System.Drawing.Color.Transparent;
            this.editPagamentoUnificato.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editPagamentoUnificato.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editPagamentoUnificato.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editPagamentoUnificato.Changed = true;
            this.editPagamentoUnificato.Editing = false;
            this.editPagamentoUnificato.Label = "Pagamento unificato";
            this.editPagamentoUnificato.LabelWidth = 175;
            this.editPagamentoUnificato.Location = new System.Drawing.Point(25, 118);
            this.editPagamentoUnificato.Model = null;
            this.editPagamentoUnificato.Name = "editPagamentoUnificato";
            this.editPagamentoUnificato.ReadOnly = false;
            this.editPagamentoUnificato.Required = false;
            this.editPagamentoUnificato.Size = new System.Drawing.Size(800, 30);
            this.editPagamentoUnificato.TabIndex = 0;
            this.editPagamentoUnificato.Text = "EditControl";
            this.editPagamentoUnificato.Value = null;
            this.editPagamentoUnificato.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editPagamentoUnificato_ComboConfirm);
            this.editPagamentoUnificato.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editPagamentoUnificato_ComboClick);
            this.Controls.SetChildIndex(this.panelCommands, 0);
            this.Controls.SetChildIndex(this.container, 0);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditCombo editFatturaAcquisto;
        private Library.Template.Controls.TemplateEditDecimal editSaldo;
        private Library.Template.Controls.TemplateEditText editNote;
        private Library.Template.Controls.TemplateEditCombo editPagamentoUnificato;


    }
}
