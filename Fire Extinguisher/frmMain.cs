/*
 *                      LOADS DEVICES CONNECTED
 *                      
 *       This form is the main form that loads with the application
 *            and lists all of our devices connected to the PC
 *       NOTE: This is not yet complete
 *       NOTE: Some improvements to make:
 *          01. Check if there's a way to remove loading form
 *          02. Check if there's a way to refresh devices even when
 *                  active panels are there
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
using System.IO.Ports; // Access ports

namespace Fire_Extinguisher
{
    public partial class frmMain : Form
    {
        // This variable loads the image assets
        // 01. Done | 02. Offline | 03. Online | 04. Error | 05. Refresh | 06. Rename | 07. Connect | 08. Warning
        // 09. Graph | 10. Info
        Image[] loadedImages = {
            Image.FromFile("assets/done.png"),
            Image.FromFile("assets/offline.png"),
            Image.FromFile("assets/online.png"),
            Image.FromFile("assets/ban.png"),
            Image.FromFile("assets/refresh.png"),
            Image.FromFile("assets/rename.png"),
            Image.FromFile("assets/connect.png"),
            Image.FromFile("assets/warning.png"),
            Image.FromFile("assets/graph.png"),
            Image.FromFile("assets/info.png")
    };

        // List of devices loaded into the system
        // List of strings
        List<string[]> devices = new List<string[]>();
        // Aliases loaded from the JSON file
        // Dictionary of the form "string":"string"
        Dictionary<string, string> aliases = new Dictionary<string, string>();
        // List of active panels of devices
        // Dictionary of the form "int":"frmDevices"
        Dictionary<int, frmDevice> activePanels = new Dictionary<int, frmDevice>();

        bool deviceListUpdate = false; // Flag to update device list
        public bool deviceStatus = false; // Flag to update device status of the selected device
        bool scanStart = false; // Flag to start a scan

        public static string APPDATALOCATION = Environment.CurrentDirectory;

        DateTime lastScan = DateTime.Now; // Time since last scan took place
        frmLoading loadingScreen = new frmLoading(); // Loading screen
        // NOTE: Might want to remove from release

        public static frmNotification notification = new frmNotification();
        System.Threading.Thread splashScreen;

        /// <summary>
        /// frmMain loads as the first form in the application. This form loads
        /// all the devices connected to the PC and act as a panel to access them
        /// individually.
        /// </summary>

        public frmMain(System.Threading.Thread _splashScreen)
        {
            InitializeComponent();

            splashScreen = _splashScreen;
        }

        //////////////////////////////////////////////////////////////////////////////
        /// Interface Functions

        /// <summary>
        /// Loads the data important for the form including scanning for connected devices
        /// </summary>
        /// <param name="sender">Sending events</param>
        /// <param name="e">Event arguements</param>

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Interface update
            enableControls(false);
            btnRename.Image = loadedImages[5];
            btnRefresh.Image = loadedImages[4];
            btnConnect.Image = loadedImages[6];
            btnGraph.Image = loadedImages[8];

            // Loads aliases from JSON
            loadAliases();
            // Refreshes the list of identified devices
            refreshClick();

            // Load banner
            drawBanner();

            notification.Show();

            if (splashScreen.IsAlive)
                splashScreen.Abort();
            this.TopMost = true; this.TopMost = false;
        }

        /// <summary>
        /// Function for what to do when form is closed
        /// </summary>
        /// <param name="sender">Sending events</param>
        /// <param name="e">Event arguements</param>

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveAliases(); // Save the aliases and exit
        }

        /// <summary>
        /// Function for what to do when form is resized
        /// </summary>
        /// <param name="sender">Sending event</param>
        /// <param name="e">Arguements</param>

        private void frmMain_ResizeEnd(object sender, EventArgs e)
        {
            // Redraw the banner when resized
            drawBanner();
        }

        /// <summary>
        /// Function for what to do on each tick of the tmrUpdate set at 1000ms interval
        /// </summary>
        /// <param name="sender">Sending events</param>
        /// <param name="e">Event arguements</param>

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            // If the scan has been going for more than 5 seconds, we force stop
            // and say that no device is connected
            if (scanStart && (DateTime.Now.Subtract(lastScan).TotalSeconds > 5))
            {
                refreshList();

                deviceListUpdate = false;
                scanStart = false;
                this.Enabled = true;
                tstProgress.Visible = false;
                btnRefresh.Enabled = true;
                Cursor = Cursors.Default;
                loadingScreen.Hide();
                enableControls(false);
                //frmMessage messageForm = new frmMessage(this.Text, "No Devices connected, please check and try again.", loadedImages[7]);
                //messageForm.ShowDialog(this);
            }

            if ((DateTime.Now.Subtract(lastScan).TotalSeconds > 30) && (activePanels.Count == 0))
            {
                refreshClick();
            }

            // If the device list is updated, we refresh the list box and update the interface
            if (deviceListUpdate)
            {
                refreshList();

                deviceListUpdate = false;
                scanStart = false;
                this.Enabled = true;
                tstProgress.Visible = false;
                btnRefresh.Enabled = true;
                lsbDevices.Enabled = true;
                Cursor = Cursors.Default;
                loadingScreen.Hide();
            }

            // If the device status updated to be online, yet the status label says offline,
            // we update it
            if (deviceStatus && (tstStatus.Text != "Online"))
            {
                tstStatus.Image = loadedImages[2];
                tstStatus.Text = "Online";
                lblNoDevice.Visible = false;
                enableControls(true);
            }

            if (!deviceStatus && (tstStatus.Text == "Online"))
            {
                tstStatus.Image = loadedImages[1];
                tstStatus.Text = "Offline";
                enableControls(false);
            }

            // If no items are selected, we hide status info
            if (lsbDevices.Items.Count == 0)
            {
                tstStatus.Text = "";
                tstStatus.Image = null;
                lblNoDevice.Visible = true;
                enableControls(false);
            }

            tstTime.Text = "   " + DateTime.Now.ToString("t") + "   ";
        }

        /// <summary>
        /// Function for what to do when refresh button is clicked
        /// </summary>
        /// <param name="sender">Sending events</param>
        /// <param name="e">Event arguements</param>

        ///////////

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // We need to make sure that the active panels are closed in case that device has gone
            // offline. Otherwise you refresh the list
            // NOTE: Might have to work on this!!!!!
            if (activePanels.Count > 0)
            {
                frmMessage warning = new frmMessage(this.Text, "There are active panels currently running. Please close them to refresh the device list.", loadedImages[3], this.Icon);
                warning.ShowDialog(this);
            }
            else
            {
                refreshClick();
            }
        }

        /// <summary>
        /// Function for what to do when the selected index of the device list is changed
        /// </summary>
        /// <param name="sender">Sending events</param>
        /// <param name="e">Event arguements</param>

        private void lsbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            // We make sure that the number of items selected is one so that
            // buttons can be enabled
            if (lsbDevices.SelectedItems.Count == 1)
            {
                // Interface update
                tstStatus.Image = loadedImages[1];
                tstStatus.Text = "Offline";
                enableControls(false);

                // Loads the port from port list and send 'update:' message to check
                // if device is one of our devices. NOTE: Check frmDevice for information
                // on the commands
                SerialPort port = new System.IO.Ports.SerialPort(devices[lsbDevices.SelectedIndex][3], 9600);
                sendData(port, "update:");
            }
        }

        /// <summary>
        /// Function for what to do when device list is enabled
        /// </summary>
        /// <param name="sender">Sending events</param>
        /// <param name="e">Event arguements</param>

        private void lsbDevices_EnabledChanged(object sender, EventArgs e)
        {
            // If the number of selected items in the device list is none,
            // we update the interface
            btnConnect.Enabled = lsbDevices.Enabled;
            btnRename.Enabled = lsbDevices.Enabled;

            if (lsbDevices.SelectedIndices.Count == 0)
            {
                tstStatus.Image = null;
                tstStatus.Text = "";
                deviceStatus = false;
                enableControls(false);
            }
        }

        /// <summary>
        /// Function for what to do when connect button is clicked
        /// </summary>
        /// <param name="sender">Sending events</param>
        /// <param name="e">Event arguements</param>

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (lsbDevices.SelectedItems.Count > 0)
            {
                // If the connect button is clicked, then we create a new device form for it
                // and load it to the activePanels list
                activePanels.Add(lsbDevices.SelectedIndex,
                                 new frmDevice(this,
                                               lsbDevices.SelectedIndex,
                                               lsbDevices.SelectedItem.ToString(),
                                               new System.IO.Ports.SerialPort(
                                                        devices[lsbDevices.SelectedIndex][3],
                                                        9600)));

                // Also loads the panel and enables the controls
                activePanels[lsbDevices.SelectedIndex].Show();
                enableControls(true);
            }
        }

        /// <summary>
        /// Function for what to do when rename button is clicked
        /// </summary>
        /// <param name="sender">Sending events</param>
        /// <param name="e">Event arguements</param>

        private void btnRename_Click(object sender, EventArgs e)
        {
            // Shows the editAlias form to edit the alias name
            frmAlias editAlias = new frmAlias(this,
                                              devices[lsbDevices.SelectedIndex][0],
                                              lsbDevices.SelectedItem.ToString());
            editAlias.ShowDialog();

            // Refreshes the list to load new name
            refreshList();
        }

        /// <summary>
        /// Function to call when graph button is clicked
        /// </summary>
        /// <param name="sender">Sending event</param>
        /// <param name="e">Event agruements</param>

        private void btnGraph_Click(object sender, EventArgs e)
        {
            // Open graph form
            frmGraph graph = new frmGraph(this.Text, this.Icon);
            graph.Show();
        }

        /// <summary>
        /// Function to handle when logo is clicked
        /// </summary>
        /// <param name="sender">Sending event</param>
        /// <param name="e">Event arguements</param>

        private void pcbSystem_Click(object sender, EventArgs e)
        {
            // Show about form
            frmAbout about = new frmAbout(this.Text, this.Icon);
            about.ShowDialog();
        }

        ////////////////////////////////////////////////////////////////////////////////
        /// General functions

        /// <summary>
        /// Function that refreshes the device list
        /// </summary>

        private void refreshClick()
        {
            lastScan = DateTime.Now; // Update the last scan time
            scanStart = true; // Flag that a scan has started

            // Show the loading screen NOTE: See if this can be removed
            //loadingScreen.changeString(this.Text, "Scanning...");
            //loadingScreen.Show(this);
            btnRefresh.Enabled = false;
            tstProgress.Visible = true;
            tstStatus.Text = "";
            tstStatus.Image = loadedImages[4];
            Cursor = Cursors.AppStarting;
            lsbDevices.Enabled = false;

            // Update the interface
            //this.Enabled = false;
            devices.Clear();

            // Function to load devices
            loadDevices();
        }

        /// <summary>
        /// Function that loads the device list
        /// </summary>

        private void loadDevices()
        {
            string[] ports = SerialPort.GetPortNames(); // Loads all the available ports

            // For each port available, we send 'deviceInfo:' command to check if the
            // device is ours.
            foreach (string portName in ports)
            {
                try
                {
                    SerialPort port = new System.IO.Ports.SerialPort(portName, 9600);

                    if (!port.IsOpen)
                    {
                        port.Open();
                        port.DataReceived += new SerialDataReceivedEventHandler(DataRecieved);
                        sendData(port, "deviceInfo:");
                    }
                } catch { }
            }
        }

        /// <summary>
        /// Function to refresh the names of the list. This does not load
        /// the devices, this update alias names
        /// </summary>

        private void refreshList()
        {
            lsbDevices.Items.Clear(); // Clear the device list
            lblNoDevice.Visible = (devices.Count == 0);

            foreach (String[] item in devices)
            {
                // For each item we found and added to the devices list, we either
                // add the alias name (If available), or the device ID to the list
                if (aliases.Keys.Contains(item[0]))
                {
                    lsbDevices.Items.Add(aliases[item[0]]);
                } else
                {
                    lsbDevices.Items.Add(item[0]);
                }
            }
        }

        /// <summary>
        /// Function to handle sending of data to the device.
        /// </summary>
        /// <param name="port">Port to send data to</param>
        /// <param name="data">String that include the data to be sent</param>
        /// <returns>Progress 0-Success -1-Failed</returns>
        
        private int sendData(SerialPort port, string data)
        {
            try
            {
                // If the device is not open, we open it
                if (!port.IsOpen)
                {
                    port.Open();
                    port.DataReceived += new SerialDataReceivedEventHandler(DataRecieved);
                }

                // Writes the data to the port
                port.WriteTimeout = 100;
                port.ReadTimeout = 1000;
                port.Write(data);
                
                return 0;
            }
            catch (Exception)
            {
                if (lsbDevices.SelectedItems.Count > 0)
                    notification.notification(0, "Could not connect to:\n    " + lsbDevices.SelectedItem.ToString() + ".\nPlease disconnect and reconnect the device.");
                return -1;
            }
        }

        /// <summary>
        /// Function to handle the recieved data when the PC recieve data from the device.
        /// NOTE: This function is async and runs on a different thread. So we cannot
        /// access classes/variables in parent thread.
        /// </summary>
        /// <param name="sender">Sending entity</param>
        /// <param name="e">Event arguements</param>

        private void DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            // Identify the sending port and read the data
            SerialPort prt = (SerialPort)sender;
            string data = prt.ReadLine();

            try
            {
                // Separating the command from parameter
                string command = data.Substring(0, data.IndexOf(':'));
                string parameter = data.Substring(data.IndexOf(':') + 1);

                // If we recieve the 'deviceInfo:' back, we know that this device is ours, so
                // we parse the JSON and add that to the device list. We also note that the device
                // list is updated by setting the flag
                if (command == "deviceInfo")
                {
                    var valuesDict = JsonSerializer.Deserialize<Dictionary<string, string>>(parameter);

                    if (valuesDict["name"] == "Fire Alarm model")
                    {
                        String[] parameters = { valuesDict["id"], "", valuesDict["version"], prt.PortName };
                        devices.Add(parameters);
                        deviceListUpdate = true;
                    }

                    frmLoading loading = new frmLoading();
                    System.Threading.Thread.Sleep(2000);
                    loading.Hide();
                    //frmMessage messageForm = new frmMessage(this.Text, "Device identified on " + prt.PortName, loadedImages[9], this.Icon);
                    //messageForm.ShowDialog();
                }
                // If we recieve the 'update:' back, we know that the device is online, so we
                // update the flag to note that device is online
                else if (command == "update")
                {
                    frmLoading loading = new frmLoading();
                    System.Threading.Thread.Sleep(2000);
                    loading.Hide();
                    //frmMessage messageForm = new frmMessage(this.Text, prt.PortName + " is ready.", loadedImages[9], this.Icon);
                    //messageForm.ShowDialog();

                    deviceStatus = true;
                }
            }
            catch (Exception) { }

            // Closing the port
            prt.Close();
            prt.Dispose();
        }

        /// <summary>
        /// Loading alias data from the JSON file
        /// </summary>

        private void loadAliases()
        {
            try
            {
                // Read the aliases file and parse the JSON and add it to the aliases
                string text = System.IO.File.ReadAllText(APPDATALOCATION +"/aliases.json");
                aliases = JsonSerializer.Deserialize<Dictionary<string, string>>(text);
            } catch (Exception) { }
        }

        /// <summary>
        /// Saves the aliases to the file back
        /// </summary>

        private void saveAliases()
        {
            try
            {
                // Serializes the aliases to JSON and store it to the file
                string text = JsonSerializer.Serialize(aliases);
                System.IO.File.WriteAllText(APPDATALOCATION + "/aliases.json", text);
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Rename an existing alias to another name
        /// </summary>
        /// <param name="text"></param>

        public void renameAlias(string text)
        {
            // Changes the text to new text
            try { aliases[devices[lsbDevices.SelectedIndex][0]] = text; } catch
            {
                frmMessage message = new frmMessage(this.Text, "Could not rename the device. Please try again later.", loadedImages[3], this.Icon);
                message.ShowDialog();
            }
        }

        /// <summary>
        /// Deletes an alias from the list
        /// </summary>

        public void deleteAlias()
        {
            // Remove the item from list
            try { aliases.Remove(devices[lsbDevices.SelectedIndex][0]); }
            catch
            {
                frmMessage message = new frmMessage(this.Text, "Could not rename the device. Please try again later.", loadedImages[3], this.Icon);
                message.ShowDialog();
            }
        }

        /// <summary>
        /// Enables/Disables the controls on the form
        /// </summary>
        /// <param name="value">Enable or disable in bool</param>

        private void enableControls(bool value)
        {
            // If we have an active panel, we do not enable the button
            if (activePanels.ContainsKey(lsbDevices.SelectedIndex))
            {
                btnConnect.Enabled = false;
            }
            else
            {
                btnConnect.Enabled = value;
            }
            btnRename.Enabled = value;
        }

        /// <summary>
        /// Closes the panel. This function is accessed from the device panel
        /// </summary>
        /// <param name="index">Index of the active device</param>

        public void closePanel(int index)
        {
            // Remove it from active panels and update interface
            activePanels.Remove(index);
            enableControls(true);
        }

        /// <summary>
        /// Used to get the selected item of the lsbDevices panel
        /// NOTE: This is used by a child form, thus the public visibility
        /// </summary>
        /// <returns>ID as Integer</returns>

        public int getLSBSelected()
        {
            return lsbDevices.SelectedIndex;
        }

        /// <summary>
        /// Draws the banner on the banner
        /// </summary>

        public void drawBanner()
        {
            // Creating the canvas
            Bitmap BitmapImage = new Bitmap(pcbSystem.Size.Width, pcbSystem.Size.Height,
                                System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            Graphics GraphicsFromImage = Graphics.FromImage(BitmapImage);

            // Loading banner

            Image banner = Image.FromFile("assets/banner.png");

            int height = BitmapImage.Size.Height;
            int width = (BitmapImage.Size.Height * banner.Size.Width) / banner.Size.Height;

            GraphicsFromImage.DrawImage(banner, 0, 0, width, height);

            // Loading info icon

            GraphicsFromImage.DrawImage(loadedImages[9], BitmapImage.Size.Width - 40, 10, 30, 30);

            // Applying to the banner

            pcbSystem.Image = BitmapImage;
        }

        /// <summary>
        /// Handles keyboard commands
        /// </summary>
        /// <param name="sender">Sending event</param>
        /// <param name="e">Event agruements</param>

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F5)
                btnRefresh.PerformClick(); // Refresh

            if (e.Control && e.KeyCode == Keys.G)
                btnGraph.PerformClick(); //Graph

            if (e.Control && e.KeyCode == Keys.C)
                btnConnect.PerformClick(); // Connect

            if (e.Control && e.KeyCode == Keys.R)
                btnRename.PerformClick(); // Rename

            if (e.Control && e.KeyCode == Keys.Down && (lsbDevices.SelectedIndex < lsbDevices.Items.Count - 1))
                lsbDevices.SelectedIndex += 1; // Select below

            if (e.Control && e.KeyCode == Keys.Up && (lsbDevices.SelectedIndex > 0))
                lsbDevices.SelectedIndex -= 1; // Select above

            if (e.Control && e.KeyCode == Keys.Q)
            {
                // Exit
                DialogResult result = MessageBox.Show("Are you sure you want to quit " + this.Text + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning); // Select above
                if (result == DialogResult.Yes)
                    Application.Exit();
            }

            if (e.KeyCode == Keys.F1)
            {
                // Show about form
                frmAbout about = new frmAbout(this.Text, this.Icon); about.ShowDialog();
            }
        }
    }
}

/*
 *                    ---- REFERENCE NOTES ----
 *                    
 *  01. ALIASES ----------------------------------------------
 *      Aliases are reference names given to devices to make it easy to identify them.
 *      They can be set to coin with the device IDs so that it's easy give custom
 *      names to the devices. These are saved in the file 'aliases'. This can be loaded
 *      and saved back to update the aliases the user have currently set.
 */