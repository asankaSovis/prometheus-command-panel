/*
 *                    HANDLE ALIAS RELATED THINGS
 *                      
 *       This form handles all tasks related to aliases
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
    public partial class frmAlias : Form
    {
        frmMain parent = null; // Parent of the form
        string name = "";
        string alias = "";

        /// <summary>
        /// This form handles all tasks related to aliases:
        ///     Rename and Deleting
        /// </summary>
        /// <param name="_parent">Parent form that created the form</param>
        /// <param name="_name">ID of the device</param>
        /// <param name="_alias">Currently added alias for the device ("" if not set)</param>

        public frmAlias(frmMain _parent, string _name, string _alias)
        {
            InitializeComponent();

            parent = _parent; name = _name; alias = _alias;

            // Updating interface and setting the parent
            lblName.Text = alias;
            this.Text = parent.Text + " - " + name + " Rename"; this.Icon = parent.Icon;

            // Set the alias in text box
            if (alias == name) { txtName.Text = "My_Device"; } else { txtName.Text = alias; }
        }

        private void frmAlias_Load(object sender, EventArgs e)
        {
            txtName.SelectAll();
        }

        /// <summary>
        /// Function that handle delete button clicks
        /// </summary>
        /// <param name="sender">Sending events</param>
        /// <param name="e">Event arguements</param>

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete the alias from the parent and close the form
            parent.deleteAlias();
            this.Close();
        }

        /// <summary>
        /// Function that handle the apply button clicks
        /// </summary>
        /// <param name="sender">Sending events</param>
        /// <param name="e">Event arguements</param>

        private void btnApply_Click(object sender, EventArgs e)
        {
            // Call rename function in parent and exit
            parent.renameAlias(txtName.Text);
            this.Close();
        }

        /// <summary>
        /// Function that handle the text changes of the txtName textbox
        /// </summary>
        /// <param name="sender">Sending events</param>
        /// <param name="e">Event arguements</param>

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // Disable apply button if there's no text
            btnApply.Enabled = ((txtName.Text.Length != 0) && (txtName.Text != name) && (txtName.Text != alias));
            btnDelete.Enabled = (name != alias);
        }

        /// <summary>
        /// Handles keyboard commands
        /// </summary>
        /// <param name="sender">Sending event</param>
        /// <param name="e">Event agruements</param>


        private void frmAlias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close(); // Close

            if (e.Control && e.KeyCode == Keys.Delete)
                btnDelete.PerformClick(); // Delete

            if (e.KeyData == Keys.Enter)
                btnApply.PerformClick(); // Enter
        }

        /// <summary>
        /// Handles keyboard commands
        /// </summary>
        /// <param name="sender">Sending event</param>
        /// <param name="e">Event agruements</param>

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
                System.Media.SystemSounds.Exclamation.Play();
            }

            if (e.KeyData == Keys.Escape)
                this.Close(); // Close

            if (e.Control && e.KeyCode == Keys.Delete)
                btnDelete.PerformClick(); // Delete

            if (e.KeyData == Keys.Enter)
                btnApply.PerformClick(); // Enter
        }
    }
}
