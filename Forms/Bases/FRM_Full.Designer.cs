namespace GC.Forms.Bases
{
    partial class FRM_Full
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Full));
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnl_btnClose = new GC.Components.CMP_BtnTopClose();
            this.pnl_btnResize = new GC.Components.CMP_BtnTopResize();
            this.pnl_btnMinimize = new GC.Components.CMP_BtnTopMinimize();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFormTitle.Location = new System.Drawing.Point(12, 9);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(43, 16);
            this.lblFormTitle.TabIndex = 35;
            this.lblFormTitle.Text = "GC - ";
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblFormTitle_MouseDown);
            // 
            // pnl_btnClose
            // 
            this.pnl_btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnl_btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_btnClose.BackgroundImage")));
            this.pnl_btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl_btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnl_btnClose.Location = new System.Drawing.Point(450, 0);
            this.pnl_btnClose.Name = "pnl_btnClose";
            this.pnl_btnClose.Size = new System.Drawing.Size(50, 30);
            this.pnl_btnClose.TabIndex = 42;
            this.pnl_btnClose.Click += new System.EventHandler(this.Pnl_btnClose_Click);
            // 
            // pnl_btnResize
            // 
            this.pnl_btnResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_btnResize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnl_btnResize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_btnResize.BackgroundImage")));
            this.pnl_btnResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl_btnResize.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnl_btnResize.Location = new System.Drawing.Point(400, 0);
            this.pnl_btnResize.Name = "pnl_btnResize";
            this.pnl_btnResize.Size = new System.Drawing.Size(50, 30);
            this.pnl_btnResize.TabIndex = 43;
            this.pnl_btnResize.Click += new System.EventHandler(this.Pnl_btnResize_Click);
            // 
            // pnl_btnMinimize
            // 
            this.pnl_btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnl_btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_btnMinimize.BackgroundImage")));
            this.pnl_btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl_btnMinimize.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnl_btnMinimize.Location = new System.Drawing.Point(350, 0);
            this.pnl_btnMinimize.Name = "pnl_btnMinimize";
            this.pnl_btnMinimize.Size = new System.Drawing.Size(50, 30);
            this.pnl_btnMinimize.TabIndex = 44;
            this.pnl_btnMinimize.Click += new System.EventHandler(this.Pnl_btnMinimize_Click);
            // 
            // FRM_Full
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.pnl_btnMinimize);
            this.Controls.Add(this.pnl_btnResize);
            this.Controls.Add(this.pnl_btnClose);
            this.Controls.Add(this.lblFormTitle);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FRM_Full";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Full";
            this.Load += new System.EventHandler(this.FRM_Full_Load);
            this.Resize += new System.EventHandler(this.FRM_Full_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private Components.CMP_BtnTopClose pnl_btnClose;
        private Components.CMP_BtnTopResize pnl_btnResize;
        private Components.CMP_BtnTopMinimize pnl_btnMinimize;
    }
}