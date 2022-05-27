/*
 *                    GRAPH FUNCTION
 *                      
 *       This form displays the graphs of historical data
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json; // To handle JSON data

namespace Fire_Extinguisher
{
    public partial class frmGraph : Form
    {
        string title = ""; // Original title sent by the parent

        string selectedID = null; // ID of the selected device, null if no device is selected
        DateTime selectedDate = DateTime.Now; // Selected date to show the graph

        // Lists to hold log data: device list, Updates and Cap levels
        Dictionary<string, List<string>> deviceList = new Dictionary<string, List<string>>();
        List<Tuple<DateTime, Dictionary<string, dynamic>>> loadedData = new List<Tuple<DateTime, Dictionary<string, dynamic>>>();
        List<Tuple<DateTime, Dictionary<string, dynamic>>> loadedCaps = new List<Tuple<DateTime, Dictionary<string, dynamic>>>();

        /// <summary>
        /// Displays a form with graphs of historical data
        /// </summary>
        /// <param name="title">Title to show on the form</param>
        /// <param name="icon">Icon to show on the form</param>
        /// <param name="_selectedID">Selected ID</param>

        public frmGraph(string _title, Icon icon, string _selectedID = "")
        {
            InitializeComponent();

            this.Text = _title + " - Sensor Logs"; this.Icon = icon; // Setting up the display

            // Setting global variables
            title = _title;
            selectedID = _selectedID;
        }

        /// <summary>
        /// Function that run when form is loaded
        /// </summary>
        /// <param name="sender">Sending events</param>
        /// <param name="e">Event arguements</param>

        private void frmGraph_Load(object sender, EventArgs e)
        {
            // When loaded, we parse the logs and load the device list
            parseLogs();
            loadDevices();

            // If there are items in the combo, we select the first one
            if (cmbDevice.Items.Count > 0) { cmbDevice.SelectedIndex = 0; }
        }

        /// <summary>
        /// Function when the selected index of the device list is changed
        /// </summary>
        /// <param name="sender">Sending events</param>
        /// <param name="e">Event arguements</param>

        private void cmbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            // We add all dates related to that device
            cmbDate.Items.Clear();

            if (cmbDevice.Items.Count > 0)
            {
                cmbDate.Items.AddRange(deviceList[cmbDevice.SelectedItem.ToString()].ToArray());
                if (cmbDate.Items.Count > 0)
                {
                    cmbDate.SelectedIndex = 0;
                }
            }

        }

        /// <summary>
        /// Function when the selected index of the date list is changed
        /// </summary>
        /// <param name="sender">Sending events</param>
        /// <param name="e">Event arguements</param>

        private void cmbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshData(); // We refresh the data
        }

        /// <summary>
        /// Function called when a new tick is registered in the timer
        /// </summary>
        /// <param name="sender">Sending events</param>
        /// <param name="e">Event arguements</param>

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            refreshData(); // Refresh the data
        }

        //////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Loads all the devices from the device list
        /// </summary>

        private void loadDevices()
        {
            cmbDevice.Items.Clear();
            cmbDevice.Items.AddRange(deviceList.Keys.ToArray());
        }

        /// <summary>
        /// Parses the logs and add them to relevant dictionaries
        /// </summary>

        private void parseLogs()
        {
            // Loading all sensor data
            foreach (var item in System.IO.Directory.GetFiles(frmMain.APPDATALOCATION + "/logs/"))
            {
                try
                {
                    string[] filename = item.Replace(frmMain.APPDATALOCATION + "/logs/", "").Split(' ');

                    if (deviceList.ContainsKey(filename[1].Replace(".log", "")))
                    {
                        deviceList[filename[1].Replace(".log", "")].Add(filename[0]);
                    }
                    else
                    {
                        List<string> dates = new List<string>();
                        dates.Add(filename[0]);
                        deviceList.Add(filename[1].Replace(".log", ""), dates);
                    }
                } catch (Exception) { }
            }

            // If the devicelist contains the ID of the selecteddevice,
            // We select it as the device
            if (deviceList.ContainsKey(selectedID))
            {
                cmbDevice.SelectedItem = selectedID;
                cmbDate.SelectedItem = DateTime.Now.ToString("d");
                this.Text = title + " - " + selectedID + " Sensor Logs";
                cmbDevice.Enabled = false;
                tmrMain.Enabled = true;
            } else
            {
                this.Text = title + " - Sensor Logs";
                tmrMain.Enabled = false;
            }

            // Disabling controls if no data exist
            if (deviceList.Count == 0)
            {
                cmbDevice.Enabled = false;
                cmbDate.Enabled = false;
                tbcMain.Enabled = false;
                lblNoLogs.Visible = true;
                prgLoading.Visible = false;
            }

        }

        /// <summary>
        /// Loads the sensor data for a selected device and a date
        /// </summary>
        /// <param name="device">Selected device</param>
        /// <param name="date">Selected date</param>

        private void loadSensorData(string device, string date)
        {
            loadedData.Clear();
            loadedCaps.Clear();

            System.IO.StreamReader reader = new System.IO.StreamReader(frmMain.APPDATALOCATION + "/logs/" + date + " " + device + ".log");
            
            // Reading the document
            while (!reader.EndOfStream)
            {
                string str = reader.ReadLine();

                if (str.Contains("update:"))
                {
                    // In case of an update
                    str = str.Replace("update:", "#");

                    if (str.Length > 1)
                    {
                        string[] splitString = str.Split('#');

                        Dictionary<string, dynamic> update = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(splitString[1]);
                        DateTime time = DateTime.Parse(splitString[0].Replace("[", "").Replace("]", ""));
                        Tuple<DateTime, Dictionary<string, dynamic>> parsedData = new Tuple<DateTime, Dictionary<string, dynamic>>(time, update);
                        loadedData.Add(parsedData);
                    }
                } else if (str.Contains("getCaps:"))
                {
                    // In case of a cap change
                    str = str.Replace("getCaps:", "#");

                    if (str.Length > 1)
                    {
                        string[] splitString = str.Split('#');

                        Dictionary<string, dynamic> update = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(splitString[1]);
                        DateTime time = DateTime.Parse(splitString[0].Replace("[", "").Replace("]", ""));
                        Tuple<DateTime, Dictionary<string, dynamic>> parsedData = new Tuple<DateTime, Dictionary<string, dynamic>>(time, update);
                        loadedCaps.Add(parsedData);
                    }
                }
            }
        }

        /// <summary>
        /// Functions that refreshes the data
        /// </summary>

        private void refreshData()
        {
            prgLoading.Visible = true;
            this.Refresh();

            // Loading data
            loadSensorData(cmbDevice.SelectedItem.ToString(), cmbDate.SelectedItem.ToString());

            DateTime lastX = DateTime.Now;

            // Drawing the graphs
            chrCO2.Series.Clear();
            chrTemp.Series.Clear();
            chrHumid.Series.Clear();

            chrCO2.Series.Add("Carbondioxide").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chrTemp.Series.Add("Temperature (°C)").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chrHumid.Series.Add("Humidity (%)").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chrCO2.Series.Add("Threshold").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chrTemp.Series.Add("Threshold").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chrHumid.Series.Add("Threshold").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            foreach (var item in loadedData)
            {
                lastX = item.Item1;
                chrCO2.Series["Carbondioxide"].Points.AddXY(lastX, decimal.Parse(Convert.ToString(item.Item2["co2"])));
                chrTemp.Series["Temperature (°C)"].Points.AddXY(lastX, decimal.Parse(Convert.ToString(item.Item2["temp"])));
                chrHumid.Series["Humidity (%)"].Points.AddXY(lastX, decimal.Parse(Convert.ToString(item.Item2["humid"])));
            }
            
            foreach (var item in loadedCaps)
            {
                chrCO2.Series["Threshold"].Points.AddXY(item.Item1, decimal.Parse(Convert.ToString(item.Item2["co2"])));
                chrTemp.Series["Threshold"].Points.AddXY(item.Item1, decimal.Parse(Convert.ToString(item.Item2["temp"])));
                chrHumid.Series["Threshold"].Points.AddXY(item.Item1, decimal.Parse(Convert.ToString(item.Item2["humid"])));
            }

            if (loadedCaps.Count > 0)
            {
                chrCO2.Series["Threshold"].Points.AddXY(lastX, decimal.Parse(Convert.ToString(loadedCaps[loadedCaps.Count - 1].Item2["co2"])));
                chrTemp.Series["Threshold"].Points.AddXY(lastX, decimal.Parse(Convert.ToString(loadedCaps[loadedCaps.Count - 1].Item2["temp"])));
                chrHumid.Series["Threshold"].Points.AddXY(lastX, decimal.Parse(Convert.ToString(loadedCaps[loadedCaps.Count - 1].Item2["humid"])));
            }

            prgLoading.Visible = false;
        }

        /// <summary>
        /// Handles keyboard commands
        /// </summary>
        /// <param name="sender">Sending event</param>
        /// <param name="e">Event agruements</param>

        private void frmGraph_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close(); // Close

            if (e.Control && e.KeyCode == Keys.Tab)
                if (tbcMain.SelectedIndex < tbcMain.TabCount - 1)
                    tbcMain.SelectedIndex += 1; // Switch tab
                else
                    tbcMain.SelectedIndex = 0;

            if (e.Control && e.KeyCode == Keys.Left)
                cmbDevice.Focus(); // Select device combo

            if (e.Control && e.KeyCode == Keys.Right)
                cmbDate.Focus(); // Select date combo

            if (e.Control && e.KeyCode == Keys.Up)
                // Select item above
                if (cmbDate.Focused && cmbDate.SelectedIndex > 0)
                    cmbDate.SelectedIndex--;
                else if (cmbDevice.Focused && cmbDevice.SelectedIndex > 0)
                    cmbDevice.SelectedIndex--;

            if (e.Control && e.KeyCode == Keys.Down)
                // Select item below
                if (cmbDate.Focused && cmbDate.SelectedIndex < cmbDate.Items.Count - 1)
                    cmbDate.SelectedIndex++; // Graph
                else if (cmbDevice.Focused && cmbDevice.SelectedIndex < cmbDevice.Items.Count - 1)
                    cmbDevice.SelectedIndex++;
        }
    }
}
