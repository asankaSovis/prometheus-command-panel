
namespace Fire_Extinguisher
{
    partial class frmSplash
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
            this.prgMain = new System.Windows.Forms.ProgressBar();
            this.pcbMain = new System.Windows.Forms.PictureBox();
            this.lblMain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // prgMain
            // 
            this.prgMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgMain.Location = new System.Drawing.Point(12, 187);
            this.prgMain.Name = "prgMain";
            this.prgMain.Size = new System.Drawing.Size(535, 11);
            this.prgMain.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgMain.TabIndex = 0;
            // 
            // pcbMain
            // 
            this.pcbMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbMain.Location = new System.Drawing.Point(12, 12);
            this.pcbMain.Name = "pcbMain";
            this.pcbMain.Size = new System.Drawing.Size(535, 142);
            this.pcbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbMain.TabIndex = 1;
            this.pcbMain.TabStop = false;
            // 
            // lblMain
            // 
            this.lblMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMain.Location = new System.Drawing.Point(12, 157);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(535, 24);
            this.lblMain.TabIndex = 2;
            this.lblMain.Text = "Loading Prometheus Command Panel...";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 210);
            this.ControlBox = false;
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.pcbMain);
            this.Controls.Add(this.prgMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSplash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prometheus Control Panel";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgMain;
        private System.Windows.Forms.PictureBox pcbMain;
        private System.Windows.Forms.Label lblMain;
    }
}