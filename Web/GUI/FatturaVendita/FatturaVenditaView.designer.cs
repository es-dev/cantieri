using System.Drawing;

namespace Web.GUI.FatturaVendita
{
    partial class FatturaVenditaView
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
            this.editCommittente = new Library.Template.Controls.TemplateEditCombo();
            this.editScadenzaInizio = new Library.Template.Controls.TemplateEditDate();
            this.editStato = new Library.Template.Controls.TemplateEditDropDown();
            this.editScadenzaFine = new Library.Template.Controls.TemplateEditDate();
            this.optNumero = new Library.Template.Controls.TemplateEditOption();
            this.optScadenza = new Library.Template.Controls.TemplateEditOption();
            this.optStato = new Library.Template.Controls.TemplateEditOption();
            this.editCommessa = new Library.Template.Controls.TemplateEditCombo();
            this.panelCommands.SuspendLayout();
            this.panelAdvancedSearch.SuspendLayout();
            this.panelOrderBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdvancedSearch
            // 
            this.panelAdvancedSearch.Controls.Add(this.editCommessa);
            this.panelAdvancedSearch.Controls.Add(this.editScadenzaFine);
            this.panelAdvancedSearch.Controls.Add(this.editStato);
            this.panelAdvancedSearch.Controls.Add(this.editScadenzaInizio);
            this.panelAdvancedSearch.Controls.Add(this.editCommittente);
            this.panelAdvancedSearch.Location = new System.Drawing.Point(243, 68);
            this.panelAdvancedSearch.Size = new System.Drawing.Size(623, 356);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnConfirmAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnCloseAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnCancelAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.lblTitleAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editCommittente, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editScadenzaInizio, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editStato, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editScadenzaFine, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editCommessa, 0);
            // 
            // panelOrderBy
            // 
            this.panelOrderBy.Controls.Add(this.optStato);
            this.panelOrderBy.Controls.Add(this.optScadenza);
            this.panelOrderBy.Controls.Add(this.optNumero);
            this.panelOrderBy.Controls.SetChildIndex(this.btnConfirmOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.btnCloseOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.btnCancelOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.lblTitleOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optAscending, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optDescending, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optNumero, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optScadenza, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optStato, 0);
            // 
            // btnCloseAdvancedSearch
            // 
            this.btnCloseAdvancedSearch.Location = new System.Drawing.Point(593, 2);
            // 
            // btnConfirmAdvancedSearch
            // 
            this.btnConfirmAdvancedSearch.Location = new System.Drawing.Point(486, 313);
            // 
            // btnCancelAdvancedSearch
            // 
            this.btnCancelAdvancedSearch.Location = new System.Drawing.Point(320, 313);
            // 
            // lblTitleAdvancedSearch
            // 
            this.lblTitleAdvancedSearch.Size = new System.Drawing.Size(585, 44);
            // 
            // editCommittente
            // 
            this.editCommittente.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editCommittente.BackColor = System.Drawing.Color.Transparent;
            this.editCommittente.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editCommittente.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editCommittente.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editCommittente.Changed = false;
            this.editCommittente.Editing = true;
            this.editCommittente.Label = "Committente";
            this.editCommittente.LabelWidth = 110;
            this.editCommittente.Location = new System.Drawing.Point(19, 105);
            this.editCommittente.Model = null;
            this.editCommittente.Name = "editCommittente";
            this.editCommittente.ReadOnly = false;
            this.editCommittente.Required = false;
            this.editCommittente.Size = new System.Drawing.Size(572, 30);
            this.editCommittente.TabIndex = 1;
            this.editCommittente.Value = null;
            this.editCommittente.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editCommittente_ComboConfirm);
            this.editCommittente.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editCommittente_ComboClick);
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
            this.editScadenzaInizio.LabelWidth = 110;
            this.editScadenzaInizio.Location = new System.Drawing.Point(19, 199);
            this.editScadenzaInizio.Name = "editScadenzaInizio";
            this.editScadenzaInizio.ReadOnly = false;
            this.editScadenzaInizio.Required = false;
            this.editScadenzaInizio.Size = new System.Drawing.Size(572, 30);
            this.editScadenzaInizio.TabIndex = 3;
            this.editScadenzaInizio.Value = null;
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
            this.editStato.LabelWidth = 110;
            this.editStato.Location = new System.Drawing.Point(19, 152);
            this.editStato.Name = "editStato";
            this.editStato.ReadOnly = false;
            this.editStato.Required = false;
            this.editStato.Size = new System.Drawing.Size(572, 30);
            this.editStato.TabIndex = 2;
            this.editStato.Value = null;
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
            this.editScadenzaFine.LabelWidth = 110;
            this.editScadenzaFine.Location = new System.Drawing.Point(19, 246);
            this.editScadenzaFine.Name = "editScadenzaFine";
            this.editScadenzaFine.ReadOnly = false;
            this.editScadenzaFine.Required = false;
            this.editScadenzaFine.Size = new System.Drawing.Size(572, 30);
            this.editScadenzaFine.TabIndex = 4;
            this.editScadenzaFine.Value = null;
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
            this.optNumero.Size = new System.Drawing.Size(440, 30);
            this.optNumero.TabIndex = 2;
            this.optNumero.Text = "Numero";
            this.optNumero.Value = false;
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
            this.optScadenza.Size = new System.Drawing.Size(440, 30);
            this.optScadenza.TabIndex = 2;
            this.optScadenza.Text = "Scadenza";
            this.optScadenza.Value = false;
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
            this.optStato.Size = new System.Drawing.Size(440, 30);
            this.optStato.TabIndex = 2;
            this.optStato.Text = "Stato";
            this.optStato.Value = false;
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
            this.editCommessa.LabelWidth = 110;
            this.editCommessa.Location = new System.Drawing.Point(19, 58);
            this.editCommessa.Model = null;
            this.editCommessa.Name = "editCommessa";
            this.editCommessa.ReadOnly = false;
            this.editCommessa.Required = false;
            this.editCommessa.Size = new System.Drawing.Size(572, 30);
            this.editCommessa.TabIndex = 0;
            this.editCommessa.Value = null;
            this.editCommessa.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editCommessa_ComboConfirm);
            this.editCommessa.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editCommessa_ComboClick);
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

        private Library.Template.Controls.TemplateEditDate editScadenzaFine;
        private Library.Template.Controls.TemplateEditDropDown editStato;
        private Library.Template.Controls.TemplateEditDate editScadenzaInizio;
        private Library.Template.Controls.TemplateEditCombo editCommittente;
        private Library.Template.Controls.TemplateEditOption optStato;
        private Library.Template.Controls.TemplateEditOption optScadenza;
        private Library.Template.Controls.TemplateEditOption optNumero;
        private Library.Template.Controls.TemplateEditCombo editCommessa;
	}
}
