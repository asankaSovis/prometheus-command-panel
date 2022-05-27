/*
 *                    DISPLAYS A NOTIFICATION TO THE USER
 *                      
 *       This form displays the notifications the system sends
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

namespace Fire_Extinguisher
{
    public partial class frmNotification : Form
    {
        // This variable loads the Status image assets
        // 01. Error/Offline | 02. Normal | 03. Warning | 04. Extinguishing | 05. Override | 06. Info
        Image[] statusImages = {
            Image.FromFile("assets/error.png"),
            Image.FromFile("assets/normal.png"),
            Image.FromFile("assets/warning.png"),
            Image.FromFile("assets/extinguish.png"),
            Image.FromFile("assets/override.png"),
            Image.FromFile("assets/info.png")
        };

        // Global variables
        bool show = false; // Whether to show or hide the notification panel
        bool autoOff = false; // Whether to automatically discard the notification
        bool flash = false; // Whether to flash the heading
        DateTime recievedTime = DateTime.Now; // Time at which the last notification is recieved

        // Sound files: warn (Warning), notify (Notification)
        System.Media.SoundPlayer warn = new System.Media.SoundPlayer(Environment.CurrentDirectory + @"\assets\tones\Warning.wav");
        System.Media.SoundPlayer notify = new System.Media.SoundPlayer(Environment.CurrentDirectory + @"\assets\tones\Notification.wav");

        /// <summary>
        /// Form that displays the system notifications
        /// </summary>

        public frmNotification()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function when form is loaded
        /// </summary>
        /// <param name="sender">Sending event</param>
        /// <param name="e">Event arguements</param>

        private void frmNotification_Load(object sender, EventArgs e)
        {
            reposition(); // Reposition the form
        }

        /// <summary>
        /// Functiom when timer register a new click
        /// </summary>
        /// <param name="sender">Sending event</param>
        /// <param name="e">Event arguements</param>

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            // If flash is enabled we flash the heading
            if (flash)
            {
                if (lblHeading.BackColor == Color.IndianRed)
                {
                    lblHeading.BackColor = Color.Transparent; lblHeading.ForeColor = Color.Red;
                }
                else
                {
                    lblHeading.BackColor = Color.IndianRed; lblHeading.ForeColor = Color.White;
                }
            }

            // If show is enabld we animate the window into view
            if ((show) && ((!this.Visible) || (this.Width < 500)))
            {
                this.Width += 200;
                if (this.Width > 500) { this.Width = 500; }

                // We also reposition
                reposition();
            }

            // If show is disabled we animate the window out of view
            if (!show)
            {
                if (this.Size.Width > 0)
                {
                    this.Width -= 200;
                    if (this.Width < 2) { this.Width = 2; }

                    // We also reposition
                    reposition();
                }

                if (this.Width < 5)
                {
                    // We hide and disable timer when window completely disappears
                    hideMe();
                    tmrMain.Enabled = false;
                }
            }

            // If we have autoOff Enabled we hide the form anyway after 5 seconds
            if (autoOff && (DateTime.Now.Subtract(recievedTime).TotalSeconds > 5))
            { show = false; autoOff = false; show = false; lblHeading.BackColor = Color.Transparent; }
        }

        /// <summary>
        /// When heading label is clicked
        /// </summary>
        /// <param name="sender">Sending events</param>
        /// <param name="e">Event arguements</param>

        private void lblHeading_Click(object sender, EventArgs e)
        {
            hide(); // Hide the notification
        }

        /// <summary>
        /// Function when info label is clicked
        /// </summary>
        /// <param name="sender">Sending events</param>
        /// <param name="e">Event arguements</param>

        private void lblInfo_Click(object sender, EventArgs e)
        {
            hide(); // Hide the notification
        }

        /// <summary>
        /// Repositions the form in screen
        /// </summary>

        private void reposition()
        {
            // Move form to bottom right of the screen and set visibility
            this.Location = new Point(
                Screen.PrimaryScreen.WorkingArea.Size.Width - this.Size.Width - 10,
                Screen.PrimaryScreen.WorkingArea.Size.Height - this.Size.Height - 10
            );

            this.Visible = true;
        }

        /// <summary>
        /// Hides the form from view
        /// </summary>

        private void hideMe()
        {
            // Hide the form, set the size to 0 and stop warn sound
            this.Visible = false;
            this.Size = new Size(0, this.Size.Height);
            warn.Stop();
        }

        /// <summary>
        /// Public function called when a form needs to send a notification
        /// 01. 0 - Standard notification
        /// 02. 1 - Device stats normal
        /// 03. 2 - Warning recieved from device
        /// 04. 3 - User overrode warnings
        /// 05. 4 - Device extinguishing
        /// 06. 5 - Device got disconnected
        /// </summary>
        /// <param name="type">Type of notification</param>
        /// <param name="text">Info Text</param>

        public void notification(int type, string text)
        {
            hideMe(); // Hide in case a notification is already active
            show = true; // Enable show
            tmrMain.Enabled = true; // Enable timer
            recievedTime = DateTime.Now; // Reset recieved times
            lblHeading.BackColor = Color.Transparent; // Reset the back colour in case

            if (type == 0) // Standard
            {
                autoOff = true;
                flash = false;
                lblInfo.Text = text;
                lblHeading.Text = "NOTIFICATION   "; lblHeading.ForeColor = Color.SkyBlue;
                notify.Play();
                pcbIcon.Image = statusImages[5];
            }
            else if (type == 1) // Normal
            {
                autoOff = true;
                flash = false;
                lblInfo.Text = text;
                lblHeading.Text = "NORMAL     "; lblHeading.ForeColor = Color.Green;
                notify.Play();
                pcbIcon.Image = statusImages[1];
            }
            else if (type == 2) // Warning
            {
                autoOff = true;
                flash = true;
                lblInfo.Text = text;
                lblHeading.Text = "WARNING  "; lblHeading.ForeColor = Color.Orange;
                warn.PlayLooping();
                pcbIcon.Image = statusImages[2];
            }
            else if (type == 3) // Overridden
            {
                autoOff = true;
                flash = false;
                lblInfo.Text = text;
                lblHeading.Text = "OVERRIDDEN    "; lblHeading.ForeColor = Color.Red;
                notify.Play();
                pcbIcon.Image = statusImages[4];
            }
            else if (type == 4) // Extinguishing
            {
                autoOff = false;
                flash = true;
                lblInfo.Text = text;
                lblHeading.Text = "EXTINGUISHING  "; lblHeading.ForeColor = Color.White;
                warn.PlayLooping();
                pcbIcon.Image = statusImages[3];
            }
            else if (type == 5) // Disconnected
            {
                autoOff = true;
                flash = false;
                lblInfo.Text = text;
                lblHeading.Text = "DISCONNECTED  "; lblHeading.ForeColor = Color.Red;
                warn.Play();
                pcbIcon.Image = statusImages[0];
            }
        }

        /// <summary>
        ///  Public function to hide the notification
        /// </summary>

        public void hide()
        {
            show = false; // Set show to false
        }

        /// <summary>
        /// Update the information text without sending a new notification
        /// </summary>
        /// <param name="text">Text to be displayed</param>

        public void update(string text)
        {
            lblInfo.Text = text; // Set the text
        }
    }
}
