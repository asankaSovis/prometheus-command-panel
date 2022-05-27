
namespace Fire_Extinguisher
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTools = new System.Windows.Forms.TableLayoutPanel();
            this.btnGraph = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.pcbSystem = new System.Windows.Forms.PictureBox();
            this.grpDevices = new System.Windows.Forms.GroupBox();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.tstStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstSeparator = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tstTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNoDevice = new System.Windows.Forms.Label();
            this.lsbDevices = new System.Windows.Forms.ListBox();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.tlpMain.SuspendLayout();
            this.tlpTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSystem)).BeginInit();
            this.grpDevices.SuspendLayout();
            this.stsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpTools, 0, 1);
            this.tlpMain.Controls.Add(this.pcbSystem, 0, 0);
            this.tlpMain.Controls.Add(this.grpDevices, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(457, 540);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpTools
            // 
            this.tlpTools.ColumnCount = 5;
            this.tlpTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpTools.Controls.Add(this.btnGraph, 0, 0);
            this.tlpTools.Controls.Add(this.btnRefresh, 0, 0);
            this.tlpTools.Controls.Add(this.btnRename, 3, 0);
            this.tlpTools.Controls.Add(this.btnConnect, 4, 0);
            this.tlpTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTools.Location = new System.Drawing.Point(3, 103);
            this.tlpTools.Name = "tlpTools";
            this.tlpTools.RowCount = 1;
            this.tlpTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTools.Size = new System.Drawing.Size(451, 41);
            this.tlpTools.TabIndex = 0;
            // 
            // btnGraph
            // 
            this.btnGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGraph.Location = new System.Drawing.Point(43, 3);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(34, 35);
            this.btnGraph.TabIndex = 3;
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(34, 35);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRename
            // 
            this.btnRename.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRename.Location = new System.Drawing.Point(264, 3);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(34, 35);
            this.btnRename.TabIndex = 2;
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.Location = new System.Drawing.Point(304, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(144, 35);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // pcbSystem
            // 
            this.pcbSystem.BackColor = System.Drawing.Color.Transparent;
            this.pcbSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbSystem.Location = new System.Drawing.Point(3, 3);
            this.pcbSystem.Name = "pcbSystem";
            this.pcbSystem.Size = new System.Drawing.Size(451, 94);
            this.pcbSystem.TabIndex = 2;
            this.pcbSystem.TabStop = false;
            this.pcbSystem.Click += new System.EventHandler(this.pcbSystem_Click);
            // 
            // grpDevices
            // 
            this.grpDevices.Controls.Add(this.stsMain);
            this.grpDevices.Controls.Add(this.lblNoDevice);
            this.grpDevices.Controls.Add(this.lsbDevices);
            this.grpDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDevices.Location = new System.Drawing.Point(3, 150);
            this.grpDevices.Name = "grpDevices";
            this.grpDevices.Size = new System.Drawing.Size(451, 387);
            this.grpDevices.TabIndex = 3;
            this.grpDevices.TabStop = false;
            this.grpDevices.Text = "Available Devices";
            // 
            // stsMain
            // 
            this.stsMain.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstStatus,
            this.tstSeparator,
            this.tstProgress,
            this.tstTime});
            this.stsMain.Location = new System.Drawing.Point(3, 358);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(445, 26);
            this.stsMain.SizingGrip = false;
            this.stsMain.TabIndex = 6;
            this.stsMain.Text = "stsMain";
            // 
            // tstStatus
            // 
            this.tstStatus.Name = "tstStatus";
            this.tstStatus.Size = new System.Drawing.Size(15, 20);
            this.tstStatus.Text = "-";
            // 
            // tstSeparator
            // 
            this.tstSeparator.Name = "tstSeparator";
            this.tstSeparator.Size = new System.Drawing.Size(161, 20);
            this.tstSeparator.Spring = true;
            // 
            // tstProgress
            // 
            this.tstProgress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstProgress.Name = "tstProgress";
            this.tstProgress.Size = new System.Drawing.Size(200, 18);
            this.tstProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // tstTime
            // 
            this.tstTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstTime.Name = "tstTime";
            this.tstTime.Size = new System.Drawing.Size(15, 20);
            this.tstTime.Text = "-";
            this.tstTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNoDevice
            // 
            this.lblNoDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoDevice.Location = new System.Drawing.Point(142, 166);
            this.lblNoDevice.Name = "lblNoDevice";
            this.lblNoDevice.Size = new System.Drawing.Size(152, 17);
            this.lblNoDevice.TabIndex = 5;
            this.lblNoDevice.Text = "No Devices Connected";
            this.lblNoDevice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsbDevices
            // 
            this.lsbDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbDevices.FormattingEnabled = true;
            this.lsbDevices.ItemHeight = 16;
            this.lsbDevices.Location = new System.Drawing.Point(3, 18);
            this.lsbDevices.Name = "lsbDevices";
            this.lsbDevices.Size = new System.Drawing.Size(445, 366);
            this.lsbDevices.TabIndex = 0;
            this.lsbDevices.SelectedIndexChanged += new System.EventHandler(this.lsbDevices_SelectedIndexChanged);
            this.lsbDevices.EnabledChanged += new System.EventHandler(this.lsbDevices_EnabledChanged);
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Interval = 1000;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 540);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(475, 585);
            this.MinimumSize = new System.Drawing.Size(475, 585);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Prometheus Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResizeEnd += new System.EventHandler(this.frmMain_ResizeEnd);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.tlpMain.ResumeLayout(false);
            this.tlpTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSystem)).EndInit();
            this.grpDevices.ResumeLayout(false);
            this.grpDevices.PerformLayout();
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpTools;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.PictureBox pcbSystem;
        private System.Windows.Forms.GroupBox grpDevices;
        private System.Windows.Forms.ListBox lsbDevices;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.Label lblNoDevice;
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStripStatusLabel tstStatus;
        private System.Windows.Forms.ToolStripStatusLabel tstSeparator;
        private System.Windows.Forms.ToolStripProgressBar tstProgress;
        private System.Windows.Forms.ToolStripStatusLabel tstTime;
        private System.Windows.Forms.Button btnGraph;
    }
}

