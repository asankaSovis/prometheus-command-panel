/* 
 * -------------------------------------------------------------------------
 *                     PROMETHEUS CONTROL PANEL v1.5.0
 *  Prometheus Command Panel is the command panel software developed for
 *  the Prometheus Fire Alarm System. It can communicate with the system
 *  to allow the user to control and analyse the data from the system.
 * 
 *                          © Asanka Sovis 2022
 *                          
 * Created: 10/03/2022
 * Last Edited: 27/05/2022
 * 
 * -------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fire_Extinguisher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Running a splash screen on a separate thread
            System.Threading.Thread thread = new System.Threading.Thread(load);
            thread.Start();
            // Running the main application
            Application.Run(new frmMain(thread));
            //Application.Run(new frmAbout("", System.Drawing.SystemIcons.Warning));
        }

        static void load()
        {
            // Loading screen and the async function called by the thread
            // for splash screen
            frmSplash splash = new frmSplash();
            splash.ShowDialog();
        }
    }
}
