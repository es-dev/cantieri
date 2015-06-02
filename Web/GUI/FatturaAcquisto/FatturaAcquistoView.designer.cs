using System.Drawing;

namespace Web.GUI.FatturaAcquisto
{
    partial class FatturaAcquistoView
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
            this.optStato = new Library.Template.Controls.TemplateEditOption();
            this.optScadenza = new Library.Template.Controls.TemplateEditOption();
            this.optNumero = new Library.Template.Controls.TemplateEditOption();
            this.editScadenzaFine = new Library.Template.Controls.TemplateEditDate();
            this.editStato = new Library.Template.Controls.TemplateEditDropDown();
            this.editScadenzaInizio = new Library.Template.Controls.TemplateEditDate();
            this.editFornitore = new Library.Template.Controls.TemplateEditCombo();
            this.editCommessa = new Library.Template.Controls.TemplateEditCombo();
            this.editNumero = new Library.Template.Controls.TemplateEditText();
            this.editDataInizio = new Library.Template.Controls.TemplateEditDate();
            this.editDataFine = new Library.Template.Controls.TemplateEditDate();
            this.optData = new Library.Template.Controls.TemplateEditOption();
            this.panelCommands.SuspendLayout();
            this.panelAdvancedSearch.SuspendLayout();
            this.panelOrderBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdvancedSearch
            // 
            this.panelAdvancedSearch.Controls.Add(this.editDataFine);
            this.panelAdvancedSearch.Controls.Add(this.editDataInizio);
            this.panelAdvancedSearch.Controls.Add(this.editNumero);
            this.panelAdvancedSearch.Controls.Add(this.editCommessa);
            this.panelAdvancedSearch.Controls.Add(this.editFornitore);
            this.panelAdvancedSearch.Controls.Add(this.editScadenzaInizio);
            this.panelAdvancedSearch.Controls.Add(this.editStato);
            this.panelAdvancedSearch.Controls.Add(this.editScadenzaFine);
            this.panelAdvancedSearch.Location = new System.Drawing.Point(243, 68);
            this.panelAdvancedSearch.Size = new System.Drawing.Size(622, 468);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnConfirmAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnCloseAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnCancelAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.lblTitleAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editScadenzaFine, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editStato, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editScadenzaInizio, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editFornitore, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editCommessa, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editNumero, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editDataInizio, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editDataFine, 0);
            // 
            // panelOrderBy
            // 
            this.panelOrderBy.Controls.Add(this.optData);
            this.panelOrderBy.Controls.Add(this.optNumero);
            this.panelOrderBy.Controls.Add(this.optScadenza);
            this.panelOrderBy.Controls.Add(this.optStato);
            this.panelOrderBy.Size = new System.Drawing.Size(473, 305);
            this.panelOrderBy.Controls.SetChildIndex(this.btnConfirmOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.btnCloseOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.btnCancelOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.lblTitleOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optAscending, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optDescending, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optStato, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optScadenza, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optNumero, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optData, 0);
            // 
            // btnCloseAdvancedSearch
            // 
            this.btnCloseAdvancedSearch.Location = new System.Drawing.Point(592, 2);
            // 
            // btnConfirmAdvancedSearch
            // 
            this.btnConfirmAdvancedSearch.Location = new System.Drawing.Point(481, 421);
            this.btnConfirmAdvancedSearch.TabIndex = 6;
            // 
            // btnCancelAdvancedSearch
            // 
            this.btnCancelAdvancedSearch.Location = new System.Drawing.Point(315, 421);
            this.btnCancelAdvancedSearch.TabIndex = 5;
            // 
            // btnCancelOrderBy
            // 
            this.btnCancelOrderBy.Location = new System.Drawing.Point(146, 264);
            // 
            // btnConfirmOrderBy
            // 
            this.btnConfirmOrderBy.Location = new System.Drawing.Point(341, 264);
            // 
            // lblTitleAdvancedSearch
            // 
            this.lblTitleAdvancedSearch.Size = new System.Drawing.Size(584, 44);
            // 
            // optDescending
            // 
            this.optDescending.Location = new System.Drawing.Point(56, 271);
            // 
            // optAscending
            // 
            this.optAscending.Location = new System.Drawing.Point(9, 271);
            // 
            // optStato
            // 
            this.optStato.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.optStato.BackColor = System.Drawing.Color.Transparent;
            this.optStato.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.optStato.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.optStato.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.optStato.Changed = true;
            this.optStato.Editing = true;
            this.optStato.Group = "Option1";
            this.optStato.Label = "";
            this.optStato.LabelWidth = 0;
            this.optStato.Location = new System.Drawing.Point(16, 192);
            this.optStato.Name = "optStato";
            this.optStato.ReadOnly = false;
            this.optStato.Required = false;
            this.optStato.Size = new System.Drawing.Size(440, 30);
            this.optStato.TabIndex = 3;
            this.optStato.Text = "Stato";
            this.optStato.Value = false;
            // 
            // optScadenza
            // 
            this.optScadenza.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.optScadenza.BackColor = System.Drawing.Color.Transparent;
            this.optScadenza.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.optScadenza.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.optScadenza.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.optScadenza.Changed = true;
            this.optScadenza.Editing = true;
            this.optScadenza.Group = "Option1";
            this.optScadenza.Label = "";
            this.optScadenza.LabelWidth = 0;
            this.optScadenza.Location = new System.Drawing.Point(16, 145);
            this.optScadenza.Name = "optScadenza";
            this.optScadenza.ReadOnly = false;
            this.optScadenza.Required = false;
            this.optScadenza.Size = new System.Drawing.Size(440, 30);
            this.optScadenza.TabIndex = 2;
            this.optScadenza.Text = "Scadenza";
            this.optScadenza.Value = false;
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
            this.optNumero.Location = new System.Drawing.Point(16, 59);
            this.optNumero.Name = "optNumero";
            this.optNumero.ReadOnly = false;
            this.optNumero.Required = false;
            this.optNumero.Size = new System.Drawing.Size(440, 30);
            this.optNumero.TabIndex = 0;
            this.optNumero.Text = "Numero";
            this.optNumero.Value = false;
            // 
            // editScadenzaFine
            // 
            this.editScadenzaFine.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editScadenzaFine.BackColor = System.Drawing.Color.Transparent;
            this.editScadenzaFine.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editScadenzaFine.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editScadenzaFine.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editScadenzaFine.Changed = false;
            this.editScadenzaFine.Editing = true;
            this.editScadenzaFine.Label = "Scadenza al";
            this.editScadenzaFine.LabelWidth = 100;
            this.editScadenzaFine.Location = new System.Drawing.Point(16, 232);
            this.editScadenzaFine.Name = "editScadenzaFine";
            this.editScadenzaFine.ReadOnly = false;
            this.editScadenzaFine.Required = false;
            this.editScadenzaFine.Size = new System.Drawing.Size(572, 30);
            this.editScadenzaFine.TabIndex = 4;
            this.editScadenzaFine.Value = null;
            // 
            // editStato
            // 
            this.editStato.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editStato.BackColor = System.Drawing.Color.Transparent;
            this.editStato.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editStato.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editStato.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editStato.Changed = false;
            this.editStato.DisplayValues = null;
            this.editStato.Editing = true;
            this.editStato.Items = null;
            this.editStato.Label = "Stato";
            this.editStato.LabelWidth = 100;
            this.editStato.Location = new System.Drawing.Point(16, 146);
            this.editStato.Name = "editStato";
            this.editStato.ReadOnly = false;
            this.editStato.Required = false;
            this.editStato.Size = new System.Drawing.Size(572, 30);
            this.editStato.TabIndex = 2;
            this.editStato.Value = null;
            // 
            // editScadenzaInizio
            // 
            this.editScadenzaInizio.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editScadenzaInizio.BackColor = System.Drawing.Color.Transparent;
            this.editScadenzaInizio.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editScadenzaInizio.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editScadenzaInizio.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editScadenzaInizio.Changed = false;
            this.editScadenzaInizio.Editing = true;
            this.editScadenzaInizio.Label = "Scadenza dal";
            this.editScadenzaInizio.LabelWidth = 100;
            this.editScadenzaInizio.Location = new System.Drawing.Point(16, 189);
            this.editScadenzaInizio.Name = "editScadenzaInizio";
            this.editScadenzaInizio.ReadOnly = false;
            this.editScadenzaInizio.Required = false;
            this.editScadenzaInizio.Size = new System.Drawing.Size(572, 30);
            this.editScadenzaInizio.TabIndex = 3;
            this.editScadenzaInizio.Value = null;
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
            this.editFornitore.Location = new System.Drawing.Point(16, 103);
            this.editFornitore.Model = null;
            this.editFornitore.Name = "editFornitore";
            this.editFornitore.ReadOnly = false;
            this.editFornitore.Required = false;
            this.editFornitore.Size = new System.Drawing.Size(572, 30);
            this.editFornitore.TabIndex = 1;
            this.editFornitore.Value = null;
            this.editFornitore.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editFornitore_ComboConfirm);
            this.editFornitore.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editFornitore_ComboClick);
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
            this.editCommessa.Location = new System.Drawing.Point(16, 60);
            this.editCommessa.Model = null;
            this.editCommessa.Name = "editCommessa";
            this.editCommessa.ReadOnly = false;
            this.editCommessa.Required = false;
            this.editCommessa.Size = new System.Drawing.Size(572, 30);
            this.editCommessa.TabIndex = 0;
            this.editCommessa.Value = null;
            this.editCommessa.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editCommessa_ComboConfirm);
            this.editCommessa.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editCommessa_ComboClick);
            // 
            // editNumero
            // 
            this.editNumero.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editNumero.BackColor = System.Drawing.Color.Transparent;
            this.editNumero.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editNumero.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editNumero.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editNumero.Changed = false;
            this.editNumero.Editing = true;
            this.editNumero.Label = "Numero";
            this.editNumero.LabelWidth = 100;
            this.editNumero.Location = new System.Drawing.Point(16, 275);
            this.editNumero.Name = "editNumero";
            this.editNumero.ReadOnly = false;
            this.editNumero.Required = false;
            this.editNumero.Size = new System.Drawing.Size(572, 30);
            this.editNumero.TabIndex = 5;
            this.editNumero.Value = null;
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
            this.editDataInizio.Location = new System.Drawing.Point(16, 318);
            this.editDataInizio.Name = "editDataInizio";
            this.editDataInizio.ReadOnly = false;
            this.editDataInizio.Required = false;
            this.editDataInizio.Size = new System.Drawing.Size(572, 30);
            this.editDataInizio.TabIndex = 6;
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
            this.editDataFine.Location = new System.Drawing.Point(16, 361);
            this.editDataFine.Name = "editDataFine";
            this.editDataFine.ReadOnly = false;
            this.editDataFine.Required = false;
            this.editDataFine.Size = new System.Drawing.Size(572, 30);
            this.editDataFine.TabIndex = 7;
            this.editDataFine.Value = null;
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
            this.optData.Location = new System.Drawing.Point(16, 102);
            this.optData.Name = "optData";
            this.optData.ReadOnly = false;
            this.optData.Required = false;
            this.optData.Size = new System.Drawing.Size(440, 30);
            this.optData.TabIndex = 1;
            this.optData.Text = "Data";
            this.optData.Value = false;
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

        private Library.Template.Controls.TemplateEditOption optNumero;
        private Library.Template.Controls.TemplateEditOption optScadenza;
        private Library.Template.Controls.TemplateEditOption optStato;
        private Library.Template.Controls.TemplateEditDate editScadenzaInizio;
        private Library.Template.Controls.TemplateEditDropDown editStato;
        private Library.Template.Controls.TemplateEditDate editScadenzaFine;
        private Library.Template.Controls.TemplateEditCombo editFornitore;
        private Library.Template.Controls.TemplateEditCombo editCommessa;
        private Library.Template.Controls.TemplateEditDate editDataFine;
        private Library.Template.Controls.TemplateEditDate editDataInizio;
        private Library.Template.Controls.TemplateEditText editNumero;
        private Library.Template.Controls.TemplateEditOption optData;
	}
}
