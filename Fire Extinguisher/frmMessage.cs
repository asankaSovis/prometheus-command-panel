/*
 *                      HANDLE SHOWING MESSAGES TO USER
 *                      
 *       This form shows messages to the user
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
    public partial class frmMessage : Form
    {

        /// <summary>
        /// frmMessage shows messages to the user
        /// </summary>
        /// <param name="title">Title of the form</param>
        /// <param name="text">Text to be displayed</param>
        /// <param name="icon">Icon to show on form</param>

        public frmMessage(string title, string text, Image icon, Icon myIcon)
        {
            InitializeComponent();

            // Updating interface
            this.Text = title;
            this.Icon = myIcon;
            lblMessage.Text = text;
            pcbIcon.Image = icon;
        }

        /// <summary>
        /// Function to handle when Ok button is clicked
        /// </summary>
        /// <param name="sender">Sending entity</param>
        /// <param name="e">Event arguement</param>

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        /// <summary>
        /// Handles keyboard commands
        /// </summary>
        /// <param name="sender">Sending event</param>
        /// <param name="e">Event agruements</param>

        private void frmMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                this.Close(); // Close
        }
    }
}
