/*
 *                      SHOWS A LOADING ANIMATION
 *                      
 *       This form displays a loading animation
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
    public partial class frmLoading : Form
    {

        /// <summary>
        ///  frmLoading handle loading of the image
        /// </summary>

        public frmLoading()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function called by parent to change the text in this form
        /// </summary>
        /// <param name="title">Title to which to change</param>
        /// <param name="text">Text to be shown</param>

        public void changeString(string title, string text, Icon icon)
        {
            this.Text = title;
            lblLoading.Text = text;
            this.Icon = icon;
        }
    }
}
