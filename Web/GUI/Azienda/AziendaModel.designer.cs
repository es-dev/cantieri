using System.Drawing;

namespace Web.GUI.Azienda
{
    partial class AziendaModel
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
            this.editNome = new Library.Template.Controls.TemplateEditCombo();
            this.editDescrizione = new Library.Template.Controls.TemplateEditText();
            this.editProvincia = new Library.Template.Controls.TemplateEditText();
            this.editCodiceISTAT = new Library.Template.Controls.TemplateEditText();
            this.editNumeroSezioni = new Library.Template.Controls.TemplateEditNumeric();
            this.clientStorage1 = new Gizmox.WebGUI.Forms.Client.ClientStorage();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editNumeroSezioni);
            this.container.Controls.Add(this.editCodiceISTAT);
            this.container.Controls.Add(this.editProvincia);
            this.container.Controls.Add(this.editDescrizione);
            this.container.Controls.Add(this.editNome);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editNome, 0);
            this.container.Controls.SetChildIndex(this.editDescrizione, 0);
            this.container.Controls.SetChildIndex(this.editProvincia, 0);
            this.container.Controls.SetChildIndex(this.editCodiceISTAT, 0);
            this.container.Controls.SetChildIndex(this.editNumeroSezioni, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(666, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(610, 3);
            // 
            // editNome
            // 
            this.editNome.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editNome.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editNome.BackColor = System.Drawing.Color.Transparent;
            this.editNome.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editNome.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editNome.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editNome.Changed = false;
            this.editNome.Editing = false;
            this.editNome.Label = "Nome";
            this.editNome.LabelWidth = 175;
            this.editNome.Location = new System.Drawing.Point(20, 75);
            this.editNome.Model = null;
            this.editNome.Multiline = false;
            this.editNome.Name = "editNome";
            this.editNome.ReadOnly = false;
            this.editNome.Required = false;
            this.editNome.Size = new System.Drawing.Size(800, 30);
            this.editNome.TabIndex = 2;
            this.editNome.Text = "EditControl";
            this.editNome.Value = "";
            // 
            // editDescrizione
            // 
            this.editDescrizione.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editDescrizione.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editDescrizione.BackColor = System.Drawing.Color.Transparent;
            this.editDescrizione.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editDescrizione.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editDescrizione.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editDescrizione.Changed = false;
            this.editDescrizione.Editing = false;
            this.editDescrizione.Label = "Descrizione";
            this.editDescrizione.LabelWidth = 175;
            this.editDescrizione.Location = new System.Drawing.Point(20, 125);
            this.editDescrizione.Multiline = false;
            this.editDescrizione.Name = "editDescrizione";
            this.editDescrizione.ReadOnly = false;
            this.editDescrizione.Required = false;
            this.editDescrizione.Size = new System.Drawing.Size(800, 30);
            this.editDescrizione.TabIndex = 3;
            this.editDescrizione.Text = "EditControl";
            this.editDescrizione.Value = "";
            // 
            // editProvincia
            // 
            this.editProvincia.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editProvincia.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editProvincia.BackColor = System.Drawing.Color.Transparent;
            this.editProvincia.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editProvincia.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editProvincia.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editProvincia.Changed = false;
            this.editProvincia.Editing = false;
            this.editProvincia.Label = "Provincia";
            this.editProvincia.LabelWidth = 175;
            this.editProvincia.Location = new System.Drawing.Point(20, 175);
            this.editProvincia.Multiline = false;
            this.editProvincia.Name = "editProvincia";
            this.editProvincia.ReadOnly = false;
            this.editProvincia.Required = false;
            this.editProvincia.Size = new System.Drawing.Size(800, 30);
            this.editProvincia.TabIndex = 4;
            this.editProvincia.Text = "EditControl";
            this.editProvincia.Value = "";
            // 
            // editCodiceISTAT
            // 
            this.editCodiceISTAT.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editCodiceISTAT.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editCodiceISTAT.BackColor = System.Drawing.Color.Transparent;
            this.editCodiceISTAT.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editCodiceISTAT.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editCodiceISTAT.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editCodiceISTAT.Changed = false;
            this.editCodiceISTAT.Editing = false;
            this.editCodiceISTAT.Label = "Codice ISTAT";
            this.editCodiceISTAT.LabelWidth = 175;
            this.editCodiceISTAT.Location = new System.Drawing.Point(20, 225);
            this.editCodiceISTAT.Multiline = false;
            this.editCodiceISTAT.Name = "editCodiceISTAT";
            this.editCodiceISTAT.ReadOnly = false;
            this.editCodiceISTAT.Required = false;
            this.editCodiceISTAT.Size = new System.Drawing.Size(800, 30);
            this.editCodiceISTAT.TabIndex = 5;
            this.editCodiceISTAT.Text = "EditControl";
            this.editCodiceISTAT.Value = "";
            // 
            // editNumeroSezioni
            // 
            this.editNumeroSezioni.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editNumeroSezioni.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editNumeroSezioni.BackColor = System.Drawing.Color.Transparent;
            this.editNumeroSezioni.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editNumeroSezioni.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editNumeroSezioni.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editNumeroSezioni.Changed = false;
            this.editNumeroSezioni.Editing = false;
            this.editNumeroSezioni.Label = "Numero Sezioni";
            this.editNumeroSezioni.LabelWidth = 175;
            this.editNumeroSezioni.Location = new System.Drawing.Point(20, 275);
            this.editNumeroSezioni.Name = "editNumeroSezioni";
            this.editNumeroSezioni.ReadOnly = false;
            this.editNumeroSezioni.Required = false;
            this.editNumeroSezioni.Size = new System.Drawing.Size(800, 30);
            this.editNumeroSezioni.TabIndex = 6;
            this.editNumeroSezioni.Text = "EditControl";
            this.editNumeroSezioni.Value = 0;
            // 
            // clientStorage1
            // 
            this.clientStorage1.Description = "";
            this.clientStorage1.MajorVersion = ((ushort)(1));
            this.clientStorage1.MinorVersion = ((ushort)(0));
            this.Controls.SetChildIndex(this.container, 0);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditCombo editNome;
        private Library.Template.Controls.TemplateEditNumeric editNumeroSezioni;
        private Library.Template.Controls.TemplateEditText editCodiceISTAT;
        private Library.Template.Controls.TemplateEditText editProvincia;
        private Library.Template.Controls.TemplateEditText editDescrizione;
        private Gizmox.WebGUI.Forms.Client.ClientStorage clientStorage1;


    }
}
