namespace GC.Forms.Main.Modals.Configuration
{
    partial class FRM_SendFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SendFeedback));
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.rbtSendSuggestion = new System.Windows.Forms.RadioButton();
            this.rbtSendError = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReport = new GC.Components.CMP_BtnRegular();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBackground.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBackground.Controls.Add(this.rbtSendSuggestion);
            this.pnlBackground.Controls.Add(this.rbtSendError);
            this.pnlBackground.Controls.Add(this.label2);
            this.pnlBackground.Controls.Add(this.btnReport);
            this.pnlBackground.Controls.Add(this.rtbText);
            this.pnlBackground.Controls.Add(this.lblInfo);
            this.pnlBackground.Location = new System.Drawing.Point(2, 30);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(796, 418);
            this.pnlBackground.TabIndex = 34;
            // 
            // rbtSendSuggestion
            // 
            this.rbtSendSuggestion.AutoSize = true;
            this.rbtSendSuggestion.Location = new System.Drawing.Point(327, 11);
            this.rbtSendSuggestion.Name = "rbtSendSuggestion";
            this.rbtSendSuggestion.Size = new System.Drawing.Size(141, 18);
            this.rbtSendSuggestion.TabIndex = 12;
            this.rbtSendSuggestion.TabStop = true;
            this.rbtSendSuggestion.Text = "Dar uma sugestão";
            this.rbtSendSuggestion.UseVisualStyleBackColor = true;
            // 
            // rbtSendError
            // 
            this.rbtSendError.AutoSize = true;
            this.rbtSendError.Checked = true;
            this.rbtSendError.Location = new System.Drawing.Point(200, 11);
            this.rbtSendError.Name = "rbtSendError";
            this.rbtSendError.Size = new System.Drawing.Size(123, 18);
            this.rbtSendError.TabIndex = 11;
            this.rbtSendError.TabStop = true;
            this.rbtSendError.Text = "Relatar um erro";
            this.rbtSendError.UseVisualStyleBackColor = true;
            this.rbtSendError.CheckedChanged += new System.EventHandler(this.rbtSendError_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "O que você deseja fazer?";
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnReport.Location = new System.Drawing.Point(23, 369);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(113, 39);
            this.btnReport.TabIndex = 9;
            this.btnReport.Text = "Reportar";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // rtbText
            // 
            this.rtbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbText.DetectUrls = false;
            this.rtbText.Location = new System.Drawing.Point(23, 65);
            this.rtbText.MaxLength = 65535;
            this.rtbText.Name = "rtbText";
            this.rtbText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbText.Size = new System.Drawing.Size(754, 288);
            this.rtbText.TabIndex = 1;
            this.rtbText.Text = "";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(20, 47);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(757, 14);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Por favor, descreva em detalhes o que você estava fazendo, qual era o horário e q" +
    "ual o problema que você encontrou:";
            // 
            // FRM_SendFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_SendFeedback";
            this.Text = "GC - Configurações > Reportando Problemas";
            this.Controls.SetChildIndex(this.pnlBackground, 0);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Label lblInfo;
        private GC.Components.CMP_BtnRegular btnReport;
        private System.Windows.Forms.RadioButton rbtSendSuggestion;
        private System.Windows.Forms.RadioButton rbtSendError;
        private System.Windows.Forms.Label label2;
    }
}