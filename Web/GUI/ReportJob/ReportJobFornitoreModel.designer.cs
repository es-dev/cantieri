using System.Drawing;

namespace Web.GUI.ReportJob
{
    partial class ReportJobFornitoreModel
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
            this.editDenominazione = new Library.Template.Controls.TemplateEditText();
            this.editFornitore = new Library.Template.Controls.TemplateEditCombo();
            this.editTipoReport = new Library.Template.Controls.TemplateEditDropDown();
            this.editNote = new Library.Template.Controls.TemplateEditText();
            this.editCreazione = new Library.Template.Controls.TemplateEditDate();
            this.editElaborazione = new Library.Template.Controls.TemplateEditDate();
            this.editCodice = new Library.Template.Controls.TemplateEditText();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editCodice);
            this.container.Controls.Add(this.editElaborazione);
            this.container.Controls.Add(this.editCreazione);
            this.container.Controls.Add(this.editNote);
            this.container.Controls.Add(this.editTipoReport);
            this.container.Controls.Add(this.editFornitore);
            this.container.Controls.Add(this.editDenominazione);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editDenominazione, 0);
            this.container.Controls.SetChildIndex(this.editFornitore, 0);
            this.container.Controls.SetChildIndex(this.editTipoReport, 0);
            this.container.Controls.SetChildIndex(this.editNote, 0);
            this.container.Controls.SetChildIndex(this.editCreazione, 0);
            this.container.Controls.SetChildIndex(this.editElaborazione, 0);
            this.container.Controls.SetChildIndex(this.editCodice, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(666, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(610, 3);
            // 
            // editDenominazione
            // 
            this.editDenominazione.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editDenominazione.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editDenominazione.BackColor = System.Drawing.Color.Transparent;
            this.editDenominazione.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editDenominazione.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editDenominazione.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editDenominazione.Changed = true;
            this.editDenominazione.Editing = false;
            this.editDenominazione.Label = "Denominazione";
            this.editDenominazione.LabelWidth = 175;
            this.editDenominazione.Location = new System.Drawing.Point(25, 165);
            this.editDenominazione.Name = "editDenominazione";
            this.editDenominazione.ReadOnly = false;
            this.editDenominazione.Required = false;
            this.editDenominazione.Size = new System.Drawing.Size(794, 30);
            this.editDenominazione.TabIndex = 2;
            this.editDenominazione.Text = "EditControl";
            this.editDenominazione.Value = null;
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
            this.editFornitore.Label = "Codice fornitore";
            this.editFornitore.LabelWidth = 175;
            this.editFornitore.Location = new System.Drawing.Point(25, 207);
            this.editFornitore.Model = null;
            this.editFornitore.Name = "editFornitore";
            this.editFornitore.ReadOnly = false;
            this.editFornitore.Required = false;
            this.editFornitore.Size = new System.Drawing.Size(794, 30);
            this.editFornitore.TabIndex = 1000;
            this.editFornitore.Value = null;
            this.editFornitore.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editFornitore_ComboConfirm);
            this.editFornitore.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editFornitore_ComboClick);
            // 
            // editTipoReport
            // 
            this.editTipoReport.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTipoReport.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTipoReport.BackColor = System.Drawing.Color.Transparent;
            this.editTipoReport.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTipoReport.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTipoReport.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTipoReport.Changed = true;
            this.editTipoReport.DisplayValues = null;
            this.editTipoReport.Editing = false;
            this.editTipoReport.Items = null;
            this.editTipoReport.Label = "Tipo";
            this.editTipoReport.LabelWidth = 175;
            this.editTipoReport.Location = new System.Drawing.Point(25, 75);
            this.editTipoReport.Name = "editTipoReport";
            this.editTipoReport.ReadOnly = false;
            this.editTipoReport.Required = false;
            this.editTipoReport.Size = new System.Drawing.Size(794, 30);
            this.editTipoReport.TabIndex = 1001;
            this.editTipoReport.Value = null;
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
            this.editNote.Location = new System.Drawing.Point(25, 346);
            this.editNote.Name = "editNote";
            this.editNote.ReadOnly = false;
            this.editNote.Required = false;
            this.editNote.Size = new System.Drawing.Size(794, 30);
            this.editNote.TabIndex = 1002;
            this.editNote.Value = null;
            // 
            // editCreazione
            // 
            this.editCreazione.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editCreazione.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editCreazione.BackColor = System.Drawing.Color.Transparent;
            this.editCreazione.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editCreazione.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editCreazione.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editCreazione.Changed = true;
            this.editCreazione.Editing = false;
            this.editCreazione.Label = "Creazione";
            this.editCreazione.LabelWidth = 175;
            this.editCreazione.Location = new System.Drawing.Point(25, 253);
            this.editCreazione.Name = "editCreazione";
            this.editCreazione.ReadOnly = false;
            this.editCreazione.Required = false;
            this.editCreazione.Size = new System.Drawing.Size(794, 30);
            this.editCreazione.TabIndex = 1003;
            this.editCreazione.Value = null;
            // 
            // editElaborazione
            // 
            this.editElaborazione.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editElaborazione.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editElaborazione.BackColor = System.Drawing.Color.Transparent;
            this.editElaborazione.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editElaborazione.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editElaborazione.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editElaborazione.Changed = true;
            this.editElaborazione.Editing = false;
            this.editElaborazione.Label = "Elaborazione";
            this.editElaborazione.LabelWidth = 175;
            this.editElaborazione.Location = new System.Drawing.Point(25, 303);
            this.editElaborazione.Name = "editElaborazione";
            this.editElaborazione.ReadOnly = false;
            this.editElaborazione.Required = false;
            this.editElaborazione.Size = new System.Drawing.Size(794, 30);
            this.editElaborazione.TabIndex = 1004;
            this.editElaborazione.Value = null;
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
            this.editCodice.Location = new System.Drawing.Point(25, 122);
            this.editCodice.Name = "editCodice";
            this.editCodice.ReadOnly = false;
            this.editCodice.Required = false;
            this.editCodice.Size = new System.Drawing.Size(794, 30);
            this.editCodice.TabIndex = 1005;
            this.editCodice.Value = null;
            this.Controls.SetChildIndex(this.panelCommands, 0);
            this.Controls.SetChildIndex(this.container, 0);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditText editDenominazione;
        private Library.Template.Controls.TemplateEditCombo editFornitore;
        private Library.Template.Controls.TemplateEditDropDown editTipoReport;
        private Library.Template.Controls.TemplateEditDate editElaborazione;
        private Library.Template.Controls.TemplateEditDate editCreazione;
        private Library.Template.Controls.TemplateEditText editNote;
        private Library.Template.Controls.TemplateEditText editCodice;


    }
}
