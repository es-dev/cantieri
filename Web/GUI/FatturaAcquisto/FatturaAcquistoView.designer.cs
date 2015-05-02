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
            this.panelCommands.SuspendLayout();
            this.panelAdvancedSearch.SuspendLayout();
            this.panelOrderBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdvancedSearch
            // 
            this.panelAdvancedSearch.Controls.Add(this.editFornitore);
            this.panelAdvancedSearch.Controls.Add(this.editScadenzaInizio);
            this.panelAdvancedSearch.Controls.Add(this.editStato);
            this.panelAdvancedSearch.Controls.Add(this.editScadenzaFine);
            this.panelAdvancedSearch.Location = new System.Drawing.Point(244, 68);
            this.panelAdvancedSearch.Size = new System.Drawing.Size(622, 307);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnConfirmAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnCloseAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnCancelAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.lblTitleAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editScadenzaFine, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editStato, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editScadenzaInizio, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editFornitore, 0);
            // 
            // panelOrderBy
            // 
            this.panelOrderBy.Controls.Add(this.optNumero);
            this.panelOrderBy.Controls.Add(this.optScadenza);
            this.panelOrderBy.Controls.Add(this.optStato);
            this.panelOrderBy.Controls.SetChildIndex(this.btnConfirmOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.btnCloseOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.btnCancelOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.lblTitleOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optAscending, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optDescending, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optStato, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optScadenza, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optNumero, 0);
            // 
            // btnCloseAdvancedSearch
            // 
            this.btnCloseAdvancedSearch.Location = new System.Drawing.Point(592, 2);
            // 
            // btnConfirmAdvancedSearch
            // 
            this.btnConfirmAdvancedSearch.Location = new System.Drawing.Point(487, 266);
            // 
            // btnCancelAdvancedSearch
            // 
            this.btnCancelAdvancedSearch.Location = new System.Drawing.Point(321, 266);
            // 
            // lblTitleAdvancedSearch
            // 
            this.lblTitleAdvancedSearch.Size = new System.Drawing.Size(584, 44);
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
            this.optStato.Location = new System.Drawing.Point(19, 153);
            this.optStato.Name = "optStato";
            this.optStato.ReadOnly = false;
            this.optStato.Required = false;
            this.optStato.Size = new System.Drawing.Size(380, 30);
            this.optStato.TabIndex = 2;
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
            this.optScadenza.Location = new System.Drawing.Point(19, 106);
            this.optScadenza.Name = "optScadenza";
            this.optScadenza.ReadOnly = false;
            this.optScadenza.Required = false;
            this.optScadenza.Size = new System.Drawing.Size(380, 30);
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
            this.optNumero.Location = new System.Drawing.Point(19, 59);
            this.optNumero.Name = "optNumero";
            this.optNumero.ReadOnly = false;
            this.optNumero.Required = false;
            this.optNumero.Size = new System.Drawing.Size(380, 30);
            this.optNumero.TabIndex = 2;
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
            this.editScadenzaFine.Location = new System.Drawing.Point(19, 158);
            this.editScadenzaFine.Name = "editScadenzaFine";
            this.editScadenzaFine.ReadOnly = false;
            this.editScadenzaFine.Required = false;
            this.editScadenzaFine.Size = new System.Drawing.Size(572, 30);
            this.editScadenzaFine.TabIndex = 7;
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
            this.editStato.Location = new System.Drawing.Point(19, 109);
            this.editStato.Name = "editStato";
            this.editStato.ReadOnly = false;
            this.editStato.Required = false;
            this.editStato.Size = new System.Drawing.Size(572, 30);
            this.editStato.TabIndex = 6;
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
            this.editScadenzaInizio.Location = new System.Drawing.Point(19, 207);
            this.editScadenzaInizio.Name = "editScadenzaInizio";
            this.editScadenzaInizio.ReadOnly = false;
            this.editScadenzaInizio.Required = false;
            this.editScadenzaInizio.Size = new System.Drawing.Size(572, 30);
            this.editScadenzaInizio.TabIndex = 5;
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
            this.editFornitore.Location = new System.Drawing.Point(19, 60);
            this.editFornitore.Model = null;
            this.editFornitore.Name = "editFornitore";
            this.editFornitore.ReadOnly = false;
            this.editFornitore.Required = false;
            this.editFornitore.Size = new System.Drawing.Size(572, 30);
            this.editFornitore.TabIndex = 7;
            this.editFornitore.Value = null;
            this.editFornitore.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editFornitore_ComboConfirm);
            this.editFornitore.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editFornitore_ComboClick);
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

        private Library.Template.Controls.TemplateEditOption optNumero;
        private Library.Template.Controls.TemplateEditOption optScadenza;
        private Library.Template.Controls.TemplateEditOption optStato;
        private Library.Template.Controls.TemplateEditDate editScadenzaInizio;
        private Library.Template.Controls.TemplateEditDropDown editStato;
        private Library.Template.Controls.TemplateEditDate editScadenzaFine;
        private Library.Template.Controls.TemplateEditCombo editFornitore;
	}
}
