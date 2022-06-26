using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace boat_rental
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // StartForm startForm = new StartForm();
            // startForm.Show();
            //
            // for (int i = 0; i < 100; i++)
            // {
            //     startForm.ProgressValue = i;
            // }
            //
            // // Thread.Sleep(2000);
            // startForm.Close();
            
            // Application.Run(new StartForm());
            Application.Run(new MainForm());
        }
    }
}
