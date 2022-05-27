/*
 *                    SPLASH SCREEN
 *                      
 *       This form displays a splash screen
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
    public partial class frmSplash : Form
    {
        /// <summary>
        /// Displays a splash screen
        /// </summary>
        
        public frmSplash()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function called when form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void frmSplash_Load(object sender, EventArgs e)
        {
            // Load the image
            pcbMain.Image = Image.FromFile(Environment.CurrentDirectory + "/assets/splash.png");
        }
    }
}
