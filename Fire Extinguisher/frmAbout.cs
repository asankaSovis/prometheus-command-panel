/*
 *                    ABOUT & SETTINGS FORM
 *                      
 *       This form displays the about information and settings
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
    public partial class frmAbout : Form
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

        /// <summary>
        /// Displays a form with application information and settngs
        /// </summary>
        /// <param name="title">Title to display on the form</param>
        /// <param name="icon">Icon to be used on the form</param>

        public frmAbout(string title, Icon icon)
        {
            InitializeComponent();

            this.Text = title; this.Icon = icon; // Setting up the form
        }

        ////////////////////////////////////////////////////////////////////
        /// Interface Functions

        /// <summary>
        /// Functions that run when the form is created
        /// </summary>
        /// <param name="sender">Sending entity</param>
        /// <param name="e">Event arguements</param>

        private void frmAbout_Load(object sender, EventArgs e)
        {
            // Loading display information
            pcbBanner.Image = Image.FromFile("assets/about.png");
            lblAbout.Text = System.IO.File.ReadAllText("about.inf");
            txtDataLoc.Text = frmMain.APPDATALOCATION;
        }

        /// <summary>
        /// Function that run when about button is checked
        /// </summary>
        /// <param name="sender">Sending entity</param>
        /// <param name="e">Event Arguements</param>

        private void rdbAbout_CheckedChanged(object sender, EventArgs e)
        {
            switchPanel(); // We call the switchPanel function
        }

        /// <summary>
        /// Function that run when settings button is checked
        /// </summary>
        /// <param name="sender">Sending entity</param>
        /// <param name="e">Event Arguements</param>

        private void rdbSettings_CheckedChanged(object sender, EventArgs e)
        {
            switchPanel(); // We call the switchPanel function
        }

        /// <summary>
        /// Function that run when Close button is clicked
        /// </summary>
        /// <param name="sender">Sending entity</param>
        /// <param name="e">Event Arguements</param>

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }

        /// <summary>
        /// Function that run when Clear Logs button is clicked
        /// </summary>
        /// <param name="sender">Sending entity</param>
        /// <param name="e">Event Arguements</param>

        private void btnLogs_Click(object sender, EventArgs e)
        {
            // We first warn the user and then delete all logs
            DialogResult reply = MessageBox.Show("Warning!\nThis will clear all the log data collected so far. Are you sure?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (reply == DialogResult.Yes)
            {
                try
                {
                    System.IO.Directory.Delete(frmMain.APPDATALOCATION + "/logs");
                    System.IO.Directory.CreateDirectory(frmMain.APPDATALOCATION + "/logs");
                }
                catch (Exception) { MessageBox.Show("An error occured while performing this action.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        /// <summary>
        /// Function that run when Remove Aliases button is clicked
        /// </summary>
        /// <param name="sender">Sending entity</param>
        /// <param name="e">Event Arguements</param>

        private void btnAliases_Click(object sender, EventArgs e)
        {
            // We first warn the user and then delete the aliases file
            DialogResult reply = MessageBox.Show("Warning!\nThis will remove all the aliases created so far. Are you sure?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (reply == DialogResult.Yes)
            {
                try
                {
                    System.IO.Directory.Delete(frmMain.APPDATALOCATION + "/aliases.json");
                    System.IO.File.Create(frmMain.APPDATALOCATION + "/aliases.json");
                }
                catch (Exception) { MessageBox.Show("An error occured while performing this action.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        /// <summary>
        /// Function that run when Export Logs button is clicked
        /// </summary>
        /// <param name="sender">Sending entity</param>
        /// <param name="e">Event Arguements</param>

        private void btnExpLogs_Click(object sender, EventArgs e)
        {
            WorkingOnIt(); // Dislpay a working on it message :)
        }

        /// <summary>
        /// Function that run when Export Aliases button is clicked
        /// </summary>
        /// <param name="sender">Sending entity</param>
        /// <param name="e">Event Arguements</param>

        private void btnExpAlias_Click(object sender, EventArgs e)
        {
            // We first ask the user to select the location and then save the aliases
            // JSON to that place
            sfdAlias.InitialDirectory = txtDataLoc.Text;
            sfdAlias.Title = this.Text;
            DialogResult result = sfdAlias.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    System.IO.File.Copy(frmMain.APPDATALOCATION + "/aliases.json", sfdAlias.FileName);
                    frmMessage messageForm = new frmMessage(this.Text, "List was copied successfully to the location:\n" + sfdAlias.FileName, loadedImages[0], this.Icon);
                    messageForm.ShowDialog();
                }
                catch (Exception) { MessageBox.Show("An error occured while performing this action.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        /// <summary>
        /// Function that run when Data Location button is clicked
        /// </summary>
        /// <param name="sender">Sending entity</param>
        /// <param name="e">Event Arguements</param>

        private void btnDataLoc_Click(object sender, EventArgs e)
        {
            WorkingOnIt(); // We display a working on it message :)
        }

        /// <summary>
        /// Function that switches the panels: About and Settings
        /// </summary>

        private void switchPanel()
        {
            spcAbout.Panel1Collapsed = rdbSettings.Checked;
            spcAbout.Panel2Collapsed = rdbAbout.Checked;
        }

        /// <summary>
        /// Just to display a working on it message for incomplete functions :)
        /// </summary>

        private void WorkingOnIt()
        {
            frmMessage messageForm = new frmMessage(this.Text, "We're working on this feature. Please hang on tight.", loadedImages[9], this.Icon);
            messageForm.ShowDialog();
        }

        /// <summary>
        /// Handles keyboard commands
        /// </summary>
        /// <param name="sender">Sending event</param>
        /// <param name="e">Event agruements</param>

        private void frmAbout_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close(); // Close

            if (e.Control && e.KeyCode == Keys.Left)
                rdbAbout.Checked = true; // About

            if (e.Control && e.KeyCode == Keys.Right)
                rdbSettings.Checked = true;// Settings
        }
    }
}
