using System.Drawing;

namespace GC.Forms.LoadingScreen
{
    partial class FRM_LoadingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_LoadingScreen));
            this.lblStatus = new System.Windows.Forms.Label();
            this.CTL_LoadingCircle = new GC.Components.CMP_CtlLoadingCircle(Properties.Resources.icon_Kuhnper_logo_128x128, Library.Style.ColorsPalette.GDE_Info_Hover);
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(13, 186);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 18);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "label2";
            // 
            // CTL_LoadingCircle
            // 
            this.CTL_LoadingCircle.Location = new System.Drawing.Point(105, 13);
            this.CTL_LoadingCircle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CTL_LoadingCircle.Name = "CTL_LoadingCircle";
            this.CTL_LoadingCircle.Size = new System.Drawing.Size(148, 148);
            this.CTL_LoadingCircle.TabIndex = 5;
            // 
            // FRM_LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(359, 215);
            this.ControlBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Controls.Add(this.CTL_LoadingCircle);
            this.Controls.Add(this.lblStatus);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FRM_LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GC - Carregando";
            this.Shown += new System.EventHandler(this.FrmLoadingScreen_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private Components.CMP_CtlLoadingCircle CTL_LoadingCircle;
    }
}