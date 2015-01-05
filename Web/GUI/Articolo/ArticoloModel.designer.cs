using System.Drawing;

namespace Web.GUI.Articolo
{
    partial class ArticoloModel
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
            this.editFatturaAcquisto = new Library.Template.Controls.TemplateEditCombo();
            this.editQuantita = new Library.Template.Controls.TemplateEditNumeric();
            this.editDescrizione = new Library.Template.Controls.TemplateEditText();
            this.editSconto = new Library.Template.Controls.TemplateEditDecimal();
            this.editCosto = new Library.Template.Controls.TemplateEditDecimal();
            this.editImporto = new Library.Template.Controls.TemplateEditDecimal();
            this.editIVA = new Library.Template.Controls.TemplateEditDecimal();
            this.editTotale = new Library.Template.Controls.TemplateEditDecimal();
            this.editCodiceArticolo = new Library.Template.Controls.TemplateEditCombo();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editCodiceArticolo);
            this.container.Controls.Add(this.editTotale);
            this.container.Controls.Add(this.editIVA);
            this.container.Controls.Add(this.editImporto);
            this.container.Controls.Add(this.editCosto);
            this.container.Controls.Add(this.editSconto);
            this.container.Controls.Add(this.editDescrizione);
            this.container.Controls.Add(this.editQuantita);
            this.container.Controls.Add(this.editFatturaAcquisto);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editFatturaAcquisto, 0);
            this.container.Controls.SetChildIndex(this.editQuantita, 0);
            this.container.Controls.SetChildIndex(this.editDescrizione, 0);
            this.container.Controls.SetChildIndex(this.editSconto, 0);
            this.container.Controls.SetChildIndex(this.editCosto, 0);
            this.container.Controls.SetChildIndex(this.editImporto, 0);
            this.container.Controls.SetChildIndex(this.editIVA, 0);
            this.container.Controls.SetChildIndex(this.editTotale, 0);
            this.container.Controls.SetChildIndex(this.editCodiceArticolo, 0);
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
            // editFatturaAcquisto
            // 
            this.editFatturaAcquisto.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editFatturaAcquisto.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editFatturaAcquisto.BackColor = System.Drawing.Color.Transparent;
            this.editFatturaAcquisto.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editFatturaAcquisto.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editFatturaAcquisto.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editFatturaAcquisto.Changed = true;
            this.editFatturaAcquisto.Editing = false;
            this.editFatturaAcquisto.Label = "Fattura";
            this.editFatturaAcquisto.LabelWidth = 175;
            this.editFatturaAcquisto.Location = new System.Drawing.Point(25, 75);
            this.editFatturaAcquisto.Model = null;
            this.editFatturaAcquisto.Name = "editFatturaAcquisto";
            this.editFatturaAcquisto.ReadOnly = false;
            this.editFatturaAcquisto.Required = false;
            this.editFatturaAcquisto.Size = new System.Drawing.Size(798, 30);
            this.editFatturaAcquisto.TabIndex = 0;
            this.editFatturaAcquisto.Text = "EditControl";
            this.editFatturaAcquisto.Value = null;
            this.editFatturaAcquisto.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editFatturaAcquisto_ComboConfirm);
            this.editFatturaAcquisto.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editFatturaAcquisto_ComboClick);
            // 
            // editQuantita
            // 
            this.editQuantita.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editQuantita.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editQuantita.BackColor = System.Drawing.Color.Transparent;
            this.editQuantita.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editQuantita.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editQuantita.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editQuantita.Changed = true;
            this.editQuantita.Editing = false;
            this.editQuantita.Label = "Quantità";
            this.editQuantita.LabelWidth = 175;
            this.editQuantita.Location = new System.Drawing.Point(25, 204);
            this.editQuantita.Name = "editQuantita";
            this.editQuantita.ReadOnly = false;
            this.editQuantita.Required = false;
            this.editQuantita.Size = new System.Drawing.Size(798, 30);
            this.editQuantita.TabIndex = 3;
            this.editQuantita.Text = "TemplateEditNumeric";
            this.editQuantita.Value = null;
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
            this.editDescrizione.Changed = true;
            this.editDescrizione.Editing = false;
            this.editDescrizione.Label = "Descrizione";
            this.editDescrizione.LabelWidth = 175;
            this.editDescrizione.Location = new System.Drawing.Point(25, 161);
            this.editDescrizione.Name = "editDescrizione";
            this.editDescrizione.ReadOnly = false;
            this.editDescrizione.Required = false;
            this.editDescrizione.Size = new System.Drawing.Size(798, 30);
            this.editDescrizione.TabIndex = 2;
            this.editDescrizione.Text = "EditControl";
            this.editDescrizione.Value = null;
            // 
            // editSconto
            // 
            this.editSconto.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editSconto.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editSconto.BackColor = System.Drawing.Color.Transparent;
            this.editSconto.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editSconto.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editSconto.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editSconto.Changed = true;
            this.editSconto.Editing = false;
            this.editSconto.Label = "Sconto";
            this.editSconto.LabelWidth = 175;
            this.editSconto.Location = new System.Drawing.Point(25, 247);
            this.editSconto.Name = "editSconto";
            this.editSconto.ReadOnly = false;
            this.editSconto.Required = false;
            this.editSconto.Size = new System.Drawing.Size(798, 30);
            this.editSconto.TabIndex = 4;
            this.editSconto.Text = "TemplateEditNumeric";
            this.editSconto.Value = null;
            // 
            // editCosto
            // 
            this.editCosto.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editCosto.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editCosto.BackColor = System.Drawing.Color.Transparent;
            this.editCosto.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editCosto.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editCosto.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editCosto.Changed = true;
            this.editCosto.Editing = false;
            this.editCosto.Label = "Costo";
            this.editCosto.LabelWidth = 175;
            this.editCosto.Location = new System.Drawing.Point(25, 290);
            this.editCosto.Name = "editCosto";
            this.editCosto.ReadOnly = false;
            this.editCosto.Required = false;
            this.editCosto.Size = new System.Drawing.Size(798, 30);
            this.editCosto.TabIndex = 5;
            this.editCosto.Text = "TemplateEditNumeric";
            this.editCosto.Value = null;
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
            this.editImporto.Location = new System.Drawing.Point(25, 333);
            this.editImporto.Name = "editImporto";
            this.editImporto.ReadOnly = false;
            this.editImporto.Required = false;
            this.editImporto.Size = new System.Drawing.Size(798, 30);
            this.editImporto.TabIndex = 6;
            this.editImporto.Text = "TemplateEditNumeric";
            this.editImporto.Value = null;
            // 
            // editIVA
            // 
            this.editIVA.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editIVA.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editIVA.BackColor = System.Drawing.Color.Transparent;
            this.editIVA.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editIVA.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editIVA.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editIVA.Changed = true;
            this.editIVA.Editing = false;
            this.editIVA.Label = "IVA";
            this.editIVA.LabelWidth = 175;
            this.editIVA.Location = new System.Drawing.Point(25, 376);
            this.editIVA.Name = "editIVA";
            this.editIVA.ReadOnly = false;
            this.editIVA.Required = false;
            this.editIVA.Size = new System.Drawing.Size(798, 30);
            this.editIVA.TabIndex = 7;
            this.editIVA.Text = "TemplateEditNumeric";
            this.editIVA.Value = null;
            // 
            // editTotale
            // 
            this.editTotale.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTotale.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTotale.BackColor = System.Drawing.Color.Transparent;
            this.editTotale.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTotale.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTotale.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTotale.Changed = true;
            this.editTotale.Editing = false;
            this.editTotale.Label = "Totale";
            this.editTotale.LabelWidth = 175;
            this.editTotale.Location = new System.Drawing.Point(25, 419);
            this.editTotale.Name = "editTotale";
            this.editTotale.ReadOnly = false;
            this.editTotale.Required = false;
            this.editTotale.Size = new System.Drawing.Size(798, 30);
            this.editTotale.TabIndex = 8;
            this.editTotale.Text = "TemplateEditNumeric";
            this.editTotale.Value = null;
            // 
            // editCodiceArticolo
            // 
            this.editCodiceArticolo.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editCodiceArticolo.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editCodiceArticolo.BackColor = System.Drawing.Color.Transparent;
            this.editCodiceArticolo.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editCodiceArticolo.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editCodiceArticolo.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editCodiceArticolo.Changed = true;
            this.editCodiceArticolo.Editing = false;
            this.editCodiceArticolo.Label = "Codice";
            this.editCodiceArticolo.LabelWidth = 175;
            this.editCodiceArticolo.Location = new System.Drawing.Point(25, 118);
            this.editCodiceArticolo.Model = null;
            this.editCodiceArticolo.Name = "editCodiceArticolo";
            this.editCodiceArticolo.ReadOnly = false;
            this.editCodiceArticolo.Required = false;
            this.editCodiceArticolo.Size = new System.Drawing.Size(800, 30);
            this.editCodiceArticolo.TabIndex = 1;
            this.editCodiceArticolo.Text = "EditControl";
            this.editCodiceArticolo.Value = null;
            this.editCodiceArticolo.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editCodice_ComboConfirm);
            this.editCodiceArticolo.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editCodice_ComboClick);
            this.Controls.SetChildIndex(this.container, 0);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Gizmox.WebGUI.Forms.Client.ClientStorage clientStorage1;
        private Library.Template.Controls.TemplateEditText editDescrizione;
        private Library.Template.Controls.TemplateEditNumeric editQuantita;
        private Library.Template.Controls.TemplateEditCombo editFatturaAcquisto;
        private Library.Template.Controls.TemplateEditDecimal editTotale;
        private Library.Template.Controls.TemplateEditDecimal editIVA;
        private Library.Template.Controls.TemplateEditDecimal editImporto;
        private Library.Template.Controls.TemplateEditDecimal editCosto;
        private Library.Template.Controls.TemplateEditDecimal editSconto;
        private Library.Template.Controls.TemplateEditCombo editCodiceArticolo;


    }
}
