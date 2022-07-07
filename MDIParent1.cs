using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Ramenen_For_Work {

    public partial class MDIParent1 {
        public bool dontAskClose = false;
        public int unwanted, potentiualVirus, virus, closeToDebug, m_ChildFormNumber = 0;
        public string version = "1.0";

        public MDIParent1() {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e) {
            Form childForm = new() { MdiParent = this };
            m_ChildFormNumber++;
            childForm.Text = "Window " + m_ChildFormNumber;
            childForm.Show();
        }

        private void Closings(object sender, EventArgs e) {
            if(!dontAskClose) {
                var answer = MessageBox.Show("This will end your Ramenen session.", "End Ramenen", MessageBoxButtons.YesNo);

                if(answer == DialogResult.No) {
                    MDIParent1 newMe = new();

                    foreach(Form childForm in MdiChildren) {
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

            if(dialog.ShowDialog() == DialogResult.OK) {
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

            if(closeToDebug == 1) {
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
            foreach(Form childForm in MdiChildren) {
                childForm.Close();
            }
        }

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e) {
            var settings = MessageBox.Show("Do you want me to hide in the taskbar?", "Settings", MessageBoxButtons.YesNo);

            if(settings == DialogResult.Yes) {
                ShowInTaskbar = false;
            }else {
                ShowInTaskbar = true;
            }
        }

        private void ContentsToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void MDIParent1_Load(object sender, EventArgs e) {

        }


    }
}