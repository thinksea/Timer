namespace 计时器
{
	partial class About
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			richTextBox1 = new RichTextBox();
			btnCancel = new Button();
			SuspendLayout();
			// 
			// richTextBox1
			// 
			richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			richTextBox1.BorderStyle = BorderStyle.FixedSingle;
			richTextBox1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
			richTextBox1.Location = new Point(16, 8);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.ReadOnly = true;
			richTextBox1.Size = new Size(421, 420);
			richTextBox1.TabIndex = 0;
			richTextBox1.Text = "计时器 v1.1\n\n功能：\n1、正向计时\n2、倒计时\n\n修改音频：\n将音频文件放置在“sound”目录即可。\n支持的音频文件格式：wav\n\n快捷键：\nF2：开始计时|继续计时\nF3：暂停计时|继续计时\nF4：停止计时";
			// 
			// btnCancel
			// 
			btnCancel.DialogResult = DialogResult.Cancel;
			btnCancel.Location = new Point(173, 438);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 1;
			btnCancel.Text = "关闭 (&C)";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// About
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancel;
			ClientSize = new Size(457, 480);
			Controls.Add(btnCancel);
			Controls.Add(richTextBox1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "About";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "使用帮助";
			TopMost = true;
			ResumeLayout(false);
		}

		#endregion

		private RichTextBox richTextBox1;
		private Button btnCancel;
	}
}