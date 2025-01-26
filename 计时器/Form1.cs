using System.Drawing.Drawing2D;

namespace 计时器
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 获取或设置选项。
        /// </summary>
        private Setting Setting
        {
            get;
            set;
        }

        /// <summary>
        /// 剩余时间/当前时间。
        /// </summary>
        private System.TimeSpan currentTime { get; set; }
        private void 重置时间()
        {
            if (this.Setting.TimerMode == TimerMode.Countdown)
            {
                currentTime = System.TimeSpan.FromSeconds(this.Setting.Duration);
            }
            else
            {
                currentTime = System.TimeSpan.Zero;
            }
        }

        private void 执行一次计数()
        {
            const int step = 1;
            if (this.Setting.TimerMode == TimerMode.Countdown)
            {
                if (currentTime.TotalSeconds >= step)
                {
                    currentTime = currentTime.Add(System.TimeSpan.FromSeconds(-step));
                }
            }
            else
            {
                currentTime = currentTime.Add(System.TimeSpan.FromSeconds(step));
            }
        }

        /// <summary>
        /// 状态
        /// </summary>
        private State State = State.Stop;

        public Form1()
        {
            InitializeComponent();
        }

        private void 保存配置()
        {
            string jsonSetting = System.Text.Json.JsonSerializer.Serialize(this.Setting, Define.JsonSerializerSettings);
            System.IO.File.WriteAllText(Define.SettingFile, jsonSetting);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string settingFile = Define.SettingFile;
            if (System.IO.File.Exists(settingFile))
            {
                string jsonSetting = System.IO.File.ReadAllText(settingFile);
                this.Setting = System.Text.Json.JsonSerializer.Deserialize<Setting>(jsonSetting, Define.JsonDeserializeSettings);
                this.TopMost = this.Setting.TopMost;
                this.Location = new System.Drawing.Point(this.Setting.X, this.Setting.Y);
			}

			this.重置时间();
            this.重置窗体尺寸();
            this.timer1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1: //帮助
                    this.帮助ToolStripMenuItem_Click(null, null);
                    break;
                case Keys.F2: //启动/继续
                    switch (this.State)
                    {
                        case State.Stop:
                            this.重置时间();
                            this.State = State.Run;
                            this.Refresh();
                            break;
                        case State.Suspend:
                            this.State = State.Run;
                            break;
                    }
                    break;
                case Keys.F3: //暂停/继续
                    switch (this.State)
                    {
                        case State.Run:
                            this.State = State.Suspend;
                            break;
                        case State.Suspend:
                            this.State = State.Run;
                            break;
                    }
                    break;
                case Keys.F4: //停止
                    if (this.State != State.Stop)
                    {
                        this.State = State.Stop;
                        this.重置时间();
                        this.Refresh();
                    }
                    break;
                case Keys.Escape: //关闭计时程序
                    this.Close();
                    break;
            }
        }

        private System.Media.SoundPlayer? player { get; set; }
        private void Play(string audioFile)
        {
            if (this.player != null)
            {
                this.player.Stop();
                this.player.Dispose();
                this.player = null;
            }
            this.player = new System.Media.SoundPlayer(audioFile);
            this.player.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.State == State.Run)
            {
                this.执行一次计数();
                if (this.Setting.PlayWarningSound)
                {
                    if (currentTime.TotalSeconds == this.Setting.WarningDuration)
                    {
                        string warningSoundFile = Define.GetSoundFile(this.Setting.WarningSound);
                        this.Play(warningSoundFile);
                    }
                }
                if (this.Setting.PlayEndSound)
                {
                    if ((this.Setting.TimerMode == TimerMode.Countdown && currentTime.TotalSeconds <= 0) || (this.Setting.TimerMode == TimerMode.ForwardTiming && currentTime.TotalSeconds >= this.Setting.Duration))
                    {
                        this.State = State.Stop;
                        string endSoundFile = Define.GetSoundFile(this.Setting.EndSound);
                        this.Play(endSoundFile);
                    }
                }
                this.Refresh();
            }
        }

        private bool dragging = false;
        private System.Drawing.Point 拖拽起始位置_Mouse;
        private System.Drawing.Point 拖拽起始位置_Form;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.dragging = true;
                this.拖拽起始位置_Mouse = System.Windows.Forms.Cursor.Position;
                this.拖拽起始位置_Form = this.Location;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.dragging)
            {
                var dif = System.Windows.Forms.Cursor.Position - new System.Drawing.Size(拖拽起始位置_Mouse);
                this.Location = 拖拽起始位置_Form + new Size(dif);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.dragging = false;
                this.Setting.X = this.Location.X;
                this.Setting.Y = this.Location.Y;
                this.保存配置();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show(this, "确认关闭计时器吗？", "", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.player != null)
            {
                this.player.Stop();
                this.player.Dispose();
                this.player = null;
            }
        }

        /// <summary>
        /// 获取文本格式。
        /// </summary>
        /// <returns></returns>
        private StringFormat GetStringFormat()
        {
            //文本布局信息 详细功能请查看注释
            StringFormat format = StringFormat.GenericTypographic;
            format.Alignment = StringAlignment.Center; //文本水平居中对齐
            format.LineAlignment = StringAlignment.Center; //文本垂直居中对齐
            format.Trimming = StringTrimming.None; //当文本超出显示区域尽可能多的保留字符可视。
            return format;
        }

        //获取需要绘制的path 
        private GraphicsPath GetStringPath(string s, float dpi, RectangleF rect, System.Drawing.Font font, StringFormat format)
        {
            GraphicsPath path = new GraphicsPath();
            //计算文字高度
            float emSize = dpi * font.SizeInPoints / 72;
            //向path中添加字符串及相应信息 
            path.AddString(s, font.FontFamily, (int)font.Style, emSize, rect, format);
            return path;
        }

        private void 重置窗体尺寸()
        {
            string text;
            switch (this.Setting.TimeFormat)
            {
                case TimeFormats.Seconds:
                    text = "999999";
                    break;
                case TimeFormats.Long:
                case TimeFormats.Short:
                default:
                    text = "99:99:99";
                    break;
            }
            System.Drawing.Font font = new System.Drawing.Font(this.Setting.TextFontName, this.Setting.TextFontSize);

            using (var g = this.CreateGraphics())
            {
                var textBoxSize = g.MeasureString(text, font);
                this.ClientSize = textBoxSize.ToSize();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            System.Drawing.Font font = new System.Drawing.Font(this.Setting.TextFontName, this.Setting.TextFontSize);
            const float borderWidth = 1;
            string text;
            switch (this.Setting.TimeFormat)
            {
                case TimeFormats.Long:
                    text = currentTime.ToString("c");
                    break;
                case TimeFormats.Short:
                    if (currentTime.TotalSeconds > 59)
                    {
                        text = currentTime.ToString("c");
                    }
                    else
                    {
                        text = currentTime.TotalSeconds.ToString("0");
                    }
                    break;
                case TimeFormats.Seconds:
                    text = currentTime.TotalSeconds.ToString("0");
                    break;
                default:
                    throw new System.Exception("未能正确识别的枚举类型“" + this.Setting.TimeFormat.ToString() + "”。");
            }
            RectangleF textRect = this.ClientRectangle;//绘制文本的区域。
                                                       //var textBoxSize = g.MeasureString(text, font);
                                                       //float dy = (textRect.Height - textBoxSize.Height) / 2.0f; //计算垂直偏移量
                                                       //float dx = (textRect.Width - textBoxSize.Width) / 2.0f; //计算水平偏移
                                                       //textRect.Offset(dx, dy); //将文字显示的工作区偏移dx,dy，实现文字居中、水平居中、垂直居中

            StringFormat format = this.GetStringFormat();

            g.SmoothingMode = SmoothingMode.HighQuality;//指定抗锯齿的呈现。
            g.InterpolationMode = InterpolationMode.HighQualityBicubic; //指定高质量的双三次插值法。
            g.CompositingQuality = CompositingQuality.HighQuality; //高质量、低速度复合。
            g.PixelOffsetMode = PixelOffsetMode.HighQuality; //指定高质量、低速度呈现。
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit; //在有提示的情况下使用每个字符的标志符号 ClearType 位图来绘制字符。 这是质量最高的设置。 用于利用 ClearType 字体功能。

            float dpi = g.DpiY;
            using (GraphicsPath path = GetStringPath(text, dpi, textRect, font, format))
            {
                if (this.Setting.ShowShadow)
                {
                    //阴影代码
                    RectangleF off = textRect;
                    off.Offset(this.Setting.ShadowOffset, this.Setting.ShadowOffset);//阴影偏移
                    using (GraphicsPath offPath = GetStringPath(text, dpi, off, font, format))
                    {
                        using (Brush b = new System.Drawing.SolidBrush(Color.FromArgb(this.Setting.ShadowAlpha, 0, 0, 0))) //阴影颜色
                        {
                            g.FillPath(b, offPath);
                            if (this.Setting.ShowShadowStroke)
                            {
                                System.Drawing.Pen borderPen = new System.Drawing.Pen(this.Setting.ShadowStrokeColor, borderWidth);
                                g.DrawPath(borderPen, offPath);//给阴影描边
                            }
                            //b.Dispose();
                        }
                    }
                }
                var fillBrush = new System.Drawing.SolidBrush(this.Setting.TextColor);

                g.FillPath(fillBrush, path);//填充轮廓（填充） fillBrush 填充色
                if (this.Setting.ShowStroke)
                {
                    System.Drawing.Pen borderPen = new System.Drawing.Pen(this.Setting.StrokeColor, borderWidth);

                    g.DrawPath(borderPen, path);//绘制轮廓（描边） borderPen 描边色
                }

                //e.Graphics.DrawString(text, font: font, fillBrush, System.Drawing.Point.Empty);
            }

        }

        private void 选项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm form = new();
            if (this.Setting != null)
            {
                form.Setting = this.Setting;
            }
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                this.Setting = form.Setting;
                this.TopMost = this.Setting.TopMost;
                this.State = State.Stop;
                this.重置时间();
                this.重置窗体尺寸();
                this.Refresh();
            }
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About form = new();
            form.ShowDialog(this);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
