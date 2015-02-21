using System.Drawing;

namespace Web.GUI.Cliente
{
    partial class ClienteItem
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
            this.infoIndirizzo = new Gizmox.WebGUI.Forms.Label();
            this.infoRagioneSociale = new Gizmox.WebGUI.Forms.Label();
            this.infoLiquidazioneTotale = new Gizmox.WebGUI.Forms.Label();
            this.imgStato = new Gizmox.WebGUI.Forms.PictureBox();
            this.infoCommesssa = new Gizmox.WebGUI.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoImage)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStato)).BeginInit();
            this.SuspendLayout();
            // 
            // infoCodice
            // 
            this.infoCodice.BackColor = System.Drawing.Color.Silver;
            this.infoCodice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoCodice.ForeColor = System.Drawing.Color.DimGray;
            this.infoCodice.Location = new System.Drawing.Point(0, 60);
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
            // infoIndirizzo
            // 
            this.infoIndirizzo.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoIndirizzo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoIndirizzo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.infoIndirizzo.Location = new System.Drawing.Point(90, 29);
            this.infoIndirizzo.Name = "infoIndirizzo";
            this.infoIndirizzo.Size = new System.Drawing.Size(302, 20);
            this.infoIndirizzo.TabIndex = 1;
            this.infoIndirizzo.Text = "Indirizzo";
            // 
            // infoRagioneSociale
            // 
            this.infoRagioneSociale.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoRagioneSociale.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoRagioneSociale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.infoRagioneSociale.Location = new System.Drawing.Point(88, 2);
            this.infoRagioneSociale.Name = "infoRagioneSociale";
            this.infoRagioneSociale.Size = new System.Drawing.Size(269, 30);
            this.infoRagioneSociale.TabIndex = 1;
            this.infoRagioneSociale.Text = "RAGIONE SOCIALE";
            // 
            // infoLiquidazioneTotale
            // 
            this.infoLiquidazioneTotale.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoLiquidazioneTotale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLiquidazioneTotale.ForeColor = System.Drawing.Color.DarkRed;
            this.infoLiquidazioneTotale.Location = new System.Drawing.Point(92, 75);
            this.infoLiquidazioneTotale.Name = "infoLiquidazioneTotale";
            this.infoLiquidazioneTotale.Size = new System.Drawing.Size(265, 16);
            this.infoLiquidazioneTotale.TabIndex = 1;
            this.infoLiquidazioneTotale.Text = "Incassato 0,00� su un totale di 0,00�";
            this.infoLiquidazioneTotale.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // imgStato
            // 
            this.imgStato.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.imgStato.BackColor = System.Drawing.Color.Transparent;
            this.imgStato.Location = new System.Drawing.Point(373, 72);
            this.imgStato.Name = "imgStato";
            this.imgStato.Size = new System.Drawing.Size(20, 20);
            this.imgStato.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStato.TabIndex = 3;
            this.imgStato.TabStop = false;
            // 
            // infoCommesssa
            // 
            this.infoCommesssa.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoCommesssa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoCommesssa.ForeColor = System.Drawing.Color.Black;
            this.infoCommesssa.Location = new System.Drawing.Point(90, 49);
            this.infoCommesssa.Name = "infoCommesssa";
            this.infoCommesssa.Size = new System.Drawing.Size(295, 20);
            this.infoCommesssa.TabIndex = 1;
            this.infoCommesssa.Text = "Commessa";
            // 
            // ClienteItem
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.JQContainer.Controls.Add(this.infoRagioneSociale);
            this.JQContainer.Controls.Add(this.panelLeft);
            this.JQContainer.Controls.Add(this.infoCommesssa);
            this.JQContainer.Controls.Add(this.infoIndirizzo);
            this.JQContainer.Controls.Add(this.imgStato);
            this.JQContainer.Controls.Add(this.infoLiquidazioneTotale);
            this.Size = new System.Drawing.Size(400, 100);
            this.ItemClick += new Library.Template.MVVM.TemplateItem.ItemClickHandler(this.ClienteItem_ItemClick);
            ((System.ComponentModel.ISupportInitialize)(this.infoImage)).EndInit();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgStato)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Gizmox.WebGUI.Forms.Label infoCodice;
        private Gizmox.WebGUI.Forms.PictureBox infoImage;
        private Gizmox.WebGUI.Forms.Panel panelLeft;
        private Gizmox.WebGUI.Forms.Label infoIndirizzo;
        private Gizmox.WebGUI.Forms.Label infoRagioneSociale;
        private Gizmox.WebGUI.Forms.Label infoCommesssa;
        private Gizmox.WebGUI.Forms.PictureBox imgStato;
        private Gizmox.WebGUI.Forms.Label infoLiquidazioneTotale;
	}
}
