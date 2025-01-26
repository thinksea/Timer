namespace 计时器
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            选项ToolStripMenuItem = new ToolStripMenuItem();
            帮助ToolStripMenuItem = new ToolStripMenuItem();
            退出ToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { 选项ToolStripMenuItem, 帮助ToolStripMenuItem, 退出ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(173, 118);
            // 
            // 选项ToolStripMenuItem
            // 
            选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            选项ToolStripMenuItem.Size = new Size(172, 38);
            选项ToolStripMenuItem.Text = "选项(&O)";
            选项ToolStripMenuItem.Click += 选项ToolStripMenuItem_Click;
            // 
            // 帮助ToolStripMenuItem
            // 
            帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            帮助ToolStripMenuItem.Size = new Size(172, 38);
            帮助ToolStripMenuItem.Text = "帮助(&H)";
            帮助ToolStripMenuItem.Click += 帮助ToolStripMenuItem_Click;
            // 
            // 退出ToolStripMenuItem
            // 
            退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            退出ToolStripMenuItem.Size = new Size(172, 38);
            退出ToolStripMenuItem.Text = "退出(&X)";
            退出ToolStripMenuItem.Click += 退出ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 350);
            ContextMenuStrip = contextMenuStrip1;
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "计时器";
            TopMost = true;
            TransparencyKey = SystemColors.Control;
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            Paint += Form1_Paint;
            KeyDown += Form1_KeyDown;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 选项ToolStripMenuItem;
        private ToolStripMenuItem 退出ToolStripMenuItem;
		private ToolStripMenuItem 帮助ToolStripMenuItem;
	}
}
