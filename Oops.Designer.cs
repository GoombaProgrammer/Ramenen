using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Ramenen_For_Work {
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Oops : Form {

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
            Reason = new Label();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(13, 13);
            Label1.Name = "Label1";
            Label1.Size = new Size(141, 25);
            Label1.TabIndex = 0;
            Label1.Text = "Ramenen error";
            // 
            // Reason
            // 
            Reason.BackColor = SystemColors.ButtonShadow;
            Reason.Location = new Point(12, 53);
            Reason.Name = "Reason";
            Reason.Size = new Size(559, 162);
            Reason.TabIndex = 1;
            Reason.Text = "yesnt";
            // 
            // Oops
            // 
            AutoScaleDimensions = new SizeF(12.0f, 25.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(583, 224);
            Controls.Add(Reason);
            Controls.Add(Label1);
            Font = new Font("Microsoft Sans Serif", 15.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6);
            Name = "Oops";
            Text = "Oops";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal Label Reason;
    }
}