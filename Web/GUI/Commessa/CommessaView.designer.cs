using System.Drawing;

namespace Web.GUI.Commessa
{
    partial class CommessaView
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
            this.editScadenzaInizio = new Library.Template.Controls.TemplateEditDate();
            this.editStato = new Library.Template.Controls.TemplateEditDropDown();
            this.editScadenzaFine = new Library.Template.Controls.TemplateEditDate();
            this.optDenominazione = new Library.Template.Controls.TemplateEditOption();
            this.optScadenza = new Library.Template.Controls.TemplateEditOption();
            this.optStato = new Library.Template.Controls.TemplateEditOption();
            this.panelCommands.SuspendLayout();
            this.panelAdvancedSearch.SuspendLayout();
            this.panelOrderBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdvancedSearch
            // 
            this.panelAdvancedSearch.Controls.Add(this.editScadenzaFine);
            this.panelAdvancedSearch.Controls.Add(this.editStato);
            this.panelAdvancedSearch.Controls.Add(this.editScadenzaInizio);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.lblTitleAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnConfirmAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnCloseAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.btnCancelAdvancedSearch, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editScadenzaInizio, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editStato, 0);
            this.panelAdvancedSearch.Controls.SetChildIndex(this.editScadenzaFine, 0);
            // 
            // panelOrderBy
            // 
            this.panelOrderBy.Controls.Add(this.optStato);
            this.panelOrderBy.Controls.Add(this.optScadenza);
            this.panelOrderBy.Controls.Add(this.optDenominazione);
            this.panelOrderBy.Location = new System.Drawing.Point(237, 69);
            this.panelOrderBy.Size = new System.Drawing.Size(473, 248);
            this.panelOrderBy.Controls.SetChildIndex(this.optAscending, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optDescending, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.lblTitleOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.btnConfirmOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.btnCloseOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.btnCancelOrderBy, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optDenominazione, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optScadenza, 0);
            this.panelOrderBy.Controls.SetChildIndex(this.optStato, 0);
            // 
            // btnConfirmAdvancedSearch
            // 
            this.btnConfirmAdvancedSearch.Location = new System.Drawing.Point(299, 208);
            // 
            // btnCancelAdvancedSearch
            // 
            this.btnCancelAdvancedSearch.Location = new System.Drawing.Point(130, 209);
            // 
            // btnCloseOrderBy
            // 
            this.btnCloseOrderBy.Location = new System.Drawing.Point(440, 2);
            // 
            // btnConfirmOrderBy
            // 
            this.btnConfirmOrderBy.Location = new System.Drawing.Point(339, 208);
            // 
            // lblTitleOrderBy
            // 
            this.lblTitleOrderBy.Size = new System.Drawing.Size(328, 44);
            // 
            // optDescending
            // 
            this.optDescending.Location = new System.Drawing.Point(379, 2);
            // 
            // optAscending
            // 
            this.optAscending.Location = new System.Drawing.Point(335, 2);
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
            this.editScadenzaInizio.LabelWidth = 150;
            this.editScadenzaInizio.Location = new System.Drawing.Point(19, 102);
            this.editScadenzaInizio.Name = "editScadenzaInizio";
            this.editScadenzaInizio.ReadOnly = false;
            this.editScadenzaInizio.Required = false;
            this.editScadenzaInizio.Size = new System.Drawing.Size(398, 30);
            this.editScadenzaInizio.TabIndex = 5;
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
            this.editStato.LabelWidth = 150;
            this.editStato.Location = new System.Drawing.Point(19, 60);
            this.editStato.Name = "editStato";
            this.editStato.ReadOnly = false;
            this.editStato.Required = false;
            this.editStato.Size = new System.Drawing.Size(398, 30);
            this.editStato.TabIndex = 6;
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
            this.editScadenzaFine.LabelWidth = 150;
            this.editScadenzaFine.Location = new System.Drawing.Point(19, 144);
            this.editScadenzaFine.Name = "editScadenzaFine";
            this.editScadenzaFine.ReadOnly = false;
            this.editScadenzaFine.Required = false;
            this.editScadenzaFine.Size = new System.Drawing.Size(398, 30);
            this.editScadenzaFine.TabIndex = 7;
            this.editScadenzaFine.Value = null;
            // 
            // optDenominazione
            // 
            this.optDenominazione.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.optDenominazione.BackColor = System.Drawing.Color.Transparent;
            this.optDenominazione.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.optDenominazione.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.optDenominazione.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.optDenominazione.Changed = true;
            this.optDenominazione.Editing = true;
            this.optDenominazione.Group = "Option1";
            this.optDenominazione.Label = "";
            this.optDenominazione.LabelWidth = 0;
            this.optDenominazione.Location = new System.Drawing.Point(19, 59);
            this.optDenominazione.Name = "optDenominazione";
            this.optDenominazione.ReadOnly = false;
            this.optDenominazione.Required = false;
            this.optDenominazione.Size = new System.Drawing.Size(380, 30);
            this.optDenominazione.TabIndex = 2;
            this.optDenominazione.Text = "Denominazione";
            this.optDenominazione.Value = false;
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
            this.optScadenza.Location = new System.Drawing.Point(19, 101);
            this.optScadenza.Name = "optScadenza";
            this.optScadenza.ReadOnly = false;
            this.optScadenza.Required = false;
            this.optScadenza.Size = new System.Drawing.Size(380, 30);
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
            this.optStato.Location = new System.Drawing.Point(19, 143);
            this.optStato.Name = "optStato";
            this.optStato.ReadOnly = false;
            this.optStato.Required = false;
            this.optStato.Size = new System.Drawing.Size(380, 30);
            this.optStato.TabIndex = 2;
            this.optStato.Text = "Stato";
            this.optStato.Value = false;
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

        private Library.Template.Controls.TemplateEditDate editScadenzaFine;
        private Library.Template.Controls.TemplateEditDropDown editStato;
        private Library.Template.Controls.TemplateEditDate editScadenzaInizio;
        private Library.Template.Controls.TemplateEditOption optDenominazione;
        private Library.Template.Controls.TemplateEditOption optStato;
        private Library.Template.Controls.TemplateEditOption optScadenza;

    }
}
