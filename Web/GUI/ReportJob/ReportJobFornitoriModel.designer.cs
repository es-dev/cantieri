using System.Drawing;

namespace Web.GUI.ReportJob
{
    partial class ReportJobFornitoriModel
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
            this.editNote = new Library.Template.Controls.TemplateEditText();
            this.editCreazione = new Library.Template.Controls.TemplateEditDate();
            this.editElaborazione = new Library.Template.Controls.TemplateEditDate();
            this.editCodice = new Library.Template.Controls.TemplateEditText();
            this.btnStampaReport = new Library.Controls.ButtonSeparatorV();
            this.editNomeFile = new Library.Template.Controls.TemplateEditLink();
            this.editAzienda = new Library.Template.Controls.TemplateEditCombo();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editAzienda);
            this.container.Controls.Add(this.editNomeFile);
            this.container.Controls.Add(this.editCodice);
            this.container.Controls.Add(this.editElaborazione);
            this.container.Controls.Add(this.editCreazione);
            this.container.Controls.Add(this.editNote);
            this.container.Controls.Add(this.editDenominazione);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editDenominazione, 0);
            this.container.Controls.SetChildIndex(this.editNote, 0);
            this.container.Controls.SetChildIndex(this.editCreazione, 0);
            this.container.Controls.SetChildIndex(this.editElaborazione, 0);
            this.container.Controls.SetChildIndex(this.editCodice, 0);
            this.container.Controls.SetChildIndex(this.editNomeFile, 0);
            this.container.Controls.SetChildIndex(this.editAzienda, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(666, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(610, 3);
            // 
            // panelCommands
            // 
            this.panelCommands.Controls.Add(this.btnStampaReport);
            this.panelCommands.Controls.SetChildIndex(this.btnHome, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnClose, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnSave, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnUpdateCancel, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnDelete, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnStampaReport, 0);
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
            this.editDenominazione.Location = new System.Drawing.Point(26, 163);
            this.editDenominazione.Name = "editDenominazione";
            this.editDenominazione.ReadOnly = false;
            this.editDenominazione.Required = true;
            this.editDenominazione.Size = new System.Drawing.Size(794, 30);
            this.editDenominazione.TabIndex = 3;
            this.editDenominazione.Text = "EditControl";
            this.editDenominazione.Value = null;
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
            this.editNote.Location = new System.Drawing.Point(26, 292);
            this.editNote.Name = "editNote";
            this.editNote.ReadOnly = false;
            this.editNote.Required = false;
            this.editNote.Size = new System.Drawing.Size(794, 30);
            this.editNote.TabIndex = 7;
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
            this.editCreazione.Location = new System.Drawing.Point(26, 206);
            this.editCreazione.Name = "editCreazione";
            this.editCreazione.ReadOnly = false;
            this.editCreazione.Required = false;
            this.editCreazione.Size = new System.Drawing.Size(794, 30);
            this.editCreazione.TabIndex = 5;
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
            this.editElaborazione.Location = new System.Drawing.Point(26, 249);
            this.editElaborazione.Name = "editElaborazione";
            this.editElaborazione.ReadOnly = false;
            this.editElaborazione.Required = true;
            this.editElaborazione.Size = new System.Drawing.Size(794, 30);
            this.editElaborazione.TabIndex = 6;
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
            this.editCodice.Location = new System.Drawing.Point(26, 120);
            this.editCodice.Name = "editCodice";
            this.editCodice.ReadOnly = false;
            this.editCodice.Required = true;
            this.editCodice.Size = new System.Drawing.Size(794, 30);
            this.editCodice.TabIndex = 2;
            this.editCodice.Value = null;
            // 
            // btnStampaReport
            // 
            this.btnStampaReport.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnStampaReport.BackColor = System.Drawing.Color.Transparent;
            this.btnStampaReport.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnStampaReport.ImageButton = "";
            this.btnStampaReport.ImageSeparator = "Images.separator_ht_small.png";
            this.btnStampaReport.Location = new System.Drawing.Point(0, 288);
            this.btnStampaReport.Name = "btnStampaReport";
            this.btnStampaReport.Size = new System.Drawing.Size(100, 72);
            this.btnStampaReport.TabIndex = 1002;
            this.btnStampaReport.TextButton = "Stampa report";
            this.btnStampaReport.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnStampaReport_Click);
            // 
            // editNomeFile
            // 
            this.editNomeFile.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editNomeFile.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editNomeFile.BackColor = System.Drawing.Color.Transparent;
            this.editNomeFile.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editNomeFile.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editNomeFile.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editNomeFile.Changed = true;
            this.editNomeFile.Editing = false;
            this.editNomeFile.Label = "Report";
            this.editNomeFile.LabelWidth = 175;
            this.editNomeFile.Location = new System.Drawing.Point(26, 335);
            this.editNomeFile.Name = "templateEditLink1";
            this.editNomeFile.ReadOnly = false;
            this.editNomeFile.Required = false;
            this.editNomeFile.Size = new System.Drawing.Size(794, 30);
            this.editNomeFile.TabIndex = 8;
            this.editNomeFile.Url = null;
            this.editNomeFile.Value = null;
            // 
            // editAzienda
            // 
            this.editAzienda.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editAzienda.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editAzienda.BackColor = System.Drawing.Color.Transparent;
            this.editAzienda.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editAzienda.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editAzienda.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editAzienda.Changed = true;
            this.editAzienda.Editing = false;
            this.editAzienda.Label = "Azienda";
            this.editAzienda.LabelWidth = 175;
            this.editAzienda.Location = new System.Drawing.Point(26, 77);
            this.editAzienda.Model = null;
            this.editAzienda.Name = "editAzienda";
            this.editAzienda.ReadOnly = false;
            this.editAzienda.Required = true;
            this.editAzienda.Size = new System.Drawing.Size(794, 30);
            this.editAzienda.TabIndex = 0;
            this.editAzienda.Text = "EditControl";
            this.editAzienda.Value = null;
            this.editAzienda.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editAzienda_ComboConfirm);
            this.editAzienda.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editAzienda_ComboClick);
            // 
            // ReportJobFornitoriModel
            // 
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditText editDenominazione;
        private Library.Template.Controls.TemplateEditDate editElaborazione;
        private Library.Template.Controls.TemplateEditDate editCreazione;
        private Library.Template.Controls.TemplateEditText editNote;
        private Library.Template.Controls.TemplateEditText editCodice;
        private Library.Controls.ButtonSeparatorV btnStampaReport;
        private Library.Template.Controls.TemplateEditLink editNomeFile;
        private Library.Template.Controls.TemplateEditCombo editAzienda;


    }
}
