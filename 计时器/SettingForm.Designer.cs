namespace 计时器
{
    partial class SettingForm
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
            colorDialog1 = new ColorDialog();
            label1 = new Label();
            cb描边 = new CheckBox();
            cb显示阴影 = new CheckBox();
            cb阴影描边 = new CheckBox();
            btn描边颜色 = new Button();
            btn阴影的描边颜色 = new Button();
            btn文本颜色 = new Button();
            btn保存 = new Button();
            btn取消 = new Button();
            cb字体 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            gb描边 = new GroupBox();
            gb阴影 = new GroupBox();
            nud阴影距离 = new NumericUpDown();
            label14 = new Label();
            nud阴影的透明度 = new NumericUpDown();
            label5 = new Label();
            gb文本 = new GroupBox();
            label10 = new Label();
            nud字号 = new NumericUpDown();
            cb时间格式 = new ComboBox();
            label8 = new Label();
            gb结束提示音 = new GroupBox();
            btn播放选中的音频1 = new Button();
            label6 = new Label();
            cb结束提示音文件 = new ComboBox();
            cb播放结束提示音 = new CheckBox();
            gb预警提示音 = new GroupBox();
            btn播放选中的音频2 = new Button();
            cb预警提示音文件 = new ComboBox();
            label9 = new Label();
            nud预警时长 = new NumericUpDown();
            l预警时长 = new Label();
            label7 = new Label();
            cb播放预警提示音 = new CheckBox();
            l总时长 = new Label();
            nud总时长 = new NumericUpDown();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            cb计时模式 = new ComboBox();
            cb窗体置顶 = new CheckBox();
            gb描边.SuspendLayout();
            gb阴影.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud阴影距离).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud阴影的透明度).BeginInit();
            gb文本.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud字号).BeginInit();
            gb结束提示音.SuspendLayout();
            gb预警提示音.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud预警时长).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud总时长).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 77);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 31);
            label1.TabIndex = 0;
            label1.Text = "字体";
            // 
            // cb描边
            // 
            cb描边.AutoSize = true;
            cb描边.Checked = true;
            cb描边.CheckState = CheckState.Checked;
            cb描边.Location = new Point(66, 416);
            cb描边.Margin = new Padding(4);
            cb描边.Name = "cb描边";
            cb描边.Size = new Size(94, 35);
            cb描边.TabIndex = 8;
            cb描边.Text = "描边";
            cb描边.UseVisualStyleBackColor = true;
            cb描边.CheckedChanged += cb描边_CheckedChanged;
            // 
            // cb显示阴影
            // 
            cb显示阴影.AutoSize = true;
            cb显示阴影.Checked = true;
            cb显示阴影.CheckState = CheckState.Checked;
            cb显示阴影.Location = new Point(668, 418);
            cb显示阴影.Margin = new Padding(4);
            cb显示阴影.Name = "cb显示阴影";
            cb显示阴影.Size = new Size(142, 35);
            cb显示阴影.TabIndex = 10;
            cb显示阴影.Text = "显示阴影";
            cb显示阴影.UseVisualStyleBackColor = true;
            cb显示阴影.CheckedChanged += cb显示阴影_CheckedChanged;
            // 
            // cb阴影描边
            // 
            cb阴影描边.AutoSize = true;
            cb阴影描边.Location = new Point(30, 151);
            cb阴影描边.Margin = new Padding(4);
            cb阴影描边.Name = "cb阴影描边";
            cb阴影描边.Size = new Size(142, 35);
            cb阴影描边.TabIndex = 4;
            cb阴影描边.Text = "阴影描边";
            cb阴影描边.UseVisualStyleBackColor = true;
            // 
            // btn描边颜色
            // 
            btn描边颜色.Location = new Point(120, 62);
            btn描边颜色.Margin = new Padding(4);
            btn描边颜色.Name = "btn描边颜色";
            btn描边颜色.Size = new Size(150, 46);
            btn描边颜色.TabIndex = 1;
            btn描边颜色.UseVisualStyleBackColor = true;
            btn描边颜色.Click += btn描边颜色_Click;
            // 
            // btn阴影的描边颜色
            // 
            btn阴影的描边颜色.Location = new Point(304, 148);
            btn阴影的描边颜色.Margin = new Padding(4);
            btn阴影的描边颜色.Name = "btn阴影的描边颜色";
            btn阴影的描边颜色.Size = new Size(150, 46);
            btn阴影的描边颜色.TabIndex = 6;
            btn阴影的描边颜色.UseVisualStyleBackColor = true;
            btn阴影的描边颜色.Click += btn阴影的描边颜色_Click;
            // 
            // btn文本颜色
            // 
            btn文本颜色.Location = new Point(120, 146);
            btn文本颜色.Margin = new Padding(4);
            btn文本颜色.Name = "btn文本颜色";
            btn文本颜色.Size = new Size(150, 46);
            btn文本颜色.TabIndex = 3;
            btn文本颜色.UseVisualStyleBackColor = true;
            btn文本颜色.Click += btn文本颜色_Click;
            // 
            // btn保存
            // 
            btn保存.Location = new Point(448, 977);
            btn保存.Margin = new Padding(4);
            btn保存.Name = "btn保存";
            btn保存.Size = new Size(150, 46);
            btn保存.TabIndex = 16;
            btn保存.Text = "保存(&S)";
            btn保存.UseVisualStyleBackColor = true;
            btn保存.Click += btn保存_Click;
            // 
            // btn取消
            // 
            btn取消.DialogResult = DialogResult.Cancel;
            btn取消.Location = new Point(658, 977);
            btn取消.Margin = new Padding(4);
            btn取消.Name = "btn取消";
            btn取消.Size = new Size(150, 46);
            btn取消.TabIndex = 17;
            btn取消.Text = "取消(&C)";
            btn取消.UseVisualStyleBackColor = true;
            // 
            // cb字体
            // 
            cb字体.DrawMode = DrawMode.OwnerDrawVariable;
            cb字体.DropDownStyle = ComboBoxStyle.DropDownList;
            cb字体.FormattingEnabled = true;
            cb字体.Location = new Point(120, 69);
            cb字体.Margin = new Padding(4);
            cb字体.Name = "cb字体";
            cb字体.Size = new Size(562, 39);
            cb字体.TabIndex = 1;
            cb字体.DrawItem += cb字体_DrawItem;
            cb字体.MeasureItem += cb字体_MeasureItem;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 153);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 31);
            label2.TabIndex = 2;
            label2.Text = "颜色";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 69);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 31);
            label3.TabIndex = 0;
            label3.Text = "颜色";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(224, 155);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 31);
            label4.TabIndex = 5;
            label4.Text = "颜色";
            // 
            // gb描边
            // 
            gb描边.Controls.Add(label3);
            gb描边.Controls.Add(btn描边颜色);
            gb描边.Location = new Point(50, 418);
            gb描边.Margin = new Padding(4);
            gb描边.Name = "gb描边";
            gb描边.Padding = new Padding(4);
            gb描边.Size = new Size(548, 232);
            gb描边.TabIndex = 9;
            gb描边.TabStop = false;
            // 
            // gb阴影
            // 
            gb阴影.Controls.Add(nud阴影距离);
            gb阴影.Controls.Add(label14);
            gb阴影.Controls.Add(nud阴影的透明度);
            gb阴影.Controls.Add(label5);
            gb阴影.Controls.Add(cb阴影描边);
            gb阴影.Controls.Add(label4);
            gb阴影.Controls.Add(btn阴影的描边颜色);
            gb阴影.Location = new Point(646, 418);
            gb阴影.Margin = new Padding(4);
            gb阴影.Name = "gb阴影";
            gb阴影.Padding = new Padding(4);
            gb阴影.Size = new Size(612, 232);
            gb阴影.TabIndex = 11;
            gb阴影.TabStop = false;
            // 
            // nud阴影距离
            // 
            nud阴影距离.Location = new Point(148, 66);
            nud阴影距离.Margin = new Padding(6, 5, 6, 5);
            nud阴影距离.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nud阴影距离.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud阴影距离.Name = "nud阴影距离";
            nud阴影距离.Size = new Size(158, 38);
            nud阴影距离.TabIndex = 1;
            nud阴影距离.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(22, 71);
            label14.Margin = new Padding(6, 0, 6, 0);
            label14.Name = "label14";
            label14.Size = new Size(110, 31);
            label14.TabIndex = 0;
            label14.Text = "阴影距离";
            // 
            // nud阴影的透明度
            // 
            nud阴影的透明度.Location = new Point(448, 66);
            nud阴影的透明度.Margin = new Padding(4);
            nud阴影的透明度.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nud阴影的透明度.Name = "nud阴影的透明度";
            nud阴影的透明度.Size = new Size(134, 38);
            nud阴影的透明度.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(340, 71);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 31);
            label5.TabIndex = 2;
            label5.Text = "透明度";
            // 
            // gb文本
            // 
            gb文本.Controls.Add(label10);
            gb文本.Controls.Add(nud字号);
            gb文本.Controls.Add(cb时间格式);
            gb文本.Controls.Add(label8);
            gb文本.Controls.Add(cb字体);
            gb文本.Controls.Add(label1);
            gb文本.Controls.Add(label2);
            gb文本.Controls.Add(btn文本颜色);
            gb文本.Location = new Point(50, 148);
            gb文本.Margin = new Padding(4);
            gb文本.Name = "gb文本";
            gb文本.Padding = new Padding(4);
            gb文本.Size = new Size(1208, 233);
            gb文本.TabIndex = 7;
            gb文本.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(330, 153);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(62, 31);
            label10.TabIndex = 4;
            label10.Text = "大小";
            // 
            // nud字号
            // 
            nud字号.Location = new Point(424, 148);
            nud字号.Margin = new Padding(6, 5, 6, 5);
            nud字号.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nud字号.Minimum = new decimal(new int[] { 24, 0, 0, 0 });
            nud字号.Name = "nud字号";
            nud字号.Size = new Size(144, 38);
            nud字号.TabIndex = 5;
            nud字号.Value = new decimal(new int[] { 24, 0, 0, 0 });
            // 
            // cb时间格式
            // 
            cb时间格式.DropDownStyle = ComboBoxStyle.DropDownList;
            cb时间格式.FormattingEnabled = true;
            cb时间格式.Location = new Point(738, 146);
            cb时间格式.Margin = new Padding(6, 5, 6, 5);
            cb时间格式.Name = "cb时间格式";
            cb时间格式.Size = new Size(290, 39);
            cb时间格式.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(636, 153);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(62, 31);
            label8.TabIndex = 6;
            label8.Text = "格式";
            // 
            // gb结束提示音
            // 
            gb结束提示音.Controls.Add(btn播放选中的音频1);
            gb结束提示音.Controls.Add(label6);
            gb结束提示音.Controls.Add(cb结束提示音文件);
            gb结束提示音.Location = new Point(50, 695);
            gb结束提示音.Margin = new Padding(4);
            gb结束提示音.Name = "gb结束提示音";
            gb结束提示音.Padding = new Padding(4);
            gb结束提示音.Size = new Size(600, 232);
            gb结束提示音.TabIndex = 13;
            gb结束提示音.TabStop = false;
            // 
            // btn播放选中的音频1
            // 
            btn播放选中的音频1.Image = Properties.Resources.sound;
            btn播放选中的音频1.Location = new Point(472, 58);
            btn播放选中的音频1.Margin = new Padding(4);
            btn播放选中的音频1.Name = "btn播放选中的音频1";
            btn播放选中的音频1.Size = new Size(76, 46);
            btn播放选中的音频1.TabIndex = 2;
            btn播放选中的音频1.UseVisualStyleBackColor = true;
            btn播放选中的音频1.Click += btn播放选中的音频1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 66);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 31);
            label6.TabIndex = 0;
            label6.Text = "音频";
            // 
            // cb结束提示音文件
            // 
            cb结束提示音文件.DropDownStyle = ComboBoxStyle.DropDownList;
            cb结束提示音文件.FormattingEnabled = true;
            cb结束提示音文件.Location = new Point(120, 62);
            cb结束提示音文件.Margin = new Padding(4);
            cb结束提示音文件.Name = "cb结束提示音文件";
            cb结束提示音文件.Size = new Size(322, 39);
            cb结束提示音文件.TabIndex = 1;
            // 
            // cb播放结束提示音
            // 
            cb播放结束提示音.AutoSize = true;
            cb播放结束提示音.Checked = true;
            cb播放结束提示音.CheckState = CheckState.Checked;
            cb播放结束提示音.Location = new Point(80, 693);
            cb播放结束提示音.Margin = new Padding(4);
            cb播放结束提示音.Name = "cb播放结束提示音";
            cb播放结束提示音.Size = new Size(214, 35);
            cb播放结束提示音.TabIndex = 12;
            cb播放结束提示音.Text = "播放结束提示音";
            cb播放结束提示音.UseVisualStyleBackColor = true;
            cb播放结束提示音.CheckedChanged += cb播放结束提示音_CheckedChanged;
            // 
            // gb预警提示音
            // 
            gb预警提示音.Controls.Add(btn播放选中的音频2);
            gb预警提示音.Controls.Add(cb预警提示音文件);
            gb预警提示音.Controls.Add(label9);
            gb预警提示音.Controls.Add(nud预警时长);
            gb预警提示音.Controls.Add(l预警时长);
            gb预警提示音.Controls.Add(label7);
            gb预警提示音.Location = new Point(690, 695);
            gb预警提示音.Margin = new Padding(4);
            gb预警提示音.Name = "gb预警提示音";
            gb预警提示音.Padding = new Padding(4);
            gb预警提示音.Size = new Size(586, 232);
            gb预警提示音.TabIndex = 15;
            gb预警提示音.TabStop = false;
            // 
            // btn播放选中的音频2
            // 
            btn播放选中的音频2.Image = Properties.Resources.sound;
            btn播放选中的音频2.Location = new Point(472, 136);
            btn播放选中的音频2.Margin = new Padding(4);
            btn播放选中的音频2.Name = "btn播放选中的音频2";
            btn播放选中的音频2.Size = new Size(76, 46);
            btn播放选中的音频2.TabIndex = 5;
            btn播放选中的音频2.UseVisualStyleBackColor = true;
            btn播放选中的音频2.Click += btn播放选中的音频2_Click;
            // 
            // cb预警提示音文件
            // 
            cb预警提示音文件.DropDownStyle = ComboBoxStyle.DropDownList;
            cb预警提示音文件.FormattingEnabled = true;
            cb预警提示音文件.Location = new Point(120, 140);
            cb预警提示音文件.Margin = new Padding(4);
            cb预警提示音文件.Name = "cb预警提示音文件";
            cb预警提示音文件.Size = new Size(322, 39);
            cb预警提示音文件.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(464, 71);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(86, 31);
            label9.TabIndex = 2;
            label9.Text = "秒播放";
            // 
            // nud预警时长
            // 
            nud预警时长.Location = new Point(196, 66);
            nud预警时长.Margin = new Padding(4);
            nud预警时长.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nud预警时长.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud预警时长.Name = "nud预警时长";
            nud预警时长.Size = new Size(250, 38);
            nud预警时长.TabIndex = 1;
            nud预警时长.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // l预警时长
            // 
            l预警时长.AutoSize = true;
            l预警时长.Location = new Point(32, 71);
            l预警时长.Margin = new Padding(4, 0, 4, 0);
            l预警时长.Name = "l预警时长";
            l预警时长.Size = new Size(158, 31);
            l预警时长.TabIndex = 0;
            l预警时长.Text = "倒计时结束前";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 144);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(62, 31);
            label7.TabIndex = 3;
            label7.Text = "音频";
            // 
            // cb播放预警提示音
            // 
            cb播放预警提示音.AutoSize = true;
            cb播放预警提示音.Checked = true;
            cb播放预警提示音.CheckState = CheckState.Checked;
            cb播放预警提示音.Location = new Point(720, 695);
            cb播放预警提示音.Margin = new Padding(4);
            cb播放预警提示音.Name = "cb播放预警提示音";
            cb播放预警提示音.Size = new Size(214, 35);
            cb播放预警提示音.TabIndex = 14;
            cb播放预警提示音.Text = "播放预警提示音";
            cb播放预警提示音.UseVisualStyleBackColor = true;
            cb播放预警提示音.CheckedChanged += cb播放预警提示音_CheckedChanged;
            // 
            // l总时长
            // 
            l总时长.AutoSize = true;
            l总时长.Location = new Point(530, 68);
            l总时长.Margin = new Padding(4, 0, 4, 0);
            l总时长.Name = "l总时长";
            l总时长.Size = new Size(86, 31);
            l总时长.TabIndex = 2;
            l总时长.Text = "总时长";
            // 
            // nud总时长
            // 
            nud总时长.Location = new Point(660, 64);
            nud总时长.Margin = new Padding(4);
            nud总时长.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nud总时长.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud总时长.Name = "nud总时长";
            nud总时长.Size = new Size(240, 38);
            nud总时长.TabIndex = 3;
            nud总时长.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(920, 68);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(38, 31);
            label11.TabIndex = 4;
            label11.Text = "秒";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(90, 148);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(62, 31);
            label12.TabIndex = 6;
            label12.Text = "文本";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(62, 68);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(110, 31);
            label13.TabIndex = 0;
            label13.Text = "计时模式";
            // 
            // cb计时模式
            // 
            cb计时模式.DropDownStyle = ComboBoxStyle.DropDownList;
            cb计时模式.FormattingEnabled = true;
            cb计时模式.Location = new Point(198, 64);
            cb计时模式.Margin = new Padding(6, 5, 6, 5);
            cb计时模式.Name = "cb计时模式";
            cb计时模式.Size = new Size(236, 39);
            cb计时模式.TabIndex = 1;
            cb计时模式.SelectedIndexChanged += cb计时模式_SelectedIndexChanged;
            // 
            // cb窗体置顶
            // 
            cb窗体置顶.AutoSize = true;
            cb窗体置顶.Location = new Point(1086, 66);
            cb窗体置顶.Name = "cb窗体置顶";
            cb窗体置顶.Size = new Size(142, 35);
            cb窗体置顶.TabIndex = 5;
            cb窗体置顶.Text = "置顶显示";
            cb窗体置顶.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            AcceptButton = btn保存;
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn取消;
            ClientSize = new Size(1318, 1067);
            Controls.Add(cb窗体置顶);
            Controls.Add(cb计时模式);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(cb播放预警提示音);
            Controls.Add(nud总时长);
            Controls.Add(gb预警提示音);
            Controls.Add(l总时长);
            Controls.Add(cb播放结束提示音);
            Controls.Add(gb结束提示音);
            Controls.Add(cb显示阴影);
            Controls.Add(gb阴影);
            Controls.Add(cb描边);
            Controls.Add(gb描边);
            Controls.Add(btn取消);
            Controls.Add(btn保存);
            Controls.Add(gb文本);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "设置";
            TopMost = true;
            FormClosed += SettingForm_FormClosed;
            gb描边.ResumeLayout(false);
            gb描边.PerformLayout();
            gb阴影.ResumeLayout(false);
            gb阴影.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud阴影距离).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud阴影的透明度).EndInit();
            gb文本.ResumeLayout(false);
            gb文本.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud字号).EndInit();
            gb结束提示音.ResumeLayout(false);
            gb结束提示音.PerformLayout();
            gb预警提示音.ResumeLayout(false);
            gb预警提示音.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud预警时长).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud总时长).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private Label label1;
        private CheckBox cb描边;
        private CheckBox cb显示阴影;
        private CheckBox cb阴影描边;
        private Button btn描边颜色;
        private Button btn阴影的描边颜色;
        private Button btn文本颜色;
        private Button btn保存;
        private Button btn取消;
        private ComboBox cb字体;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox gb描边;
        private GroupBox gb阴影;
        private Label label5;
        private GroupBox gb文本;
        private GroupBox gb结束提示音;
        private CheckBox cb播放结束提示音;
        private GroupBox gb预警提示音;
        private CheckBox cb播放预警提示音;
        private Label label6;
        private Label label7;
        private Label l预警时长;
        private Label label9;
        private NumericUpDown nud预警时长;
        private Label l总时长;
        private NumericUpDown nud总时长;
        private Label label11;
        private ComboBox cb结束提示音文件;
        private ComboBox cb预警提示音文件;
        private Button btn播放选中的音频1;
        private Button btn播放选中的音频2;
        private Label label12;
        private NumericUpDown nud阴影的透明度;
        private Label label13;
		private ComboBox cb计时模式;
		private ComboBox cb时间格式;
		private Label label8;
		private Label label10;
		private NumericUpDown nud字号;
		private Label label14;
		private NumericUpDown nud阴影距离;
        private CheckBox cb窗体置顶;
    }
}