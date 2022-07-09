using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Ramenen_For_Work {
    public partial class cder {
        private Process myProcess = new();
        private IntPtr myHandle;

        [DllImport("user32.dll", SetLastError = true)]
        private extern static long SetParent(long hWndChild, long hWndNewParent);
        [DllImport("user32.dll", SetLastError = true)]
        private extern static long FindWindowA(string lpClassName, string lpWindowName);


        public cder() {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            if (ListBox1.SelectedIndex == -1) return;

            string fileName = ListBox1.SelectedItem.ToString().ToLowerInvariant();
            
            if(fileName.EndsWith(".txt") || fileName.EndsWith(".doc") || fileName.EndsWith(".ini")) {
                var notepad = new Notepad();
                notepad.MdiParent = MDIParent1.CurrentInstance;
                notepad.Open($@"C:\VirtualSystem\Ramenen\Groups\{ListBox1.SelectedItem.ToString()}");
                notepad.Directory = ListBox1.SelectedItem.ToString().Split('\\')[0];
                notepad.Show();
            }else if(fileName.EndsWith(".png") || fileName.EndsWith(".jpg")) {
                Oops oops = new();
                oops.MdiParent = MDIParent1.CurrentInstance;
                oops.SetReason("Photo Viewer coming soon.");
                oops.Show();
            } else if (fileName.EndsWith(".ras") || fileName.EndsWith(".dll")) {
                Oops oops = new();
                oops.MdiParent = MDIParent1.CurrentInstance;
                oops.SetReason("You can not open system files.");
                oops.Show();
            } else if(fileName.EndsWith(".com") || fileName.EndsWith(".rex")) {
                try {
                    Form child;
                    AssemblyName t = new();
                    Assembly asm = Assembly.LoadFrom($@"C:\VirtualSystem\Ramenen\Groups\{ListBox1.SelectedItem.ToString}");
                    Type type = asm.GetType(GetAssemblyNamespace(asm) + ".RamenenDefault", true, true);
                    child = (Form)Activator.CreateInstance(type);
                    child.MdiParent = MDIParent1.CurrentInstance;
                    child.Show();
                }catch (Exception ex) {
                    Oops oops = new();
                    oops.MdiParent = MDIParent1.CurrentInstance;
                    oops.SetReason("The executable is corrupt or invalid");
                    oops.Show();
                }
            } else {
                if(INI.ReadIni(@"C:\VirtualSystem\Ramenen\Groups\System\firewall.ini", "Block", "UnknownExtensions") == "False") {
                    var notepad = new Notepad();
                    notepad.MdiParent = MDIParent1.CurrentInstance;
                    notepad.Open($@"C:\VirtualSystem\Ramenen\Groups\{ListBox1.SelectedItem.ToString()}");
                    notepad.Directory = ListBox1.SelectedItem.ToString().Split('\\')[0];
                    notepad.Show();
                } else {
                    Oops oops = new();
                    oops.MdiParent = MDIParent1.CurrentInstance;
                    oops.SetReason("The file is unknown and has been blocked for security");
                    oops.Show();
                }
            }
        }

        private string GetAssemblyNamespace(Assembly asm) {
            string ns = "";

            foreach (Type tp in asm.GetModules().First().GetTypes()) {
                if (ns.Length == 0 ? true : tp.Namespace.Length < ns.Length)
                    ns = tp.Namespace;
            }

            return ns;
        }
    }
}