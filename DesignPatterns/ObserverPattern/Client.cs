using System;
using System.Windows.Forms;

namespace ObserverPattern
{
    public static class Client
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ObserverForm());
        }
    }
}
