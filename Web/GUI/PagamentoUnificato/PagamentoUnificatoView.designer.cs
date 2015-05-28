using System.Drawing;

namespace Web.GUI.PagamentoUnificato
{
    partial class PagamentoUnificatoView
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
            this.optCodice = new Library.Template.Controls.TemplateEditOption();
            this.optData = new Library.Template.Controls.TemplateEditOption();
            this.editAnagraficaFornitore = new Library.Template.Controls.TemplateEditCombo();
            this.editDataInizio = new Library.Template.Controls.TemplateEditDate();
            this.editDataFine = new Library.Template.Controls.TemplateEditDate();
            this.panelCommands.SuspendLayout();
            this.panelAdvancedSearch.SuspendLayout();
            this.panelOrderBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdvancedSearch
            // 
            this.panelAdvancedSearch.Controls.Add(this.editDataFine);
            this.panelAdvancedSearch.Controls.Add(this.editDataInizio);
            this.panelAdvancedSearch.Controls.Add(this.editAnagraficaFornitore);
            this.panelAdvancedSearch.Location = new System.Drawing.Point(244, 68);
            this.panelAdvancedSearch.Size = new System.Drawing.Size(622, 249);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnConfirmAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnCloseAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnCancelAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.lblTitleAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editAnagraficaFornitore, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editDataInizio, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editDataFine, 0);
            // 
            // panelOrderBy
            // 
            this.panelOrderBy.Controls.Add(this.optData);
            this.panelOrderBy.Controls.Add(this.optCodice);
            this.panelOrderBy.Controls.SetChildIndex(this.btnConfirmOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.btnCloseOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.btnCancelOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.lblTitleOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optAscending, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optDescending, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optCodice, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optData, 0);
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
            // optCodice
            // 
            this.optCodice.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.optCodice.BackColor = System.Drawing.Color.Transparent;
            this.optCodice.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.optCodice.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.optCodice.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.optCodice.Changed = true;
            this.optCodice.Editing = true;
            this.optCodice.Group = "Option1";
            this.optCodice.Label = "";
            this.optCodice.LabelWidth = 0;
            this.optCodice.Location = new System.Drawing.Point(19, 59);
            this.optCodice.Name = "optCodice";
            this.optCodice.ReadOnly = false;
            this.optCodice.Required = false;
            this.optCodice.Size = new System.Drawing.Size(380, 30);
            this.optCodice.TabIndex = 2;
            this.optCodice.Text = "Codice";
            this.optCodice.Value = false;
            // 
            // optData
            // 
            this.optData.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.optData.BackColor = System.Drawing.Color.Transparent;
            this.optData.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.optData.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.optData.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.optData.Changed = true;
            this.optData.Editing = true;
            this.optData.Group = "Option1";
            this.optData.Label = "";
            this.optData.LabelWidth = 0;
            this.optData.Location = new System.Drawing.Point(19, 106);
            this.optData.Name = "optData";
            this.optData.ReadOnly = false;
            this.optData.Required = false;
            this.optData.Size = new System.Drawing.Size(380, 30);
            this.optData.TabIndex = 2;
            this.optData.Text = "Data";
            this.optData.Value = false;
            // 
            // editAnagraficaFornitore
            // 
            this.editAnagraficaFornitore.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editAnagraficaFornitore.BackColor = System.Drawing.Color.Transparent;
            this.editAnagraficaFornitore.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editAnagraficaFornitore.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editAnagraficaFornitore.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editAnagraficaFornitore.Changed = false;
            this.editAnagraficaFornitore.Editing = true;
            this.editAnagraficaFornitore.Label = "Fornitore";
            this.editAnagraficaFornitore.LabelWidth = 135;
            this.editAnagraficaFornitore.Location = new System.Drawing.Point(19, 60);
            this.editAnagraficaFornitore.Model = null;
            this.editAnagraficaFornitore.Name = "editAnagraficaFornitore";
            this.editAnagraficaFornitore.ReadOnly = false;
            this.editAnagraficaFornitore.Required = false;
            this.editAnagraficaFornitore.Size = new System.Drawing.Size(572, 30);
            this.editAnagraficaFornitore.TabIndex = 7;
            this.editAnagraficaFornitore.Value = null;
            this.editAnagraficaFornitore.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editAnagraficaFornitore_ComboConfirm);
            this.editAnagraficaFornitore.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editAnagraficaFornitore_ComboClick);
            // 
            // editDataInizio
            // 
            this.editDataInizio.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editDataInizio.BackColor = System.Drawing.Color.Transparent;
            this.editDataInizio.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editDataInizio.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editDataInizio.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editDataInizio.Changed = false;
            this.editDataInizio.Editing = true;
            this.editDataInizio.Label = "Data dal";
            this.editDataInizio.LabelWidth = 135;
            this.editDataInizio.Location = new System.Drawing.Point(19, 106);
            this.editDataInizio.Name = "editDataInizio";
            this.editDataInizio.ReadOnly = false;
            this.editDataInizio.Required = false;
            this.editDataInizio.Size = new System.Drawing.Size(572, 30);
            this.editDataInizio.TabIndex = 5;
            this.editDataInizio.Value = null;
            // 
            // editDataFine
            // 
            this.editDataFine.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editDataFine.BackColor = System.Drawing.Color.Transparent;
            this.editDataFine.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editDataFine.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editDataFine.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editDataFine.Changed = false;
            this.editDataFine.Editing = true;
            this.editDataFine.Label = "Data al";
            this.editDataFine.LabelWidth = 135;
            this.editDataFine.Location = new System.Drawing.Point(19, 152);
            this.editDataFine.Name = "editDataFine";
            this.editDataFine.ReadOnly = false;
            this.editDataFine.Required = false;
            this.editDataFine.Size = new System.Drawing.Size(572, 30);
            this.editDataFine.TabIndex = 7;
            this.editDataFine.Value = null;
            this.Controls.SetChildIndex(this.panelOrderBy, 0);
            this.Controls.SetChildIndex(this.panelCommands, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnOrderBy, 0);
            this.Controls.SetChildIndex(this.btnAdvancedSearch, 0);
            this.Controls.SetChildIndex(this.panelAdvancedSearch, 0);
            this.panelCommands.ResumeLayout(false);
            this.panelAdvancedSearch.ResumeLayout(false);
            this.panelOrderBy.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditOption optData;
        private Library.Template.Controls.TemplateEditOption optCodice;
        private Library.Template.Controls.TemplateEditDate editDataFine;
        private Library.Template.Controls.TemplateEditDate editDataInizio;
        private Library.Template.Controls.TemplateEditCombo editAnagraficaFornitore;
	}
}
