using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Ramenen_For_Work {
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Update : Form {

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
            Label1 = new Label();
            Label2 = new Label();
            RichTextBox1 = new RichTextBox();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label1.Location = new Point(162, 19);
            Label1.Name = "Label1";
            Label1.Size = new Size(223, 20);
            Label1.TabIndex = 0;
            Label1.Text = "There is an update available!";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label2.Location = new Point(12, 40);
            Label2.Name = "Label2";
            Label2.Size = new Size(102, 20);
            Label2.TabIndex = 1;
            Label2.Text = "Changelogs:";
            // 
            // RichTextBox1
            // 
            RichTextBox1.Location = new Point(13, 72);
            RichTextBox1.Name = "RichTextBox1";
            RichTextBox1.Size = new Size(529, 138);
            RichTextBox1.TabIndex = 2;
            RichTextBox1.Text = "";
            // 
            // Button1
            // 
            Button1.Location = new Point(142, 230);
            Button1.Name = "Button1";
            Button1.Size = new Size(229, 28);
            Button1.TabIndex = 3;
            Button1.Text = "Download new version";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(554, 270);
            Controls.Add(Button1);
            Controls.Add(RichTextBox1);
            Controls.Add(Label2);
            Controls.Add(Label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Update";
            Text = "Update";
            Load += new EventHandler(Update_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal Label Label2;
        internal RichTextBox RichTextBox1;
        internal Button Button1;
    }
}