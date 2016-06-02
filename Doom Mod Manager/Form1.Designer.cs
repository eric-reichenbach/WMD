namespace WMD
{
    partial class FORM_MAINWIN
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_MAINWIN));
            this.PAN_CONTENT = new System.Windows.Forms.Panel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DGRIDV_MODS = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.GBX_SRCPRT = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_SRCPRT = new System.Windows.Forms.Button();
            this.TBOX_PARAM = new System.Windows.Forms.TextBox();
            this.GBX_MODMAN = new System.Windows.Forms.GroupBox();
            this.GBX_MODCOLL_NAME = new System.Windows.Forms.GroupBox();
            this.CHKBX_ASSOC_SRCPRT = new System.Windows.Forms.CheckBox();
            this.BTN_MODCOLL_NAME_VALIDATE = new System.Windows.Forms.Button();
            this.BTN_MODCOLL_NAME_CANCEL = new System.Windows.Forms.Button();
            this.TXTBX__MODCOLL_NAME = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_ADD_MODCOLL = new System.Windows.Forms.Button();
            this.BTN_MODCOLL_DEL = new System.Windows.Forms.Button();
            this.LSTB_MODCOLL = new System.Windows.Forms.ListBox();
            this.BTN_LAUNCH = new System.Windows.Forms.Button();
            this.FLDIA_SRCPRT = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CONMSTRIP_WINDOW = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CONTEXT_FOLDER = new System.Windows.Forms.ToolStripMenuItem();
            this.CONTEXT_DELETE_DATA = new System.Windows.Forms.ToolStripMenuItem();
            this.CONTEXT_RESET_ENVVAR = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.loadOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PAN_CONTENT.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGRIDV_MODS)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.GBX_SRCPRT.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.GBX_MODMAN.SuspendLayout();
            this.GBX_MODCOLL_NAME.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.CONMSTRIP_WINDOW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PAN_CONTENT
            // 
            this.PAN_CONTENT.Controls.Add(this.toolStripContainer1);
            this.PAN_CONTENT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PAN_CONTENT.Location = new System.Drawing.Point(3, 3);
            this.PAN_CONTENT.Name = "PAN_CONTENT";
            this.PAN_CONTENT.Size = new System.Drawing.Size(738, 267);
            this.PAN_CONTENT.TabIndex = 1;
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayoutPanel2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(738, 267);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(738, 267);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.DGRIDV_MODS, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(738, 267);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // DGRIDV_MODS
            // 
            this.DGRIDV_MODS.AllowDrop = true;
            this.DGRIDV_MODS.AllowUserToAddRows = false;
            this.DGRIDV_MODS.AllowUserToOrderColumns = true;
            this.DGRIDV_MODS.AllowUserToResizeColumns = false;
            this.DGRIDV_MODS.AllowUserToResizeRows = false;
            this.DGRIDV_MODS.AutoGenerateColumns = false;
            this.DGRIDV_MODS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGRIDV_MODS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGRIDV_MODS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selected,
            this.loadOrder,
            this.dataGridViewTextBoxColumn1});
            this.DGRIDV_MODS.DataSource = this.modListBindingSource;
            this.DGRIDV_MODS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGRIDV_MODS.EnableHeadersVisualStyles = false;
            this.DGRIDV_MODS.Location = new System.Drawing.Point(323, 3);
            this.DGRIDV_MODS.MultiSelect = false;
            this.DGRIDV_MODS.Name = "DGRIDV_MODS";
            this.DGRIDV_MODS.RowHeadersVisible = false;
            this.DGRIDV_MODS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGRIDV_MODS.Size = new System.Drawing.Size(412, 261);
            this.DGRIDV_MODS.TabIndex = 0;
            this.DGRIDV_MODS.TabStop = false;
            this.DGRIDV_MODS.DragDrop += new System.Windows.Forms.DragEventHandler(this.DGRIDV_MODS_DragDrop);
            this.DGRIDV_MODS.DragEnter += new System.Windows.Forms.DragEventHandler(this.DGRIDV_MODS_DragEnter);
            this.DGRIDV_MODS.DoubleClick += new System.EventHandler(this.DGRIDV_MODS_DoubleClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.GBX_SRCPRT, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.GBX_MODMAN, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(314, 261);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // GBX_SRCPRT
            // 
            this.GBX_SRCPRT.BackColor = System.Drawing.SystemColors.Control;
            this.GBX_SRCPRT.Controls.Add(this.tableLayoutPanel5);
            this.GBX_SRCPRT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBX_SRCPRT.Location = new System.Drawing.Point(3, 3);
            this.GBX_SRCPRT.Name = "GBX_SRCPRT";
            this.GBX_SRCPRT.Size = new System.Drawing.Size(308, 100);
            this.GBX_SRCPRT.TabIndex = 0;
            this.GBX_SRCPRT.TabStop = false;
            this.GBX_SRCPRT.Text = "Select your Sourceport";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.18182F));
            this.tableLayoutPanel5.Controls.Add(this.BTN_SRCPRT, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.TBOX_PARAM, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(302, 81);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // BTN_SRCPRT
            // 
            this.BTN_SRCPRT.BackColor = System.Drawing.Color.Brown;
            this.BTN_SRCPRT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_SRCPRT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_SRCPRT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SRCPRT.ForeColor = System.Drawing.Color.White;
            this.BTN_SRCPRT.Location = new System.Drawing.Point(3, 3);
            this.BTN_SRCPRT.Name = "BTN_SRCPRT";
            this.BTN_SRCPRT.Size = new System.Drawing.Size(296, 24);
            this.BTN_SRCPRT.TabIndex = 0;
            this.BTN_SRCPRT.Text = "Select your sourceport";
            this.BTN_SRCPRT.UseVisualStyleBackColor = false;
            this.BTN_SRCPRT.Click += new System.EventHandler(this.BTN_SRCPRT_Click);
            // 
            // TBOX_PARAM
            // 
            this.TBOX_PARAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBOX_PARAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBOX_PARAM.ForeColor = System.Drawing.Color.Gray;
            this.TBOX_PARAM.Location = new System.Drawing.Point(3, 33);
            this.TBOX_PARAM.Multiline = true;
            this.TBOX_PARAM.Name = "TBOX_PARAM";
            this.TBOX_PARAM.Size = new System.Drawing.Size(296, 45);
            this.TBOX_PARAM.TabIndex = 1;
            this.TBOX_PARAM.Text = "Optional launch parameters...";
            this.TBOX_PARAM.Enter += new System.EventHandler(this.TBOX_PARAM_Enter);
            this.TBOX_PARAM.Leave += new System.EventHandler(this.TBOX_PARAM_Leave);
            // 
            // GBX_MODMAN
            // 
            this.GBX_MODMAN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GBX_MODMAN.Controls.Add(this.GBX_MODCOLL_NAME);
            this.GBX_MODMAN.Controls.Add(this.tableLayoutPanel4);
            this.GBX_MODMAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBX_MODMAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBX_MODMAN.Location = new System.Drawing.Point(3, 109);
            this.GBX_MODMAN.Name = "GBX_MODMAN";
            this.GBX_MODMAN.Size = new System.Drawing.Size(308, 149);
            this.GBX_MODMAN.TabIndex = 1;
            this.GBX_MODMAN.TabStop = false;
            this.GBX_MODMAN.Text = "Wadpacks";
            // 
            // GBX_MODCOLL_NAME
            // 
            this.GBX_MODCOLL_NAME.Controls.Add(this.CHKBX_ASSOC_SRCPRT);
            this.GBX_MODCOLL_NAME.Controls.Add(this.BTN_MODCOLL_NAME_VALIDATE);
            this.GBX_MODCOLL_NAME.Controls.Add(this.BTN_MODCOLL_NAME_CANCEL);
            this.GBX_MODCOLL_NAME.Controls.Add(this.TXTBX__MODCOLL_NAME);
            this.GBX_MODCOLL_NAME.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GBX_MODCOLL_NAME.Location = new System.Drawing.Point(3, 73);
            this.GBX_MODCOLL_NAME.Name = "GBX_MODCOLL_NAME";
            this.GBX_MODCOLL_NAME.Size = new System.Drawing.Size(302, 73);
            this.GBX_MODCOLL_NAME.TabIndex = 5;
            this.GBX_MODCOLL_NAME.TabStop = false;
            this.GBX_MODCOLL_NAME.Text = "Enter a name for the new wadpack";
            this.GBX_MODCOLL_NAME.Visible = false;
            // 
            // CHKBX_ASSOC_SRCPRT
            // 
            this.CHKBX_ASSOC_SRCPRT.AutoSize = true;
            this.CHKBX_ASSOC_SRCPRT.Checked = true;
            this.CHKBX_ASSOC_SRCPRT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHKBX_ASSOC_SRCPRT.Location = new System.Drawing.Point(6, 47);
            this.CHKBX_ASSOC_SRCPRT.Name = "CHKBX_ASSOC_SRCPRT";
            this.CHKBX_ASSOC_SRCPRT.Size = new System.Drawing.Size(219, 17);
            this.CHKBX_ASSOC_SRCPRT.TabIndex = 4;
            this.CHKBX_ASSOC_SRCPRT.Text = "Link the pack to the selected Sourceport";
            this.CHKBX_ASSOC_SRCPRT.UseVisualStyleBackColor = true;
            // 
            // BTN_MODCOLL_NAME_VALIDATE
            // 
            this.BTN_MODCOLL_NAME_VALIDATE.Location = new System.Drawing.Point(239, 18);
            this.BTN_MODCOLL_NAME_VALIDATE.Name = "BTN_MODCOLL_NAME_VALIDATE";
            this.BTN_MODCOLL_NAME_VALIDATE.Size = new System.Drawing.Size(57, 20);
            this.BTN_MODCOLL_NAME_VALIDATE.TabIndex = 3;
            this.BTN_MODCOLL_NAME_VALIDATE.Text = "Validate";
            this.BTN_MODCOLL_NAME_VALIDATE.UseVisualStyleBackColor = true;
            this.BTN_MODCOLL_NAME_VALIDATE.Click += new System.EventHandler(this.BTN__MODCOLL_NAME_VALIDATE_Click);
            // 
            // BTN_MODCOLL_NAME_CANCEL
            // 
            this.BTN_MODCOLL_NAME_CANCEL.Location = new System.Drawing.Point(239, 44);
            this.BTN_MODCOLL_NAME_CANCEL.Name = "BTN_MODCOLL_NAME_CANCEL";
            this.BTN_MODCOLL_NAME_CANCEL.Size = new System.Drawing.Size(57, 20);
            this.BTN_MODCOLL_NAME_CANCEL.TabIndex = 2;
            this.BTN_MODCOLL_NAME_CANCEL.Text = "Cancel";
            this.BTN_MODCOLL_NAME_CANCEL.UseVisualStyleBackColor = true;
            this.BTN_MODCOLL_NAME_CANCEL.Click += new System.EventHandler(this.BTN__MODCOLL_NAME_CANCEL_Click);
            // 
            // TXTBX__MODCOLL_NAME
            // 
            this.TXTBX__MODCOLL_NAME.Location = new System.Drawing.Point(6, 19);
            this.TXTBX__MODCOLL_NAME.Name = "TXTBX__MODCOLL_NAME";
            this.TXTBX__MODCOLL_NAME.Size = new System.Drawing.Size(227, 20);
            this.TXTBX__MODCOLL_NAME.TabIndex = 0;
            this.TXTBX__MODCOLL_NAME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTBX__MODCOLL_NAME_KeyDown);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.LSTB_MODCOLL, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(302, 130);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.30463F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.69537F));
            this.tableLayoutPanel6.Controls.Add(this.BTN_ADD_MODCOLL, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.BTN_MODCOLL_DEL, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 93);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(296, 34);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // BTN_ADD_MODCOLL
            // 
            this.BTN_ADD_MODCOLL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_ADD_MODCOLL.Location = new System.Drawing.Point(3, 3);
            this.BTN_ADD_MODCOLL.Name = "BTN_ADD_MODCOLL";
            this.BTN_ADD_MODCOLL.Size = new System.Drawing.Size(154, 28);
            this.BTN_ADD_MODCOLL.TabIndex = 2;
            this.BTN_ADD_MODCOLL.Text = "Add a new wad collection";
            this.BTN_ADD_MODCOLL.UseVisualStyleBackColor = true;
            this.BTN_ADD_MODCOLL.Click += new System.EventHandler(this.BTN_ADD_MODCOLL_Click);
            // 
            // BTN_MODCOLL_DEL
            // 
            this.BTN_MODCOLL_DEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_MODCOLL_DEL.Location = new System.Drawing.Point(163, 3);
            this.BTN_MODCOLL_DEL.Name = "BTN_MODCOLL_DEL";
            this.BTN_MODCOLL_DEL.Size = new System.Drawing.Size(130, 28);
            this.BTN_MODCOLL_DEL.TabIndex = 3;
            this.BTN_MODCOLL_DEL.Text = "Delete selected ";
            this.BTN_MODCOLL_DEL.UseVisualStyleBackColor = true;
            this.BTN_MODCOLL_DEL.Click += new System.EventHandler(this.BTN_MODCOLL_DEL_Click);
            // 
            // LSTB_MODCOLL
            // 
            this.LSTB_MODCOLL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSTB_MODCOLL.FormattingEnabled = true;
            this.LSTB_MODCOLL.Location = new System.Drawing.Point(3, 3);
            this.LSTB_MODCOLL.Name = "LSTB_MODCOLL";
            this.LSTB_MODCOLL.Size = new System.Drawing.Size(296, 84);
            this.LSTB_MODCOLL.Sorted = true;
            this.LSTB_MODCOLL.TabIndex = 3;
            this.LSTB_MODCOLL.SelectedIndexChanged += new System.EventHandler(this.LSTB_MODCOLL_SelectedIndexChanged);
            // 
            // BTN_LAUNCH
            // 
            this.BTN_LAUNCH.BackColor = System.Drawing.Color.Brown;
            this.BTN_LAUNCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_LAUNCH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_LAUNCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LAUNCH.ForeColor = System.Drawing.Color.White;
            this.BTN_LAUNCH.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_LAUNCH.Location = new System.Drawing.Point(3, 276);
            this.BTN_LAUNCH.Name = "BTN_LAUNCH";
            this.BTN_LAUNCH.Size = new System.Drawing.Size(738, 23);
            this.BTN_LAUNCH.TabIndex = 2;
            this.BTN_LAUNCH.Text = "Launch the game";
            this.BTN_LAUNCH.UseVisualStyleBackColor = false;
            this.BTN_LAUNCH.Click += new System.EventHandler(this.BTN_LAUNCH_Click);
            // 
            // FLDIA_SRCPRT
            // 
            this.FLDIA_SRCPRT.DefaultExt = "exe";
            this.FLDIA_SRCPRT.FileOk += new System.ComponentModel.CancelEventHandler(this.FLDIA_SRCPRT_FileOk);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PAN_CONTENT, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTN_LAUNCH, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(744, 302);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // CONMSTRIP_WINDOW
            // 
            this.CONMSTRIP_WINDOW.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CONTEXT_FOLDER,
            this.CONTEXT_DELETE_DATA,
            this.CONTEXT_RESET_ENVVAR});
            this.CONMSTRIP_WINDOW.Name = "CONMSTRIP_WINDOW";
            this.CONMSTRIP_WINDOW.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CONMSTRIP_WINDOW.ShowImageMargin = false;
            this.CONMSTRIP_WINDOW.Size = new System.Drawing.Size(222, 70);
            // 
            // CONTEXT_FOLDER
            // 
            this.CONTEXT_FOLDER.Name = "CONTEXT_FOLDER";
            this.CONTEXT_FOLDER.Size = new System.Drawing.Size(221, 22);
            this.CONTEXT_FOLDER.Text = "Open Folder";
            this.CONTEXT_FOLDER.Click += new System.EventHandler(this.CONTEXT_FOLDER_Click);
            // 
            // CONTEXT_DELETE_DATA
            // 
            this.CONTEXT_DELETE_DATA.Name = "CONTEXT_DELETE_DATA";
            this.CONTEXT_DELETE_DATA.Size = new System.Drawing.Size(221, 22);
            this.CONTEXT_DELETE_DATA.Text = "Delete XML data";
            this.CONTEXT_DELETE_DATA.Click += new System.EventHandler(this.CONTEXT_DELETE_DATA_Click);
            // 
            // CONTEXT_RESET_ENVVAR
            // 
            this.CONTEXT_RESET_ENVVAR.Name = "CONTEXT_RESET_ENVVAR";
            this.CONTEXT_RESET_ENVVAR.Size = new System.Drawing.Size(221, 22);
            this.CONTEXT_RESET_ENVVAR.Text = "Remove DOOMWADDIR variable";
            this.CONTEXT_RESET_ENVVAR.Click += new System.EventHandler(this.CONTEXT_RESET_ENVVAR_Click);
            // 
            // selected
            // 
            this.selected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selected.DataPropertyName = "selected";
            this.selected.FillWeight = 29.39524F;
            this.selected.HeaderText = "";
            this.selected.MinimumWidth = 20;
            this.selected.Name = "selected";
            this.selected.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.selected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.selected.ToolTipText = "Select the wad";
            this.selected.Width = 32;
            // 
            // loadOrder
            // 
            this.loadOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.loadOrder.DataPropertyName = "loadOrder";
            this.loadOrder.FillWeight = 78.8327F;
            this.loadOrder.HeaderText = "Load order";
            this.loadOrder.MaxInputLength = 3;
            this.loadOrder.MinimumWidth = 100;
            this.loadOrder.Name = "loadOrder";
            this.loadOrder.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.loadOrder.ToolTipText = "Loaded in a ascending order (e.g. wads 1 are loaded before wads 2)";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "displayText";
            this.dataGridViewTextBoxColumn1.FillWeight = 181.3152F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Drag/drop WADs, PK3s, DEHs... to add them. Doubleclick on a row to delete the wad" +
    ".";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // modListBindingSource
            // 
            this.modListBindingSource.DataSource = typeof(WMD.ModList);
            // 
            // FORM_MAINWIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 302);
            this.ContextMenuStrip = this.CONMSTRIP_WINDOW;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(760, 340);
            this.Name = "FORM_MAINWIN";
            this.Text = "WMD - Wad Manager for Doom";
            this.PAN_CONTENT.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGRIDV_MODS)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.GBX_SRCPRT.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.GBX_MODMAN.ResumeLayout(false);
            this.GBX_MODCOLL_NAME.ResumeLayout(false);
            this.GBX_MODCOLL_NAME.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.CONMSTRIP_WINDOW.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PAN_CONTENT;
        private System.Windows.Forms.GroupBox GBX_SRCPRT;
        private System.Windows.Forms.Button BTN_SRCPRT;
        private System.Windows.Forms.OpenFileDialog FLDIA_SRCPRT;
        private System.Windows.Forms.Button BTN_LAUNCH;
        private System.Windows.Forms.GroupBox GBX_MODMAN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox GBX_MODCOLL_NAME;
        private System.Windows.Forms.TextBox TXTBX__MODCOLL_NAME;
        private System.Windows.Forms.Button BTN_MODCOLL_NAME_VALIDATE;
        private System.Windows.Forms.Button BTN_MODCOLL_NAME_CANCEL;
        private System.Windows.Forms.BindingSource modListBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button BTN_ADD_MODCOLL;
        private System.Windows.Forms.ListBox LSTB_MODCOLL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox TBOX_PARAM;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button BTN_MODCOLL_DEL;
        private System.Windows.Forms.DataGridView DGRIDV_MODS;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ContextMenuStrip CONMSTRIP_WINDOW;
        private System.Windows.Forms.ToolStripMenuItem CONTEXT_FOLDER;
        private System.Windows.Forms.ToolStripMenuItem CONTEXT_DELETE_DATA;
        private System.Windows.Forms.CheckBox CHKBX_ASSOC_SRCPRT;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem CONTEXT_RESET_ENVVAR;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn loadOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

