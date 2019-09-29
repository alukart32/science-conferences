using ScienceConferenceApp.Forms;
using ScienceConferenceApp.Forms.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceConferenceApp
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
            BaseForm mainForm = new MainForm();
            Application.Run(mainForm);
        }
    }
}
