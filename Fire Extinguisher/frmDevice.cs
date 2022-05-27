/*
 *                      HANDLE A SELECTED DEVICE
 *                      
 *       This form handles all tasks and display information related
 *                      to an extinguisher device.
 *       NOTE: This is not yet complete
 *       NOTE: Some improvements to make:
 *          01. Check if it's important to close the port everytime
 *                  we complete a command
 *          02. Check if chkOverride_Click is important
 *          03. Work on CO2 levels. Find how to interpret the analog
 *                  data got from the atmega
 *          04. Research and find the cap levels for each sensor data
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
    public partial class frmDevice : Form
    {
        // This variable loads the image assets
        // 01. Done | 02. Offline | 03. Online | 04. Error | 05. Refresh
        Image[] loadedImages = { 
            Image.FromFile("assets/done.png"), 
            Image.FromFile("assets/offline.png"), 
            Image.FromFile("assets/online.png"), 
            Image.FromFile("assets/ban.png"), 
            Image.FromFile("assets/refresh.png")
        };

        // This variable loads the Status image assets
        // 01. Error/Offline | 02. Normal | 03. Warning | 04. Extinguishing | 05. Override | 06. Pause | 07. Sync
        Image[] statusImages = { 
            Image.FromFile("assets/error.png"), 
            Image.FromFile("assets/normal.png"), 
            Image.FromFile("assets/warning.png"), 
            Image.FromFile("assets/extinguish.png"), 
            Image.FromFile("assets/override.png"),
            Image.FromFile("assets/pauseb.png"),
            Image.FromFile("assets/syncb.png")
        };

        Image[] syncpause = {
            Image.FromFile("assets/sync.png"), 
            Image.FromFile("assets/pause.png")
        };

        frmMain parent = null; // Variable to hold the parent form
        // Parent is important to control the online/offline status
        int myIndex = 0; // Holds the index of the device in the identified devices
        string myDeviceID = null; // Holds the ID of the device
        // list in the parent form
        string myAlias = ""; // Alias of the device this form is controlling
        SerialPort myDevice = null; // Serial port to which the device is connected

        Tuple<bool, string, DateTime> dataRecieved = new Tuple<bool, string, DateTime>(false, "", DateTime.Now);
        // dataRecieved variable holds data when recieved from the port
        // Tuple of the form (bool, string, DateTime) : (If data is recieved and needs to be parsed,
        //                                               Recieved data, Date/time recieved)

        Dictionary<string, string> deviceInfo = null;
        // deviceInfo variable holds the info about the device that this form is controlling
        // Dictionary of the form "string":"string"
        // {"name":Name of the device,"version":Version of the firmware,"id":Id of the device}
        // ex: {"name":"Fire Alarm model","version":"v0.0","id":"abcd"}

        Dictionary<string, dynamic> update = new Dictionary<string, dynamic>();
        // update variable holds the update recieved. The update holds current information
        // on the device:
        // {"co2":Int CO2 level measured in ppm,"temp":Int Temperature level measured in °C,
        //      "humid":Int Humidity level measured as a percentage,"warning":Bool whether
        //      warning is turned on,"open":Bool whether the valve is open,"override":
        //      Bool whether override is turned on,"userBuzz":Bool whether the user
        //      turned on the buzz,"userValve":Bool whether the user turned on the valve}
        // ex: {"co2":1.11919,"temp":32,"humid":56,"warning":true,"open":true,"override":
        //      true,"userBuzz":false,"userValve":false}

        Dictionary<string, decimal> caps = null;
        // caps hold the warning levels of CO2, Temperature and Humidity set. CO2 level
        // will determine if the valve is open. Both Temperature and Humidity levels will
        // determine if warning is given.
        // {"co2":Int CO2 level to turn on the valve,"temp":Int Temperature level for
        //      warning,"humid":Humidity level for warning}
        // ex: {"co2":1.11919,"temp":32,"humid":56}
        
        bool portBusy = false; // Bool to show if the port is busy
        bool ackRecieved = false; // Bool to show if acknowledgement is recieved by the
        // device
        string sendCommand = ""; // A command is available to be send to the device

        DateTime lastUpdate = DateTime.Now; // This will let us know when we recieved a reply back last

        /// <summary>
        ///  frmDevice handles and shows information about the devices
        ///  connected to the PC.All information are displayed and
        ///  all controls available.
        /// </summary>
        /// <param name="_parent">Parent form that loaded this form</param>
        /// <param name="_myIndex">Holds the index of the device in the identified devices list in the parent form</param>
        /// <param name="_alias">Alias of the device this form is controlling</param>
        /// <param name="_myDevice">Serial port to which the device is connected</param>

        public frmDevice(frmMain _parent, int _myIndex, string _alias, SerialPort _myDevice)
        {
            InitializeComponent();

            // Set globals
            parent = _parent; myIndex = _myIndex; myDevice = _myDevice; myAlias = _alias;

            // Set visual elements
            this.Text = _parent.Text + " - " + _alias;
            this.Icon = parent.Icon;
            pcbLogo.Image = Image.FromFile("assets/logo.png");
            btnGraph.Image = Image.FromFile("assets/graph.png");
            tstNotification.Image = Image.FromFile("assets/notification.png");
            pcbStatus.Image = statusImages[6];

            // Method to handle the data when data is recieved by the PC, also set the write
            // timeout to 100ms
            myDevice.DataReceived += new SerialDataReceivedEventHandler(DataRecieved);
            myDevice.WriteTimeout = 100;
            myDevice.ReadTimeout = 400;

            // Connect to the device
            reconnect();
            chkSync.Checked = false;
            chkSync.BackgroundImage = syncpause[1];
        }

        //////////////////////////////////////////////////////////////////////////////
        /// Interface Functions

        /// <summary>
        /// Function for what to do when the form is closing
        /// </summary>
        /// <param name="sender">Sending entity</param>
        /// <param name="e">Event arguement</param>

        private void frmDevice_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.closePanel(myIndex); // Notifies the parent that this form handing
            // the particular device is closed.

            // Disconnect from device
            myDevice.Close();
            myDevice.Dispose();
        }

        /// <summary>
        /// Function for what to do on each tick of the tmrMain set at 500ms interval
        /// </summary>
        /// <param name="sender">Sending entity</param>
        /// <param name="e">Passed arguements</param>

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            // If we recieved the acknowledgement, we update the interface and mark
            // the port as available.
            if (ackRecieved)
            {
                lblRecieve.Text = "Recieved";
                lblRecieve.Image = loadedImages[0];

                ackRecieved = false;
                portBusy = false;
            }

            if(!chkSync.Checked)
            {
                // If the port is not busy and a command is not in queue, we send the update
                // command with no data, otherwise, we send the command in queue and remove it
                // from queue. If port is busy, we continue on.
                if (!portBusy)
                {
                    if (sendCommand == "")
                    {
                        sendData("update:");
                    }
                    else
                    {
                        sendData(sendCommand);
                        sendCommand = "";
                    }
                }

                // If it's been 10 seconds since, we recieved any data from the device,
                // we reconnect to it. Otherwise we continue to mark the device as online.
                if (DateTime.Now.Subtract(lastUpdate).TotalSeconds > 10)
                {
                    // Interface update
                    //tstStatus.Image = loadedImages[1];
                    //tstStatus.Text = "Offline";
                    if (lblStatus.Text != "Disconnected")
                        frmMain.notification.notification(0, "Device on " + myDevice.PortName + " got disconnected.\n" + "Device: " + lblDeviceName.Text + "\nAttempting to reconnect");

                    lblConn.Text = "Status: Disconnected";
                    lblStatus.Text = "Disconnected";
                    pcbStatus.Image = statusImages[0];

                    // Resetting all information we have
                    if (DateTime.Now.Subtract(dataRecieved.Item3).TotalSeconds > 10)
                    {
                        portBusy = false;
                        dataRecieved = new Tuple<bool, string, DateTime>(false, "", DateTime.Now);
                    }
                    ackRecieved = false;
                    enableWork(false);


                    // Reconnect
                    reconnect();
                }
                else
                {
                    // Interface update
                    tstStatus.Image = loadedImages[2];
                    tstStatus.Text = "Online";
                    enableWork(true);

                    // If the status is disconnected, we update port information again
                    if (lblConn.Text == "Status: Disconnected")
                    {
                        lblConn.Text = "Status: Connected\nPort: " + myDevice.PortName +
                                       "\nBitrate: " + myDevice.BaudRate +
                                       "\nWrite Timeout: " + myDevice.WriteTimeout +
                                       "\nRead Timeout: " + myDevice.ReadTimeout;
                    }
                }

                // If deviceInfo is not null, we have device information recieved from the device,
                // so we update the device information on the interface and clear deviceInfo data.
                if (deviceInfo != null)
                {
                    lblDeviceInfo.Text = deviceInfo["id"] + "\n" + deviceInfo["name"] + "\n" + deviceInfo["version"];
                    myDeviceID = deviceInfo["id"];
                    deviceInfo = null;
                }

                // If caps is not null, we have cap information recieved from the device,
                // so we parse the cap infor and clear the data
                if (caps != null)
                {
                    parseCaps();
                    caps = null;
                }
            }

            // If we have recieved data (First bool item of dataRecieved tuple), we call
            // parseUpdate() function and update interface
            if (dataRecieved.Item1)
            {
                lblRecieve.Text = "[" + DateTime.Now.ToString() + "]    " + dataRecieved.Item2;
                lblRecieve.Image = loadedImages[0];
                txtSend.Text = "";
                btnSend.Enabled = true;

                dataRecieved = new Tuple<bool, string, DateTime>(false, dataRecieved.Item2, dataRecieved.Item3);
                if (dataRecieved.Item2.Contains("initialize:"))
                {
                    portBusy = false;
                    reconnect();
                }
                else
                {
                    parseUpdate();
                }
            }

            // We also mark the time and date on the status bar
            tstDate.Text = DateTime.Now.ToString("hh:mm tt | dd/MM/yyyy");
        }

        /// <summary>
        /// Function to handle clicks of btnSend. This button sends the command in the text box
        /// under the Advanced Controls
        /// </summary>
        /// <param name="sender">Sending entity</param>
        /// <param name="e">Passed arguements</param>

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Set the command entered in the txtSend as a pending command
            sendData(txtSend.Text);
        }

        /// <summary>
        /// Function to handle clicks of btnCaps. This button sends the command to the device
        /// to change the warning values for the sensors.
        /// </summary>
        /// <param name="sender">Sending entity</param>
        /// <param name="e">Arguements passed</param>

        private void btnCaps_Click(object sender, EventArgs e)
        {
            // Sets the send command as the '"setCaps":JSON with cap values"
            sendCommand = "setCaps:{\"co2\":" + nudCO2.Value.ToString() + ",\"temp\":" 
                + nudTemp.Value.ToString() + ",\"humid\":" + nudHumid.Value.ToString() + "}";
        }

        /// <summary>
        /// Function to handle when text is changed in txtSend. This function disables the
        /// send button when the text box is empty.
        /// </summary>
        /// <param name="sender">Sending entity</param>
        /// <param name="e">Arguements passed</param>

        private void txtSend_TextChanged(object sender, EventArgs e)
        {
            btnSend.Enabled = (txtSend.TextLength > 0);
        }

        /// <summary>
        /// Function to handle when chkUserBuzz is checked. We send the command
        /// '"userBuzz":true/false". True/False will be set by whether chkUserBuzz is
        /// checked or not.
        /// </summary>
        /// <param name="sender">Sending entity</param>
        /// <param name="e">Arguements sent</param>

        private void chkUserBuzz_CheckedChanged(object sender, EventArgs e)
        {
            sendCommand = "userBuzz:" + chkUserBuzz.Checked.ToString().ToLower();

            if (chkUserBuzz.Checked)
            {
                frmMain.notification.notification(2, "USER WARNING\nWarning turned on for device on " + myDevice.PortName + "\nDevice Name: " + myAlias);
                chkUserBuzz.BackColor = Color.DarkGoldenrod;
                chkUserBuzz.ForeColor = Color.White;
            }
            else
            {
                frmMain.notification.notification(1, "USER WARNING\nWarning turned off for device on " + myDevice.PortName + "\nDevice Name: " + myAlias);
                chkUserBuzz.BackColor = Color.LemonChiffon;
                chkUserBuzz.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Function to handle when chkUserValve is checked. We send the command
        /// '"userValve":true/false". True/False will be set by whether chkUserValve is
        /// checked or not.
        /// </summary>
        /// <param name="sender">Sending entity</param>
        /// <param name="e">Arguements sent</param>

        private void chkUserValve_CheckedChanged(object sender, EventArgs e)
        {
            sendCommand = "userValve:" + chkUserValve.Checked.ToString().ToLower();

            if (chkUserValve.Checked)
            {
                frmMain.notification.notification(4, "USER VALVE\nValve opened for device on " + myDevice.PortName + "\nDevice Name: " + myAlias);
                chkUserValve.BackColor = Color.CornflowerBlue;
                chkUserValve.ForeColor = Color.White;
            }
            else
            {
                frmMain.notification.notification(1, "USER VALVE\nValve closed for device on " + myDevice.PortName + "\nDevice Name: " + myAlias);
                chkUserValve.BackColor = Color.LightSteelBlue;
                chkUserValve.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Function to handle when chkOverride is checked. We send the command
        /// '"override":true/false". True/False will be set by whether chkOverride is
        /// checked or not.
        /// </summary>
        /// <param name="sender">Sending entity</param>
        /// <param name="e">Arguements sent</param>

        private void chkOverride_CheckedChanged(object sender, EventArgs e)
        {
            sendCommand = "override:" + chkOverride.Checked.ToString().ToLower();

            chkUserBuzz.Enabled = !(chkOverride.Checked);
            chkUserValve.Enabled = !(chkOverride.Checked);

            if (chkOverride.Checked)
            {
                chkOverride.BackColor = Color.Firebrick;
                chkOverride.ForeColor = Color.White;
            }
            else
            {
                chkOverride.BackColor = Color.LightCoral;
                chkOverride.ForeColor = Color.Black;
            }
                
        }

        /// <summary>
        /// Function to handle when chkAdvanced is checked. We show or hide the
        /// advanced panel when the checkbox is checked.
        /// </summary>
        /// <param name="sender">Sending entity</param>
        /// <param name="e">Arguements sent</param>

        private void chkAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            spcMain.Panel2Collapsed = !chkAdvanced.Checked;
        }

        /// <summary>
        /// Open about form when logo is clicked
        /// </summary>
        /// <param name="sender">Sending event</param>
        /// <param name="e">Event arguements</param>

        private void pcbLogo_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout(parent.Text, parent.Icon);
            about.ShowDialog();
        }

        //////////////////////////
        ///NOTE: Check if this function is important

        private void chkOverride_Click(object sender, EventArgs e)
        {
            //sendCommand = "override:" + chkOverride.Checked.ToString().ToLower();
        }

        ////////////////////////////////////////////////////////////////////////////////
        /// General functions

        /// <summary>
        /// Function that does all procedures needed to connect to the device. This also
        /// act as the method to reconnect to the device.
        /// </summary>

        private void reconnect()
        {
            // Setting indicators
            tstStatus.Image = loadedImages[1];
            tstStatus.Text = "Offline";
            lblDeviceName.Text = myAlias;

            if (!portBusy)
            {
                sendData("deviceInfo:"); // Send 'deviceInfo:' to the port. This, if device recieved
                                         // will return 'deviceInfo:{JSON with device info}'. We can use this to identify that
                                         // the device is connected.
            }
        }

        /// <summary>
        /// Function to handle sending of data to the device.
        /// </summary>
        /// <param name="data">String that include the data to be sent</param>
        /// <returns>Progress 0-Success -1-Failed</returns>

        private int sendData(string data)
        {
            portBusy = true; // Marks the port as busy by the portBusy variable
            
            // Visual indicators
            lblRecieve.Image = loadedImages[4];
            btnSend.Enabled = false;

            try
            {
                // If the device is not open, we open it
                if (!myDevice.IsOpen)
                {
                    myDevice.Open();
                }

                // Writes the data to the port
                myDevice.WriteLine(data);

                return 0;
            }
            catch (Exception)
            {
                // Visual indicators if failed
                lblRecieve.Image = loadedImages[3];
                lblRecieve.Text = "Sending failed";
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
            try
            {
                // Identify the sending port and read the data
                SerialPort prt = (SerialPort)sender;
                string data = prt.ReadLine();
                lastUpdate = DateTime.Now;
                // Separating the command from parameter
                string command = data.Substring(0, data.IndexOf(':'));
                string parameter = data.Substring(data.IndexOf(':') + 1);

                // 'ack' identifies that the device acknowledges the recieved data.
                // This can be used to identify when the port is ready to accept data again.
                if (command == "ack")
                {
                    // 'ack' can come with parameters if the command was to accept data
                    // FROM PC TO DEVICE, not DEVICE TO PC. In that case ack doesn't carry
                    // any data.
                    // NOTE: For communication information, please refer notes at the end
                    // of the file
                    if (parameter.Contains("setCaps"))
                    {
                        // If setCaps was acked, we send getCaps command to confirm that
                        // data is set correctly.
                        sendCommand = "getCaps:";
                    }

                    // Mark that we recieved ack to note that port is open for data
                    // NOTE: Check if closing the port is important
                    ackRecieved = true;

                    prt.Close();
                    prt.Dispose();
                }
                else if (command != "")
                {
                    // If the command is not empty (Error) or ack, then the device is returning
                    // data to the PC> So we send the command and data (After parsing to JSON)
                    // to the parseData() function.
                    dataRecieved = new Tuple<bool, string, DateTime>(true, data, DateTime.Now);
                    parseData(command, parameter);
                }

            }
            catch (Exception) { }
        }

        /// <summary>
        /// Function to handle the data recieved by the dataRecieved function. Here,
        /// data is parsed to JSON and required steps are taken.
        /// </summary>
        /// <param name="command">String command</param>
        /// <param name="data">String data</param>

        private void parseData(string command, string data)
        {
            try
            {
                if (command == "deviceInfo")
                {
                    // Device has returned its device info. We need to send back the getCaps command
                    // to update the cap values next
                    deviceInfo = JsonSerializer.Deserialize<Dictionary<string, string>>(data);
                    sendCommand = "getCaps:";
                }
                else if (command == "getCaps")
                {
                    // Device has returned the cap levels set in the device
                    caps = JsonSerializer.Deserialize<Dictionary<string, decimal>>(data);
                }
                else if (command == "update")
                {
                    // Device has returned updated data from the device
                    update = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(data);
                }
                else if (command.Contains("initialize:"))
                {
                    dataRecieved = new Tuple<bool, string, DateTime>(true, "initialize:", DateTime.Now);
                }

                writeToLog(command + ":" + data);
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Function to update the update data from the device:
        /// {"co2":Int CO2 level measured in ppm,"temp":Int Temperature level measured in °C,
        ///      "humid":Int Humidity level measured as a percentage,"warning":Bool whether
        ///      warning is turned on,"open":Bool whether the valve is open,"override":
        ///      Bool whether override is turned on,"userBuzz":Bool whether the user
        ///      turned on the buzz,"userValve":Bool whether the user turned on the valve}
        /// ex: {"co2":1.11919,"temp":32,"humid":56,"warning":true,"open":true,"override":
        ///      true,"userBuzz":false,"userValve":false}
        /// </summary>

        private void parseUpdate()
        {
            try
            {
                // Parsing the CO2, Temperature, Humidity levels
                decimal co2 = decimal.Parse(Convert.ToString(update["co2"]));
                decimal temp = decimal.Parse(Convert.ToString(update["temp"]));
                decimal humid = decimal.Parse(Convert.ToString(update["humid"]));

                // Setting the update data
                lblCO2.Text = Decimal.Round(co2, 2).ToString() + " PPM";
                lblTemp.Text = temp.ToString() + " °C";
                lblHumid.Text = humid.ToString() + " %";

                string stats = "device: " + lblDeviceName.Text + "\nReadings: " + lblCO2.Text + " | " + lblTemp.Text + " | " + lblHumid.Text;

                // Setting the status data
                if (Convert.ToString(update["override"]) == "True")
                {
                    if (lblStatus.Text != "Overridden")
                        frmMain.notification.notification(3, "Warnings of the device on " + myDevice.PortName + " overridden\n" + stats);
                    else
                        frmMain.notification.update("Warnings of the device on " + myDevice.PortName + " overridden\n" + stats);
                    lblStatus.Text = "Overridden";
                    pcbStatus.Image = statusImages[4];
                }
                else if (Convert.ToString(update["open"]) == "True")
                {
                    if (lblStatus.Text != "Extinguishing")
                        frmMain.notification.notification(4, "Device on " + myDevice.PortName + " is extinguishing\n" + stats);
                    else
                        frmMain.notification.update("Device on " + myDevice.PortName + " is extinguishing\n" + stats);
                    lblStatus.Text = "Extinguishing";
                    pcbStatus.Image = statusImages[3];
                }
                else if (Convert.ToString(update["warning"]) == "True")
                {
                    if (lblStatus.Text != "Warning")
                        frmMain.notification.notification(2, "Device on " + myDevice.PortName + " has issued a warning\n" + stats);
                    else
                        frmMain.notification.update("Device on " + myDevice.PortName + " has issued a warning\n" + stats);
                    lblStatus.Text = "Warning";
                    pcbStatus.Image = statusImages[2];
                }
                else
                {
                    if (lblStatus.Text != "Normal")
                        frmMain.notification.notification(1, "Device on " + myDevice.PortName + " issued a notification\n" + stats);
                    else
                        frmMain.notification.update("Device on " + myDevice.PortName + " issued a notification\n" + stats);
                    lblStatus.Text = "Normal";
                    pcbStatus.Image = statusImages[1];
                }

                // Colouring the labels to indicate warnings
                if (co2 > nudCO2.Value) { lblCO2.ForeColor = Color.Red; }
                else { lblCO2.ForeColor = Color.Green; };
                if (temp > nudTemp.Value) { lblTemp.ForeColor = Color.Red; }
                else { lblTemp.ForeColor = Color.Green; };
                if (humid < nudHumid.Value) { lblHumid.ForeColor = Color.Red; }
                else { lblHumid.ForeColor = Color.Green; };

                // Visualizing the CO2, Temperature, Humidity levels
                // NOTE: Work on CO2 levels
                pcbCO2.Image = drawLevel(0, 2000, co2, nudCO2.Value);
                pcbTemp.Image = drawLevel(-40, 125, temp, nudTemp.Value);
                pcbHumid.Image = drawLevel(0, 100, humid, nudHumid.Value, true);
            } catch (Exception) { }
        }

        /// <summary>
        /// Function to parse the cap levels sent by the device:
        /// {"co2":Int CO2 level to turn on the valve,"temp":Int Temperature level for
        ///      warning,"humid":Humidity level for warning}
        /// ex: {"co2":1.11919,"temp":32,"humid":56}
        /// </summary>

        private void parseCaps()
        {
            try
            {
                // Parsing Cap values and storing it in the numeric inputs
                nudCO2.Value = decimal.Parse(Convert.ToString(caps["co2"]));
                nudTemp.Value = decimal.Parse(Convert.ToString(caps["temp"]));
                nudHumid.Value = decimal.Parse(Convert.ToString(caps["humid"]));

                btnCaps.BackColor = SystemColors.Control;
            }
            catch(Exception) { }
        }

        /// <summary>
        /// Function to draw the levels for CO2, Temperature and Humidity
        /// </summary>
        /// <param name="min">Minimum value of the data</param>
        /// <param name="max">Maximum value of the data</param>
        /// <param name="value">Value sent by the device</param>
        /// <param name="cap">Cap set as the tolerance level</param>
        /// <param name="oppose">Notify if the cap is from above or below</param>
        /// <returns>Returns the image to be set in the respective visualization for picturebox as Image</returns>

        private Image drawLevel(decimal min, decimal max, decimal value, decimal cap, Boolean oppose = false)
        {
            // Remapping values to the min max levels of the picturebox using the remap function
            decimal newValue = remap(max - value, min, max, 20, pcbCO2.Size.Height - 20);
            decimal capValue = remap(max - cap, min, max, 20, pcbCO2.Size.Height - 20);

            // Setting up the brush according to if the cap is passed
            Brush paintBrush = null;
            if ((value > cap) ^ oppose) { paintBrush = Brushes.IndianRed; } else { paintBrush = Brushes.DarkSeaGreen; }

            // Identifying the width and height for the indicator
            float width = pcbCO2.Size.Width - 40; float height = pcbCO2.Size.Height - 40;

            // Setting up the image and bitmap
            Bitmap BitmapImage = new Bitmap(pcbCO2.Size.Width, pcbCO2.Size.Height,
                                            System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            Graphics GraphicsFromImage = Graphics.FromImage(BitmapImage);

            // Drawing--------------------------------------------------------------------------------------------
            // Base shape
            GraphicsFromImage.FillRectangle(Brushes.AntiqueWhite, 20, 20, width, height);
            // Marking the level
            GraphicsFromImage.FillRectangle(paintBrush, 20, (float)newValue, width, height - (float)newValue + 20);
            // Marking the cap position
            GraphicsFromImage.DrawLine(new Pen(Brushes.DarkRed, 3), 20, (float)capValue, width + 20, (float)capValue);
            // Drawing border
            GraphicsFromImage.DrawRectangle(new Pen(paintBrush, 3), 20, 20, width, height);

            return BitmapImage;
        }

        /// <summary>
        /// Function to remap the value from one range to another
        /// </summary>
        /// <param name="value">The original value as decimal</param>
        /// <param name="from1">Min value of original range as decimal</param>
        /// <param name="to1">Max value of original range as decimal</param>
        /// <param name="from2">Min value of new range as decimal</param>
        /// <param name="to2">Max value of new range as decimal</param>
        /// <returns>Returns decimal value of new value as decimal</returns>

        private decimal remap(decimal value, decimal from1, decimal to1, decimal from2, decimal to2)
        {
            return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
        }

        /// <summary>
        /// Writes the recieved data to a log file
        /// </summary>
        /// <param name="line">Text to be logged</param>

        private void writeToLog(string line)
        {
            try
            {
                if (myDeviceID != null)
                {
                    System.IO.StreamWriter writer = new System.IO.StreamWriter(frmMain.APPDATALOCATION + "/logs/" + DateTime.Now.ToString("dd-MM-yyyy") + " " + myDeviceID + ".log", true);
                    writer.WriteLine("[" + DateTime.Now.ToString() + "] " + line);
                    writer.Close();
                    writer.Dispose();
                }
            } catch (Exception) { }
        }

        /// <summary>
        /// All three of these are to notify the user that the defaults have been changed
        /// and that they must hit the Apply button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void nudCO2_ValueChanged(object sender, EventArgs e)
        {
            btnCaps.BackColor = Color.LightCoral;
        }

        private void nudTemp_ValueChanged(object sender, EventArgs e)
        {
            btnCaps.BackColor = Color.LightCoral;
        }

        private void nudHumid_ValueChanged(object sender, EventArgs e)
        {
            btnCaps.BackColor = Color.LightCoral;
        }

        /// <summary>
        /// Displays the graphs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnGraph_Click(object sender, EventArgs e)
        {
            frmGraph graph = new frmGraph(parent.Text, parent.Icon, myDeviceID);
            graph.Show();
        }

        /// <summary>
        /// Turns on or off the command items in case the device get disconnected
        /// </summary>
        /// <param name="enable">On or off</param>

        private void enableWork(Boolean enable)
        {
            txtSend.Enabled = btnSend.Enabled = enable;
            btnCaps.Enabled = btnCapDefaults.Enabled = enable;
            nudCO2.Enabled = nudHumid.Enabled = nudTemp.Enabled = enable;
            chkAdvanced.Enabled = chkOverride.Enabled = chkUserBuzz.Enabled = chkUserValve.Enabled = enable;
        }

        /////////////////////////////////////////////////
        ///NOTE: Need fixing

        /// <summary>
        /// Reloads the default cap values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCapDefaults_Click(object sender, EventArgs e)
        {
            sendCommand = "getCaps:";
        }

        /// <summary>
        /// Handles keyboard commands
        /// </summary>
        /// <param name="sender">Sending event</param>
        /// <param name="e">Event agruements</param>

        private void frmDevice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close(); // Close

            if (e.KeyData == Keys.F1)
            {
                // Show about
                frmAbout about = new frmAbout(parent.Text, parent.Icon);
                about.ShowDialog();
            }

            if (e.Control && e.KeyCode == Keys.O)
                chkOverride.Checked = !chkOverride.Checked; // Override

            if (e.Control && e.KeyCode == Keys.B)
                chkUserBuzz.Checked = !chkUserBuzz.Checked; // Buzz

            if (e.Control && e.KeyCode == Keys.V)
                chkUserValve.Checked = !chkUserValve.Checked; // Valve

            if (e.Control && e.KeyCode == Keys.G)
                btnGraph.PerformClick(); // Graph
        }

        private void tstNotification_Click(object sender, EventArgs e)
        {
            frmMain.notification.notification(10, "");
        }

        private void chkSync_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSync.Checked)
            {
                chkSync.BackgroundImage = syncpause[1];
                pcbStatus.Image = statusImages[5];
                lblStatus.Text = "Sync Paused...";
                tstStatus.Text = "Sync Paused...";
                tstStatus.Image = syncpause[1];
            }
            else
            { 
                chkSync.BackgroundImage = syncpause[0];
            }
        }

        private void txtSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
            }
        }
    }
}

/*
 *                    ---- REFERENCE NOTES ----
 *                    
 *  01. COMMUNICATION INFORMATION --------------------------
 *      Communication is done by serial print statements in both ends. Serial data is a string and
 *      is structured in JSON format for ease and is encoded and decoded at both ends. A typical
 *      serial data stream is of the form:
 *              <command>:<JSON data>
 *      Command is a single command (ex: deviceInfo, ack, getCaps) while JSON data is a dictionary of
 *      data structured in JSON format. Always, a command is issued by the PC and the device accepts it
 *      and returns data or acknowledgement.
 *      
 *      Communication happens as follows:
 *          01. The PC sends the command as '<command>:' (ex: getCaps:, setCaps:, update:). This step
 *              will also contain data as '<command>:<JSON data>' if the command is to send data to
 *              the device.
 *          02. The device returns the data for the command as '<command>:<JSON data>'. This step
 *              is only performed if the command is a command to retrieve data. In case of a
 *              data sending command, this message will not be recieved.
 *          o3. The device also sends an 'ack:<command>' message to acknowledge that the command is handled.
 *              This can be used to know that the command was executed successfully and we can use
 *              the port to send more data.
 *              
 *  02. SENSOR DATA-------------------------------------------
 *      The device measures three sensing data: CO2, Temperature and Humidity. CO2 is measured in
 *      ????????????, Temperature in Degree celsius °C and Humidity as a percentage. These values
 *      are processed to determine the threat and also sent back to the PC for the user.
 *              
 *  02. WARNING LEVELS ---------------------------------------
 *      NOTE: This is also called cap and threshold levels within the project.
 *      This defines levels for each sensing: CO2, Temperature and Humidity. Once the level is
 *      passed, relevant action is taken.
 *      NOTE: The three cap levels have to be researched.
 */