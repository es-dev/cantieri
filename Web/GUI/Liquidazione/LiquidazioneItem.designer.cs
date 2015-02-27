using System.Drawing;

namespace Web.GUI.Liquidazione
{
    partial class LiquidazioneItem
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
            this.infoCodice = new Gizmox.WebGUI.Forms.Label();
            this.infoImage = new Gizmox.WebGUI.Forms.PictureBox();
            this.panelLeft = new Gizmox.WebGUI.Forms.Panel();
            this.infoNote = new Gizmox.WebGUI.Forms.Label();
            this.infoLiquidazione = new Gizmox.WebGUI.Forms.Label();
            this.infoData = new Gizmox.WebGUI.Forms.Label();
            this.infoImporto = new Gizmox.WebGUI.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoImage)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.jqContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoCodice
            // 
            this.infoCodice.BackColor = System.Drawing.Color.Silver;
            this.infoCodice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoCodice.ForeColor = System.Drawing.Color.DimGray;
            this.infoCodice.Location = new System.Drawing.Point(0, 62);
            this.infoCodice.Name = "infoCodice";
            this.infoCodice.Size = new System.Drawing.Size(83, 33);
            this.infoCodice.TabIndex = 2;
            this.infoCodice.Text = "CODE";
            this.infoCodice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoImage
            // 
            this.infoImage.BackColor = System.Drawing.Color.Transparent;
            this.infoImage.Location = new System.Drawing.Point(18, 4);
            this.infoImage.Name = "infoImage";
            this.infoImage.Size = new System.Drawing.Size(48, 48);
            this.infoImage.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.StretchImage;
            this.infoImage.TabIndex = 1;
            this.infoImage.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.panelLeft.BackColor = System.Drawing.Color.Gainsboro;
            this.panelLeft.Controls.Add(this.infoCodice);
            this.panelLeft.Controls.Add(this.infoImage);
            this.panelLeft.Location = new System.Drawing.Point(2, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(83, 96);
            this.panelLeft.TabIndex = 0;
            // 
            // infoNote
            // 
            this.infoNote.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.infoNote.Location = new System.Drawing.Point(96, 34);
            this.infoNote.Name = "infoNote";
            this.infoNote.Size = new System.Drawing.Size(297, 32);
            this.infoNote.TabIndex = 1;
            this.infoNote.Text = "Note";
            // 
            // infoLiquidazione
            // 
            this.infoLiquidazione.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoLiquidazione.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLiquidazione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.infoLiquidazione.Location = new System.Drawing.Point(91, 2);
            this.infoLiquidazione.Name = "infoLiquidazione";
            this.infoLiquidazione.Size = new System.Drawing.Size(263, 30);
            this.infoLiquidazione.TabIndex = 1;
            this.infoLiquidazione.Text = "INCASSO";
            // 
            // infoData
            // 
            this.infoData.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoData.ForeColor = System.Drawing.Color.DarkRed;
            this.infoData.Location = new System.Drawing.Point(96, 78);
            this.infoData.Name = "infoData";
            this.infoData.Size = new System.Drawing.Size(154, 16);
            this.infoData.TabIndex = 1;
            this.infoData.Text = "Incassato il dd/MM/yyyy";
            // 
            // infoImporto
            // 
            this.infoImporto.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoImporto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoImporto.ForeColor = System.Drawing.Color.DarkRed;
            this.infoImporto.Location = new System.Drawing.Point(253, 80);
            this.infoImporto.Name = "infoImporto";
            this.infoImporto.Size = new System.Drawing.Size(140, 16);
            this.infoImporto.TabIndex = 1;
            this.infoImporto.Text = "Importo 0,00€";
            this.infoImporto.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LiquidazioneItem
            // 
            this.jqContainer.Controls.Add(this.panelLeft);
            this.jqContainer.Controls.Add(this.infoImporto);
            this.jqContainer.Controls.Add(this.infoData);
            this.jqContainer.Controls.Add(this.infoNote);
            this.jqContainer.Controls.Add(this.infoLiquidazione);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Size = new System.Drawing.Size(400, 100);
            this.ItemClick += new Library.Template.MVVM.TemplateItem.ItemClickHandler(this.LiquidazioneItem_ItemClick);
            ((System.ComponentModel.ISupportInitialize)(this.infoImage)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.jqContainer.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Gizmox.WebGUI.Forms.Label infoCodice;
        private Gizmox.WebGUI.Forms.PictureBox infoImage;
        private Gizmox.WebGUI.Forms.Panel panelLeft;
        private Gizmox.WebGUI.Forms.Label infoNote;
        private Gizmox.WebGUI.Forms.Label infoLiquidazione;
        private Gizmox.WebGUI.Forms.Label infoImporto;
        private Gizmox.WebGUI.Forms.Label infoData;
	}
}
