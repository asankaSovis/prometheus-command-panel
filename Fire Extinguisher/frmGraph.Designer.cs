
namespace Fire_Extinguisher
{
    partial class frmGraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpDevice = new System.Windows.Forms.GroupBox();
            this.tlpControls = new System.Windows.Forms.TableLayoutPanel();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.prgLoading = new System.Windows.Forms.ProgressBar();
            this.grpPlot = new System.Windows.Forms.GroupBox();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tabCO2 = new System.Windows.Forms.TabPage();
            this.lblNoLogs = new System.Windows.Forms.Label();
            this.chrCO2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabTemp = new System.Windows.Forms.TabPage();
            this.chrTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabHumidity = new System.Windows.Forms.TabPage();
            this.chrHumid = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.tlpMain.SuspendLayout();
            this.grpDevice.SuspendLayout();
            this.tlpControls.SuspendLayout();
            this.grpPlot.SuspendLayout();
            this.tbcMain.SuspendLayout();
            this.tabCO2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrCO2)).BeginInit();
            this.tabTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrTemp)).BeginInit();
            this.tabHumidity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrHumid)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.grpDevice, 0, 0);
            this.tlpMain.Controls.Add(this.grpPlot, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(989, 558);
            this.tlpMain.TabIndex = 0;
            // 
            // grpDevice
            // 
            this.grpDevice.Controls.Add(this.tlpControls);
            this.grpDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDevice.Location = new System.Drawing.Point(3, 3);
            this.grpDevice.Name = "grpDevice";
            this.grpDevice.Size = new System.Drawing.Size(983, 49);
            this.grpDevice.TabIndex = 0;
            this.grpDevice.TabStop = false;
            this.grpDevice.Text = "Controls";
            // 
            // tlpControls
            // 
            this.tlpControls.ColumnCount = 4;
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.Controls.Add(this.cmbDevice, 0, 0);
            this.tlpControls.Controls.Add(this.cmbDate, 1, 0);
            this.tlpControls.Controls.Add(this.prgLoading, 3, 0);
            this.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControls.Location = new System.Drawing.Point(3, 18);
            this.tlpControls.Name = "tlpControls";
            this.tlpControls.RowCount = 1;
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpControls.Size = new System.Drawing.Size(977, 28);
            this.tlpControls.TabIndex = 1;
            // 
            // cmbDevice
            // 
            this.cmbDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(3, 3);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(187, 24);
            this.cmbDevice.TabIndex = 1;
            this.cmbDevice.SelectedIndexChanged += new System.EventHandler(this.cmbDevice_SelectedIndexChanged);
            // 
            // cmbDate
            // 
            this.cmbDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Location = new System.Drawing.Point(196, 3);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(201, 24);
            this.cmbDate.TabIndex = 2;
            this.cmbDate.SelectedIndexChanged += new System.EventHandler(this.cmbDate_SelectedIndexChanged);
            // 
            // prgLoading
            // 
            this.prgLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prgLoading.Location = new System.Drawing.Point(560, 3);
            this.prgLoading.Name = "prgLoading";
            this.prgLoading.Size = new System.Drawing.Size(414, 22);
            this.prgLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgLoading.TabIndex = 2;
            // 
            // grpPlot
            // 
            this.grpPlot.Controls.Add(this.tbcMain);
            this.grpPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPlot.Location = new System.Drawing.Point(3, 58);
            this.grpPlot.Name = "grpPlot";
            this.grpPlot.Size = new System.Drawing.Size(983, 497);
            this.grpPlot.TabIndex = 1;
            this.grpPlot.TabStop = false;
            this.grpPlot.Text = "Sensor Data";
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tabCO2);
            this.tbcMain.Controls.Add(this.tabTemp);
            this.tbcMain.Controls.Add(this.tabHumidity);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(3, 18);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(977, 476);
            this.tbcMain.TabIndex = 0;
            // 
            // tabCO2
            // 
            this.tabCO2.Controls.Add(this.lblNoLogs);
            this.tabCO2.Controls.Add(this.chrCO2);
            this.tabCO2.Location = new System.Drawing.Point(4, 25);
            this.tabCO2.Name = "tabCO2";
            this.tabCO2.Padding = new System.Windows.Forms.Padding(3);
            this.tabCO2.Size = new System.Drawing.Size(969, 447);
            this.tabCO2.TabIndex = 0;
            this.tabCO2.Text = "Carbondioxide";
            this.tabCO2.UseVisualStyleBackColor = true;
            // 
            // lblNoLogs
            // 
            this.lblNoLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoLogs.Location = new System.Drawing.Point(0, 0);
            this.lblNoLogs.Name = "lblNoLogs";
            this.lblNoLogs.Size = new System.Drawing.Size(969, 447);
            this.lblNoLogs.TabIndex = 2;
            this.lblNoLogs.Text = "NO LOGS";
            this.lblNoLogs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoLogs.Visible = false;
            // 
            // chrCO2
            // 
            chartArea1.Name = "ChartArea1";
            this.chrCO2.ChartAreas.Add(chartArea1);
            this.chrCO2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chrCO2.Legends.Add(legend1);
            this.chrCO2.Location = new System.Drawing.Point(3, 3);
            this.chrCO2.Name = "chrCO2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrCO2.Series.Add(series1);
            this.chrCO2.Size = new System.Drawing.Size(963, 441);
            this.chrCO2.TabIndex = 1;
            this.chrCO2.Text = "Sensor Data";
            // 
            // tabTemp
            // 
            this.tabTemp.Controls.Add(this.chrTemp);
            this.tabTemp.Location = new System.Drawing.Point(4, 25);
            this.tabTemp.Name = "tabTemp";
            this.tabTemp.Padding = new System.Windows.Forms.Padding(3);
            this.tabTemp.Size = new System.Drawing.Size(969, 447);
            this.tabTemp.TabIndex = 1;
            this.tabTemp.Text = "Temperature";
            this.tabTemp.UseVisualStyleBackColor = true;
            // 
            // chrTemp
            // 
            chartArea2.Name = "ChartArea1";
            this.chrTemp.ChartAreas.Add(chartArea2);
            this.chrTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chrTemp.Legends.Add(legend2);
            this.chrTemp.Location = new System.Drawing.Point(3, 3);
            this.chrTemp.Name = "chrTemp";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrTemp.Series.Add(series2);
            this.chrTemp.Size = new System.Drawing.Size(963, 441);
            this.chrTemp.TabIndex = 1;
            this.chrTemp.Text = "Sensor Data";
            // 
            // tabHumidity
            // 
            this.tabHumidity.Controls.Add(this.chrHumid);
            this.tabHumidity.Location = new System.Drawing.Point(4, 25);
            this.tabHumidity.Name = "tabHumidity";
            this.tabHumidity.Padding = new System.Windows.Forms.Padding(3);
            this.tabHumidity.Size = new System.Drawing.Size(969, 447);
            this.tabHumidity.TabIndex = 2;
            this.tabHumidity.Text = "Humidity";
            this.tabHumidity.UseVisualStyleBackColor = true;
            // 
            // chrHumid
            // 
            chartArea3.Name = "ChartArea1";
            this.chrHumid.ChartAreas.Add(chartArea3);
            this.chrHumid.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chrHumid.Legends.Add(legend3);
            this.chrHumid.Location = new System.Drawing.Point(3, 3);
            this.chrHumid.Name = "chrHumid";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chrHumid.Series.Add(series3);
            this.chrHumid.Size = new System.Drawing.Size(963, 441);
            this.chrHumid.TabIndex = 1;
            this.chrHumid.Text = "Sensor Data";
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // frmGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 558);
            this.Controls.Add(this.tlpMain);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmGraph";
            this.Text = "Sensor Logs";
            this.Load += new System.EventHandler(this.frmGraph_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGraph_KeyDown);
            this.tlpMain.ResumeLayout(false);
            this.grpDevice.ResumeLayout(false);
            this.tlpControls.ResumeLayout(false);
            this.grpPlot.ResumeLayout(false);
            this.tbcMain.ResumeLayout(false);
            this.tabCO2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrCO2)).EndInit();
            this.tabTemp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrTemp)).EndInit();
            this.tabHumidity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrHumid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox grpDevice;
        private System.Windows.Forms.TableLayoutPanel tlpControls;
        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.ComboBox cmbDate;
        private System.Windows.Forms.GroupBox grpPlot;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tabCO2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrCO2;
        private System.Windows.Forms.TabPage tabTemp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrTemp;
        private System.Windows.Forms.TabPage tabHumidity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrHumid;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Label lblNoLogs;
        private System.Windows.Forms.ProgressBar prgLoading;
    }
}