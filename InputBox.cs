using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ramenen_For_Work {
    public partial class InputBox : Form {
        public InputBox(string caption, string text) {
            InitializeComponent();
            this.Text = caption;
            label1.Text = text;

            this.DialogResult = DialogResult.None;
        }

        private void InputBox_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
        }

        public static string Show(string caption, string text) {
            using(var ib = new InputBox(caption, text)) {
                ib.ShowDialog();
                return ib.textBox1.Text;
            }
        }
    }
}
