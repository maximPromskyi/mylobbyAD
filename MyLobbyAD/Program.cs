using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyLobbyAD
{
    static class Program
    {
        static Mutex mutex = new Mutex(true, Application.ProductName);
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!mutex.WaitOne(TimeSpan.Zero, true))
            {
                Process.GetProcessesByName(Application.ProductName);
                foreach (Process process in Process.GetProcessesByName(Application.ProductName))
                {
                    process.Kill();
                }
            }
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ActiveDirectoryForm());
        }
    }
}
