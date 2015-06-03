using System.Drawing;

namespace Web.GUI.Incasso
{
    partial class IncassoItem
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
            this.infoIncasso = new Gizmox.WebGUI.Forms.Label();
            this.infoData = new Gizmox.WebGUI.Forms.Label();
            this.infoImporto = new Gizmox.WebGUI.Forms.Label();
            this.infoTransazionePagamento = new Gizmox.WebGUI.Forms.Label();
            this.infoFatturaVendita = new Gizmox.WebGUI.Forms.Label();
            this.infoCommittente = new Gizmox.WebGUI.Forms.Label();
            this.jqContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoImage)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // jqContainer
            // 
            this.jqContainer.Controls.Add(this.infoFatturaVendita);
            this.jqContainer.Controls.Add(this.infoTransazionePagamento);
            this.jqContainer.Controls.Add(this.panelLeft);
            this.jqContainer.Controls.Add(this.infoImporto);
            this.jqContainer.Controls.Add(this.infoData);
            this.jqContainer.Controls.Add(this.infoIncasso);
            this.jqContainer.Controls.Add(this.infoCommittente);
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
            // infoIncasso
            // 
            this.infoIncasso.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoIncasso.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoIncasso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.infoIncasso.Location = new System.Drawing.Point(91, 2);
            this.infoIncasso.Name = "infoIncasso";
            this.infoIncasso.Size = new System.Drawing.Size(298, 30);
            this.infoIncasso.TabIndex = 1;
            this.infoIncasso.Text = "INCASSO";
            // 
            // infoData
            // 
            this.infoData.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.infoData.Location = new System.Drawing.Point(94, 76);
            this.infoData.Name = "infoData";
            this.infoData.Size = new System.Drawing.Size(151, 18);
            this.infoData.TabIndex = 1;
            this.infoData.Text = "Incassato il dd/MM/yyyy";
            // 
            // infoImporto
            // 
            this.infoImporto.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoImporto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoImporto.ForeColor = System.Drawing.Color.DarkRed;
            this.infoImporto.Location = new System.Drawing.Point(253, 80);
            this.infoImporto.Name = "infoImporto";
            this.infoImporto.Size = new System.Drawing.Size(140, 16);
            this.infoImporto.TabIndex = 1;
            this.infoImporto.Text = "Importo 0,00€";
            this.infoImporto.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // infoTransazionePagamento
            // 
            this.infoTransazionePagamento.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoTransazionePagamento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTransazionePagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.infoTransazionePagamento.Location = new System.Drawing.Point(304, 54);
            this.infoTransazionePagamento.Name = "infoTransazionePagamento";
            this.infoTransazionePagamento.Size = new System.Drawing.Size(88, 18);
            this.infoTransazionePagamento.TabIndex = 1;
            this.infoTransazionePagamento.Text = "Transazione";
            this.infoTransazionePagamento.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // infoFatturaVendita
            // 
            this.infoFatturaVendita.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoFatturaVendita.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoFatturaVendita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.infoFatturaVendita.Location = new System.Drawing.Point(94, 54);
            this.infoFatturaVendita.Name = "infoFatturaVendita";
            this.infoFatturaVendita.Size = new System.Drawing.Size(226, 18);
            this.infoFatturaVendita.TabIndex = 1;
            this.infoFatturaVendita.Text = "Fattura vendita";
            // 
            // infoCommittente
            // 
            this.infoCommittente.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoCommittente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoCommittente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.infoCommittente.Location = new System.Drawing.Point(94, 32);
            this.infoCommittente.Name = "infoCommittente";
            this.infoCommittente.Size = new System.Drawing.Size(296, 18);
            this.infoCommittente.TabIndex = 1;
            this.infoCommittente.Text = "Committente";
            // 
            // IncassoItem
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Size = new System.Drawing.Size(400, 100);
            this.jqContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoImage)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Gizmox.WebGUI.Forms.Label infoCodice;
        private Gizmox.WebGUI.Forms.PictureBox infoImage;
        private Gizmox.WebGUI.Forms.Panel panelLeft;
        private Gizmox.WebGUI.Forms.Label infoIncasso;
        private Gizmox.WebGUI.Forms.Label infoImporto;
        private Gizmox.WebGUI.Forms.Label infoData;
        private Gizmox.WebGUI.Forms.Label infoFatturaVendita;
        private Gizmox.WebGUI.Forms.Label infoTransazionePagamento;
        private Gizmox.WebGUI.Forms.Label infoCommittente;
	}
}
