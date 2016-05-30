using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace WMD
{
    public partial class FORM_MAINWIN : Form
    {
        private PM pm = PM.getInstance();

        public FORM_MAINWIN()
        {
            InitializeComponent();
            Text = pm.txt("WMD - Wad Manager for Doom");
            BTN_ADD_MODCOLL.Text = pm.txt("Create a new wad collection");
            BTN_LAUNCH.Text = pm.txt("Launch the game");
            BTN_MODCOLL_DEL.Text = pm.txt("Delete selected");
            BTN_SRCPRT.Text = pm.txt("Select your sourceport");
            BTN_MODCOLL_NAME_CANCEL.Text = pm.txt("Cancel");
            BTN_MODCOLL_NAME_VALIDATE.Text = pm.txt("Validate");
            GBX_MODCOLL_NAME.Text = pm.txt("Enter a name for the new wadpack");
            GBX_MODMAN.Text = pm.txt("Wadpacks");
            GBX_SRCPRT.Text = pm.txt("Select your Sourceport");
            CHKBX_ASSOC_SRCPRT.Text = pm.txt("Link the pack to the selected Sourceport");
            toolTip1.SetToolTip(CHKBX_ASSOC_SRCPRT, pm.txt("It will also create a specific config file for the pack (it's useful for wads with specific key bindings)"));
            DGRIDV_MODS.Columns[1].HeaderText = pm.txt("Load order");
            DGRIDV_MODS.Columns[1].ToolTipText = pm.txt("Loaded in a ascending order (e.g. wads 1 are loaded before wads 2)");
            DGRIDV_MODS.Columns[2].HeaderText = pm.txt("Drag/drop WADs, PK3s, DEHs... to add them. Doubleclick on a row to delete the wad.");
            CONMSTRIP_WINDOW.Items["CONTEXT_FOLDER"].Text = pm.txt("Open Folder");
            CONMSTRIP_WINDOW.Items["CONTEXT_DELETE_DATA"].Text = pm.txt("Delete XML data");
            CONMSTRIP_WINDOW.Items["CONTEXT_RESET_ENVVAR"].Text = pm.txt("Remove DOOMWADDIR variable");

            try
            {
                DGRIDV_MODS.DataSource = new ModList();
                if (!string.IsNullOrEmpty(pm.SrcPrt))
                {
                    setSrcPrt(pm.SrcPrt);
                }
                reinitModColl();
            }
            catch
            {
                MessageBox.Show(pm.txt("Unable to load, the xml file might be read only."),
                               pm.txt("Error"),
                               MessageBoxButtons.OK);
            }
        }

        public void ExecuteCommandSync(string path, string command)
        {
            try
            {
                // create the ProcessStartInfo using "cmd" as the program to be run,
                // and "/c " as the parameters.
                // Incidentally, /c tells cmd that we want it to execute the command that follows,
                // and then exit.
                var procStartInfo =
                    new ProcessStartInfo(path, command);

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
                var proc = new Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                // Get the output into a string
                string result = proc.StandardOutput.ReadToEnd();
                proc.WaitForExit();
                // Display the command output.
                Console.WriteLine(result);
            }
            catch
            {
            }
        }

        public void setSrcPrt(string srcPrt)
        {
            var f = new FileInfo(srcPrt);

            BTN_SRCPRT.BackColor = Color.OliveDrab;
            BTN_SRCPRT.Text = pm.txt("$ selected", f.Name.ToString());
            pm.SrcPrt = f.FullName;
        }

        void BTN__MODCOLL_NAME_CANCEL_Click(object sender, EventArgs e)
        {
            reinitModColl();
        }

        void BTN__MODCOLL_NAME_VALIDATE_Click(object sender, EventArgs e)
        {
            validateNewModColl();
        }

        void BTN_ADD_MODCOLL_Click(object sender, EventArgs e)
        {
            GBX_MODCOLL_NAME.Visible = true;
            LSTB_MODCOLL.Enabled = false;
            BTN_ADD_MODCOLL.Enabled = false;
            TXTBX__MODCOLL_NAME.Focus();
        }

        void BTN_LAUNCH_Click(object sender, EventArgs e)
        {
            string mdStr = "";
            var mdlst = new List<Mod>();
            foreach (DataGridViewRow r in DGRIDV_MODS.Rows)
            {
                if ((bool)r.Cells[0].Value)
                    mdlst.Add(new Mod((bool)r.Cells[0].Value, (int)r.Cells[1].Value, r.Cells[2].Value.ToString()));
                mdlst = mdlst.OrderBy(o => o.loadOrder).ToList();
            }
            foreach (Mod m in mdlst)
                mdStr += " -file \"" + m.fileI.FullName + "\"";
            string txt = pm.txt("Optional launch parameters...");
            if (!TBOX_PARAM.Text.Equals(txt) && !TBOX_PARAM.Text.Equals(""))
                mdStr += " " + TBOX_PARAM.Text;
            string path = pm.SrcPrt;
            if (LSTB_MODCOLL.SelectedItem != null)
            {
                var q = (from item in pm.getModColllist()
                         where (item.ToString().Equals(LSTB_MODCOLL.SelectedItem.ToString()))
                         select item);
                if (q.Count() > 0)
                {
                    var mc = q.First();
                    if (mc.srcPrt != null)
                        path = mc.srcPrt.FullName;
                    mdStr += " -config \"" + mc.config.FullName + "\"";
                    if (!mc.config.Exists)
                    {
                        mdStr += " -height " + System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height + "";
                        mdStr += " -width " + System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width + "";
                    }
                    mdStr += " -savedir \"" + mc.save.FullName.Replace("\\", "/") + "\"";
                }
                else
                {
                    mdStr += " -height " + System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height + "";
                    mdStr += " -width " + System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width + "";
                }
            }
            else
            {
                mdStr += " -height " + System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height + "";
                mdStr += " -width " + System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width + "";
            }
            ExecuteCommandSync("" + path + "", mdStr);
        }

        void BTN_MODCOLL_DEL_Click(object sender, EventArgs e)
        {
            if (LSTB_MODCOLL.SelectedItem == null)
                return;
            if (LSTB_MODCOLL.SelectedItem.ToString().Equals("[none]"))
                return;
            var q = (from item in pm.getModColllist()
                     where item.ToString().Equals(LSTB_MODCOLL.SelectedItem.ToString())
                     select item);
            if (q.Count() <= 0)
                return;
            var mc = q.First();
            var confirmResult = MessageBox.Show(pm.txt("Delete the Wad collection named \"$\"?", mc.name),
                      pm.txt("Confirm Delete"),
                      MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                pm.removeModColl(mc);
                reinitModColl();
            }
        }

        void BTN_SRCPRT_Click(object sender, EventArgs e)
        {
            FLDIA_SRCPRT.Filter = "Executable files|*.exe";
            var di = new DirectoryInfo(".");
            if (!string.IsNullOrEmpty(pm.SrcPrt))
                di = new DirectoryInfo(pm.SrcPrt);
            FLDIA_SRCPRT.InitialDirectory = di.FullName;
            FLDIA_SRCPRT.ShowDialog();
        }

        void CONTEXT_DELETE_DATA_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(pm.txt("Are you sure to delete all data contained in the xml file? You should only do that if there is bugs or issues with the manager."),
                                     pm.txt("Confirm Delete"),
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Try to delete the file.
                    pm.deleteEverything();
                    reinitModColl();
                }
                catch
                {
                    MessageBox.Show(pm.txt("Unable to delete the file, it might be read only."),
                                    pm.txt("Error"),
                                    MessageBoxButtons.OK);
                }
            }
        }

        void CONTEXT_FOLDER_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe",
                "/select," + new DirectoryInfo(PM.MODDIRECTORY).FullName);
        }

        void CONTEXT_RESET_ENVVAR_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(pm.txt("The environment variable DOOMWADDIR is used by sourceports to find your IWADs.\r\n\r\nNext time you will launch WMD, it will ask if you want to recreate it.\r\n\r\nAre you sure you want to delete the environment variable DOOMWADDIR?"),
                                     pm.txt("Confirm Delete"),
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Try to delete the var.
                    Environment.SetEnvironmentVariable("DOOMWADDIR", "", EnvironmentVariableTarget.User);
                    pm.StopAskingVar = false;
                }
                catch
                {
                    MessageBox.Show(pm.txt("Unable to delete the variable for unknown reasons."),
                                    pm.txt("Error"),
                                    MessageBoxButtons.OK);
                }
            }
        }

        void deselectWads()
        {
            foreach (DataGridViewRow r in DGRIDV_MODS.Rows)
            {
                r.Cells[0].Value = false;
                r.Cells[1].Value = 0;
            }
        }

        void DGRIDV_MODS_DoubleClick(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(pm.txt("Are you sure to delete the selected wad?"),
                                     pm.txt("Confirm Delete"),
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Mod toDel;
                using (DataGridViewRow r = DGRIDV_MODS.SelectedRows[0])
                {
                    toDel = new Mod(false, 0, r.Cells[2].Value.ToString());
                }

                try
                {
                    // Try to delete the file.
                    File.Delete(toDel.fileI.FullName);
                    DGRIDV_MODS.DataSource = new ModList();
                }
                catch
                {
                    MessageBox.Show(pm.txt("Unable to delete the file, it might be read only."),
                                    pm.txt("Error"),
                                    MessageBoxButtons.OK);
                }
            }
        }

        void DGRIDV_MODS_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                var fi = new FileInfo(file);
                if (fi.Extension.ToLower().Equals(".dpz"))
                {
                    try
                    {
                        ZipFile.ExtractToDirectory(fi.FullName, @".");
                        ModColl mc = pm.readXmlPackage(new FileInfo(@".\\WMF.xml"));
                        pm.addModColl(mc);
                        reinitModColl();
                        LSTB_MODCOLL.Focus();
                    }
                    catch
                    {

                    }
                }
                else
                {
                    int stri = fi.DirectoryName.Length;
                    string namefile = fi.FullName.Substring(stri + 1, fi.FullName.Length - stri - 1);
                    File.Copy(file, PM.MODDIRECTORY + "/" + namefile, true);
                }
            }
            DGRIDV_MODS.DataSource = new ModList();
        }

        void DGRIDV_MODS_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        void FLDIA_SRCPRT_FileOk(object sender, CancelEventArgs e)
        {
            if (FLDIA_SRCPRT.FileName.Contains(".exe"))
                setSrcPrt(FLDIA_SRCPRT.FileName);
        }

        void LSTB_MODCOLL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LSTB_MODCOLL.SelectedItem == null)
                return;

            var q = (from item in pm.getModColllist()
                     where item.ToString().Equals(LSTB_MODCOLL.SelectedItem.ToString())
                     select item);
            if (q.Count() <= 0)
                return;
            var mc = q.First();
            deselectWads();
            DGRIDV_MODS.ClearSelection();
            foreach (Mod m in mc)
            {
                for (int i = 0; i < DGRIDV_MODS.Rows.Count; i++)
                {
                    if (DGRIDV_MODS.Rows[i].DataBoundItem.ToString() == m.fileI.Name)
                    {
                        DGRIDV_MODS.Rows[i].Cells[0].Value = true;
                        DGRIDV_MODS.Rows[i].Cells[1].Value = m.loadOrder;
                    }
                }
            }
        }

        void reinitModColl()
        {
            TXTBX__MODCOLL_NAME.Clear();
            GBX_MODCOLL_NAME.Visible = false;
            LSTB_MODCOLL.Enabled = true;
            BTN_ADD_MODCOLL.Enabled = true;
            LSTB_MODCOLL.Items.Clear();
            foreach (ModColl mc in pm.getModColllist())
            {
                LSTB_MODCOLL.Items.Add(mc.ToString());
            }
        }

        void TBOX_PARAM_Enter(object sender, EventArgs e)
        {
            string txt = pm.txt("Optional launch parameters...");
            if (TBOX_PARAM.Text.Equals(txt))
            {
                TBOX_PARAM.Text = "";
                TBOX_PARAM.ForeColor = Color.Black;
            }
        }

        void TBOX_PARAM_Leave(object sender, EventArgs e)
        {
            string txt = pm.txt("Optional launch parameters...");
            if (TBOX_PARAM.Text.Equals(""))
            {
                TBOX_PARAM.Text = txt;
                TBOX_PARAM.ForeColor = Color.Gray;
            }
        }

        void TXTBX__MODCOLL_NAME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validateNewModColl();
                e.Handled = true;
            }
        }

        void validateNewModColl()
        {
            if (TXTBX__MODCOLL_NAME.Text.Equals(pm.txt("[none]")))
                return;
            if (string.IsNullOrEmpty(TXTBX__MODCOLL_NAME.Text))
                return;

            var q = (from item in pm.getModColllist()
                     where item.name.Equals(TXTBX__MODCOLL_NAME.Text)
                     select item);
            if (q.Count() > 0)
                pm.removeModColl(q.First());

            string srcPrt = "";
            if (CHKBX_ASSOC_SRCPRT.Checked == true)
                if (!string.IsNullOrEmpty(pm.SrcPrt))
                    srcPrt = pm.SrcPrt;
            var mc = new ModColl(TXTBX__MODCOLL_NAME.Text, srcPrt);
            foreach (DataGridViewRow r in DGRIDV_MODS.Rows)
            {
                if ((bool)r.Cells[0].Value)
                    mc.Add(new Mod((bool)r.Cells[0].Value, (int)r.Cells[1].Value, r.Cells[2].Value.ToString()));
            }
            if (mc.Count != 0)
            {
                pm.addModColl(mc);
                reinitModColl();
                LSTB_MODCOLL.Focus();
            }
        }

    }
}