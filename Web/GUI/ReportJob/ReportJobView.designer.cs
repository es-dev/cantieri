using System.Drawing;

namespace Web.GUI.ReportJob
{
    partial class ReportJobView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportJobView));
            this.panelTipoReport = new Gizmox.WebGUI.Forms.Panel();
            this.btnCancelTipoReport = new Gizmox.WebGUI.Forms.Button();
            this.btnConfirmTipoReport = new Gizmox.WebGUI.Forms.Button();
            this.optResocontoFornitori = new Gizmox.WebGUI.Forms.RadioButton();
            this.optSituazioneFornitore = new Gizmox.WebGUI.Forms.RadioButton();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.panelCommands.SuspendLayout();
            this.panelTipoReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnAdd_Click);
            // 
            // panelTipoReport
            // 
            this.panelTipoReport.BackColor = System.Drawing.Color.White;
            this.panelTipoReport.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.Silver);
            this.panelTipoReport.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.panelTipoReport.Controls.Add(this.btnCancelTipoReport);
            this.panelTipoReport.Controls.Add(this.btnConfirmTipoReport);
            this.panelTipoReport.Controls.Add(this.optResocontoFornitori);
            this.panelTipoReport.Controls.Add(this.optSituazioneFornitore);
            this.panelTipoReport.Controls.Add(this.label1);
            this.panelTipoReport.Location = new System.Drawing.Point(102, 144);
            this.panelTipoReport.Name = "panelTipoReport";
            this.panelTipoReport.Size = new System.Drawing.Size(573, 206);
            this.panelTipoReport.TabIndex = 13;
            this.panelTipoReport.Visible = false;
            // 
            // btnCancelTipoReport
            // 
            this.btnCancelTipoReport.CustomStyle = "F";
            this.btnCancelTipoReport.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnCancelTipoReport.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCancelTipoReport.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnCancelTipoReport.Image"));
            this.btnCancelTipoReport.Location = new System.Drawing.Point(356, 163);
            this.btnCancelTipoReport.Name = "btnCancelTipoReport";
            this.btnCancelTipoReport.Size = new System.Drawing.Size(97, 31);
            this.btnCancelTipoReport.TabIndex = 2;
            this.btnCancelTipoReport.Text = "Annulla";
            this.btnCancelTipoReport.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelTipoReport.Click += new System.EventHandler(this.btnCancelTipoReport_Click);
            // 
            // btnConfirmTipoReport
            // 
            this.btnConfirmTipoReport.CustomStyle = "F";
            this.btnConfirmTipoReport.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnConfirmTipoReport.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnConfirmTipoReport.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnConfirmTipoReport.Image"));
            this.btnConfirmTipoReport.Location = new System.Drawing.Point(460, 163);
            this.btnConfirmTipoReport.Name = "btnConfirmTipoReport";
            this.btnConfirmTipoReport.Size = new System.Drawing.Size(101, 31);
            this.btnConfirmTipoReport.TabIndex = 2;
            this.btnConfirmTipoReport.Text = "Conferma";
            this.btnConfirmTipoReport.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmTipoReport.Click += new System.EventHandler(this.btnConfirmTipoReport_Click);
            // 
            // optResocontoFornitori
            // 
            this.optResocontoFornitori.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand;
            this.optResocontoFornitori.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.optResocontoFornitori.Location = new System.Drawing.Point(34, 100);
            this.optResocontoFornitori.Name = "optResocontoFornitori";
            this.optResocontoFornitori.Size = new System.Drawing.Size(495, 47);
            this.optResocontoFornitori.TabIndex = 1;
            this.optResocontoFornitori.Text = "Resoconto fornitori (genera un report contenente la situazione generale di tutti " +
    "i fornitori, le somme da pagare e le scadenze imminenti)";
            // 
            // optSituazioneFornitore
            // 
            this.optSituazioneFornitore.Checked = true;
            this.optSituazioneFornitore.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand;
            this.optSituazioneFornitore.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.optSituazioneFornitore.Location = new System.Drawing.Point(34, 51);
            this.optSituazioneFornitore.Name = "optSituazioneFornitore";
            this.optSituazioneFornitore.Size = new System.Drawing.Size(495, 47);
            this.optSituazioneFornitore.TabIndex = 1;
            this.optSituazioneFornitore.Text = "Situazione fornitore (genera un report presentando la situazione completa per un " +
    "singolo fornitore)";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleziona un tipo di report";
            // 
            // ReportJobView
            // 
            this.Controls.Add(this.panelTipoReport);
            this.Controls.SetChildIndex(this.panelCommands, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnOrderBy, 0);
            this.Controls.SetChildIndex(this.btnAdvancedSearch, 0);
            this.Controls.SetChildIndex(this.panelTipoReport, 0);
            this.panelCommands.ResumeLayout(false);
            this.panelTipoReport.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Gizmox.WebGUI.Forms.Panel panelTipoReport;
        private Gizmox.WebGUI.Forms.Button btnCancelTipoReport;
        private Gizmox.WebGUI.Forms.Button btnConfirmTipoReport;
        private Gizmox.WebGUI.Forms.RadioButton optResocontoFornitori;
        private Gizmox.WebGUI.Forms.RadioButton optSituazioneFornitore;
        private Gizmox.WebGUI.Forms.Label label1;

    }
}
