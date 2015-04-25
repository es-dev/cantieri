using System.Drawing;

namespace Web.GUI.SAL
{
    partial class SALItem
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
            this.infoSAL = new Gizmox.WebGUI.Forms.Label();
            this.panelLeft = new Gizmox.WebGUI.Forms.Panel();
            this.infoCommesssa = new Gizmox.WebGUI.Forms.Label();
            this.infoAndamentoLavoro = new Gizmox.WebGUI.Forms.Label();
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
            this.jqContainer.Controls.Add(this.infoSAL);
            this.jqContainer.Controls.Add(this.imgStato);
            this.jqContainer.Controls.Add(this.infoAndamentoLavoro);
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
            // infoSAL
            // 
            this.infoSAL.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoSAL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoSAL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.infoSAL.Location = new System.Drawing.Point(87, 2);
            this.infoSAL.Name = "infoSAL";
            this.infoSAL.Size = new System.Drawing.Size(267, 30);
            this.infoSAL.TabIndex = 1;
            this.infoSAL.Text = "DENOMINAZIONE";
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
            // infoCommesssa
            // 
            this.infoCommesssa.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoCommesssa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoCommesssa.ForeColor = System.Drawing.Color.Black;
            this.infoCommesssa.Location = new System.Drawing.Point(90, 30);
            this.infoCommesssa.Name = "infoCommesssa";
            this.infoCommesssa.Size = new System.Drawing.Size(305, 19);
            this.infoCommesssa.TabIndex = 1;
            this.infoCommesssa.Text = "Commessa";
            // 
            // infoAndamentoLavoro
            // 
            this.infoAndamentoLavoro.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoAndamentoLavoro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoAndamentoLavoro.ForeColor = System.Drawing.Color.DarkRed;
            this.infoAndamentoLavoro.Location = new System.Drawing.Point(92, 49);
            this.infoAndamentoLavoro.Name = "infoAndamentoLavoro";
            this.infoAndamentoLavoro.Size = new System.Drawing.Size(274, 44);
            this.infoAndamentoLavoro.TabIndex = 1;
            this.infoAndamentoLavoro.Text = "Margine 0,00€ su importo lavori di 0,00€";
            this.infoAndamentoLavoro.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            // SALItem
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
        private Gizmox.WebGUI.Forms.Label infoSAL;
        private Gizmox.WebGUI.Forms.Panel panelLeft;
        private Gizmox.WebGUI.Forms.Label infoCommesssa;
        private Gizmox.WebGUI.Forms.PictureBox imgStato;
        private Gizmox.WebGUI.Forms.Label infoAndamentoLavoro;
	}
}
