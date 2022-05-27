
namespace Fire_Extinguisher
{
    partial class frmAbout
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpNavigation = new System.Windows.Forms.TableLayoutPanel();
            this.rdbSettings = new System.Windows.Forms.RadioButton();
            this.rdbAbout = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.spcAbout = new System.Windows.Forms.SplitContainer();
            this.tlpAbout = new System.Windows.Forms.TableLayoutPanel();
            this.lblAbout = new System.Windows.Forms.Label();
            this.pcbBanner = new System.Windows.Forms.PictureBox();
            this.tlpSettings = new System.Windows.Forms.TableLayoutPanel();
            this.tlpLogs = new System.Windows.Forms.TableLayoutPanel();
            this.btnExpLogs = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.tlpAliases = new System.Windows.Forms.TableLayoutPanel();
            this.btnExpAlias = new System.Windows.Forms.Button();
            this.btnAliases = new System.Windows.Forms.Button();
            this.tlpDataLocation = new System.Windows.Forms.TableLayoutPanel();
            this.txtDataLoc = new System.Windows.Forms.TextBox();
            this.btnDataLoc = new System.Windows.Forms.Button();
            this.sfdAlias = new System.Windows.Forms.SaveFileDialog();
            this.tlpMain.SuspendLayout();
            this.tlpNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcAbout)).BeginInit();
            this.spcAbout.Panel1.SuspendLayout();
            this.spcAbout.Panel2.SuspendLayout();
            this.spcAbout.SuspendLayout();
            this.tlpAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBanner)).BeginInit();
            this.tlpSettings.SuspendLayout();
            this.tlpLogs.SuspendLayout();
            this.tlpAliases.SuspendLayout();
            this.tlpDataLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpNavigation, 0, 0);
            this.tlpMain.Controls.Add(this.btnOk, 0, 2);
            this.tlpMain.Controls.Add(this.spcAbout, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpMain.Size = new System.Drawing.Size(434, 345);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpNavigation
            // 
            this.tlpNavigation.BackColor = System.Drawing.Color.Transparent;
            this.tlpNavigation.ColumnCount = 4;
            this.tlpNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNavigation.Controls.Add(this.rdbSettings, 2, 0);
            this.tlpNavigation.Controls.Add(this.rdbAbout, 1, 0);
            this.tlpNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNavigation.Location = new System.Drawing.Point(0, 0);
            this.tlpNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.tlpNavigation.Name = "tlpNavigation";
            this.tlpNavigation.RowCount = 1;
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNavigation.Size = new System.Drawing.Size(434, 35);
            this.tlpNavigation.TabIndex = 0;
            // 
            // rdbSettings
            // 
            this.rdbSettings.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbSettings.Location = new System.Drawing.Point(220, 3);
            this.rdbSettings.Name = "rdbSettings";
            this.rdbSettings.Size = new System.Drawing.Size(114, 29);
            this.rdbSettings.TabIndex = 2;
            this.rdbSettings.TabStop = true;
            this.rdbSettings.Text = "Settings";
            this.rdbSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbSettings.UseVisualStyleBackColor = true;
            this.rdbSettings.CheckedChanged += new System.EventHandler(this.rdbSettings_CheckedChanged);
            // 
            // rdbAbout
            // 
            this.rdbAbout.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbAbout.Location = new System.Drawing.Point(100, 3);
            this.rdbAbout.Name = "rdbAbout";
            this.rdbAbout.Size = new System.Drawing.Size(114, 29);
            this.rdbAbout.TabIndex = 1;
            this.rdbAbout.TabStop = true;
            this.rdbAbout.Text = "About";
            this.rdbAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbAbout.UseVisualStyleBackColor = true;
            this.rdbAbout.CheckedChanged += new System.EventHandler(this.rdbAbout_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnOk.Location = new System.Drawing.Point(158, 311);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(118, 31);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Close";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // spcAbout
            // 
            this.spcAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcAbout.Location = new System.Drawing.Point(3, 38);
            this.spcAbout.Name = "spcAbout";
            // 
            // spcAbout.Panel1
            // 
            this.spcAbout.Panel1.Controls.Add(this.tlpAbout);
            // 
            // spcAbout.Panel2
            // 
            this.spcAbout.Panel2.Controls.Add(this.tlpSettings);
            this.spcAbout.Panel2Collapsed = true;
            this.spcAbout.Size = new System.Drawing.Size(428, 267);
            this.spcAbout.SplitterDistance = 167;
            this.spcAbout.TabIndex = 2;
            // 
            // tlpAbout
            // 
            this.tlpAbout.ColumnCount = 1;
            this.tlpAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAbout.Controls.Add(this.lblAbout, 0, 1);
            this.tlpAbout.Controls.Add(this.pcbBanner, 0, 0);
            this.tlpAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAbout.Location = new System.Drawing.Point(0, 0);
            this.tlpAbout.Name = "tlpAbout";
            this.tlpAbout.RowCount = 2;
            this.tlpAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tlpAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAbout.Size = new System.Drawing.Size(428, 267);
            this.tlpAbout.TabIndex = 0;
            // 
            // lblAbout
            // 
            this.lblAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.886957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.Location = new System.Drawing.Point(10, 129);
            this.lblAbout.Margin = new System.Windows.Forms.Padding(10);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(408, 128);
            this.lblAbout.TabIndex = 3;
            this.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbBanner
            // 
            this.pcbBanner.BackColor = System.Drawing.Color.Transparent;
            this.pcbBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbBanner.Location = new System.Drawing.Point(0, 0);
            this.pcbBanner.Margin = new System.Windows.Forms.Padding(0);
            this.pcbBanner.Name = "pcbBanner";
            this.pcbBanner.Size = new System.Drawing.Size(428, 119);
            this.pcbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbBanner.TabIndex = 0;
            this.pcbBanner.TabStop = false;
            // 
            // tlpSettings
            // 
            this.tlpSettings.ColumnCount = 1;
            this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSettings.Controls.Add(this.tlpLogs, 0, 0);
            this.tlpSettings.Controls.Add(this.tlpAliases, 0, 1);
            this.tlpSettings.Controls.Add(this.tlpDataLocation, 0, 2);
            this.tlpSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSettings.Location = new System.Drawing.Point(0, 0);
            this.tlpSettings.Name = "tlpSettings";
            this.tlpSettings.RowCount = 5;
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSettings.Size = new System.Drawing.Size(96, 100);
            this.tlpSettings.TabIndex = 0;
            // 
            // tlpLogs
            // 
            this.tlpLogs.ColumnCount = 2;
            this.tlpLogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLogs.Controls.Add(this.btnExpLogs, 0, 0);
            this.tlpLogs.Controls.Add(this.btnLogs, 0, 0);
            this.tlpLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLogs.Location = new System.Drawing.Point(3, 3);
            this.tlpLogs.Name = "tlpLogs";
            this.tlpLogs.RowCount = 1;
            this.tlpLogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpLogs.Size = new System.Drawing.Size(90, 34);
            this.tlpLogs.TabIndex = 4;
            // 
            // btnExpLogs
            // 
            this.btnExpLogs.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExpLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExpLogs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExpLogs.Location = new System.Drawing.Point(48, 3);
            this.btnExpLogs.Name = "btnExpLogs";
            this.btnExpLogs.Size = new System.Drawing.Size(39, 28);
            this.btnExpLogs.TabIndex = 2;
            this.btnExpLogs.Text = "Export Logs";
            this.btnExpLogs.UseVisualStyleBackColor = false;
            this.btnExpLogs.Click += new System.EventHandler(this.btnExpLogs_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.BackColor = System.Drawing.Color.LightCoral;
            this.btnLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogs.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogs.Location = new System.Drawing.Point(3, 3);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(39, 28);
            this.btnLogs.TabIndex = 1;
            this.btnLogs.Text = "Clear Logs";
            this.btnLogs.UseVisualStyleBackColor = false;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // tlpAliases
            // 
            this.tlpAliases.ColumnCount = 2;
            this.tlpAliases.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAliases.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAliases.Controls.Add(this.btnExpAlias, 0, 0);
            this.tlpAliases.Controls.Add(this.btnAliases, 0, 0);
            this.tlpAliases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAliases.Location = new System.Drawing.Point(3, 43);
            this.tlpAliases.Name = "tlpAliases";
            this.tlpAliases.RowCount = 1;
            this.tlpAliases.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAliases.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpAliases.Size = new System.Drawing.Size(90, 34);
            this.tlpAliases.TabIndex = 5;
            // 
            // btnExpAlias
            // 
            this.btnExpAlias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExpAlias.Location = new System.Drawing.Point(48, 3);
            this.btnExpAlias.Name = "btnExpAlias";
            this.btnExpAlias.Size = new System.Drawing.Size(39, 28);
            this.btnExpAlias.TabIndex = 3;
            this.btnExpAlias.Text = "Export Alias List";
            this.btnExpAlias.UseVisualStyleBackColor = true;
            this.btnExpAlias.Click += new System.EventHandler(this.btnExpAlias_Click);
            // 
            // btnAliases
            // 
            this.btnAliases.BackColor = System.Drawing.Color.LightCoral;
            this.btnAliases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAliases.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAliases.Location = new System.Drawing.Point(3, 3);
            this.btnAliases.Name = "btnAliases";
            this.btnAliases.Size = new System.Drawing.Size(39, 28);
            this.btnAliases.TabIndex = 2;
            this.btnAliases.Text = "Clear Aliases";
            this.btnAliases.UseVisualStyleBackColor = false;
            this.btnAliases.Click += new System.EventHandler(this.btnAliases_Click);
            // 
            // tlpDataLocation
            // 
            this.tlpDataLocation.ColumnCount = 2;
            this.tlpDataLocation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDataLocation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpDataLocation.Controls.Add(this.txtDataLoc, 0, 0);
            this.tlpDataLocation.Controls.Add(this.btnDataLoc, 1, 0);
            this.tlpDataLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDataLocation.Location = new System.Drawing.Point(3, 83);
            this.tlpDataLocation.Name = "tlpDataLocation";
            this.tlpDataLocation.RowCount = 1;
            this.tlpDataLocation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDataLocation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpDataLocation.Size = new System.Drawing.Size(90, 34);
            this.tlpDataLocation.TabIndex = 6;
            // 
            // txtDataLoc
            // 
            this.txtDataLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataLoc.Enabled = false;
            this.txtDataLoc.Location = new System.Drawing.Point(3, 6);
            this.txtDataLoc.Name = "txtDataLoc";
            this.txtDataLoc.Size = new System.Drawing.Size(34, 22);
            this.txtDataLoc.TabIndex = 0;
            // 
            // btnDataLoc
            // 
            this.btnDataLoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDataLoc.Location = new System.Drawing.Point(43, 3);
            this.btnDataLoc.Name = "btnDataLoc";
            this.btnDataLoc.Size = new System.Drawing.Size(44, 28);
            this.btnDataLoc.TabIndex = 1;
            this.btnDataLoc.Text = "...";
            this.btnDataLoc.UseVisualStyleBackColor = true;
            this.btnDataLoc.Click += new System.EventHandler(this.btnDataLoc_Click);
            // 
            // sfdAlias
            // 
            this.sfdAlias.FileName = "Aliases List.txt";
            this.sfdAlias.Filter = "Text Files | *.txt | All Files | *.*";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(434, 345);
            this.Controls.Add(this.tlpMain);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prometheus Control Panel";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAbout_KeyDown);
            this.tlpMain.ResumeLayout(false);
            this.tlpNavigation.ResumeLayout(false);
            this.spcAbout.Panel1.ResumeLayout(false);
            this.spcAbout.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcAbout)).EndInit();
            this.spcAbout.ResumeLayout(false);
            this.tlpAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBanner)).EndInit();
            this.tlpSettings.ResumeLayout(false);
            this.tlpLogs.ResumeLayout(false);
            this.tlpAliases.ResumeLayout(false);
            this.tlpDataLocation.ResumeLayout(false);
            this.tlpDataLocation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpNavigation;
        private System.Windows.Forms.RadioButton rdbSettings;
        private System.Windows.Forms.RadioButton rdbAbout;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.SplitContainer spcAbout;
        private System.Windows.Forms.TableLayoutPanel tlpSettings;
        private System.Windows.Forms.TableLayoutPanel tlpLogs;
        private System.Windows.Forms.Button btnExpLogs;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.TableLayoutPanel tlpAliases;
        private System.Windows.Forms.Button btnExpAlias;
        private System.Windows.Forms.Button btnAliases;
        private System.Windows.Forms.TableLayoutPanel tlpDataLocation;
        private System.Windows.Forms.TextBox txtDataLoc;
        private System.Windows.Forms.Button btnDataLoc;
        private System.Windows.Forms.SaveFileDialog sfdAlias;
        private System.Windows.Forms.TableLayoutPanel tlpAbout;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.PictureBox pcbBanner;
    }
}