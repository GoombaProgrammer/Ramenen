using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Ramenen_For_Work {

    public partial class MDIParent1 {
        public bool dontAskClose = false;
        public int unwanted, potentialVirus, virus, closeToDebug, m_ChildFormNumber = 0;
        public string version = "1.0";
        public string RootPath { get; set; } = @"C:\VirtualSystem\Ramenen";

        public static MDIParent1 CurrentInstance { get; private set; }

        public MDIParent1() {
            InitializeComponent();
            CurrentInstance = this;
        }

        private void ShowNewForm(object sender, EventArgs e) {
            Form childForm = new() { MdiParent = this };
            m_ChildFormNumber++;
            childForm.Text = "Window " + m_ChildFormNumber;
            childForm.Show();
        }

        private void Closings(object sender, EventArgs e) {
            if (!dontAskClose) {
                var answer = MessageBox.Show("This will end your Ramenen session.", "End Ramenen", MessageBoxButtons.YesNo);

                if (answer == DialogResult.No) {
                    MDIParent1 newMe = new();

                    foreach (Form childForm in MdiChildren) {
                        childForm.MdiParent = newMe;
                    }

                    newMe.Show();
                    dontAskClose = true;
                    this.Close();
                }
            }
        }

        private void OpenFile(object sender, EventArgs e) {
            OpenFileDialog dialog = new() {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };

            if (dialog.ShowDialog() == DialogResult.OK) {
                string fileName = dialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e) {
            // Use My.Computer.Clipboard to insert the selected text or images into the clipboard
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e) {
            // Use My.Computer.Clipboard to insert the selected text or images into the clipboard
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileVertical);

            if (closeToDebug == 1) {
                MessageBox.Show("You are now in debug mode!");
                ShowInTaskbar = true;
                TopMost = false;
                FormBorderStyle = FormBorderStyle.SizableToolWindow;
                closeToDebug = 0;
            }
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (Form childForm in MdiChildren) {
                childForm.Close();
            }
        }

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e) {
            var settings = MessageBox.Show("Do you want me to hide in the taskbar?", "Settings", MessageBoxButtons.YesNo);

            if (settings == DialogResult.Yes) {
                ShowInTaskbar = false;
            } else {
                ShowInTaskbar = true;
            }
        }

        private void ContentsToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void MDIParent1_Load(object sender, EventArgs e) {
            // Conversion note: Improve initial creation by using a zip archive
            if (!Directory.Exists(RootPath)) {
                Directory.CreateDirectory(RootPath);

                using (var memoryStream = new MemoryStream(Properties.Resources._default)) {
                    var archive = new ZipArchive(memoryStream);
                    archive.ExtractToDirectory(RootPath);
                }
            }

            MenuStrip.BackColor = Color.FromName(INI.ReadIni(@$"{RootPath}\Groups\System\ramenen.ini", "Colors", "StripColor"));

            // Conversion note: Don't waste time on P/Invoke calls for every MdiClient Control
            Color bgColor = Color.FromName(INI.ReadIni(@$"{RootPath}\Groups\System\ramenen.ini", "Colors", "BackgroundColor"));

            foreach (Control ctl in Controls) {
                if (ctl is MdiClient) {
                    ctl.BackColor = bgColor;
                }
            }

            ListBox1.BackColor = Color.FromName(INI.ReadIni(@$"{RootPath}\Groups\System\ramenen.ini", "Colors", "GroupsColor"));

            // Conversion note: Don't read the file every time
            string rasContent = File.ReadAllText($@"{RootPath}\Groups\System\status.ras");

            switch (rasContent) {
                case "2":
                    Directory.Delete(RootPath, true);
                    Application.Exit();
                    break;
                case "1":
                    break;
                case "0":
                    MessageBox.Show("Debug MsgBox");
                    break;
                default:
                    Application.Exit();
                    break;
            }

            UpdateGroups();

            CheckVersionAsync();
        }

        public async void CheckVersionAsync() {
            using (var httpClient = new HttpClient()) {
                string res = await httpClient.GetStringAsync("http://taart.site/ramenen/ver.txt");

                if (!version.StartsWith(res)) {
                    var updateDialog = new Update();
                    updateDialog.MdiParent = this;
                    updateDialog.Show();
                }
            }
        }

        private void CreateFolderToolStripMenuItem_Click(object sender, EventArgs e) {
            this.TopMost = false;
            var fName = InputBox.Show("Group name:", "Enter a name for the group.");
            Directory.CreateDirectory($@"{RootPath}\Groups\" + fName.Replace("..", ""));
            UpdateGroups();
            this.TopMost = true;
        }

        public void UpdateGroups() {
            Directory.CreateDirectory($@"{RootPath}\Groups");
            ListBox1.Items.Clear();

            DirectoryInfo dirInfo = new DirectoryInfo($@"{RootPath}\Groups");
            DirectoryInfo[] dirInfoArray = dirInfo.GetDirectories();

            foreach (var fri in dirInfoArray) {
                ListBox1.Items.Add(fri.Name);
            }
        }

        private void ListBox1_DoubleClick(object sender, EventArgs e) {
            if (!(ListBox1.SelectedIndex == -1)) {
                if (Directory.Exists($@"{RootPath}\Groups\" + ListBox1.SelectedItem)) {
                    var newChild = new cder();
                    var dirInfo = new DirectoryInfo($@"{RootPath}\Groups\" + ListBox1.SelectedItem);
                    var fiArr = dirInfo.GetFiles();

                    foreach (var fri in fiArr) {
                        newChild.ListBox1.Items.Add(ListBox1.SelectedItem.ToString().Split('\\')[0] + "\\" + fri.Name);
                    }

                    newChild.MdiParent = this;
                    newChild.Show();
                } else {
                    UpdateGroups();
                }
            }
        }

        private void NewFileToolStripMenuItem_Click(object sender, EventArgs e) {
            this.TopMost = false;
            string newFileName = InputBox.Show("New file", "Enter the group and file name. For example: groupname\\foo.bar");

            if(!newFileName.Contains('\\')) {
                MessageBox.Show("Invalid path.");
            }else {
                if (Directory.Exists($@"{RootPath}\Groups\{newFileName.Split('\\')[0]}")) {
                    File.Create($@"{RootPath}\Groups\{newFileName.Split('\\')[0]}\{newFileName.Split('\\')[1]}").Close();
                }else {
                    MessageBox.Show("Group does not exist.");
                }
            }

            this.TopMost = true;
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e) {
            ListBox1.Visible = ToolBarToolStripMenuItem.Checked;    
        }

        private void AntiVirusToolStripMenuItem_Click(object sender, EventArgs e) {
            this.TopMost = false;
            var answer = MessageBox.Show("Do you want to edit the Ramenen Firewall/Anti-Virus configuration?", "Ramenen Firewall", MessageBoxButtons.YesNo);

            if(answer == DialogResult.Yes) {
                var notepad = new Notepad();
                notepad.MdiParent = this;
                notepad.Open($@"{RootPath}\Groups\System\firewall.ini");
                notepad.Directory = "System";
                notepad.Show();
            }
        }

        private void ScanForVirussesToolStripMenuItem_Click(object sender, EventArgs e) {
            GetFiles(RootPath);

            MessageBox.Show("Complete. " + (virus + potentialVirus + unwanted) + " virus found, where " + (potentialVirus + unwanted) + " may not be a virus");

            unwanted = 0;
            potentialVirus = 0;
            virus = 0;
        }

        public void GetFiles(string path) {
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly);

            bool allowAllFileNames = INI.ReadIni($@"{RootPath}\Groups\System\firewall.ini", "Protection", "AllowAllFileNames") == "False";

            // Conversion note: The anti virus seems pretty shitty, no front, not gonna implement (at least for now)
            foreach(string file in files) {

            }
        }

        private void RenameToolStripMenuItem_Click(object e, EventArgs e) {
            try {
                this.TopMost = false;
                string oldName = InputBox.Show("InputBox", "Enter the file name and group you want to move (ex. Programs\\tgo.rex)");
                string newName = InputBox.Show("InputBox", "Enter the file name and groups (ex. Programs\\tgo_backup.rex)");
                this.TopMost = true;

                File.Move($@"{RootPath}\Groups\" + oldName, $@"{RootPath}\Groups\" + newName);

                // Conversion note: Is this even needed?
                var newMe = new MDIParent1();

                foreach(Form childForm in MdiChildren) {
                    childForm.MdiParent = this;
                }

                newMe.Show();
                dontAskClose = true;
                Close();
            }catch(Exception ex) {
                var newOops = new Oops();
                newOops.SetReason("Fatal error during move! Does the file / group exist?");
                newOops.MdiParent = this;
                newOops.Show();
            }
        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            ListBox1.Visible = ToolBarToolStripMenuItem.Checked;
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e) {
            TopMost = false;
            string oldName = InputBox.Show("InputBox", "Which file or group do you want to delete? (ex Programs\\example.rex)").Replace("..", "");
            TopMost = true;

            try {
                if(oldName != string.Empty) {
                    if(File.Exists($@"{RootPath}\Groups\{oldName}")) {
                        File.Delete($@"{RootPath}\Groups\{oldName}");
                    }else {
                        if(Directory.Exists($@"{RootPath}\Groups\{oldName}")) {
                            Directory.Delete($@"{RootPath}\Groups\{oldName}", true);
                        }
                    }
                }else {
                    var newOops = new Oops();
                    newOops.SetReason("Fatal error during deletion! Does the file / group exist?");
                    newOops.MdiParent = this;
                    newOops.Show();
                }
            }catch(Exception ex) {
                var newOops = new Oops();
                newOops.SetReason("Fatal error during deletion! Does the file / group exist?");
                newOops.MdiParent = this;
                newOops.Show();
            }

            UpdateGroups();
        }

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e) {
            dontAskClose = true;
            Application.Restart();
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e) {
            Close();
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e) {
            UpdateGroups();
        }

        private void CreditsToolStripMenuItem_Click(object sender, EventArgs e) {
            TopMost = false;
            MessageBox.Show("Main developer: Imusing / Ava#7777. NoodleStore and some other stuff by GoldenretriverYT. You, for using this!");
            TopMost = true;
        }
    }
}