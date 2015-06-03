using System.Drawing;

namespace Web.GUI.Commessa
{
    partial class CommessaItem
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
            this.infoDenominazione = new Gizmox.WebGUI.Forms.Label();
            this.panelLeft = new Gizmox.WebGUI.Forms.Panel();
            this.infoDescrizione = new Gizmox.WebGUI.Forms.Label();
            this.imgStato = new Gizmox.WebGUI.Forms.PictureBox();
            this.infoStatoLavori = new Gizmox.WebGUI.Forms.Label();
            this.infoProgressBar = new Gizmox.WebGUI.Forms.ProgressBar();
            this.infoProgress = new Gizmox.WebGUI.Forms.Label();
            this.jqContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoImage)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStato)).BeginInit();
            this.SuspendLayout();
            // 
            // jqContainer
            // 
            this.jqContainer.Controls.Add(this.infoProgress);
            this.jqContainer.Controls.Add(this.infoProgressBar);
            this.jqContainer.Controls.Add(this.panelLeft);
            this.jqContainer.Controls.Add(this.infoDenominazione);
            this.jqContainer.Controls.Add(this.infoDescrizione);
            this.jqContainer.Controls.Add(this.infoStatoLavori);
            this.jqContainer.Controls.Add(this.imgStato);
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
            // infoDenominazione
            // 
            this.infoDenominazione.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoDenominazione.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoDenominazione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.infoDenominazione.Location = new System.Drawing.Point(91, 2);
            this.infoDenominazione.Name = "infoDenominazione";
            this.infoDenominazione.Size = new System.Drawing.Size(263, 30);
            this.infoDenominazione.TabIndex = 1;
            this.infoDenominazione.Text = "DENOMINAZIONE";
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
            // infoDescrizione
            // 
            this.infoDescrizione.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoDescrizione.Location = new System.Drawing.Point(91, 36);
            this.infoDescrizione.Name = "infoDescrizione";
            this.infoDescrizione.Size = new System.Drawing.Size(305, 36);
            this.infoDescrizione.TabIndex = 2;
            this.infoDescrizione.Text = "Descrizione";
            // 
            // imgStato
            // 
            this.imgStato.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.imgStato.BackColor = System.Drawing.Color.Transparent;
            this.imgStato.Location = new System.Drawing.Point(370, 74);
            this.imgStato.Name = "imgStato";
            this.imgStato.Size = new System.Drawing.Size(20, 20);
            this.imgStato.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStato.TabIndex = 3;
            this.imgStato.TabStop = false;
            // 
            // infoStatoLavori
            // 
            this.infoStatoLavori.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoStatoLavori.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoStatoLavori.ForeColor = System.Drawing.Color.DarkRed;
            this.infoStatoLavori.Location = new System.Drawing.Point(224, 74);
            this.infoStatoLavori.Name = "infoStatoLavori";
            this.infoStatoLavori.Size = new System.Drawing.Size(143, 16);
            this.infoStatoLavori.TabIndex = 1;
            this.infoStatoLavori.Text = "Scadenza dd/MM/yyyy";
            this.infoStatoLavori.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // infoProgressBar
            // 
            this.infoProgressBar.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.infoProgressBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.infoProgressBar.Location = new System.Drawing.Point(90, 75);
            this.infoProgressBar.Name = "infoProgressBar";
            this.infoProgressBar.Size = new System.Drawing.Size(100, 15);
            this.infoProgressBar.TabIndex = 4;
            // 
            // infoProgress
            // 
            this.infoProgress.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.infoProgress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoProgress.ForeColor = System.Drawing.Color.Blue;
            this.infoProgress.Location = new System.Drawing.Point(195, 72);
            this.infoProgress.Name = "infoProgress";
            this.infoProgress.Size = new System.Drawing.Size(29, 18);
            this.infoProgress.TabIndex = 1;
            this.infoProgress.Text = "0%";
            this.infoProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CommessaItem
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Size = new System.Drawing.Size(400, 100);
            this.jqContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoImage)).EndInit();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgStato)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Gizmox.WebGUI.Forms.Label infoCodice;
        private Gizmox.WebGUI.Forms.PictureBox infoImage;
        private Gizmox.WebGUI.Forms.Label infoDenominazione;
        private Gizmox.WebGUI.Forms.Panel panelLeft;
        private Gizmox.WebGUI.Forms.Label infoDescrizione;
        private Gizmox.WebGUI.Forms.Label infoStatoLavori;
        private Gizmox.WebGUI.Forms.PictureBox imgStato;
        private Gizmox.WebGUI.Forms.ProgressBar infoProgressBar;
        private Gizmox.WebGUI.Forms.Label infoProgress;
	}
}
