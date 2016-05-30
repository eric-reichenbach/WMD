using System;
using System.Windows.Forms;

namespace WMD
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Environment.GetEnvironmentVariable("DOOMWADDIR", EnvironmentVariableTarget.User) == null && Environment.GetEnvironmentVariable("DOOMWADDIR", EnvironmentVariableTarget.Machine) == null)
            {
                if (PM.getInstance().StopAskingVar)
                    Application.Run(new FORM_MAINWIN());
                else
                    Application.Run(new launchCheck());
            }
            else
                Application.Run(new FORM_MAINWIN());
        }
    }
}