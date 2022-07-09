using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Ramenen_For_Work {
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class cder : Form {

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
            ListBox1 = new ListBox();
            PictureBox1 = new PictureBox();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ListBox1
            // 
            ListBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            ListBox1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListBox1.FormattingEnabled = true;
            ListBox1.ItemHeight = 20;
            ListBox1.Location = new Point(0, 0);
            ListBox1.Margin = new Padding(2);
            ListBox1.Name = "ListBox1";
            ListBox1.Size = new Size(600, 324);
            ListBox1.TabIndex = 0;
            // 
            // PictureBox1
            // 
            PictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PictureBox1.BackColor = SystemColors.ActiveCaptionText;
            PictureBox1.Location = new Point(510, 347);
            PictureBox1.Margin = new Padding(2);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(81, 75);
            PictureBox1.TabIndex = 1;
            PictureBox1.TabStop = false;
            // 
            // Button1
            // 
            Button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Button1.Font = new Font("Arial", 22.0f);
            Button1.Location = new Point(9, 347);
            Button1.Margin = new Padding(2);
            Button1.Name = "Button1";
            Button1.Size = new Size(496, 75);
            Button1.TabIndex = 2;
            Button1.Text = "Open File";
            Button1.UseVisualStyleBackColor = true;
            // 
            // cder
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(600, 431);
            Controls.Add(Button1);
            Controls.Add(PictureBox1);
            Controls.Add(ListBox1);
            Cursor = Cursors.Default;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "cder";
            Text = "Ramenen - rXplorer";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ResumeLayout(false);

        }

        internal ListBox ListBox1;
        internal PictureBox PictureBox1;
        internal Button Button1;
    }
}