using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Ramenen_For_Work {
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Notepad : Form {

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
            RichTextBox1 = new RichTextBox();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            ListBox1 = new ListBox();
            ListBox1.SelectedIndexChanged += new EventHandler(ListBox1_SelectedIndexChanged);
            SuspendLayout();
            // 
            // RichTextBox1
            // 
            RichTextBox1.Location = new Point(13, 13);
            RichTextBox1.Name = "RichTextBox1";
            RichTextBox1.Size = new Size(508, 355);
            RichTextBox1.TabIndex = 0;
            RichTextBox1.Text = "";
            // 
            // Button1
            // 
            Button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Button1.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button1.ForeColor = SystemColors.ActiveCaptionText;
            Button1.Location = new Point(-6, 375);
            Button1.Name = "Button1";
            Button1.Size = new Size(175, 29);
            Button1.TabIndex = 1;
            Button1.Text = "Save";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Button2.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button2.ForeColor = SystemColors.ActiveCaptionText;
            Button2.Location = new Point(175, 375);
            Button2.Name = "Button2";
            Button2.Size = new Size(175, 29);
            Button2.TabIndex = 2;
            Button2.Text = "Save As...";
            Button2.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            Button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Button3.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button3.ForeColor = SystemColors.ActiveCaptionText;
            Button3.Location = new Point(356, 375);
            Button3.Name = "Button3";
            Button3.Size = new Size(178, 29);
            Button3.TabIndex = 3;
            Button3.Text = "Open";
            Button3.UseVisualStyleBackColor = true;
            // 
            // ListBox1
            // 
            ListBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            ListBox1.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListBox1.FormattingEnabled = true;
            ListBox1.ItemHeight = 16;
            ListBox1.Location = new Point(13, 13);
            ListBox1.Name = "ListBox1";
            ListBox1.Size = new Size(508, 356);
            ListBox1.TabIndex = 4;
            ListBox1.Visible = false;
            // 
            // Notepad
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 416);
            Controls.Add(ListBox1);
            Controls.Add(Button3);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(RichTextBox1);
            Name = "Notepad";
            ShowIcon = false;
            Text = "Notepad";
            Load += new EventHandler(Notepad_Load);
            ResumeLayout(false);

        }

        internal RichTextBox RichTextBox1;
        internal Button Button1;
        internal Button Button2;
        internal Button Button3;
        internal ListBox ListBox1;
    }
}