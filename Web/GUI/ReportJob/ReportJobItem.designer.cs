using System.Drawing;

namespace Web.GUI.ReportJob
{
    partial class ReportJobItem
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
            this.infoCodiceReport = new Gizmox.WebGUI.Forms.Label();
            this.infoTipo = new Gizmox.WebGUI.Forms.Label();
            this.infoFornitore = new Gizmox.WebGUI.Forms.Label();
            this.infoElaborazione = new Gizmox.WebGUI.Forms.Label();
            this.lnkReport = new Gizmox.WebGUI.Forms.LinkLabel();
            this.jqContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoImage)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // jqContainer
            // 
            this.jqContainer.Controls.Add(this.lnkReport);
            this.jqContainer.Controls.Add(this.infoElaborazione);
            this.jqContainer.Controls.Add(this.panelLeft);
            this.jqContainer.Controls.Add(this.infoTipo);
            this.jqContainer.Controls.Add(this.infoFornitore);
            this.jqContainer.Controls.Add(this.infoCodiceReport);
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
            // infoCodiceReport
            // 
            this.infoCodiceReport.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoCodiceReport.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoCodiceReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.infoCodiceReport.Location = new System.Drawing.Point(91, 3);
            this.infoCodiceReport.Name = "infoCodiceReport";
            this.infoCodiceReport.Size = new System.Drawing.Size(263, 30);
            this.infoCodiceReport.TabIndex = 1;
            this.infoCodiceReport.Text = "CODICE REPORT";
            // 
            // infoTipo
            // 
            this.infoTipo.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.infoTipo.Location = new System.Drawing.Point(91, 33);
            this.infoTipo.Name = "infoTipo";
            this.infoTipo.Size = new System.Drawing.Size(304, 21);
            this.infoTipo.TabIndex = 1;
            this.infoTipo.Text = "Tipo";
            // 
            // infoFornitore
            // 
            this.infoFornitore.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoFornitore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoFornitore.ForeColor = System.Drawing.Color.DarkRed;
            this.infoFornitore.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.infoFornitore.Location = new System.Drawing.Point(91, 74);
            this.infoFornitore.Name = "infoFornitore";
            this.infoFornitore.Size = new System.Drawing.Size(305, 20);
            this.infoFornitore.TabIndex = 1;
            this.infoFornitore.Text = "Fornitore";
            this.infoFornitore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // infoElaborazione
            // 
            this.infoElaborazione.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoElaborazione.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoElaborazione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.infoElaborazione.Location = new System.Drawing.Point(91, 53);
            this.infoElaborazione.Name = "infoElaborazione";
            this.infoElaborazione.Size = new System.Drawing.Size(156, 21);
            this.infoElaborazione.TabIndex = 1;
            this.infoElaborazione.Text = "Elaborato il dd/MM/yyyy";
            // 
            // lnkReport
            // 
            this.lnkReport.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand;
            this.lnkReport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkReport.LinkColor = System.Drawing.Color.Blue;
            this.lnkReport.Location = new System.Drawing.Point(319, 54);
            this.lnkReport.Name = "lnkReport";
            this.lnkReport.Size = new System.Drawing.Size(76, 15);
            this.lnkReport.TabIndex = 2;
            this.lnkReport.TabStop = true;
            this.lnkReport.Text = "Report (PDF)";
            this.lnkReport.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lnkReport.Visible = false;
            // 
            // ReportJobItem
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
        private Gizmox.WebGUI.Forms.Label infoCodiceReport;
        private Gizmox.WebGUI.Forms.Label infoTipo;
        private Gizmox.WebGUI.Forms.Label infoFornitore;
        private Gizmox.WebGUI.Forms.Label infoElaborazione;
        private Gizmox.WebGUI.Forms.LinkLabel lnkReport;
	}
}
