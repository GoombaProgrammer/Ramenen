using System;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Ramenen_For_Work {
    public partial class Notepad {
        public string FullName { get; set; } = "";
        public string Directory { get; set; } = "System";
        private int amountPressed = 0;

        public Notepad() {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e) {
            amountPressed++;

            if(amountPressed == 5) {
                MDIParent1.CurrentInstance.closeToDebug = 1;
            }

            ListBox1.Show();
            ListBox1.Items.Clear();

            DirectoryInfo dirInfo = new($@"C:\VirtualSystem\Ramenen\Groups\{Directory}");
            DirectoryInfo[] fiArr = dirInfo.GetDirectories();

            DirectoryInfo dirInfo2 = new DirectoryInfo(dirInfo.FullName);
            FileInfo[] fiArr2 = dirInfo2.GetFiles();

            foreach(FileInfo fileInfo in fiArr2) {
                ListBox1.Items.Add(fileInfo.Name);
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (ListBox1.SelectedIndex == -1) return;

            StreamReader streader = new($@"C:\VirtualSystem\Ramenen\Groups\{Directory}\{ListBox1.SelectedItem.ToString()}");
            RichTextBox1.Text = streader.ReadToEnd();
            streader.Close();
            ListBox1.Hide();
        }


    }
}