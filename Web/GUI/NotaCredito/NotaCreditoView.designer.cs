using System.Drawing;

namespace Web.GUI.NotaCredito
{
    partial class NotaCreditoView
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
            this.optNumero = new Library.Template.Controls.TemplateEditOption();
            this.optData = new Library.Template.Controls.TemplateEditOption();
            this.editFornitore = new Library.Template.Controls.TemplateEditCombo();
            this.editDataInizio = new Library.Template.Controls.TemplateEditDate();
            this.editDataFine = new Library.Template.Controls.TemplateEditDate();
            this.editCommessa = new Library.Template.Controls.TemplateEditCombo();
            this.panelCommands.SuspendLayout();
            this.panelAdvancedSearch.SuspendLayout();
            this.panelOrderBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdvancedSearch
            // 
            this.panelAdvancedSearch.Controls.Add(this.editCommessa);
            this.panelAdvancedSearch.Controls.Add(this.editDataFine);
            this.panelAdvancedSearch.Controls.Add(this.editDataInizio);
            this.panelAdvancedSearch.Controls.Add(this.editFornitore);
            this.panelAdvancedSearch.Location = new System.Drawing.Point(244, 68);
            this.panelAdvancedSearch.Size = new System.Drawing.Size(622, 309);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnConfirmAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnCloseAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnCancelAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.lblTitleAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editFornitore, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editDataInizio, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editDataFine, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editCommessa, 0);
            // 
            // panelOrderBy
            // 
            this.panelOrderBy.Controls.Add(this.optData);
            this.panelOrderBy.Controls.Add(this.optNumero);
            this.panelOrderBy.Size = new System.Drawing.Size(473, 212);
            this.panelOrderBy.Controls.SetChildIndex(this.btnConfirmOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.btnCloseOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.btnCancelOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.lblTitleOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optAscending, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optDescending, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optNumero, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optData, 0);
            // 
            // btnCloseAdvancedSearch
            // 
            this.btnCloseAdvancedSearch.Location = new System.Drawing.Point(592, 2);
            // 
            // btnConfirmAdvancedSearch
            // 
            this.btnConfirmAdvancedSearch.Location = new System.Drawing.Point(483, 264);
            // 
            // btnCancelAdvancedSearch
            // 
            this.btnCancelAdvancedSearch.Location = new System.Drawing.Point(317, 264);
            // 
            // btnCancelOrderBy
            // 
            this.btnCancelOrderBy.Location = new System.Drawing.Point(146, 171);
            // 
            // btnConfirmOrderBy
            // 
            this.btnConfirmOrderBy.Location = new System.Drawing.Point(341, 171);
            // 
            // lblTitleAdvancedSearch
            // 
            this.lblTitleAdvancedSearch.Size = new System.Drawing.Size(584, 44);
            // 
            // optDescending
            // 
            this.optDescending.Location = new System.Drawing.Point(56, 178);
            // 
            // optAscending
            // 
            this.optAscending.Location = new System.Drawing.Point(9, 178);
            // 
            // optNumero
            // 
            this.optNumero.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.optNumero.BackColor = System.Drawing.Color.Transparent;
            this.optNumero.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.optNumero.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.optNumero.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.optNumero.Changed = true;
            this.optNumero.Editing = true;
            this.optNumero.Group = "Option1";
            this.optNumero.Label = "";
            this.optNumero.LabelWidth = 0;
            this.optNumero.Location = new System.Drawing.Point(19, 59);
            this.optNumero.Name = "optNumero";
            this.optNumero.ReadOnly = false;
            this.optNumero.Required = false;
            this.optNumero.Size = new System.Drawing.Size(438, 30);
            this.optNumero.TabIndex = 2;
            this.optNumero.Text = "Numero";
            this.optNumero.Value = false;
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
            this.optData.Size = new System.Drawing.Size(438, 30);
            this.optData.TabIndex = 2;
            this.optData.Text = "Data";
            this.optData.Value = false;
            // 
            // editFornitore
            // 
            this.editFornitore.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editFornitore.BackColor = System.Drawing.Color.Transparent;
            this.editFornitore.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editFornitore.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editFornitore.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editFornitore.Changed = false;
            this.editFornitore.Editing = true;
            this.editFornitore.Label = "Fornitore";
            this.editFornitore.LabelWidth = 100;
            this.editFornitore.Location = new System.Drawing.Point(22, 108);
            this.editFornitore.Model = null;
            this.editFornitore.Name = "editFornitore";
            this.editFornitore.ReadOnly = false;
            this.editFornitore.Required = false;
            this.editFornitore.Size = new System.Drawing.Size(572, 30);
            this.editFornitore.TabIndex = 7;
            this.editFornitore.Value = null;
            this.editFornitore.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editFornitore_ComboConfirm);
            this.editFornitore.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editFornitore_ComboClick);
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
            this.editDataInizio.LabelWidth = 100;
            this.editDataInizio.Location = new System.Drawing.Point(22, 156);
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
            this.editDataFine.LabelWidth = 100;
            this.editDataFine.Location = new System.Drawing.Point(22, 204);
            this.editDataFine.Name = "editDataFine";
            this.editDataFine.ReadOnly = false;
            this.editDataFine.Required = false;
            this.editDataFine.Size = new System.Drawing.Size(572, 30);
            this.editDataFine.TabIndex = 7;
            this.editDataFine.Value = null;
            // 
            // editCommessa
            // 
            this.editCommessa.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editCommessa.BackColor = System.Drawing.Color.Transparent;
            this.editCommessa.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editCommessa.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editCommessa.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editCommessa.Changed = false;
            this.editCommessa.Editing = true;
            this.editCommessa.Label = "Commessa";
            this.editCommessa.LabelWidth = 100;
            this.editCommessa.Location = new System.Drawing.Point(22, 60);
            this.editCommessa.Model = null;
            this.editCommessa.Name = "editCommessa";
            this.editCommessa.ReadOnly = false;
            this.editCommessa.Required = false;
            this.editCommessa.Size = new System.Drawing.Size(572, 30);
            this.editCommessa.TabIndex = 0;
            this.editCommessa.Value = null;
            this.editCommessa.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editCommessa_ComboConfirm);
            this.editCommessa.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editCommessa_ComboClick);
            this.Controls.SetChildIndex(this.panelCommands, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnOrderBy, 0);
            this.Controls.SetChildIndex(this.btnAdvancedSearch, 0);
            this.Controls.SetChildIndex(this.panelAdvancedSearch, 0);
            this.Controls.SetChildIndex(this.panelOrderBy, 0);
            this.panelCommands.ResumeLayout(false);
            this.panelAdvancedSearch.ResumeLayout(false);
            this.panelOrderBy.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditOption optData;
        private Library.Template.Controls.TemplateEditOption optNumero;
        private Library.Template.Controls.TemplateEditDate editDataFine;
        private Library.Template.Controls.TemplateEditDate editDataInizio;
        private Library.Template.Controls.TemplateEditCombo editFornitore;
        private Library.Template.Controls.TemplateEditCombo editCommessa;
	}
}
