
namespace Fire_Extinguisher
{
    partial class frmDevice
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
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.tstStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstSeparator = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstNotification = new System.Windows.Forms.ToolStripStatusLabel();
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.tlpPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.grpDevice = new System.Windows.Forms.GroupBox();
            this.tlpDevice = new System.Windows.Forms.TableLayoutPanel();
            this.lblDeviceInfo = new System.Windows.Forms.Label();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.tlpParams = new System.Windows.Forms.TableLayoutPanel();
            this.tlpControls = new System.Windows.Forms.TableLayoutPanel();
            this.grpCommand = new System.Windows.Forms.GroupBox();
            this.tlpCommand = new System.Windows.Forms.TableLayoutPanel();
            this.pcbStatus = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.tlpCommands = new System.Windows.Forms.TableLayoutPanel();
            this.chkAdvanced = new System.Windows.Forms.CheckBox();
            this.chkUserValve = new System.Windows.Forms.CheckBox();
            this.chkUserBuzz = new System.Windows.Forms.CheckBox();
            this.chkOverride = new System.Windows.Forms.CheckBox();
            this.grpCaps = new System.Windows.Forms.GroupBox();
            this.tlpCaps = new System.Windows.Forms.TableLayoutPanel();
            this.btnCapDefaults = new System.Windows.Forms.Button();
            this.lblHumidCap = new System.Windows.Forms.Label();
            this.lblTempCap = new System.Windows.Forms.Label();
            this.nudCO2 = new System.Windows.Forms.NumericUpDown();
            this.nudTemp = new System.Windows.Forms.NumericUpDown();
            this.nudHumid = new System.Windows.Forms.NumericUpDown();
            this.btnCaps = new System.Windows.Forms.Button();
            this.lblCO2Cap = new System.Windows.Forms.Label();
            this.grpConn = new System.Windows.Forms.GroupBox();
            this.lblConn = new System.Windows.Forms.Label();
            this.grpGraph = new System.Windows.Forms.GroupBox();
            this.btnGraph = new System.Windows.Forms.Button();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.tlpStatus = new System.Windows.Forms.TableLayoutPanel();
            this.grpCO2 = new System.Windows.Forms.GroupBox();
            this.tlpCO2 = new System.Windows.Forms.TableLayoutPanel();
            this.pcbCO2 = new System.Windows.Forms.PictureBox();
            this.lblCO2 = new System.Windows.Forms.Label();
            this.grpTemp = new System.Windows.Forms.GroupBox();
            this.tlpTemp = new System.Windows.Forms.TableLayoutPanel();
            this.pcbTemp = new System.Windows.Forms.PictureBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.grpHumid = new System.Windows.Forms.GroupBox();
            this.tlpHumid = new System.Windows.Forms.TableLayoutPanel();
            this.pcbHumid = new System.Windows.Forms.PictureBox();
            this.lblHumid = new System.Windows.Forms.Label();
            this.grpAdvanced = new System.Windows.Forms.GroupBox();
            this.tlpComm = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecieve = new System.Windows.Forms.Label();
            this.tlpSend = new System.Windows.Forms.TableLayoutPanel();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.chkSync = new System.Windows.Forms.CheckBox();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.stsStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            this.tlpPanel.SuspendLayout();
            this.tlpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.grpDevice.SuspendLayout();
            this.tlpDevice.SuspendLayout();
            this.tlpParams.SuspendLayout();
            this.tlpControls.SuspendLayout();
            this.grpCommand.SuspendLayout();
            this.tlpCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStatus)).BeginInit();
            this.grpControls.SuspendLayout();
            this.tlpCommands.SuspendLayout();
            this.grpCaps.SuspendLayout();
            this.tlpCaps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHumid)).BeginInit();
            this.grpConn.SuspendLayout();
            this.grpGraph.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.tlpStatus.SuspendLayout();
            this.grpCO2.SuspendLayout();
            this.tlpCO2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCO2)).BeginInit();
            this.grpTemp.SuspendLayout();
            this.tlpTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTemp)).BeginInit();
            this.grpHumid.SuspendLayout();
            this.tlpHumid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHumid)).BeginInit();
            this.grpAdvanced.SuspendLayout();
            this.tlpComm.SuspendLayout();
            this.tlpSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsStatus
            // 
            this.stsStatus.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstStatus,
            this.tstSeparator,
            this.tstDate,
            this.tstNotification});
            this.stsStatus.Location = new System.Drawing.Point(0, 720);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(948, 26);
            this.stsStatus.TabIndex = 0;
            this.stsStatus.Text = "statusStrip1";
            // 
            // tstStatus
            // 
            this.tstStatus.Name = "tstStatus";
            this.tstStatus.Size = new System.Drawing.Size(27, 20);
            this.tstStatus.Text = "___";
            // 
            // tstSeparator
            // 
            this.tstSeparator.Name = "tstSeparator";
            this.tstSeparator.Size = new System.Drawing.Size(763, 20);
            this.tstSeparator.Spring = true;
            // 
            // tstDate
            // 
            this.tstDate.Name = "tstDate";
            this.tstDate.Size = new System.Drawing.Size(143, 20);
            this.tstDate.Text = "00/00/0000 00:00:00";
            // 
            // tstNotification
            // 
            this.tstNotification.Name = "tstNotification";
            this.tstNotification.Size = new System.Drawing.Size(0, 20);
            this.tstNotification.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tstNotification.ToolTipText = "Pin the last notification to the screen";
            this.tstNotification.Click += new System.EventHandler(this.tstNotification_Click);
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spcMain.IsSplitterFixed = true;
            this.spcMain.Location = new System.Drawing.Point(0, 0);
            this.spcMain.Name = "spcMain";
            this.spcMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.tlpPanel);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.grpAdvanced);
            this.spcMain.Panel2Collapsed = true;
            this.spcMain.Size = new System.Drawing.Size(948, 720);
            this.spcMain.SplitterDistance = 626;
            this.spcMain.SplitterWidth = 3;
            this.spcMain.TabIndex = 1;
            // 
            // tlpPanel
            // 
            this.tlpPanel.ColumnCount = 1;
            this.tlpPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPanel.Controls.Add(this.tlpInfo, 0, 0);
            this.tlpPanel.Controls.Add(this.tlpParams, 0, 1);
            this.tlpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPanel.Location = new System.Drawing.Point(0, 0);
            this.tlpPanel.Name = "tlpPanel";
            this.tlpPanel.RowCount = 2;
            this.tlpPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPanel.Size = new System.Drawing.Size(948, 720);
            this.tlpPanel.TabIndex = 0;
            // 
            // tlpInfo
            // 
            this.tlpInfo.ColumnCount = 2;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfo.Controls.Add(this.pcbLogo, 0, 0);
            this.tlpInfo.Controls.Add(this.grpDevice, 1, 0);
            this.tlpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInfo.Location = new System.Drawing.Point(3, 3);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 1;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfo.Size = new System.Drawing.Size(942, 114);
            this.tlpInfo.TabIndex = 0;
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbLogo.Location = new System.Drawing.Point(3, 3);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(114, 108);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            this.pcbLogo.Click += new System.EventHandler(this.pcbLogo_Click);
            // 
            // grpDevice
            // 
            this.grpDevice.Controls.Add(this.tlpDevice);
            this.grpDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDevice.Location = new System.Drawing.Point(123, 3);
            this.grpDevice.Name = "grpDevice";
            this.grpDevice.Size = new System.Drawing.Size(816, 108);
            this.grpDevice.TabIndex = 1;
            this.grpDevice.TabStop = false;
            this.grpDevice.Text = "Device Info";
            // 
            // tlpDevice
            // 
            this.tlpDevice.ColumnCount = 1;
            this.tlpDevice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDevice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDevice.Controls.Add(this.lblDeviceInfo, 0, 1);
            this.tlpDevice.Controls.Add(this.lblDeviceName, 0, 0);
            this.tlpDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDevice.Location = new System.Drawing.Point(3, 18);
            this.tlpDevice.Name = "tlpDevice";
            this.tlpDevice.RowCount = 2;
            this.tlpDevice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDevice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDevice.Size = new System.Drawing.Size(810, 87);
            this.tlpDevice.TabIndex = 2;
            // 
            // lblDeviceInfo
            // 
            this.lblDeviceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeviceInfo.Location = new System.Drawing.Point(3, 30);
            this.lblDeviceInfo.Name = "lblDeviceInfo";
            this.lblDeviceInfo.Size = new System.Drawing.Size(804, 57);
            this.lblDeviceInfo.TabIndex = 2;
            this.lblDeviceInfo.Text = "Loading device information...";
            this.lblDeviceInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceName.Location = new System.Drawing.Point(3, 0);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(804, 30);
            this.lblDeviceName.TabIndex = 0;
            this.lblDeviceName.Text = "Loading device name...";
            this.lblDeviceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpParams
            // 
            this.tlpParams.ColumnCount = 2;
            this.tlpParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 464F));
            this.tlpParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpParams.Controls.Add(this.tlpControls, 1, 0);
            this.tlpParams.Controls.Add(this.grpStatus, 0, 0);
            this.tlpParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpParams.Location = new System.Drawing.Point(3, 123);
            this.tlpParams.Name = "tlpParams";
            this.tlpParams.RowCount = 1;
            this.tlpParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpParams.Size = new System.Drawing.Size(942, 594);
            this.tlpParams.TabIndex = 1;
            // 
            // tlpControls
            // 
            this.tlpControls.ColumnCount = 1;
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpControls.Controls.Add(this.grpCommand, 0, 0);
            this.tlpControls.Controls.Add(this.grpControls, 0, 1);
            this.tlpControls.Controls.Add(this.grpCaps, 0, 2);
            this.tlpControls.Controls.Add(this.grpConn, 0, 3);
            this.tlpControls.Controls.Add(this.grpGraph, 0, 4);
            this.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControls.Location = new System.Drawing.Point(481, 3);
            this.tlpControls.Name = "tlpControls";
            this.tlpControls.RowCount = 5;
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.Size = new System.Drawing.Size(458, 588);
            this.tlpControls.TabIndex = 0;
            // 
            // grpCommand
            // 
            this.grpCommand.Controls.Add(this.tlpCommand);
            this.grpCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCommand.Location = new System.Drawing.Point(3, 3);
            this.grpCommand.Name = "grpCommand";
            this.grpCommand.Size = new System.Drawing.Size(452, 113);
            this.grpCommand.TabIndex = 0;
            this.grpCommand.TabStop = false;
            this.grpCommand.Text = "Device Status";
            // 
            // tlpCommand
            // 
            this.tlpCommand.ColumnCount = 2;
            this.tlpCommand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpCommand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCommand.Controls.Add(this.pcbStatus, 0, 0);
            this.tlpCommand.Controls.Add(this.lblStatus, 1, 0);
            this.tlpCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCommand.Location = new System.Drawing.Point(3, 18);
            this.tlpCommand.Name = "tlpCommand";
            this.tlpCommand.RowCount = 1;
            this.tlpCommand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCommand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tlpCommand.Size = new System.Drawing.Size(446, 92);
            this.tlpCommand.TabIndex = 0;
            // 
            // pcbStatus
            // 
            this.pcbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbStatus.Location = new System.Drawing.Point(3, 3);
            this.pcbStatus.Name = "pcbStatus";
            this.pcbStatus.Size = new System.Drawing.Size(94, 86);
            this.pcbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbStatus.TabIndex = 0;
            this.pcbStatus.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblStatus.Location = new System.Drawing.Point(103, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(340, 92);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Loading device status...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.tlpCommands);
            this.grpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpControls.Location = new System.Drawing.Point(3, 122);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(452, 69);
            this.grpControls.TabIndex = 1;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controls";
            // 
            // tlpCommands
            // 
            this.tlpCommands.ColumnCount = 4;
            this.tlpCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCommands.Controls.Add(this.chkAdvanced, 3, 0);
            this.tlpCommands.Controls.Add(this.chkUserValve, 2, 0);
            this.tlpCommands.Controls.Add(this.chkUserBuzz, 1, 0);
            this.tlpCommands.Controls.Add(this.chkOverride, 0, 0);
            this.tlpCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCommands.Location = new System.Drawing.Point(3, 18);
            this.tlpCommands.Name = "tlpCommands";
            this.tlpCommands.RowCount = 1;
            this.tlpCommands.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCommands.Size = new System.Drawing.Size(446, 48);
            this.tlpCommands.TabIndex = 0;
            // 
            // chkAdvanced
            // 
            this.chkAdvanced.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAdvanced.AutoSize = true;
            this.chkAdvanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAdvanced.Location = new System.Drawing.Point(363, 3);
            this.chkAdvanced.Name = "chkAdvanced";
            this.chkAdvanced.Size = new System.Drawing.Size(80, 42);
            this.chkAdvanced.TabIndex = 9;
            this.chkAdvanced.Text = "More";
            this.chkAdvanced.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAdvanced.UseVisualStyleBackColor = true;
            this.chkAdvanced.CheckedChanged += new System.EventHandler(this.chkAdvanced_CheckedChanged);
            // 
            // chkUserValve
            // 
            this.chkUserValve.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkUserValve.AutoSize = true;
            this.chkUserValve.BackColor = System.Drawing.Color.LightSteelBlue;
            this.chkUserValve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkUserValve.Location = new System.Drawing.Point(243, 3);
            this.chkUserValve.Name = "chkUserValve";
            this.chkUserValve.Size = new System.Drawing.Size(114, 42);
            this.chkUserValve.TabIndex = 8;
            this.chkUserValve.Text = "Open Valve";
            this.chkUserValve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkUserValve.UseVisualStyleBackColor = false;
            this.chkUserValve.CheckedChanged += new System.EventHandler(this.chkUserValve_CheckedChanged);
            // 
            // chkUserBuzz
            // 
            this.chkUserBuzz.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkUserBuzz.AutoSize = true;
            this.chkUserBuzz.BackColor = System.Drawing.Color.LemonChiffon;
            this.chkUserBuzz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkUserBuzz.Location = new System.Drawing.Point(123, 3);
            this.chkUserBuzz.Name = "chkUserBuzz";
            this.chkUserBuzz.Size = new System.Drawing.Size(114, 42);
            this.chkUserBuzz.TabIndex = 7;
            this.chkUserBuzz.Text = "Buzz";
            this.chkUserBuzz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkUserBuzz.UseVisualStyleBackColor = false;
            this.chkUserBuzz.CheckedChanged += new System.EventHandler(this.chkUserBuzz_CheckedChanged);
            // 
            // chkOverride
            // 
            this.chkOverride.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkOverride.AutoSize = true;
            this.chkOverride.BackColor = System.Drawing.Color.LightCoral;
            this.chkOverride.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkOverride.Location = new System.Drawing.Point(3, 3);
            this.chkOverride.Name = "chkOverride";
            this.chkOverride.Size = new System.Drawing.Size(114, 42);
            this.chkOverride.TabIndex = 6;
            this.chkOverride.Text = "Override";
            this.chkOverride.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkOverride.UseVisualStyleBackColor = false;
            this.chkOverride.CheckedChanged += new System.EventHandler(this.chkOverride_CheckedChanged);
            this.chkOverride.Click += new System.EventHandler(this.chkOverride_Click);
            // 
            // grpCaps
            // 
            this.grpCaps.Controls.Add(this.tlpCaps);
            this.grpCaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCaps.Location = new System.Drawing.Point(3, 197);
            this.grpCaps.Name = "grpCaps";
            this.grpCaps.Size = new System.Drawing.Size(452, 92);
            this.grpCaps.TabIndex = 2;
            this.grpCaps.TabStop = false;
            this.grpCaps.Text = "Level Setup";
            // 
            // tlpCaps
            // 
            this.tlpCaps.ColumnCount = 4;
            this.tlpCaps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpCaps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpCaps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpCaps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCaps.Controls.Add(this.btnCapDefaults, 3, 1);
            this.tlpCaps.Controls.Add(this.lblHumidCap, 2, 1);
            this.tlpCaps.Controls.Add(this.lblTempCap, 1, 1);
            this.tlpCaps.Controls.Add(this.nudCO2, 0, 0);
            this.tlpCaps.Controls.Add(this.nudTemp, 1, 0);
            this.tlpCaps.Controls.Add(this.nudHumid, 2, 0);
            this.tlpCaps.Controls.Add(this.btnCaps, 3, 0);
            this.tlpCaps.Controls.Add(this.lblCO2Cap, 0, 1);
            this.tlpCaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCaps.Location = new System.Drawing.Point(3, 18);
            this.tlpCaps.Name = "tlpCaps";
            this.tlpCaps.RowCount = 2;
            this.tlpCaps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCaps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCaps.Size = new System.Drawing.Size(446, 71);
            this.tlpCaps.TabIndex = 0;
            // 
            // btnCapDefaults
            // 
            this.btnCapDefaults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCapDefaults.Location = new System.Drawing.Point(303, 38);
            this.btnCapDefaults.Name = "btnCapDefaults";
            this.btnCapDefaults.Size = new System.Drawing.Size(140, 30);
            this.btnCapDefaults.TabIndex = 5;
            this.btnCapDefaults.Text = "Load Defaults";
            this.btnCapDefaults.UseVisualStyleBackColor = true;
            this.btnCapDefaults.Click += new System.EventHandler(this.btnCapDefaults_Click);
            // 
            // lblHumidCap
            // 
            this.lblHumidCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHumidCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidCap.Location = new System.Drawing.Point(203, 35);
            this.lblHumidCap.Name = "lblHumidCap";
            this.lblHumidCap.Size = new System.Drawing.Size(94, 36);
            this.lblHumidCap.TabIndex = 6;
            this.lblHumidCap.Text = "Humid (%)";
            this.lblHumidCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempCap
            // 
            this.lblTempCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTempCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempCap.Location = new System.Drawing.Point(103, 35);
            this.lblTempCap.Name = "lblTempCap";
            this.lblTempCap.Size = new System.Drawing.Size(94, 36);
            this.lblTempCap.TabIndex = 5;
            this.lblTempCap.Text = "Temp (°C)";
            this.lblTempCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudCO2
            // 
            this.nudCO2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCO2.DecimalPlaces = 2;
            this.nudCO2.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudCO2.Location = new System.Drawing.Point(3, 6);
            this.nudCO2.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudCO2.Name = "nudCO2";
            this.nudCO2.Size = new System.Drawing.Size(94, 22);
            this.nudCO2.TabIndex = 1;
            this.nudCO2.ValueChanged += new System.EventHandler(this.nudCO2_ValueChanged);
            // 
            // nudTemp
            // 
            this.nudTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTemp.Location = new System.Drawing.Point(103, 6);
            this.nudTemp.Name = "nudTemp";
            this.nudTemp.Size = new System.Drawing.Size(94, 22);
            this.nudTemp.TabIndex = 2;
            this.nudTemp.ValueChanged += new System.EventHandler(this.nudTemp_ValueChanged);
            // 
            // nudHumid
            // 
            this.nudHumid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudHumid.Location = new System.Drawing.Point(203, 6);
            this.nudHumid.Name = "nudHumid";
            this.nudHumid.Size = new System.Drawing.Size(94, 22);
            this.nudHumid.TabIndex = 3;
            this.nudHumid.ValueChanged += new System.EventHandler(this.nudHumid_ValueChanged);
            // 
            // btnCaps
            // 
            this.btnCaps.BackColor = System.Drawing.SystemColors.Control;
            this.btnCaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCaps.Location = new System.Drawing.Point(303, 3);
            this.btnCaps.Name = "btnCaps";
            this.btnCaps.Size = new System.Drawing.Size(140, 29);
            this.btnCaps.TabIndex = 4;
            this.btnCaps.Text = "Apply";
            this.btnCaps.UseVisualStyleBackColor = false;
            this.btnCaps.Click += new System.EventHandler(this.btnCaps_Click);
            // 
            // lblCO2Cap
            // 
            this.lblCO2Cap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCO2Cap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCO2Cap.Location = new System.Drawing.Point(3, 35);
            this.lblCO2Cap.Name = "lblCO2Cap";
            this.lblCO2Cap.Size = new System.Drawing.Size(94, 36);
            this.lblCO2Cap.TabIndex = 4;
            this.lblCO2Cap.Text = "CO2 (PPM)";
            this.lblCO2Cap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpConn
            // 
            this.grpConn.Controls.Add(this.lblConn);
            this.grpConn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpConn.Location = new System.Drawing.Point(3, 295);
            this.grpConn.Name = "grpConn";
            this.grpConn.Padding = new System.Windows.Forms.Padding(10, 20, 3, 3);
            this.grpConn.Size = new System.Drawing.Size(452, 134);
            this.grpConn.TabIndex = 3;
            this.grpConn.TabStop = false;
            this.grpConn.Text = "Connection Info";
            // 
            // lblConn
            // 
            this.lblConn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConn.Location = new System.Drawing.Point(10, 35);
            this.lblConn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConn.Name = "lblConn";
            this.lblConn.Size = new System.Drawing.Size(439, 96);
            this.lblConn.TabIndex = 0;
            this.lblConn.Text = "Status: Disconnected";
            // 
            // grpGraph
            // 
            this.grpGraph.Controls.Add(this.btnGraph);
            this.grpGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGraph.Location = new System.Drawing.Point(3, 435);
            this.grpGraph.Name = "grpGraph";
            this.grpGraph.Size = new System.Drawing.Size(452, 150);
            this.grpGraph.TabIndex = 4;
            this.grpGraph.TabStop = false;
            this.grpGraph.Text = "Graph Options";
            // 
            // btnGraph
            // 
            this.btnGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGraph.Location = new System.Drawing.Point(3, 18);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(446, 129);
            this.btnGraph.TabIndex = 0;
            this.btnGraph.Text = "Display Graph";
            this.btnGraph.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.tlpStatus);
            this.grpStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpStatus.Location = new System.Drawing.Point(3, 3);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(472, 588);
            this.grpStatus.TabIndex = 1;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Live Feed";
            // 
            // tlpStatus
            // 
            this.tlpStatus.ColumnCount = 3;
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpStatus.Controls.Add(this.grpCO2, 0, 0);
            this.tlpStatus.Controls.Add(this.grpTemp, 1, 0);
            this.tlpStatus.Controls.Add(this.grpHumid, 2, 0);
            this.tlpStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStatus.Location = new System.Drawing.Point(3, 18);
            this.tlpStatus.Name = "tlpStatus";
            this.tlpStatus.RowCount = 1;
            this.tlpStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 472F));
            this.tlpStatus.Size = new System.Drawing.Size(466, 567);
            this.tlpStatus.TabIndex = 0;
            // 
            // grpCO2
            // 
            this.grpCO2.Controls.Add(this.tlpCO2);
            this.grpCO2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCO2.Location = new System.Drawing.Point(3, 3);
            this.grpCO2.Name = "grpCO2";
            this.grpCO2.Size = new System.Drawing.Size(149, 561);
            this.grpCO2.TabIndex = 0;
            this.grpCO2.TabStop = false;
            this.grpCO2.Text = "CO2";
            // 
            // tlpCO2
            // 
            this.tlpCO2.ColumnCount = 1;
            this.tlpCO2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCO2.Controls.Add(this.pcbCO2, 0, 0);
            this.tlpCO2.Controls.Add(this.lblCO2, 0, 1);
            this.tlpCO2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCO2.Location = new System.Drawing.Point(3, 18);
            this.tlpCO2.Name = "tlpCO2";
            this.tlpCO2.RowCount = 2;
            this.tlpCO2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCO2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpCO2.Size = new System.Drawing.Size(143, 540);
            this.tlpCO2.TabIndex = 0;
            // 
            // pcbCO2
            // 
            this.pcbCO2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbCO2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbCO2.Location = new System.Drawing.Point(3, 3);
            this.pcbCO2.Name = "pcbCO2";
            this.pcbCO2.Size = new System.Drawing.Size(137, 474);
            this.pcbCO2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCO2.TabIndex = 0;
            this.pcbCO2.TabStop = false;
            // 
            // lblCO2
            // 
            this.lblCO2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCO2.Location = new System.Drawing.Point(3, 480);
            this.lblCO2.Name = "lblCO2";
            this.lblCO2.Size = new System.Drawing.Size(137, 60);
            this.lblCO2.TabIndex = 1;
            this.lblCO2.Text = "00";
            this.lblCO2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpTemp
            // 
            this.grpTemp.Controls.Add(this.tlpTemp);
            this.grpTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTemp.Location = new System.Drawing.Point(158, 3);
            this.grpTemp.Name = "grpTemp";
            this.grpTemp.Size = new System.Drawing.Size(149, 561);
            this.grpTemp.TabIndex = 1;
            this.grpTemp.TabStop = false;
            this.grpTemp.Text = "Temp (°C)";
            // 
            // tlpTemp
            // 
            this.tlpTemp.ColumnCount = 1;
            this.tlpTemp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTemp.Controls.Add(this.pcbTemp, 0, 0);
            this.tlpTemp.Controls.Add(this.lblTemp, 0, 1);
            this.tlpTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTemp.Location = new System.Drawing.Point(3, 18);
            this.tlpTemp.Name = "tlpTemp";
            this.tlpTemp.RowCount = 2;
            this.tlpTemp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTemp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpTemp.Size = new System.Drawing.Size(143, 540);
            this.tlpTemp.TabIndex = 1;
            // 
            // pcbTemp
            // 
            this.pcbTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbTemp.Location = new System.Drawing.Point(3, 3);
            this.pcbTemp.Name = "pcbTemp";
            this.pcbTemp.Size = new System.Drawing.Size(137, 474);
            this.pcbTemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbTemp.TabIndex = 0;
            this.pcbTemp.TabStop = false;
            // 
            // lblTemp
            // 
            this.lblTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(3, 480);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(137, 60);
            this.lblTemp.TabIndex = 1;
            this.lblTemp.Text = "00";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpHumid
            // 
            this.grpHumid.Controls.Add(this.tlpHumid);
            this.grpHumid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpHumid.Location = new System.Drawing.Point(313, 3);
            this.grpHumid.Name = "grpHumid";
            this.grpHumid.Size = new System.Drawing.Size(150, 561);
            this.grpHumid.TabIndex = 2;
            this.grpHumid.TabStop = false;
            this.grpHumid.Text = "Humid (%)";
            // 
            // tlpHumid
            // 
            this.tlpHumid.ColumnCount = 1;
            this.tlpHumid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHumid.Controls.Add(this.pcbHumid, 0, 0);
            this.tlpHumid.Controls.Add(this.lblHumid, 0, 1);
            this.tlpHumid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHumid.Location = new System.Drawing.Point(3, 18);
            this.tlpHumid.Name = "tlpHumid";
            this.tlpHumid.RowCount = 2;
            this.tlpHumid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHumid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpHumid.Size = new System.Drawing.Size(144, 540);
            this.tlpHumid.TabIndex = 1;
            // 
            // pcbHumid
            // 
            this.pcbHumid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbHumid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbHumid.Location = new System.Drawing.Point(3, 3);
            this.pcbHumid.Name = "pcbHumid";
            this.pcbHumid.Size = new System.Drawing.Size(138, 474);
            this.pcbHumid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbHumid.TabIndex = 0;
            this.pcbHumid.TabStop = false;
            // 
            // lblHumid
            // 
            this.lblHumid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHumid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumid.Location = new System.Drawing.Point(3, 480);
            this.lblHumid.Name = "lblHumid";
            this.lblHumid.Size = new System.Drawing.Size(138, 60);
            this.lblHumid.TabIndex = 1;
            this.lblHumid.Text = "00";
            this.lblHumid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpAdvanced
            // 
            this.grpAdvanced.Controls.Add(this.tlpComm);
            this.grpAdvanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAdvanced.Location = new System.Drawing.Point(0, 0);
            this.grpAdvanced.Name = "grpAdvanced";
            this.grpAdvanced.Size = new System.Drawing.Size(948, 91);
            this.grpAdvanced.TabIndex = 0;
            this.grpAdvanced.TabStop = false;
            this.grpAdvanced.Text = "Advanced Controls";
            // 
            // tlpComm
            // 
            this.tlpComm.ColumnCount = 1;
            this.tlpComm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpComm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpComm.Controls.Add(this.lblRecieve, 0, 1);
            this.tlpComm.Controls.Add(this.tlpSend, 0, 0);
            this.tlpComm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpComm.Location = new System.Drawing.Point(3, 18);
            this.tlpComm.Name = "tlpComm";
            this.tlpComm.RowCount = 2;
            this.tlpComm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlpComm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpComm.Size = new System.Drawing.Size(942, 70);
            this.tlpComm.TabIndex = 0;
            // 
            // lblRecieve
            // 
            this.lblRecieve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecieve.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRecieve.Location = new System.Drawing.Point(3, 39);
            this.lblRecieve.Name = "lblRecieve";
            this.lblRecieve.Size = new System.Drawing.Size(936, 31);
            this.lblRecieve.TabIndex = 0;
            this.lblRecieve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpSend
            // 
            this.tlpSend.ColumnCount = 3;
            this.tlpSend.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpSend.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSend.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpSend.Controls.Add(this.txtSend, 1, 0);
            this.tlpSend.Controls.Add(this.btnSend, 2, 0);
            this.tlpSend.Controls.Add(this.chkSync, 0, 0);
            this.tlpSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSend.Location = new System.Drawing.Point(3, 3);
            this.tlpSend.Name = "tlpSend";
            this.tlpSend.RowCount = 1;
            this.tlpSend.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSend.Size = new System.Drawing.Size(936, 33);
            this.tlpSend.TabIndex = 1;
            // 
            // txtSend
            // 
            this.txtSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSend.Location = new System.Drawing.Point(36, 5);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(797, 22);
            this.txtSend.TabIndex = 0;
            this.txtSend.TextChanged += new System.EventHandler(this.txtSend_TextChanged);
            this.txtSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(839, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 27);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // chkSync
            // 
            this.chkSync.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSync.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSync.Location = new System.Drawing.Point(3, 3);
            this.chkSync.Name = "chkSync";
            this.chkSync.Size = new System.Drawing.Size(27, 27);
            this.chkSync.TabIndex = 2;
            this.chkSync.UseVisualStyleBackColor = true;
            this.chkSync.CheckedChanged += new System.EventHandler(this.chkSync_CheckedChanged);
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 500;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // frmDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 746);
            this.Controls.Add(this.spcMain);
            this.Controls.Add(this.stsStatus);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(966, 791);
            this.Name = "frmDevice";
            this.Text = "Prometheus Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDevice_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDevice_KeyDown);
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.tlpPanel.ResumeLayout(false);
            this.tlpInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.grpDevice.ResumeLayout(false);
            this.tlpDevice.ResumeLayout(false);
            this.tlpParams.ResumeLayout(false);
            this.tlpControls.ResumeLayout(false);
            this.grpCommand.ResumeLayout(false);
            this.tlpCommand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbStatus)).EndInit();
            this.grpControls.ResumeLayout(false);
            this.tlpCommands.ResumeLayout(false);
            this.tlpCommands.PerformLayout();
            this.grpCaps.ResumeLayout(false);
            this.tlpCaps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCO2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHumid)).EndInit();
            this.grpConn.ResumeLayout(false);
            this.grpGraph.ResumeLayout(false);
            this.grpStatus.ResumeLayout(false);
            this.tlpStatus.ResumeLayout(false);
            this.grpCO2.ResumeLayout(false);
            this.tlpCO2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCO2)).EndInit();
            this.grpTemp.ResumeLayout(false);
            this.tlpTemp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbTemp)).EndInit();
            this.grpHumid.ResumeLayout(false);
            this.tlpHumid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbHumid)).EndInit();
            this.grpAdvanced.ResumeLayout(false);
            this.tlpComm.ResumeLayout(false);
            this.tlpSend.ResumeLayout(false);
            this.tlpSend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.GroupBox grpAdvanced;
        private System.Windows.Forms.TableLayoutPanel tlpComm;
        private System.Windows.Forms.Label lblRecieve;
        private System.Windows.Forms.TableLayoutPanel tlpSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ToolStripStatusLabel tstStatus;
        private System.Windows.Forms.ToolStripStatusLabel tstSeparator;
        private System.Windows.Forms.ToolStripStatusLabel tstDate;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.TableLayoutPanel tlpPanel;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.TableLayoutPanel tlpParams;
        private System.Windows.Forms.TableLayoutPanel tlpControls;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.TableLayoutPanel tlpStatus;
        private System.Windows.Forms.GroupBox grpDevice;
        private System.Windows.Forms.TableLayoutPanel tlpDevice;
        private System.Windows.Forms.Label lblDeviceInfo;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.GroupBox grpCO2;
        private System.Windows.Forms.GroupBox grpTemp;
        private System.Windows.Forms.GroupBox grpHumid;
        private System.Windows.Forms.GroupBox grpCommand;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.GroupBox grpCaps;
        private System.Windows.Forms.GroupBox grpConn;
        private System.Windows.Forms.TableLayoutPanel tlpCommand;
        private System.Windows.Forms.PictureBox pcbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TableLayoutPanel tlpCommands;
        private System.Windows.Forms.CheckBox chkAdvanced;
        private System.Windows.Forms.CheckBox chkUserValve;
        private System.Windows.Forms.CheckBox chkUserBuzz;
        private System.Windows.Forms.CheckBox chkOverride;
        private System.Windows.Forms.TableLayoutPanel tlpCaps;
        private System.Windows.Forms.NumericUpDown nudCO2;
        private System.Windows.Forms.NumericUpDown nudTemp;
        private System.Windows.Forms.NumericUpDown nudHumid;
        private System.Windows.Forms.Button btnCaps;
        private System.Windows.Forms.Label lblConn;
        private System.Windows.Forms.Button btnCapDefaults;
        private System.Windows.Forms.Label lblHumidCap;
        private System.Windows.Forms.Label lblTempCap;
        private System.Windows.Forms.Label lblCO2Cap;
        private System.Windows.Forms.TableLayoutPanel tlpCO2;
        private System.Windows.Forms.PictureBox pcbCO2;
        private System.Windows.Forms.Label lblCO2;
        private System.Windows.Forms.TableLayoutPanel tlpTemp;
        private System.Windows.Forms.PictureBox pcbTemp;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TableLayoutPanel tlpHumid;
        private System.Windows.Forms.PictureBox pcbHumid;
        private System.Windows.Forms.Label lblHumid;
        private System.Windows.Forms.GroupBox grpGraph;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.ToolStripStatusLabel tstNotification;
        private System.Windows.Forms.CheckBox chkSync;
    }
}