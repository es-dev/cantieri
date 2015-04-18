using System.Drawing;

namespace Web.GUI.Agenda
{
	partial class SchedulerView
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
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(0, 288);
            // 
            // btnDay
            // 
            this.btnDay.Location = new System.Drawing.Point(0, 144);
            // 
            // btnWeek
            // 
            this.btnWeek.Location = new System.Drawing.Point(0, 216);
            this.Controls.SetChildIndex(this.panelCommands, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnOrderBy, 0);
            this.Controls.SetChildIndex(this.btnAdvancedSearch, 0);
            this.Controls.SetChildIndex(this.btnPrevious, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
	}
}
