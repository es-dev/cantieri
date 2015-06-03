using System.Drawing;

namespace Web.GUI.FatturaAcquisto
{
    partial class FatturaAcquistoItem
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
            this.infoPagamentoTotale = new Gizmox.WebGUI.Forms.Label();
            this.infoCodice = new Gizmox.WebGUI.Forms.Label();
            this.infoImage = new Gizmox.WebGUI.Forms.PictureBox();
            this.infoNumeroData = new Gizmox.WebGUI.Forms.Label();
            this.panelLeft = new Gizmox.WebGUI.Forms.Panel();
            this.infoFornitore = new Gizmox.WebGUI.Forms.Label();
            this.infoCentroCosto = new Gizmox.WebGUI.Forms.Label();
            this.imgStato = new Gizmox.WebGUI.Forms.PictureBox();
            this.jqContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoImage)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStato)).BeginInit();
            this.SuspendLayout();
            // 
            // jqContainer
            // 
            this.jqContainer.Controls.Add(this.panelLeft);
            this.jqContainer.Controls.Add(this.infoNumeroData);
            this.jqContainer.Controls.Add(this.imgStato);
            this.jqContainer.Controls.Add(this.infoCentroCosto);
            this.jqContainer.Controls.Add(this.infoFornitore);
            this.jqContainer.Controls.Add(this.infoPagamentoTotale);
            // 
            // infoPagamentoTotale
            // 
            this.infoPagamentoTotale.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoPagamentoTotale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoPagamentoTotale.ForeColor = System.Drawing.Color.DarkRed;
            this.infoPagamentoTotale.Location = new System.Drawing.Point(93, 78);
            this.infoPagamentoTotale.Name = "infoPagamentoTotale";
            this.infoPagamentoTotale.Size = new System.Drawing.Size(265, 16);
            this.infoPagamentoTotale.TabIndex = 1;
            this.infoPagamentoTotale.Text = "Pagato 0,00€ su un totale di 0,00€";
            this.infoPagamentoTotale.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // infoNumeroData
            // 
            this.infoNumeroData.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoNumeroData.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoNumeroData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.infoNumeroData.Location = new System.Drawing.Point(91, 2);
            this.infoNumeroData.Name = "infoNumeroData";
            this.infoNumeroData.Size = new System.Drawing.Size(301, 26);
            this.infoNumeroData.TabIndex = 1;
            this.infoNumeroData.Text = "NUMERO";
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
            // infoFornitore
            // 
            this.infoFornitore.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoFornitore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoFornitore.ForeColor = System.Drawing.Color.Black;
            this.infoFornitore.Location = new System.Drawing.Point(92, 32);
            this.infoFornitore.Name = "infoFornitore";
            this.infoFornitore.Size = new System.Drawing.Size(304, 18);
            this.infoFornitore.TabIndex = 1;
            this.infoFornitore.Text = "Fornitore";
            // 
            // infoCentroCosto
            // 
            this.infoCentroCosto.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoCentroCosto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoCentroCosto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.infoCentroCosto.Location = new System.Drawing.Point(92, 52);
            this.infoCentroCosto.Name = "infoCentroCosto";
            this.infoCentroCosto.Size = new System.Drawing.Size(303, 18);
            this.infoCentroCosto.TabIndex = 1;
            this.infoCentroCosto.Text = "Centro di Costo";
            // 
            // imgStato
            // 
            this.imgStato.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.imgStato.BackColor = System.Drawing.Color.Transparent;
            this.imgStato.Location = new System.Drawing.Point(373, 74);
            this.imgStato.Name = "imgStato";
            this.imgStato.Size = new System.Drawing.Size(20, 20);
            this.imgStato.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStato.TabIndex = 3;
            this.imgStato.TabStop = false;
            // 
            // FatturaAcquistoItem
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

        private Gizmox.WebGUI.Forms.Label infoPagamentoTotale;
        private Gizmox.WebGUI.Forms.Label infoCodice;
        private Gizmox.WebGUI.Forms.PictureBox infoImage;
        private Gizmox.WebGUI.Forms.Label infoNumeroData;
        private Gizmox.WebGUI.Forms.Panel panelLeft;
        private Gizmox.WebGUI.Forms.Label infoFornitore;
        private Gizmox.WebGUI.Forms.Label infoCentroCosto;
        private Gizmox.WebGUI.Forms.PictureBox imgStato;
	}
}
