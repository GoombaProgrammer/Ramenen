using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Ramenen_For_Work {
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MDIParent1 : Form {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing) {
            try {
                if (disposing && components is not null) {
                    components.Dispose();
                }
            } finally {
                base.Dispose(disposing);
            }
        }


        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            MenuStrip = new MenuStrip();
            MenuStrip.ItemClicked += new ToolStripItemClickedEventHandler(MenuStrip_ItemClicked);
            FileMenu = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem.Click += new EventHandler(ExitToolsStripMenuItem_Click);
            ExitToolStripMenuItem1 = new ToolStripMenuItem();
            ExitToolStripMenuItem1.Click += new EventHandler(ExitToolStripMenuItem1_Click);
            RestartToolStripMenuItem = new ToolStripMenuItem();
            RestartToolStripMenuItem.Click += new EventHandler(RestartToolStripMenuItem_Click);
            CreateFolderToolStripMenuItem = new ToolStripMenuItem();
            CreateFolderToolStripMenuItem.Click += new EventHandler(CreateFolderToolStripMenuItem_Click);
            NewFileToolStripMenuItem = new ToolStripMenuItem();
            NewFileToolStripMenuItem.Click += new EventHandler(NewFileToolStripMenuItem_Click);
            RenameToolStripMenuItem = new ToolStripMenuItem();
            RenameToolStripMenuItem.Click += new EventHandler(RenameToolStripMenuItem_Click);
            DeleteToolStripMenuItem = new ToolStripMenuItem();
            DeleteToolStripMenuItem.Click += new EventHandler(DeleteToolStripMenuItem_Click);
            EditMenu = new ToolStripMenuItem();
            UndoToolStripMenuItem = new ToolStripMenuItem();
            RedoToolStripMenuItem = new ToolStripMenuItem();
            ToolStripSeparator6 = new ToolStripSeparator();
            CutToolStripMenuItem = new ToolStripMenuItem();
            CutToolStripMenuItem.Click += new EventHandler(CutToolStripMenuItem_Click);
            CopyToolStripMenuItem = new ToolStripMenuItem();
            CopyToolStripMenuItem.Click += new EventHandler(CopyToolStripMenuItem_Click);
            PasteToolStripMenuItem = new ToolStripMenuItem();
            PasteToolStripMenuItem.Click += new EventHandler(PasteToolStripMenuItem_Click);
            ToolStripSeparator7 = new ToolStripSeparator();
            SelectAllToolStripMenuItem = new ToolStripMenuItem();
            ViewMenu = new ToolStripMenuItem();
            ToolBarToolStripMenuItem = new ToolStripMenuItem();
            ToolBarToolStripMenuItem.Click += new EventHandler(ToolBarToolStripMenuItem_Click);
            StatusBarToolStripMenuItem = new ToolStripMenuItem();
            StatusBarToolStripMenuItem.Click += new EventHandler(StatusBarToolStripMenuItem_Click);
            ToolsMenu = new ToolStripMenuItem();
            OptionsToolStripMenuItem = new ToolStripMenuItem();
            OptionsToolStripMenuItem.Click += new EventHandler(OptionsToolStripMenuItem_Click);
            AntiVirusToolStripMenuItem = new ToolStripMenuItem();
            AntiVirusToolStripMenuItem.Click += new EventHandler(AntiVirusToolStripMenuItem_Click);
            ScanForVirussesToolStripMenuItem = new ToolStripMenuItem();
            ScanForVirussesToolStripMenuItem.Click += new EventHandler(ScanForVirussesToolStripMenuItem_Click);
            ToolStripSeparator1 = new ToolStripSeparator();
            CreditsToolStripMenuItem = new ToolStripMenuItem();
            CreditsToolStripMenuItem.Click += new EventHandler(CreditsToolStripMenuItem_Click);
            WindowsMenu = new ToolStripMenuItem();
            CascadeToolStripMenuItem = new ToolStripMenuItem();
            CascadeToolStripMenuItem.Click += new EventHandler(CascadeToolStripMenuItem_Click);
            TileVerticalToolStripMenuItem = new ToolStripMenuItem();
            TileVerticalToolStripMenuItem.Click += new EventHandler(TileVerticalToolStripMenuItem_Click);
            TileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            TileHorizontalToolStripMenuItem.Click += new EventHandler(TileHorizontalToolStripMenuItem_Click);
            CloseAllToolStripMenuItem = new ToolStripMenuItem();
            CloseAllToolStripMenuItem.Click += new EventHandler(CloseAllToolStripMenuItem_Click);
            ArrangeIconsToolStripMenuItem = new ToolStripMenuItem();
            ArrangeIconsToolStripMenuItem.Click += new EventHandler(ArrangeIconsToolStripMenuItem_Click);
            ToolTip = new ToolTip(components);
            ListBox1 = new ListBox();
            ListBox1.DoubleClick += new EventHandler(ListBox1_DoubleClick);
            ContextMenuStrip1 = new ContextMenuStrip(components);
            RefreshToolStripMenuItem = new ToolStripMenuItem();
            RefreshToolStripMenuItem.Click += new EventHandler(RefreshToolStripMenuItem_Click);
            MenuStrip.SuspendLayout();
            ContextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.BackColor = Color.LightGray;
            MenuStrip.ImageScalingSize = new Size(20, 20);
            MenuStrip.Items.AddRange(new ToolStripItem[] { FileMenu, EditMenu, ViewMenu, ToolsMenu, WindowsMenu });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.MdiWindowListItem = WindowsMenu;
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Padding = new Padding(5, 2, 0, 2);
            MenuStrip.Size = new Size(1195, 24);
            MenuStrip.TabIndex = 5;
            MenuStrip.Text = "MenuStrip";
            // 
            // FileMenu
            // 
            FileMenu.DropDownItems.AddRange(new ToolStripItem[] { ExitToolStripMenuItem, CreateFolderToolStripMenuItem, NewFileToolStripMenuItem, RenameToolStripMenuItem, DeleteToolStripMenuItem });
            FileMenu.ImageTransparentColor = SystemColors.ActiveBorder;
            FileMenu.Name = "FileMenu";
            FileMenu.Size = new Size(37, 20);
            FileMenu.Text = "&File";
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ExitToolStripMenuItem1, RestartToolStripMenuItem });
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(178, 22);
            ExitToolStripMenuItem.Text = "E&xit";
            // 
            // ExitToolStripMenuItem1
            // 
            ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1";
            ExitToolStripMenuItem1.Size = new Size(110, 22);
            ExitToolStripMenuItem1.Text = "Exit";
            // 
            // RestartToolStripMenuItem
            // 
            RestartToolStripMenuItem.Name = "RestartToolStripMenuItem";
            RestartToolStripMenuItem.Size = new Size(110, 22);
            RestartToolStripMenuItem.Text = "Restart";
            // 
            // CreateFolderToolStripMenuItem
            // 
            CreateFolderToolStripMenuItem.Name = "CreateFolderToolStripMenuItem";
            CreateFolderToolStripMenuItem.Size = new Size(178, 22);
            CreateFolderToolStripMenuItem.Text = "Create &Group";
            // 
            // NewFileToolStripMenuItem
            // 
            NewFileToolStripMenuItem.Name = "NewFileToolStripMenuItem";
            NewFileToolStripMenuItem.Size = new Size(178, 22);
            NewFileToolStripMenuItem.Text = "New &File";
            // 
            // RenameToolStripMenuItem
            // 
            RenameToolStripMenuItem.Name = "RenameToolStripMenuItem";
            RenameToolStripMenuItem.Size = new Size(178, 22);
            RenameToolStripMenuItem.Text = "M&ove";
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.Size = new Size(178, 22);
            DeleteToolStripMenuItem.Text = "Delete File or Group";
            // 
            // EditMenu
            // 
            EditMenu.DropDownItems.AddRange(new ToolStripItem[] { UndoToolStripMenuItem, RedoToolStripMenuItem, ToolStripSeparator6, CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, ToolStripSeparator7, SelectAllToolStripMenuItem });
            EditMenu.Name = "EditMenu";
            EditMenu.Size = new Size(39, 20);
            EditMenu.Text = "&Edit";
            // 
            // UndoToolStripMenuItem
            // 
            UndoToolStripMenuItem.Image = (Image)resources.GetObject("UndoToolStripMenuItem.Image");
            UndoToolStripMenuItem.ImageTransparentColor = Color.Black;
            UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            UndoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            UndoToolStripMenuItem.Size = new Size(166, 22);
            UndoToolStripMenuItem.Text = "&Undo";
            // 
            // RedoToolStripMenuItem
            // 
            RedoToolStripMenuItem.Image = (Image)resources.GetObject("RedoToolStripMenuItem.Image");
            RedoToolStripMenuItem.ImageTransparentColor = Color.Black;
            RedoToolStripMenuItem.Name = "RedoToolStripMenuItem";
            RedoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            RedoToolStripMenuItem.Size = new Size(166, 22);
            RedoToolStripMenuItem.Text = "&Redo";
            // 
            // ToolStripSeparator6
            // 
            ToolStripSeparator6.Name = "ToolStripSeparator6";
            ToolStripSeparator6.Size = new Size(163, 6);
            // 
            // CutToolStripMenuItem
            // 
            CutToolStripMenuItem.Image = (Image)resources.GetObject("CutToolStripMenuItem.Image");
            CutToolStripMenuItem.ImageTransparentColor = Color.Black;
            CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            CutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            CutToolStripMenuItem.Size = new Size(166, 22);
            CutToolStripMenuItem.Text = "Cu&t";
            // 
            // CopyToolStripMenuItem
            // 
            CopyToolStripMenuItem.Image = (Image)resources.GetObject("CopyToolStripMenuItem.Image");
            CopyToolStripMenuItem.ImageTransparentColor = Color.Black;
            CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            CopyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            CopyToolStripMenuItem.Size = new Size(166, 22);
            CopyToolStripMenuItem.Text = "&Copy";
            // 
            // PasteToolStripMenuItem
            // 
            PasteToolStripMenuItem.Image = (Image)resources.GetObject("PasteToolStripMenuItem.Image");
            PasteToolStripMenuItem.ImageTransparentColor = Color.Black;
            PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            PasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            PasteToolStripMenuItem.Size = new Size(166, 22);
            PasteToolStripMenuItem.Text = "&Paste";
            // 
            // ToolStripSeparator7
            // 
            ToolStripSeparator7.Name = "ToolStripSeparator7";
            ToolStripSeparator7.Size = new Size(163, 6);
            // 
            // SelectAllToolStripMenuItem
            // 
            SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            SelectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            SelectAllToolStripMenuItem.Size = new Size(166, 22);
            SelectAllToolStripMenuItem.Text = "Select &All";
            // 
            // ViewMenu
            // 
            ViewMenu.DropDownItems.AddRange(new ToolStripItem[] { ToolBarToolStripMenuItem, StatusBarToolStripMenuItem });
            ViewMenu.Name = "ViewMenu";
            ViewMenu.Size = new Size(44, 20);
            ViewMenu.Text = "&View";
            // 
            // ToolBarToolStripMenuItem
            // 
            ToolBarToolStripMenuItem.Checked = true;
            ToolBarToolStripMenuItem.CheckOnClick = true;
            ToolBarToolStripMenuItem.CheckState = CheckState.Checked;
            ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem";
            ToolBarToolStripMenuItem.Size = new Size(126, 22);
            ToolBarToolStripMenuItem.Text = "&Toolbar";
            // 
            // StatusBarToolStripMenuItem
            // 
            StatusBarToolStripMenuItem.Checked = true;
            StatusBarToolStripMenuItem.CheckOnClick = true;
            StatusBarToolStripMenuItem.CheckState = CheckState.Checked;
            StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem";
            StatusBarToolStripMenuItem.Size = new Size(126, 22);
            StatusBarToolStripMenuItem.Text = "&Status Bar";
            // 
            // ToolsMenu
            // 
            ToolsMenu.DropDownItems.AddRange(new ToolStripItem[] { OptionsToolStripMenuItem, AntiVirusToolStripMenuItem, ScanForVirussesToolStripMenuItem, ToolStripSeparator1, CreditsToolStripMenuItem });
            ToolsMenu.Name = "ToolsMenu";
            ToolsMenu.Size = new Size(46, 20);
            ToolsMenu.Text = "&Tools";
            // 
            // OptionsToolStripMenuItem
            // 
            OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            OptionsToolStripMenuItem.Size = new Size(162, 22);
            OptionsToolStripMenuItem.Text = "&Options";
            // 
            // AntiVirusToolStripMenuItem
            // 
            AntiVirusToolStripMenuItem.Name = "AntiVirusToolStripMenuItem";
            AntiVirusToolStripMenuItem.Size = new Size(162, 22);
            AntiVirusToolStripMenuItem.Text = "&Firewall Settings";
            // 
            // ScanForVirussesToolStripMenuItem
            // 
            ScanForVirussesToolStripMenuItem.Name = "ScanForVirussesToolStripMenuItem";
            ScanForVirussesToolStripMenuItem.Size = new Size(162, 22);
            ScanForVirussesToolStripMenuItem.Text = "&Scan for Virusses";
            // 
            // ToolStripSeparator1
            // 
            ToolStripSeparator1.Name = "ToolStripSeparator1";
            ToolStripSeparator1.Size = new Size(159, 6);
            // 
            // CreditsToolStripMenuItem
            // 
            CreditsToolStripMenuItem.Name = "CreditsToolStripMenuItem";
            CreditsToolStripMenuItem.Size = new Size(162, 22);
            CreditsToolStripMenuItem.Text = "Credits";
            // 
            // WindowsMenu
            // 
            WindowsMenu.DropDownItems.AddRange(new ToolStripItem[] { CascadeToolStripMenuItem, TileVerticalToolStripMenuItem, TileHorizontalToolStripMenuItem, CloseAllToolStripMenuItem, ArrangeIconsToolStripMenuItem });
            WindowsMenu.Name = "WindowsMenu";
            WindowsMenu.Size = new Size(68, 20);
            WindowsMenu.Text = "&Windows";
            // 
            // CascadeToolStripMenuItem
            // 
            CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem";
            CascadeToolStripMenuItem.Size = new Size(150, 22);
            CascadeToolStripMenuItem.Text = "&Cascade";
            // 
            // TileVerticalToolStripMenuItem
            // 
            TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem";
            TileVerticalToolStripMenuItem.Size = new Size(150, 22);
            TileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            // 
            // TileHorizontalToolStripMenuItem
            // 
            TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem";
            TileHorizontalToolStripMenuItem.Size = new Size(150, 22);
            TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            // 
            // CloseAllToolStripMenuItem
            // 
            CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem";
            CloseAllToolStripMenuItem.Size = new Size(150, 22);
            CloseAllToolStripMenuItem.Text = "C&lose All";
            // 
            // ArrangeIconsToolStripMenuItem
            // 
            ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem";
            ArrangeIconsToolStripMenuItem.Size = new Size(150, 22);
            ArrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            // 
            // ListBox1
            // 
            ListBox1.ContextMenuStrip = ContextMenuStrip1;
            ListBox1.Dock = DockStyle.Left;
            ListBox1.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point);
            ListBox1.FormattingEnabled = true;
            ListBox1.ItemHeight = 15;
            ListBox1.Location = new Point(0, 24);
            ListBox1.Margin = new Padding(2);
            ListBox1.Name = "ListBox1";
            ListBox1.Size = new Size(137, 751);
            ListBox1.TabIndex = 9;
            // 
            // ContextMenuStrip1
            // 
            ContextMenuStrip1.Items.AddRange(new ToolStripItem[] { RefreshToolStripMenuItem });
            ContextMenuStrip1.Name = "ContextMenuStrip1";
            ContextMenuStrip1.Size = new Size(114, 26);
            // 
            // RefreshToolStripMenuItem
            // 
            RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            RefreshToolStripMenuItem.Size = new Size(113, 22);
            RefreshToolStripMenuItem.Text = "Refresh";
            // 
            // MDIParent1
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1195, 775);
            Controls.Add(ListBox1);
            Controls.Add(MenuStrip);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MainMenuStrip = MenuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MDIParent1";
            ShowInTaskbar = false;
            Text = "Ramenen Program Manager";
            WindowState = FormWindowState.Maximized;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ContextMenuStrip1.ResumeLayout(false);
            FormClosing += new FormClosingEventHandler(Closings);
            Load += new EventHandler(MDIParent1_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal ToolStripMenuItem ArrangeIconsToolStripMenuItem;
        internal ToolStripMenuItem CloseAllToolStripMenuItem;
        internal ToolStripMenuItem WindowsMenu;
        internal ToolStripMenuItem CascadeToolStripMenuItem;
        internal ToolStripMenuItem TileVerticalToolStripMenuItem;
        internal ToolStripMenuItem TileHorizontalToolStripMenuItem;
        internal ToolStripMenuItem OptionsToolStripMenuItem;
        internal ToolTip ToolTip;
        internal ToolStripMenuItem ExitToolStripMenuItem;
        internal ToolStripMenuItem FileMenu;
        internal MenuStrip MenuStrip;
        internal ToolStripMenuItem EditMenu;
        internal ToolStripMenuItem UndoToolStripMenuItem;
        internal ToolStripMenuItem RedoToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator6;
        internal ToolStripMenuItem CutToolStripMenuItem;
        internal ToolStripMenuItem CopyToolStripMenuItem;
        internal ToolStripMenuItem PasteToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator7;
        internal ToolStripMenuItem SelectAllToolStripMenuItem;
        internal ToolStripMenuItem ViewMenu;
        internal ToolStripMenuItem ToolBarToolStripMenuItem;
        internal ToolStripMenuItem StatusBarToolStripMenuItem;
        internal ToolStripMenuItem ToolsMenu;
        internal ToolStripMenuItem CreateFolderToolStripMenuItem;
        internal ToolStripMenuItem NewFileToolStripMenuItem;
        internal ListBox ListBox1;
        internal ToolStripMenuItem AntiVirusToolStripMenuItem;
        internal ToolStripMenuItem ScanForVirussesToolStripMenuItem;
        internal ToolStripMenuItem RenameToolStripMenuItem;
        internal ToolStripMenuItem DeleteToolStripMenuItem;
        internal ToolStripMenuItem ExitToolStripMenuItem1;
        internal ToolStripMenuItem RestartToolStripMenuItem;
        internal ContextMenuStrip ContextMenuStrip1;
        internal ToolStripMenuItem RefreshToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator1;
        internal ToolStripMenuItem CreditsToolStripMenuItem;
    }
}