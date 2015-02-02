using System.Drawing;

namespace Web.GUI.SAL
{
    partial class SALModel
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
            this.editCommessa = new Library.Template.Controls.TemplateEditCombo();
            this.editData = new Library.Template.Controls.TemplateEditData();
            this.editDenominazione = new Library.Template.Controls.TemplateEditText();
            this.editTotaleAcquisti = new Library.Template.Controls.TemplateEditDecimal();
            this.editTotaleVendite = new Library.Template.Controls.TemplateEditDecimal();
            this.editCodice = new Library.Template.Controls.TemplateEditText();
            this.lblFatturato = new Gizmox.WebGUI.Forms.Label();
            this.lblPagamenti = new Gizmox.WebGUI.Forms.Label();
            this.editTotalePagamenti = new Library.Template.Controls.TemplateEditDecimal();
            this.editTotaleIncassi = new Library.Template.Controls.TemplateEditDecimal();
            this.lblStato = new Gizmox.WebGUI.Forms.Label();
            this.editStato = new Gizmox.WebGUI.Forms.Label();
            this.lblAndamento = new Gizmox.WebGUI.Forms.Label();
            this.btnCalcoloSAL = new Library.Controls.ButtonSeparatorV();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.lblAndamento);
            this.container.Controls.Add(this.editStato);
            this.container.Controls.Add(this.lblStato);
            this.container.Controls.Add(this.editTotaleIncassi);
            this.container.Controls.Add(this.editTotalePagamenti);
            this.container.Controls.Add(this.lblPagamenti);
            this.container.Controls.Add(this.lblFatturato);
            this.container.Controls.Add(this.editCodice);
            this.container.Controls.Add(this.editTotaleVendite);
            this.container.Controls.Add(this.editTotaleAcquisti);
            this.container.Controls.Add(this.editDenominazione);
            this.container.Controls.Add(this.editData);
            this.container.Controls.Add(this.editCommessa);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editCommessa, 0);
            this.container.Controls.SetChildIndex(this.editData, 0);
            this.container.Controls.SetChildIndex(this.editDenominazione, 0);
            this.container.Controls.SetChildIndex(this.editTotaleAcquisti, 0);
            this.container.Controls.SetChildIndex(this.editTotaleVendite, 0);
            this.container.Controls.SetChildIndex(this.editCodice, 0);
            this.container.Controls.SetChildIndex(this.lblFatturato, 0);
            this.container.Controls.SetChildIndex(this.lblPagamenti, 0);
            this.container.Controls.SetChildIndex(this.editTotalePagamenti, 0);
            this.container.Controls.SetChildIndex(this.editTotaleIncassi, 0);
            this.container.Controls.SetChildIndex(this.lblStato, 0);
            this.container.Controls.SetChildIndex(this.editStato, 0);
            this.container.Controls.SetChildIndex(this.lblAndamento, 0);
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
            this.panelCommands.Controls.Add(this.btnCalcoloSAL);
            this.panelCommands.Controls.SetChildIndex(this.btnClose, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnSave, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnUpdateCancel, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnDelete, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnCalcoloSAL, 0);
            // 
            // editCommessa
            // 
            this.editCommessa.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editCommessa.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editCommessa.BackColor = System.Drawing.Color.Transparent;
            this.editCommessa.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editCommessa.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editCommessa.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editCommessa.Changed = true;
            this.editCommessa.Editing = false;
            this.editCommessa.Label = "Commessa";
            this.editCommessa.LabelWidth = 175;
            this.editCommessa.Location = new System.Drawing.Point(25, 75);
            this.editCommessa.Model = null;
            this.editCommessa.Name = "editCommessa";
            this.editCommessa.ReadOnly = false;
            this.editCommessa.Required = false;
            this.editCommessa.Size = new System.Drawing.Size(800, 30);
            this.editCommessa.TabIndex = 0;
            this.editCommessa.Text = "EditControl";
            this.editCommessa.Value = null;
            this.editCommessa.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editCommessa_ComboConfirm);
            this.editCommessa.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editCommessa_ComboClick);
            // 
            // editData
            // 
            this.editData.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editData.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editData.BackColor = System.Drawing.Color.Transparent;
            this.editData.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editData.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editData.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editData.Changed = true;
            this.editData.Editing = false;
            this.editData.Label = "Data";
            this.editData.LabelWidth = 175;
            this.editData.Location = new System.Drawing.Point(25, 204);
            this.editData.Name = "editData";
            this.editData.ReadOnly = false;
            this.editData.Required = false;
            this.editData.Size = new System.Drawing.Size(798, 30);
            this.editData.TabIndex = 2;
            this.editData.Text = "EditControl";
            this.editData.Value = null;
            this.editData.Leave += new System.EventHandler(this.editData_Leave);
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
            this.editDenominazione.Location = new System.Drawing.Point(25, 161);
            this.editDenominazione.Name = "editDenominazione";
            this.editDenominazione.ReadOnly = false;
            this.editDenominazione.Required = false;
            this.editDenominazione.Size = new System.Drawing.Size(798, 30);
            this.editDenominazione.TabIndex = 6;
            this.editDenominazione.Text = "EditControl";
            this.editDenominazione.Value = null;
            // 
            // editTotaleAcquisti
            // 
            this.editTotaleAcquisti.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTotaleAcquisti.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTotaleAcquisti.BackColor = System.Drawing.Color.Transparent;
            this.editTotaleAcquisti.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTotaleAcquisti.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTotaleAcquisti.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTotaleAcquisti.Changed = true;
            this.editTotaleAcquisti.Editing = false;
            this.editTotaleAcquisti.Label = "Acquisti fornitori";
            this.editTotaleAcquisti.LabelWidth = 175;
            this.editTotaleAcquisti.Location = new System.Drawing.Point(25, 290);
            this.editTotaleAcquisti.Name = "editTotaleAcquisti";
            this.editTotaleAcquisti.ReadOnly = false;
            this.editTotaleAcquisti.Required = false;
            this.editTotaleAcquisti.Size = new System.Drawing.Size(798, 30);
            this.editTotaleAcquisti.TabIndex = 3;
            this.editTotaleAcquisti.Text = "TemplateEditNumeric";
            this.editTotaleAcquisti.Value = null;
            // 
            // editTotaleVendite
            // 
            this.editTotaleVendite.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTotaleVendite.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTotaleVendite.BackColor = System.Drawing.Color.Transparent;
            this.editTotaleVendite.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTotaleVendite.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTotaleVendite.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTotaleVendite.Changed = true;
            this.editTotaleVendite.Editing = false;
            this.editTotaleVendite.Label = "Fatture al cliente";
            this.editTotaleVendite.LabelWidth = 175;
            this.editTotaleVendite.Location = new System.Drawing.Point(25, 333);
            this.editTotaleVendite.Name = "editTotaleVendite";
            this.editTotaleVendite.ReadOnly = false;
            this.editTotaleVendite.Required = false;
            this.editTotaleVendite.Size = new System.Drawing.Size(798, 30);
            this.editTotaleVendite.TabIndex = 4;
            this.editTotaleVendite.Text = "TemplateEditNumeric";
            this.editTotaleVendite.Value = null;
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
            this.editCodice.Location = new System.Drawing.Point(25, 118);
            this.editCodice.Name = "editCodice";
            this.editCodice.ReadOnly = false;
            this.editCodice.Required = false;
            this.editCodice.Size = new System.Drawing.Size(798, 30);
            this.editCodice.TabIndex = 1000;
            this.editCodice.Text = "EditControl";
            this.editCodice.Value = null;
            // 
            // lblFatturato
            // 
            this.lblFatturato.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblFatturato.BackColor = System.Drawing.Color.Gainsboro;
            this.lblFatturato.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatturato.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFatturato.Location = new System.Drawing.Point(13, 247);
            this.lblFatturato.Name = "lblFatturato";
            this.lblFatturato.Size = new System.Drawing.Size(887, 30);
            this.lblFatturato.TabIndex = 1001;
            this.lblFatturato.Text = "TOTALE FATTURATO";
            this.lblFatturato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPagamenti
            // 
            this.lblPagamenti.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblPagamenti.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPagamenti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagamenti.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPagamenti.Location = new System.Drawing.Point(13, 376);
            this.lblPagamenti.Name = "lblPagamenti";
            this.lblPagamenti.Size = new System.Drawing.Size(887, 30);
            this.lblPagamenti.TabIndex = 1001;
            this.lblPagamenti.Text = "TOTALE  PAGAMENTI";
            this.lblPagamenti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editTotalePagamenti
            // 
            this.editTotalePagamenti.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTotalePagamenti.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTotalePagamenti.BackColor = System.Drawing.Color.Transparent;
            this.editTotalePagamenti.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTotalePagamenti.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTotalePagamenti.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTotalePagamenti.Changed = true;
            this.editTotalePagamenti.Editing = false;
            this.editTotalePagamenti.Label = "Pagamenti fornitori";
            this.editTotalePagamenti.LabelWidth = 175;
            this.editTotalePagamenti.Location = new System.Drawing.Point(25, 419);
            this.editTotalePagamenti.Name = "editTotalePagamenti";
            this.editTotalePagamenti.ReadOnly = false;
            this.editTotalePagamenti.Required = false;
            this.editTotalePagamenti.Size = new System.Drawing.Size(798, 30);
            this.editTotalePagamenti.TabIndex = 3;
            this.editTotalePagamenti.Text = "TemplateEditNumeric";
            this.editTotalePagamenti.Value = null;
            // 
            // editTotaleIncassi
            // 
            this.editTotaleIncassi.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTotaleIncassi.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTotaleIncassi.BackColor = System.Drawing.Color.Transparent;
            this.editTotaleIncassi.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTotaleIncassi.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTotaleIncassi.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTotaleIncassi.Changed = true;
            this.editTotaleIncassi.Editing = false;
            this.editTotaleIncassi.Label = "Incassi cliente";
            this.editTotaleIncassi.LabelWidth = 175;
            this.editTotaleIncassi.Location = new System.Drawing.Point(25, 462);
            this.editTotaleIncassi.Name = "editTotaleIncassi";
            this.editTotaleIncassi.ReadOnly = false;
            this.editTotaleIncassi.Required = false;
            this.editTotaleIncassi.Size = new System.Drawing.Size(798, 30);
            this.editTotaleIncassi.TabIndex = 3;
            this.editTotaleIncassi.Text = "TemplateEditNumeric";
            this.editTotaleIncassi.Value = null;
            // 
            // lblStato
            // 
            this.lblStato.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStato.ForeColor = System.Drawing.Color.Gray;
            this.lblStato.Location = new System.Drawing.Point(25, 548);
            this.lblStato.Name = "lblStato";
            this.lblStato.Size = new System.Drawing.Size(163, 30);
            this.lblStato.TabIndex = 1002;
            this.lblStato.Text = "Stato";
            // 
            // editStato
            // 
            this.editStato.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editStato.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStato.Location = new System.Drawing.Point(199, 548);
            this.editStato.Name = "editStato";
            this.editStato.Size = new System.Drawing.Size(621, 49);
            this.editStato.TabIndex = 1003;
            this.editStato.Text = "---";
            // 
            // lblAndamento
            // 
            this.lblAndamento.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblAndamento.BackColor = System.Drawing.Color.Gainsboro;
            this.lblAndamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAndamento.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAndamento.Location = new System.Drawing.Point(13, 505);
            this.lblAndamento.Name = "lblAndamento";
            this.lblAndamento.Size = new System.Drawing.Size(887, 30);
            this.lblAndamento.TabIndex = 1001;
            this.lblAndamento.Text = "ANDAMENTO DEL LAVORO";
            this.lblAndamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalcoloSAL
            // 
            this.btnCalcoloSAL.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnCalcoloSAL.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcoloSAL.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnCalcoloSAL.ImageButton = "";
            this.btnCalcoloSAL.ImageSeparator = "Images.separator_ht_small.png";
            this.btnCalcoloSAL.Location = new System.Drawing.Point(0, 217);
            this.btnCalcoloSAL.Name = "btnCalcoloSAL";
            this.btnCalcoloSAL.Size = new System.Drawing.Size(100, 72);
            this.btnCalcoloSAL.TabIndex = 1002;
            this.btnCalcoloSAL.TextButton = "Calcolo SAL";
            this.btnCalcoloSAL.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnCalcoloSAL_Click);
            this.Controls.SetChildIndex(this.panelCommands, 0);
            this.Controls.SetChildIndex(this.container, 0);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditText editDenominazione;
        private Library.Template.Controls.TemplateEditData editData;
        private Library.Template.Controls.TemplateEditCombo editCommessa;
        private Library.Template.Controls.TemplateEditDecimal editTotaleVendite;
        private Library.Template.Controls.TemplateEditDecimal editTotaleAcquisti;
        private Library.Template.Controls.TemplateEditText editCodice;
        private Gizmox.WebGUI.Forms.Label lblPagamenti;
        private Gizmox.WebGUI.Forms.Label lblFatturato;
        private Library.Template.Controls.TemplateEditDecimal editTotaleIncassi;
        private Library.Template.Controls.TemplateEditDecimal editTotalePagamenti;
        private Gizmox.WebGUI.Forms.Label lblAndamento;
        private Gizmox.WebGUI.Forms.Label editStato;
        private Gizmox.WebGUI.Forms.Label lblStato;
        private Library.Controls.ButtonSeparatorV btnCalcoloSAL;


    }
}
