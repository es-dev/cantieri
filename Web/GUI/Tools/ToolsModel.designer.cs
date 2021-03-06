using System.Drawing;

namespace Web.GUI.Tools
{
    partial class ToolsModel 
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
            this.lblComuni = new Gizmox.WebGUI.Forms.Label();
            this.lblPagamentiFatture = new Gizmox.WebGUI.Forms.Label();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.btnCheckComuni = new Gizmox.WebGUI.Forms.Button();
            this.lblLogAttivita = new Gizmox.WebGUI.Forms.Label();
            this.listLogger = new Gizmox.WebGUI.Forms.ListBox();
            this.btnClearLog = new Gizmox.WebGUI.Forms.Button();
            this.lblWarning = new Gizmox.WebGUI.Forms.Label();
            this.btnCheckStati = new Gizmox.WebGUI.Forms.Button();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.label2);
            this.container.Controls.Add(this.btnCheckStati);
            this.container.Controls.Add(this.lblWarning);
            this.container.Controls.Add(this.btnClearLog);
            this.container.Controls.Add(this.listLogger);
            this.container.Controls.Add(this.lblLogAttivita);
            this.container.Controls.Add(this.btnCheckComuni);
            this.container.Controls.Add(this.label1);
            this.container.Controls.Add(this.lblPagamentiFatture);
            this.container.Controls.Add(this.lblComuni);
            this.container.Size = new System.Drawing.Size(923, 625);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.lblComuni, 0);
            this.container.Controls.SetChildIndex(this.lblPagamentiFatture, 0);
            this.container.Controls.SetChildIndex(this.label1, 0);
            this.container.Controls.SetChildIndex(this.btnCheckComuni, 0);
            this.container.Controls.SetChildIndex(this.lblLogAttivita, 0);
            this.container.Controls.SetChildIndex(this.listLogger, 0);
            this.container.Controls.SetChildIndex(this.btnClearLog, 0);
            this.container.Controls.SetChildIndex(this.lblWarning, 0);
            this.container.Controls.SetChildIndex(this.btnCheckStati, 0);
            this.container.Controls.SetChildIndex(this.label2, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(664, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(608, 3);
            // 
            // panelCommands
            // 
            this.panelCommands.Size = new System.Drawing.Size(101, 672);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 600);
            // 
            // lblComuni
            // 
            this.lblComuni.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblComuni.BackColor = System.Drawing.Color.Gainsboro;
            this.lblComuni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComuni.ForeColor = System.Drawing.Color.DarkRed;
            this.lblComuni.Location = new System.Drawing.Point(13, 71);
            this.lblComuni.Name = "lblComuni";
            this.lblComuni.Size = new System.Drawing.Size(885, 30);
            this.lblComuni.TabIndex = 1001;
            this.lblComuni.Text = "CONTROLLO ARCHIVIO COMUNI E PROVINCE";
            this.lblComuni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPagamentiFatture
            // 
            this.lblPagamentiFatture.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblPagamentiFatture.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPagamentiFatture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagamentiFatture.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPagamentiFatture.Location = new System.Drawing.Point(13, 197);
            this.lblPagamentiFatture.Name = "lblPagamentiFatture";
            this.lblPagamentiFatture.Size = new System.Drawing.Size(883, 30);
            this.lblPagamentiFatture.TabIndex = 1001;
            this.lblPagamentiFatture.Text = "VERIFICA COERENZA STATI";
            this.lblPagamentiFatture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 58);
            this.label1.TabIndex = 1002;
            this.label1.Text = "Questa procedura consente di controllare l\'archivio comuni e province e di verifi" +
    "care l\'esatta associazione nelle varie tabelle dati...";
            // 
            // btnCheckComuni
            // 
            this.btnCheckComuni.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnCheckComuni.CustomStyle = "F";
            this.btnCheckComuni.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnCheckComuni.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckComuni.Location = new System.Drawing.Point(741, 123);
            this.btnCheckComuni.Name = "btnCheckComuni";
            this.btnCheckComuni.Size = new System.Drawing.Size(119, 32);
            this.btnCheckComuni.TabIndex = 1003;
            this.btnCheckComuni.Text = "Avvia";
            this.btnCheckComuni.Click += new System.EventHandler(this.btnCheckComuni_Click);
            // 
            // lblLogAttivita
            // 
            this.lblLogAttivita.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblLogAttivita.BackColor = System.Drawing.Color.Gainsboro;
            this.lblLogAttivita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogAttivita.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLogAttivita.Location = new System.Drawing.Point(13, 328);
            this.lblLogAttivita.Name = "lblLogAttivita";
            this.lblLogAttivita.Size = new System.Drawing.Size(883, 30);
            this.lblLogAttivita.TabIndex = 1001;
            this.lblLogAttivita.Text = "LOG ATTIVITA\'";
            this.lblLogAttivita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listLogger
            // 
            this.listLogger.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.listLogger.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLogger.Location = new System.Drawing.Point(47, 370);
            this.listLogger.Name = "listLogger";
            this.listLogger.Size = new System.Drawing.Size(797, 116);
            this.listLogger.TabIndex = 1004;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.btnClearLog.CustomStyle = "F";
            this.btnClearLog.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnClearLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLog.Location = new System.Drawing.Point(47, 564);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 29);
            this.btnClearLog.TabIndex = 1003;
            this.btnClearLog.Text = "Clear log";
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblWarning.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(124, 569);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(772, 47);
            this.lblWarning.TabIndex = 1002;
            this.lblWarning.Text = "Sono stati riscontrati errori nelle procedure di controllo, verificare i log rice" +
    "rcando la parola chiave ERROR per avere maggiori dettagli...";
            this.lblWarning.Visible = false;
            // 
            // btnCheckStati
            // 
            this.btnCheckStati.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnCheckStati.CustomStyle = "F";
            this.btnCheckStati.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnCheckStati.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckStati.Location = new System.Drawing.Point(741, 258);
            this.btnCheckStati.Name = "btnCheckStati";
            this.btnCheckStati.Size = new System.Drawing.Size(119, 32);
            this.btnCheckStati.TabIndex = 1003;
            this.btnCheckStati.Text = "Avvia";
            this.btnCheckStati.Click += new System.EventHandler(this.btnCheckStati_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(645, 58);
            this.label2.TabIndex = 1002;
            this.label2.Text = "Questa procedura consente di verificare e correggere eventuali incoerenze rilevat" +
    "e negli stati dei fornitori, dei committenti, delle fatture, dei SAL e delle com" +
    "messe di lavorazione...";
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Gizmox.WebGUI.Forms.Label lblPagamentiFatture;
        private Gizmox.WebGUI.Forms.Label lblComuni;
        private Gizmox.WebGUI.Forms.ListBox listLogger;
        private Gizmox.WebGUI.Forms.Label lblLogAttivita;
        private Gizmox.WebGUI.Forms.Button btnCheckComuni;
        private Gizmox.WebGUI.Forms.Label label1;
        private Gizmox.WebGUI.Forms.Label lblWarning;
        private Gizmox.WebGUI.Forms.Button btnClearLog;
        private Gizmox.WebGUI.Forms.Label label2;
        private Gizmox.WebGUI.Forms.Button btnCheckStati;


    }
}
