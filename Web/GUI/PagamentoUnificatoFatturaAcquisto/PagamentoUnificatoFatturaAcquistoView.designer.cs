using System.Drawing;

namespace Web.GUI.PagamentoUnificatoFatturaAcquisto
{
    partial class PagamentoUnificatoFatturaAcquistoView
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
            this.editPagamentoUnificato = new Library.Template.Controls.TemplateEditCombo();
            this.panelCommands.SuspendLayout();
            this.panelAdvancedSearch.SuspendLayout();
            this.panelOrderBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdvancedSearch
            // 
            this.panelAdvancedSearch.Controls.Add(this.editPagamentoUnificato);
            this.panelAdvancedSearch.Controls.Add(this.editFatturaAcquisto);
            this.panelAdvancedSearch.Location = new System.Drawing.Point(244, 68);
            this.panelAdvancedSearch.Size = new System.Drawing.Size(622, 249);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnConfirmAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnCloseAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnCancelAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.lblTitleAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editFatturaAcquisto, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editPagamentoUnificato, 0);
            // 
            // btnCloseAdvancedSearch
            // 
            this.btnCloseAdvancedSearch.Location = new System.Drawing.Point(592, 2);
            // 
            // btnConfirmAdvancedSearch
            // 
            this.btnConfirmAdvancedSearch.Location = new System.Drawing.Point(487, 208);
            // 
            // btnCancelAdvancedSearch
            // 
            this.btnCancelAdvancedSearch.Location = new System.Drawing.Point(321, 208);
            // 
            // lblTitleAdvancedSearch
            // 
            this.lblTitleAdvancedSearch.Size = new System.Drawing.Size(584, 44);
            // 
            // editFatturaAcquisto
            // 
            this.editFatturaAcquisto.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editFatturaAcquisto.BackColor = System.Drawing.Color.Transparent;
            this.editFatturaAcquisto.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editFatturaAcquisto.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editFatturaAcquisto.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editFatturaAcquisto.Changed = false;
            this.editFatturaAcquisto.Editing = true;
            this.editFatturaAcquisto.Label = "Fattura di acquisto";
            this.editFatturaAcquisto.LabelWidth = 145;
            this.editFatturaAcquisto.Location = new System.Drawing.Point(19, 60);
            this.editFatturaAcquisto.Model = null;
            this.editFatturaAcquisto.Name = "editFatturaAcquisto";
            this.editFatturaAcquisto.ReadOnly = false;
            this.editFatturaAcquisto.Required = false;
            this.editFatturaAcquisto.Size = new System.Drawing.Size(572, 30);
            this.editFatturaAcquisto.TabIndex = 7;
            this.editFatturaAcquisto.Value = null;
            this.editFatturaAcquisto.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editFatturaAcquisto_ComboConfirm);
            this.editFatturaAcquisto.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editFatturaAcquisto_ComboClick);
            // 
            // editPagamentoUnificato
            // 
            this.editPagamentoUnificato.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editPagamentoUnificato.BackColor = System.Drawing.Color.Transparent;
            this.editPagamentoUnificato.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editPagamentoUnificato.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editPagamentoUnificato.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editPagamentoUnificato.Changed = false;
            this.editPagamentoUnificato.Editing = true;
            this.editPagamentoUnificato.Label = "Pagamento unificato";
            this.editPagamentoUnificato.LabelWidth = 145;
            this.editPagamentoUnificato.Location = new System.Drawing.Point(19, 105);
            this.editPagamentoUnificato.Model = null;
            this.editPagamentoUnificato.Name = "editPagamentoUnificato";
            this.editPagamentoUnificato.ReadOnly = false;
            this.editPagamentoUnificato.Required = false;
            this.editPagamentoUnificato.Size = new System.Drawing.Size(572, 30);
            this.editPagamentoUnificato.TabIndex = 7;
            this.editPagamentoUnificato.Value = null;
            this.editPagamentoUnificato.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editPagamentoUnificato_ComboConfirm);
            this.editPagamentoUnificato.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editPagamentoUnificato_ComboClick);
            this.Controls.SetChildIndex(this.panelAdvancedSearch, 0);
            this.Controls.SetChildIndex(this.panelOrderBy, 0);
            this.Controls.SetChildIndex(this.panelCommands, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnOrderBy, 0);
            this.Controls.SetChildIndex(this.btnAdvancedSearch, 0);
            this.panelCommands.ResumeLayout(false);
            this.panelAdvancedSearch.ResumeLayout(false);
            this.panelOrderBy.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditCombo editPagamentoUnificato;
        private Library.Template.Controls.TemplateEditCombo editFatturaAcquisto;
	}
}
