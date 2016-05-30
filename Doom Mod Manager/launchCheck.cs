using System;
using System.Windows.Forms;

namespace WMD
{
    public partial class launchCheck : Form
    {
        PM pm = PM.getInstance();

        public launchCheck()
        {
            InitializeComponent();
            Text = pm.txt("Launch Check");
            label1.Text = pm.txt("The environment variable \"DOOMWADDIR\" has not been found.\r\n\r\nThis variable allows Sourceports to easily find your IWADs(the files needed to play the game).\r\n\r\nWould you like to create the variable for the windows session currently in use ?");
            BTN_LATER.Text = pm.txt("Ask later");
            BTN_NO.Text = pm.txt("No");
            BTN_YES.Text = pm.txt("Yes (recommended)");
        }

        void BTN_LATER_Click(object sender, EventArgs e)
        {
            //do nothing
            pm.StopAskingVar = false;
            open_main_window();
        }

        void BTN_NO_Click(object sender, EventArgs e)
        {
            //create a shit file to remember
            pm.StopAskingVar = true;
            open_main_window();
        }

        void BTN_YES_Click(object sender, EventArgs e)
        {
            //create var
            FOLDBRDIA_DOOMWADDIR.ShowDialog();
            if (!string.IsNullOrEmpty(FOLDBRDIA_DOOMWADDIR.SelectedPath))
            {
                Environment.SetEnvironmentVariable("DOOMWADDIR", FOLDBRDIA_DOOMWADDIR.SelectedPath, EnvironmentVariableTarget.User);

                open_main_window();
            }
        }

        void open_main_window()
        {
            var frm = new FORM_MAINWIN();
            Visible = false;
            frm.ShowDialog();
            Close();
        }
    }
}