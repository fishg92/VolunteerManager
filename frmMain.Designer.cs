namespace VolunteerManager
{
    partial class frmMain
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tsNav = new System.Windows.Forms.ToolStrip();
            this.btnVolunteer = new System.Windows.Forms.ToolStripButton();
            this.btnWorkDay = new System.Windows.Forms.ToolStripButton();
            this.btnReports = new System.Windows.Forms.ToolStripButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tsNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsNav
            // 
            this.tsNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVolunteer,
            this.btnWorkDay,
            this.btnReports});
            this.tsNav.Location = new System.Drawing.Point(0, 0);
            this.tsNav.Name = "tsNav";
            this.tsNav.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsNav.Size = new System.Drawing.Size(892, 25);
            this.tsNav.TabIndex = 0;
            this.tsNav.Text = "toolStrip1";
            // 
            // btnVolunteer
            // 
            this.btnVolunteer.Image = global::VolunteerManager.Properties.Resources.agt_family;
            this.btnVolunteer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVolunteer.Name = "btnVolunteer";
            this.btnVolunteer.Size = new System.Drawing.Size(83, 22);
            this.btnVolunteer.Text = "Volunteers";
            this.btnVolunteer.Click += new System.EventHandler(this.btnVolunteer_Click);
            // 
            // btnWorkDay
            // 
            this.btnWorkDay.Image = global::VolunteerManager.Properties.Resources.korganizer;
            this.btnWorkDay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWorkDay.Name = "btnWorkDay";
            this.btnWorkDay.Size = new System.Drawing.Size(83, 22);
            this.btnWorkDay.Text = "Work Days";
            this.btnWorkDay.Click += new System.EventHandler(this.btnWorkDay_Click);
            // 
            // btnReports
            // 
            this.btnReports.Image = global::VolunteerManager.Properties.Resources.printer;
            this.btnReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(67, 22);
            this.btnReports.Text = "Reports";
            this.btnReports.Visible = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 25);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(892, 442);
            this.pnlMain.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 467);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.tsNav);
            this.Name = "frmMain";
            this.Text = "HAAH Volunteer Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tsNav.ResumeLayout(false);
            this.tsNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsNav;
        private System.Windows.Forms.ToolStripButton btnVolunteer;
        private System.Windows.Forms.ToolStripButton btnWorkDay;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripButton btnReports;
    }
}