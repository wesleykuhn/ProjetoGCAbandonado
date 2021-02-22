namespace GC.GlobalModals
{
    partial class FRM_MiniLoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MiniLoad));
            this.PNL_Background = new System.Windows.Forms.Panel();
            this.PNL_LoadingCircle = new GC.Components.CMP_CtlPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.PNL_Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_Background
            // 
            this.PNL_Background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.PNL_Background.Controls.Add(this.PNL_LoadingCircle);
            this.PNL_Background.Controls.Add(this.label1);
            this.PNL_Background.Location = new System.Drawing.Point(1, 1);
            this.PNL_Background.Name = "PNL_Background";
            this.PNL_Background.Size = new System.Drawing.Size(298, 184);
            this.PNL_Background.TabIndex = 0;
            // 
            // PNL_LoadingCircle
            // 
            this.PNL_LoadingCircle.Cursor = System.Windows.Forms.Cursors.Default;
            this.PNL_LoadingCircle.Location = new System.Drawing.Point(75, 6);
            this.PNL_LoadingCircle.Name = "PNL_LoadingCircle";
            this.PNL_LoadingCircle.Size = new System.Drawing.Size(148, 148);
            this.PNL_LoadingCircle.TabIndex = 2;
            this.PNL_LoadingCircle.Text = "cmP_CtlPanel1";
            this.PNL_LoadingCircle.Paint += new System.Windows.Forms.PaintEventHandler(this.PNL_LoadingCircle_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Por favor, aguarde...";
            // 
            // FRM_MiniLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(300, 186);
            this.Controls.Add(this.PNL_Background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FRM_MiniLoad";
            this.Text = "GC - Aguarde";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.FrmModal_MiniLoad_Shown);
            this.Controls.SetChildIndex(this.PNL_Background, 0);
            this.PNL_Background.ResumeLayout(false);
            this.PNL_Background.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Background;
        private System.Windows.Forms.Label label1;
        private Components.CMP_CtlPanel PNL_LoadingCircle;
    }
}