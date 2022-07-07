using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Ramenen_For_Work {
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class SplashScreen1 : Form {

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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen1));
            PictureBox1 = new PictureBox();
            startupTimer = new Timer(components);
            startupTimer.Tick += new EventHandler(startupTimer_Tick);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PictureBox1
            // 
            PictureBox1.BackgroundImage = (Image)resources.GetObject("PictureBox1.BackgroundImage");
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBox1.Dock = DockStyle.Fill;
            PictureBox1.Location = new Point(0, 0);
            PictureBox1.Margin = new Padding(2, 2, 2, 2);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(297, 452);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // startupTimer
            // 
            startupTimer.Enabled = true;
            startupTimer.Interval = 4966;
            // 
            // SplashScreen1
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 452);
            ControlBox = false;
            Controls.Add(PictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SplashScreen1";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(SplashScreen1_Load);
            ResumeLayout(false);

        }

        internal PictureBox PictureBox1;
        internal Timer startupTimer;
    }
}