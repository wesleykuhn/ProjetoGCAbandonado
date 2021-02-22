namespace GC.Forms.Main.Modals.Main
{
    partial class FRM_MemoryUsage
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
            this.PGB_Bar = new System.Windows.Forms.ProgressBar();
            this.LBL_Details = new System.Windows.Forms.Label();
            this.LBL_Free = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PGB_Bar
            // 
            this.PGB_Bar.Location = new System.Drawing.Point(20, 80);
            this.PGB_Bar.Name = "PGB_Bar";
            this.PGB_Bar.Size = new System.Drawing.Size(360, 30);
            this.PGB_Bar.TabIndex = 38;
            // 
            // LBL_Details
            // 
            this.LBL_Details.AutoSize = true;
            this.LBL_Details.ForeColor = System.Drawing.SystemColors.Control;
            this.LBL_Details.Location = new System.Drawing.Point(138, 60);
            this.LBL_Details.Name = "LBL_Details";
            this.LBL_Details.Size = new System.Drawing.Size(124, 14);
            this.LBL_Details.TabIndex = 39;
            this.LBL_Details.Text = "Usado / Disponível";
            // 
            // LBL_Free
            // 
            this.LBL_Free.AutoSize = true;
            this.LBL_Free.ForeColor = System.Drawing.SystemColors.Control;
            this.LBL_Free.Location = new System.Drawing.Point(177, 116);
            this.LBL_Free.Name = "LBL_Free";
            this.LBL_Free.Size = new System.Drawing.Size(46, 14);
            this.LBL_Free.TabIndex = 40;
            this.LBL_Free.Text = "Livre: ";
            // 
            // FRM_MemoryUsage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.LBL_Free);
            this.Controls.Add(this.LBL_Details);
            this.Controls.Add(this.PGB_Bar);
            this.Name = "FRM_MemoryUsage";
            this.Text = "GC - Uso Da Mémoria";
            this.Controls.SetChildIndex(this.PGB_Bar, 0);
            this.Controls.SetChildIndex(this.LBL_Details, 0);
            this.Controls.SetChildIndex(this.LBL_Free, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar PGB_Bar;
        private System.Windows.Forms.Label LBL_Details;
        private System.Windows.Forms.Label LBL_Free;
    }
}