using System.Drawing;

namespace Web.GUI.Fornitore
{
    partial class FornitoreItem
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
            this.infoRagioneSociale = new Gizmox.WebGUI.Forms.Label();
            this.infoPartitaIVA = new Gizmox.WebGUI.Forms.Label();
            this.infoCommesssa = new Gizmox.WebGUI.Forms.Label();
            this.imgStato = new Gizmox.WebGUI.Forms.PictureBox();
            this.infoPagamentoTotale = new Gizmox.WebGUI.Forms.Label();
            this.jqContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoImage)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStato)).BeginInit();
            this.SuspendLayout();
            // 
            // jqContainer
            // 
            this.jqContainer.Controls.Add(this.infoRagioneSociale);
            this.jqContainer.Controls.Add(this.panelLeft);
            this.jqContainer.Controls.Add(this.infoPartitaIVA);
            this.jqContainer.Controls.Add(this.infoPagamentoTotale);
            this.jqContainer.Controls.Add(this.imgStato);
            this.jqContainer.Controls.Add(this.infoCommesssa);
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
            // infoRagioneSociale
            // 
            this.infoRagioneSociale.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoRagioneSociale.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoRagioneSociale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.infoRagioneSociale.Location = new System.Drawing.Point(89, 2);
            this.infoRagioneSociale.Name = "infoRagioneSociale";
            this.infoRagioneSociale.Size = new System.Drawing.Size(303, 27);
            this.infoRagioneSociale.TabIndex = 1;
            this.infoRagioneSociale.Text = "RAGIONE SOCIALE";
            // 
            // infoPartitaIVA
            // 
            this.infoPartitaIVA.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoPartitaIVA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoPartitaIVA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.infoPartitaIVA.Location = new System.Drawing.Point(91, 31);
            this.infoPartitaIVA.Name = "infoPartitaIVA";
            this.infoPartitaIVA.Size = new System.Drawing.Size(294, 17);
            this.infoPartitaIVA.TabIndex = 1;
            this.infoPartitaIVA.Text = "Partita IVA";
            // 
            // infoCommesssa
            // 
            this.infoCommesssa.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoCommesssa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoCommesssa.ForeColor = System.Drawing.Color.Black;
            this.infoCommesssa.Location = new System.Drawing.Point(91, 52);
            this.infoCommesssa.Name = "infoCommesssa";
            this.infoCommesssa.Size = new System.Drawing.Size(295, 20);
            this.infoCommesssa.TabIndex = 1;
            this.infoCommesssa.Text = "Commessa";
            // 
            // imgStato
            // 
            this.imgStato.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.imgStato.BackColor = System.Drawing.Color.Transparent;
            this.imgStato.Location = new System.Drawing.Point(375, 74);
            this.imgStato.Name = "imgStato";
            this.imgStato.Size = new System.Drawing.Size(20, 20);
            this.imgStato.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStato.TabIndex = 3;
            this.imgStato.TabStop = false;
            // 
            // infoPagamentoTotale
            // 
            this.infoPagamentoTotale.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoPagamentoTotale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoPagamentoTotale.ForeColor = System.Drawing.Color.DarkRed;
            this.infoPagamentoTotale.Location = new System.Drawing.Point(94, 77);
            this.infoPagamentoTotale.Name = "infoPagamentoTotale";
            this.infoPagamentoTotale.Size = new System.Drawing.Size(264, 16);
            this.infoPagamentoTotale.TabIndex = 1;
            this.infoPagamentoTotale.Text = "Pagato 0,00� su un totale di 0,00�";
            this.infoPagamentoTotale.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FornitoreItem
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
        private Gizmox.WebGUI.Forms.Panel panelLeft;
        private Gizmox.WebGUI.Forms.Label infoRagioneSociale;
        private Gizmox.WebGUI.Forms.Label infoPartitaIVA;
        private Gizmox.WebGUI.Forms.Label infoCommesssa;
        private Gizmox.WebGUI.Forms.Label infoPagamentoTotale;
        private Gizmox.WebGUI.Forms.PictureBox imgStato;
	}
}
