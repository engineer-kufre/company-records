using CompanyRecordsClassLib;
using System;
using System.Windows.Forms;

namespace CompanyRecordsAppUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //create the connection between the UI and the library
            DISocket.PlugSocket();
            IOperations operations = DISocket.Isocket;

            //run Form app
            Application.Run(new CompanyRecords(operations));
        }
    }
}
