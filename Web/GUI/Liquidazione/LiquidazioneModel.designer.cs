using System.Drawing;

namespace Web.GUI.Liquidazione
{
    partial class LiquidazioneModel
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
            this.clientStorage1 = new Gizmox.WebGUI.Forms.Client.ClientStorage();
            this.editEseguito = new Library.Template.Controls.TemplateEditCheckBox();
            this.editScadenza = new Library.Template.Controls.TemplateEditData();
            this.editData = new Library.Template.Controls.TemplateEditData();
            this.editImporto = new Library.Template.Controls.TemplateEditText();
            this.editModalita = new Library.Template.Controls.TemplateEditText();
            this.editFatturaVendita = new Library.Template.Controls.TemplateEditCombo();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editFatturaVendita);
            this.container.Controls.Add(this.editModalita);
            this.container.Controls.Add(this.editImporto);
            this.container.Controls.Add(this.editData);
            this.container.Controls.Add(this.editScadenza);
            this.container.Controls.Add(this.editEseguito);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editEseguito, 0);
            this.container.Controls.SetChildIndex(this.editScadenza, 0);
            this.container.Controls.SetChildIndex(this.editData, 0);
            this.container.Controls.SetChildIndex(this.editImporto, 0);
            this.container.Controls.SetChildIndex(this.editModalita, 0);
            this.container.Controls.SetChildIndex(this.editFatturaVendita, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(666, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(610, 3);
            // 
            // clientStorage1
            // 
            this.clientStorage1.Description = "";
            this.clientStorage1.MajorVersion = ((ushort)(1));
            this.clientStorage1.MinorVersion = ((ushort)(0));
            // 
            // editEseguito
            // 
            this.editEseguito.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editEseguito.BackColor = System.Drawing.Color.Transparent;
            this.editEseguito.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editEseguito.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editEseguito.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editEseguito.Changed = true;
            this.editEseguito.Editing = false;
            this.editEseguito.Label = "Eseguito";
            this.editEseguito.LabelWidth = 175;
            this.editEseguito.Location = new System.Drawing.Point(25, 314);
            this.editEseguito.Name = "editEseguito";
            this.editEseguito.ReadOnly = false;
            this.editEseguito.Required = false;
            this.editEseguito.Size = new System.Drawing.Size(798, 30);
            this.editEseguito.TabIndex = 9;
            this.editEseguito.Text = "TemplateCheckBox";
            this.editEseguito.TextFalse = "";
            this.editEseguito.TextTrue = "";
            this.editEseguito.Value = null;
            // 
            // editScadenza
            // 
            this.editScadenza.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editScadenza.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editScadenza.BackColor = System.Drawing.Color.Transparent;
            this.editScadenza.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editScadenza.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editScadenza.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editScadenza.Changed = true;
            this.editScadenza.Editing = false;
            this.editScadenza.Label = "Scadenza";
            this.editScadenza.LabelWidth = 175;
            this.editScadenza.Location = new System.Drawing.Point(25, 265);
            this.editScadenza.Name = "editScadenza";
            this.editScadenza.ReadOnly = false;
            this.editScadenza.Required = false;
            this.editScadenza.Size = new System.Drawing.Size(798, 30);
            this.editScadenza.TabIndex = 8;
            this.editScadenza.Text = "EditControl";
            this.editScadenza.Value = null;
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
            this.editData.Location = new System.Drawing.Point(25, 120);
            this.editData.Name = "editData";
            this.editData.ReadOnly = false;
            this.editData.Required = false;
            this.editData.Size = new System.Drawing.Size(798, 30);
            this.editData.TabIndex = 8;
            this.editData.Text = "EditControl";
            this.editData.Value = null;
            // 
            // editImporto
            // 
            this.editImporto.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editImporto.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editImporto.BackColor = System.Drawing.Color.Transparent;
            this.editImporto.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editImporto.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editImporto.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editImporto.Changed = true;
            this.editImporto.Editing = false;
            this.editImporto.Label = "Importo";
            this.editImporto.LabelWidth = 175;
            this.editImporto.Location = new System.Drawing.Point(25, 216);
            this.editImporto.Name = "editImporto";
            this.editImporto.ReadOnly = false;
            this.editImporto.Required = false;
            this.editImporto.Size = new System.Drawing.Size(798, 30);
            this.editImporto.TabIndex = 5;
            this.editImporto.Text = "EditControl";
            this.editImporto.Value = null;
            // 
            // editModalita
            // 
            this.editModalita.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editModalita.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editModalita.BackColor = System.Drawing.Color.Transparent;
            this.editModalita.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editModalita.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editModalita.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editModalita.Changed = true;
            this.editModalita.Editing = false;
            this.editModalita.Label = "Modalità";
            this.editModalita.LabelWidth = 175;
            this.editModalita.Location = new System.Drawing.Point(25, 168);
            this.editModalita.Name = "editModalita";
            this.editModalita.ReadOnly = false;
            this.editModalita.Required = false;
            this.editModalita.Size = new System.Drawing.Size(798, 30);
            this.editModalita.TabIndex = 3;
            this.editModalita.Text = "EditControl";
            this.editModalita.Value = null;
            // 
            // editFatturaVendita
            // 
            this.editFatturaVendita.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editFatturaVendita.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editFatturaVendita.BackColor = System.Drawing.Color.Transparent;
            this.editFatturaVendita.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editFatturaVendita.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editFatturaVendita.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editFatturaVendita.Changed = true;
            this.editFatturaVendita.Editing = false;
            this.editFatturaVendita.Label = "Fattura vendita";
            this.editFatturaVendita.LabelWidth = 175;
            this.editFatturaVendita.Location = new System.Drawing.Point(25, 75);
            this.editFatturaVendita.Model = null;
            this.editFatturaVendita.Name = "editFatturaVendita";
            this.editFatturaVendita.ReadOnly = false;
            this.editFatturaVendita.Required = false;
            this.editFatturaVendita.Size = new System.Drawing.Size(800, 30);
            this.editFatturaVendita.TabIndex = 2;
            this.editFatturaVendita.Text = "EditControl";
            this.editFatturaVendita.Value = null;
            this.editFatturaVendita.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editFatturaVendita_ComboConfirm);
            this.editFatturaVendita.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editFatturaVendita_ComboClick);
            this.Controls.SetChildIndex(this.container, 0);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Gizmox.WebGUI.Forms.Client.ClientStorage clientStorage1;
        private Library.Template.Controls.TemplateEditCombo editFatturaVendita;
        private Library.Template.Controls.TemplateEditText editModalita;
        private Library.Template.Controls.TemplateEditText editImporto;
        private Library.Template.Controls.TemplateEditData editData;
        private Library.Template.Controls.TemplateEditData editScadenza;
        private Library.Template.Controls.TemplateEditCheckBox editEseguito;


    }
}
