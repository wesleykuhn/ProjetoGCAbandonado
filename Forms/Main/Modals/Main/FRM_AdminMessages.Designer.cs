namespace GC.Forms.Main.Modals.Main
{
    partial class FRM_AdminMessages
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.spcMessages = new System.Windows.Forms.SplitContainer();
            this.wbsBody = new System.Windows.Forms.WebBrowser();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblDelivered = new System.Windows.Forms.Label();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.lblColor = new System.Windows.Forms.Label();
            this.flpSubject = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSubject = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMessages)).BeginInit();
            this.spcMessages.Panel2.SuspendLayout();
            this.spcMessages.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.flpSubject.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.spcMessages);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 518);
            this.panel1.TabIndex = 0;
            // 
            // spcMessages
            // 
            this.spcMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spcMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.spcMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spcMessages.Location = new System.Drawing.Point(10, 28);
            this.spcMessages.Name = "spcMessages";
            // 
            // spcMessages.Panel1
            // 
            this.spcMessages.Panel1.AutoScroll = true;
            this.spcMessages.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.spcMessages.Panel1MinSize = 250;
            // 
            // spcMessages.Panel2
            // 
            this.spcMessages.Panel2.AutoScroll = true;
            this.spcMessages.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.spcMessages.Panel2.Controls.Add(this.wbsBody);
            this.spcMessages.Panel2.Controls.Add(this.pnlInfo);
            this.spcMessages.Panel2.Controls.Add(this.flpSubject);
            this.spcMessages.Panel2MinSize = 500;
            this.spcMessages.Size = new System.Drawing.Size(876, 480);
            this.spcMessages.SplitterDistance = 303;
            this.spcMessages.TabIndex = 0;
            // 
            // wbsBody
            // 
            this.wbsBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbsBody.Location = new System.Drawing.Point(7, 87);
            this.wbsBody.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbsBody.Name = "wbsBody";
            this.wbsBody.Size = new System.Drawing.Size(549, 380);
            this.wbsBody.TabIndex = 6;
            this.wbsBody.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.wbsBody_Navigating);
            // 
            // pnlInfo
            // 
            this.pnlInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInfo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.lblDelivered);
            this.pnlInfo.Controls.Add(this.pnlColor);
            this.pnlInfo.Controls.Add(this.lblColor);
            this.pnlInfo.Location = new System.Drawing.Point(11, 12);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(541, 28);
            this.pnlInfo.TabIndex = 5;
            // 
            // lblDelivered
            // 
            this.lblDelivered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDelivered.AutoSize = true;
            this.lblDelivered.BackColor = System.Drawing.SystemColors.Control;
            this.lblDelivered.Location = new System.Drawing.Point(296, 7);
            this.lblDelivered.Name = "lblDelivered";
            this.lblDelivered.Size = new System.Drawing.Size(239, 14);
            this.lblDelivered.TabIndex = 4;
            this.lblDelivered.Text = "Enviado em 20/20/2020 às 24:59:59";
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.SystemColors.Control;
            this.pnlColor.Location = new System.Drawing.Point(4, 6);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(53, 16);
            this.pnlColor.TabIndex = 2;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.SystemColors.Control;
            this.lblColor.Location = new System.Drawing.Point(63, 7);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(16, 14);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "- ";
            // 
            // flpSubject
            // 
            this.flpSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpSubject.AutoSize = true;
            this.flpSubject.BackColor = System.Drawing.SystemColors.Control;
            this.flpSubject.Controls.Add(this.lblSubject);
            this.flpSubject.Location = new System.Drawing.Point(7, 45);
            this.flpSubject.Name = "flpSubject";
            this.flpSubject.Size = new System.Drawing.Size(549, 37);
            this.flpSubject.TabIndex = 0;
            // 
            // lblSubject
            // 
            this.lblSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(3, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(268, 32);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Título do subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mensagens:";
            // 
            // FRM_AdminMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_AdminMessages";
            this.Text = "GC - Mensagens e Anúncios da Administração";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.spcMessages.Panel2.ResumeLayout(false);
            this.spcMessages.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMessages)).EndInit();
            this.spcMessages.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.flpSubject.ResumeLayout(false);
            this.flpSubject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer spcMessages;
        private System.Windows.Forms.FlowLayoutPanel flpSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Label lblDelivered;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.WebBrowser wbsBody;
    }
}