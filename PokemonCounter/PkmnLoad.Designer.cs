namespace PokemonCounter
{
    partial class PkmnLoad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PkmnLoad));
            this.PNL_MENU = new System.Windows.Forms.Panel();
            this.BT_MINIMIZE = new System.Windows.Forms.Button();
            this.BT_CLOSE = new System.Windows.Forms.Button();
            this.PNL_CONTENT = new System.Windows.Forms.Panel();
            this.PNL_SEARCH = new System.Windows.Forms.Panel();
            this.PNL_SEARCH_UNDERLINE = new System.Windows.Forms.Panel();
            this.TBL_SEARCH = new System.Windows.Forms.TableLayoutPanel();
            this.CKB_CAUGHT = new System.Windows.Forms.CheckBox();
            this.TB_DEX = new System.Windows.Forms.TextBox();
            this.TB_NAME = new System.Windows.Forms.TextBox();
            this.TB_COUNT = new System.Windows.Forms.TextBox();
            this.LBL_SEARCH = new System.Windows.Forms.Label();
            this.BT_DELETE = new System.Windows.Forms.Button();
            this.DGV_PKMN = new System.Windows.Forms.DataGridView();
            this.DGV_Icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.DGV_Caught = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGV_Dexnmb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Encounters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_counterRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_alpha = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGV_pkmnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_genIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_gameIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_shiny = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGV_animated = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGV_autosave = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGV_addHotkey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_subHotkey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_resetHotkey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_exportCounter = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGV_exportFileCounter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_importPicture = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGV_importFilePicture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMS_DGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BT_CANCEL = new System.Windows.Forms.Button();
            this.BT_LOAD = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Caught = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PNL_MENU.SuspendLayout();
            this.PNL_CONTENT.SuspendLayout();
            this.PNL_SEARCH.SuspendLayout();
            this.TBL_SEARCH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PKMN)).BeginInit();
            this.CMS_DGV.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_MENU
            // 
            this.PNL_MENU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PNL_MENU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_MENU.Controls.Add(this.BT_MINIMIZE);
            this.PNL_MENU.Controls.Add(this.BT_CLOSE);
            this.PNL_MENU.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_MENU.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PNL_MENU.Location = new System.Drawing.Point(0, 0);
            this.PNL_MENU.Name = "PNL_MENU";
            this.PNL_MENU.Size = new System.Drawing.Size(311, 35);
            this.PNL_MENU.TabIndex = 1;
            this.PNL_MENU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_menu_MouseDown);
            this.PNL_MENU.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_menu_MouseMove);
            this.PNL_MENU.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_menu_MouseUp);
            // 
            // BT_MINIMIZE
            // 
            this.BT_MINIMIZE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_MINIMIZE.BackColor = System.Drawing.Color.Transparent;
            this.BT_MINIMIZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_MINIMIZE.ForeColor = System.Drawing.Color.White;
            this.BT_MINIMIZE.Image = global::PokemonCounter.Properties.Resources.menu_minimize;
            this.BT_MINIMIZE.Location = new System.Drawing.Point(247, 5);
            this.BT_MINIMIZE.Name = "BT_MINIMIZE";
            this.BT_MINIMIZE.Size = new System.Drawing.Size(25, 25);
            this.BT_MINIMIZE.TabIndex = 3;
            this.BT_MINIMIZE.UseVisualStyleBackColor = false;
            this.BT_MINIMIZE.Click += new System.EventHandler(this.BT_MINIMIZE_Click);
            // 
            // BT_CLOSE
            // 
            this.BT_CLOSE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_CLOSE.BackColor = System.Drawing.Color.Transparent;
            this.BT_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_CLOSE.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CLOSE.ForeColor = System.Drawing.Color.White;
            this.BT_CLOSE.Image = global::PokemonCounter.Properties.Resources.menu_close;
            this.BT_CLOSE.Location = new System.Drawing.Point(278, 5);
            this.BT_CLOSE.Name = "BT_CLOSE";
            this.BT_CLOSE.Size = new System.Drawing.Size(25, 25);
            this.BT_CLOSE.TabIndex = 1;
            this.BT_CLOSE.UseVisualStyleBackColor = false;
            this.BT_CLOSE.Click += new System.EventHandler(this.BT_CLOSE_Click);
            // 
            // PNL_CONTENT
            // 
            this.PNL_CONTENT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PNL_CONTENT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_CONTENT.Controls.Add(this.tableLayoutPanel1);
            this.PNL_CONTENT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_CONTENT.Location = new System.Drawing.Point(0, 35);
            this.PNL_CONTENT.Name = "PNL_CONTENT";
            this.PNL_CONTENT.Size = new System.Drawing.Size(311, 411);
            this.PNL_CONTENT.TabIndex = 2;
            // 
            // PNL_SEARCH
            // 
            this.PNL_SEARCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PNL_SEARCH.Controls.Add(this.pictureBox1);
            this.PNL_SEARCH.Controls.Add(this.PNL_SEARCH_UNDERLINE);
            this.PNL_SEARCH.Controls.Add(this.TBL_SEARCH);
            this.PNL_SEARCH.Controls.Add(this.LBL_SEARCH);
            this.PNL_SEARCH.Location = new System.Drawing.Point(3, 3);
            this.PNL_SEARCH.Name = "PNL_SEARCH";
            this.PNL_SEARCH.Size = new System.Drawing.Size(303, 83);
            this.PNL_SEARCH.TabIndex = 37;
            // 
            // PNL_SEARCH_UNDERLINE
            // 
            this.PNL_SEARCH_UNDERLINE.BackColor = System.Drawing.Color.Black;
            this.PNL_SEARCH_UNDERLINE.Location = new System.Drawing.Point(8, 27);
            this.PNL_SEARCH_UNDERLINE.Name = "PNL_SEARCH_UNDERLINE";
            this.PNL_SEARCH_UNDERLINE.Size = new System.Drawing.Size(150, 2);
            this.PNL_SEARCH_UNDERLINE.TabIndex = 32;
            // 
            // TBL_SEARCH
            // 
            this.TBL_SEARCH.AutoSize = true;
            this.TBL_SEARCH.ColumnCount = 4;
            this.TBL_SEARCH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.TBL_SEARCH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TBL_SEARCH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.TBL_SEARCH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.TBL_SEARCH.Controls.Add(this.label3, 3, 0);
            this.TBL_SEARCH.Controls.Add(this.label2, 2, 0);
            this.TBL_SEARCH.Controls.Add(this.label1, 1, 0);
            this.TBL_SEARCH.Controls.Add(this.Caught, 0, 0);
            this.TBL_SEARCH.Controls.Add(this.CKB_CAUGHT, 0, 1);
            this.TBL_SEARCH.Controls.Add(this.TB_DEX, 1, 1);
            this.TBL_SEARCH.Controls.Add(this.TB_NAME, 2, 1);
            this.TBL_SEARCH.Controls.Add(this.TB_COUNT, 3, 1);
            this.TBL_SEARCH.Location = new System.Drawing.Point(35, 30);
            this.TBL_SEARCH.Name = "TBL_SEARCH";
            this.TBL_SEARCH.RowCount = 2;
            this.TBL_SEARCH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TBL_SEARCH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TBL_SEARCH.Size = new System.Drawing.Size(260, 54);
            this.TBL_SEARCH.TabIndex = 32;
            // 
            // CKB_CAUGHT
            // 
            this.CKB_CAUGHT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CKB_CAUGHT.AutoSize = true;
            this.CKB_CAUGHT.Location = new System.Drawing.Point(26, 33);
            this.CKB_CAUGHT.Name = "CKB_CAUGHT";
            this.CKB_CAUGHT.Size = new System.Drawing.Size(15, 14);
            this.CKB_CAUGHT.TabIndex = 35;
            this.CKB_CAUGHT.UseVisualStyleBackColor = true;
            this.CKB_CAUGHT.CheckedChanged += new System.EventHandler(this.CKB_CAUGHT_CheckedChanged);
            // 
            // TB_DEX
            // 
            this.TB_DEX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_DEX.Location = new System.Drawing.Point(70, 30);
            this.TB_DEX.Name = "TB_DEX";
            this.TB_DEX.Size = new System.Drawing.Size(34, 20);
            this.TB_DEX.TabIndex = 32;
            this.TB_DEX.TextChanged += new System.EventHandler(this.TB_DEX_TextChanged);
            // 
            // TB_NAME
            // 
            this.TB_NAME.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_NAME.Location = new System.Drawing.Point(110, 30);
            this.TB_NAME.Name = "TB_NAME";
            this.TB_NAME.Size = new System.Drawing.Size(63, 20);
            this.TB_NAME.TabIndex = 33;
            this.TB_NAME.TextChanged += new System.EventHandler(this.TB_NAME_TextChanged);
            // 
            // TB_COUNT
            // 
            this.TB_COUNT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_COUNT.Location = new System.Drawing.Point(188, 30);
            this.TB_COUNT.Name = "TB_COUNT";
            this.TB_COUNT.Size = new System.Drawing.Size(60, 20);
            this.TB_COUNT.TabIndex = 34;
            this.TB_COUNT.TextChanged += new System.EventHandler(this.TB_COUNT_TextChanged);
            // 
            // LBL_SEARCH
            // 
            this.LBL_SEARCH.AutoSize = true;
            this.LBL_SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_SEARCH.Location = new System.Drawing.Point(7, 8);
            this.LBL_SEARCH.Name = "LBL_SEARCH";
            this.LBL_SEARCH.Size = new System.Drawing.Size(57, 16);
            this.LBL_SEARCH.TabIndex = 25;
            this.LBL_SEARCH.Text = "Search";
            // 
            // BT_DELETE
            // 
            this.BT_DELETE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_DELETE.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BT_DELETE.Enabled = false;
            this.BT_DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_DELETE.ForeColor = System.Drawing.Color.White;
            this.BT_DELETE.Location = new System.Drawing.Point(3, 4);
            this.BT_DELETE.Name = "BT_DELETE";
            this.BT_DELETE.Size = new System.Drawing.Size(86, 30);
            this.BT_DELETE.TabIndex = 31;
            this.BT_DELETE.Text = "Delete";
            this.BT_DELETE.UseVisualStyleBackColor = false;
            this.BT_DELETE.Click += new System.EventHandler(this.BT_DELETE_Click);
            // 
            // DGV_PKMN
            // 
            this.DGV_PKMN.AllowUserToAddRows = false;
            this.DGV_PKMN.AllowUserToDeleteRows = false;
            this.DGV_PKMN.AllowUserToOrderColumns = true;
            this.DGV_PKMN.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGV_PKMN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_PKMN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_PKMN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_PKMN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PKMN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_Icon,
            this.DGV_Caught,
            this.DGV_Dexnmb,
            this.DGV_Name,
            this.DGV_Encounters,
            this.DGV_counterRatio,
            this.ID,
            this.DGV_alpha,
            this.DGV_pkmnIndex,
            this.DGV_genIndex,
            this.DGV_gameIndex,
            this.DGV_shiny,
            this.DGV_animated,
            this.DGV_autosave,
            this.DGV_addHotkey,
            this.DGV_subHotkey,
            this.DGV_resetHotkey,
            this.DGV_exportCounter,
            this.DGV_exportFileCounter,
            this.DGV_importPicture,
            this.DGV_importFilePicture});
            this.DGV_PKMN.ContextMenuStrip = this.CMS_DGV;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_PKMN.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_PKMN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_PKMN.Location = new System.Drawing.Point(3, 92);
            this.DGV_PKMN.Name = "DGV_PKMN";
            this.DGV_PKMN.ReadOnly = true;
            this.DGV_PKMN.RowHeadersVisible = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DGV_PKMN.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DGV_PKMN.Size = new System.Drawing.Size(303, 271);
            this.DGV_PKMN.StandardTab = true;
            this.DGV_PKMN.TabIndex = 30;
            this.DGV_PKMN.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_PKMN_CellMouseUp);
            // 
            // DGV_Icon
            // 
            this.DGV_Icon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DGV_Icon.HeaderText = "Icon";
            this.DGV_Icon.Name = "DGV_Icon";
            this.DGV_Icon.ReadOnly = true;
            this.DGV_Icon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Icon.Width = 34;
            // 
            // DGV_Caught
            // 
            this.DGV_Caught.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DGV_Caught.HeaderText = "Caught";
            this.DGV_Caught.MinimumWidth = 25;
            this.DGV_Caught.Name = "DGV_Caught";
            this.DGV_Caught.ReadOnly = true;
            this.DGV_Caught.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Caught.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DGV_Caught.Width = 66;
            // 
            // DGV_Dexnmb
            // 
            this.DGV_Dexnmb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV_Dexnmb.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Dexnmb.HeaderText = "#";
            this.DGV_Dexnmb.Name = "DGV_Dexnmb";
            this.DGV_Dexnmb.ReadOnly = true;
            this.DGV_Dexnmb.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Dexnmb.Width = 39;
            // 
            // DGV_Name
            // 
            this.DGV_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DGV_Name.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Name.HeaderText = "Name";
            this.DGV_Name.Name = "DGV_Name";
            this.DGV_Name.ReadOnly = true;
            this.DGV_Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Name.Width = 60;
            // 
            // DGV_Encounters
            // 
            this.DGV_Encounters.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DGV_Encounters.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_Encounters.HeaderText = "Count";
            this.DGV_Encounters.Name = "DGV_Encounters";
            this.DGV_Encounters.ReadOnly = true;
            this.DGV_Encounters.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DGV_counterRatio
            // 
            this.DGV_counterRatio.HeaderText = "ratio";
            this.DGV_counterRatio.Name = "DGV_counterRatio";
            this.DGV_counterRatio.ReadOnly = true;
            this.DGV_counterRatio.Visible = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // DGV_alpha
            // 
            this.DGV_alpha.HeaderText = "alpha";
            this.DGV_alpha.Name = "DGV_alpha";
            this.DGV_alpha.ReadOnly = true;
            this.DGV_alpha.Visible = false;
            // 
            // DGV_pkmnIndex
            // 
            this.DGV_pkmnIndex.HeaderText = "pkmnIndex";
            this.DGV_pkmnIndex.Name = "DGV_pkmnIndex";
            this.DGV_pkmnIndex.ReadOnly = true;
            this.DGV_pkmnIndex.Visible = false;
            // 
            // DGV_genIndex
            // 
            this.DGV_genIndex.HeaderText = "genIndex";
            this.DGV_genIndex.Name = "DGV_genIndex";
            this.DGV_genIndex.ReadOnly = true;
            this.DGV_genIndex.Visible = false;
            // 
            // DGV_gameIndex
            // 
            this.DGV_gameIndex.HeaderText = "gameIndex";
            this.DGV_gameIndex.Name = "DGV_gameIndex";
            this.DGV_gameIndex.ReadOnly = true;
            this.DGV_gameIndex.Visible = false;
            // 
            // DGV_shiny
            // 
            this.DGV_shiny.HeaderText = "shiny";
            this.DGV_shiny.Name = "DGV_shiny";
            this.DGV_shiny.ReadOnly = true;
            this.DGV_shiny.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_shiny.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DGV_shiny.Visible = false;
            // 
            // DGV_animated
            // 
            this.DGV_animated.HeaderText = "animated";
            this.DGV_animated.Name = "DGV_animated";
            this.DGV_animated.ReadOnly = true;
            this.DGV_animated.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_animated.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DGV_animated.Visible = false;
            // 
            // DGV_autosave
            // 
            this.DGV_autosave.HeaderText = "autosave";
            this.DGV_autosave.Name = "DGV_autosave";
            this.DGV_autosave.ReadOnly = true;
            this.DGV_autosave.Visible = false;
            // 
            // DGV_addHotkey
            // 
            this.DGV_addHotkey.HeaderText = "addHotkey";
            this.DGV_addHotkey.Name = "DGV_addHotkey";
            this.DGV_addHotkey.ReadOnly = true;
            this.DGV_addHotkey.Visible = false;
            // 
            // DGV_subHotkey
            // 
            this.DGV_subHotkey.HeaderText = "subHotkey";
            this.DGV_subHotkey.Name = "DGV_subHotkey";
            this.DGV_subHotkey.ReadOnly = true;
            this.DGV_subHotkey.Visible = false;
            // 
            // DGV_resetHotkey
            // 
            this.DGV_resetHotkey.HeaderText = "resetHotkey";
            this.DGV_resetHotkey.Name = "DGV_resetHotkey";
            this.DGV_resetHotkey.ReadOnly = true;
            this.DGV_resetHotkey.Visible = false;
            // 
            // DGV_exportCounter
            // 
            this.DGV_exportCounter.HeaderText = "exportCounter";
            this.DGV_exportCounter.Name = "DGV_exportCounter";
            this.DGV_exportCounter.ReadOnly = true;
            this.DGV_exportCounter.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_exportCounter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DGV_exportCounter.Visible = false;
            // 
            // DGV_exportFileCounter
            // 
            this.DGV_exportFileCounter.HeaderText = "exportFileCounter";
            this.DGV_exportFileCounter.Name = "DGV_exportFileCounter";
            this.DGV_exportFileCounter.ReadOnly = true;
            this.DGV_exportFileCounter.Visible = false;
            // 
            // DGV_importPicture
            // 
            this.DGV_importPicture.HeaderText = "importPicture";
            this.DGV_importPicture.Name = "DGV_importPicture";
            this.DGV_importPicture.ReadOnly = true;
            this.DGV_importPicture.Visible = false;
            // 
            // DGV_importFilePicture
            // 
            this.DGV_importFilePicture.HeaderText = "importFilePicture";
            this.DGV_importFilePicture.Name = "DGV_importFilePicture";
            this.DGV_importFilePicture.ReadOnly = true;
            this.DGV_importFilePicture.Visible = false;
            // 
            // CMS_DGV
            // 
            this.CMS_DGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.CMS_DGV.Name = "CMS_DGV";
            this.CMS_DGV.Size = new System.Drawing.Size(155, 26);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::PokemonCounter.Properties.Resources.refresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // BT_CANCEL
            // 
            this.BT_CANCEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_CANCEL.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BT_CANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CANCEL.ForeColor = System.Drawing.Color.White;
            this.BT_CANCEL.Location = new System.Drawing.Point(205, 4);
            this.BT_CANCEL.Name = "BT_CANCEL";
            this.BT_CANCEL.Size = new System.Drawing.Size(89, 30);
            this.BT_CANCEL.TabIndex = 29;
            this.BT_CANCEL.Text = "Cancel";
            this.BT_CANCEL.UseVisualStyleBackColor = false;
            this.BT_CANCEL.Click += new System.EventHandler(this.BT_CANCEL_Click);
            // 
            // BT_LOAD
            // 
            this.BT_LOAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_LOAD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BT_LOAD.Enabled = false;
            this.BT_LOAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_LOAD.ForeColor = System.Drawing.Color.White;
            this.BT_LOAD.Location = new System.Drawing.Point(101, 4);
            this.BT_LOAD.Name = "BT_LOAD";
            this.BT_LOAD.Size = new System.Drawing.Size(93, 30);
            this.BT_LOAD.TabIndex = 28;
            this.BT_LOAD.Text = "Load";
            this.BT_LOAD.UseVisualStyleBackColor = false;
            this.BT_LOAD.Click += new System.EventHandler(this.BT_LOAD_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.PNL_SEARCH, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DGV_PKMN, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.31694F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.68306F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(309, 409);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.51485F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.48515F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Controls.Add(this.BT_DELETE, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BT_CANCEL, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BT_LOAD, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 369);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(303, 37);
            this.tableLayoutPanel2.TabIndex = 38;
            // 
            // Caught
            // 
            this.Caught.AutoSize = true;
            this.Caught.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Caught.Location = new System.Drawing.Point(3, 0);
            this.Caught.Name = "Caught";
            this.Caught.Size = new System.Drawing.Size(61, 26);
            this.Caught.TabIndex = 33;
            this.Caught.Text = "Caught";
            this.Caught.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(70, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 26);
            this.label1.TabIndex = 34;
            this.label1.Text = "Dex";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(110, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 36;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(179, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 37;
            this.label3.Text = "Encounters";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PokemonCounter.Properties.Resources.magnifier;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // PkmnLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 446);
            this.Controls.Add(this.PNL_CONTENT);
            this.Controls.Add(this.PNL_MENU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PkmnLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Load";
            this.Load += new System.EventHandler(this.PkmnLoad_Load);
            this.PNL_MENU.ResumeLayout(false);
            this.PNL_CONTENT.ResumeLayout(false);
            this.PNL_SEARCH.ResumeLayout(false);
            this.PNL_SEARCH.PerformLayout();
            this.TBL_SEARCH.ResumeLayout(false);
            this.TBL_SEARCH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PKMN)).EndInit();
            this.CMS_DGV.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_MENU;
        private System.Windows.Forms.Button BT_MINIMIZE;
        private System.Windows.Forms.Button BT_CLOSE;
        private System.Windows.Forms.Panel PNL_CONTENT;
        private System.Windows.Forms.Button BT_CANCEL;
        private System.Windows.Forms.Button BT_LOAD;
        private System.Windows.Forms.DataGridView DGV_PKMN;
        private System.Windows.Forms.Button BT_DELETE;
        private System.Windows.Forms.ContextMenuStrip CMS_DGV;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.TextBox TB_COUNT;
        private System.Windows.Forms.TextBox TB_NAME;
        private System.Windows.Forms.TextBox TB_DEX;
        private System.Windows.Forms.CheckBox CKB_CAUGHT;
        private System.Windows.Forms.DataGridViewImageColumn DGV_Icon;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGV_Caught;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Dexnmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Encounters;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_counterRatio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGV_alpha;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_pkmnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_genIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_gameIndex;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGV_shiny;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGV_animated;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGV_autosave;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_addHotkey;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_subHotkey;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_resetHotkey;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGV_exportCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_exportFileCounter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGV_importPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_importFilePicture;
        private System.Windows.Forms.Panel PNL_SEARCH;
        private System.Windows.Forms.Panel PNL_SEARCH_UNDERLINE;
        private System.Windows.Forms.TableLayoutPanel TBL_SEARCH;
        private System.Windows.Forms.Label LBL_SEARCH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Caught;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}