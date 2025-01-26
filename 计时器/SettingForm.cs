using System.Windows.Forms;

namespace 计时器
{
    public partial class SettingForm : Form
    {
        /// <summary>
        /// 音频文件。
        /// </summary>
        private System.Collections.Generic.Dictionary<string, string> Sounds = new();

        /// <summary>
        /// 获取或设置选项。
        /// </summary>
        public Setting Setting
        {
            get
            {
                Setting setting = new();

                setting.TimerMode = (TimerMode)this.cb计时模式.SelectedValue;
                setting.Duration = System.Convert.ToInt32(this.nud总时长.Value);
                setting.TopMost = this.cb窗体置顶.Checked;
                setting.PlayEndSound = this.cb播放结束提示音.Checked;
                setting.EndSound = System.IO.Path.GetFileName((string)this.cb结束提示音文件.SelectedValue);

                setting.PlayWarningSound = this.cb播放预警提示音.Checked;
                setting.WarningSound = System.IO.Path.GetFileName((string)this.cb预警提示音文件.SelectedValue);
                setting.WarningDuration = System.Convert.ToInt32(this.nud预警时长.Value);

                setting.TextFontName = this.cb字体.Text;
                setting.TextColor = this.btn文本颜色.BackColor;
                setting.TextFontSize = System.Convert.ToInt32(this.nud字号.Value);
                setting.TimeFormat = (TimeFormats)this.cb时间格式.SelectedValue;
                setting.ShowStroke = this.cb描边.Checked;
                setting.StrokeColor = this.btn描边颜色.BackColor;
                setting.ShowShadow = this.cb显示阴影.Checked;
                setting.ShadowOffset = System.Convert.ToInt32(this.nud阴影距离.Value);
                setting.ShadowAlpha = System.Convert.ToInt32(this.nud阴影的透明度.Value);
                setting.ShowShadowStroke = this.cb阴影描边.Checked;
                setting.ShadowStrokeColor = this.btn阴影的描边颜色.BackColor;
                return setting;
            }
            set
            {
                this.cb计时模式.SelectedValue = value.TimerMode;
                this.nud总时长.Value = value.Duration;
                this.cb窗体置顶.Checked = value.TopMost;
                this.cb播放结束提示音.Checked = value.PlayEndSound;
                this.cb结束提示音文件.SelectedValue = Define.GetSoundFile(value.EndSound);

                this.cb播放预警提示音.Checked = value.PlayWarningSound;
                this.cb预警提示音文件.SelectedValue = Define.GetSoundFile(value.WarningSound);
                this.nud预警时长.Value = value.WarningDuration;

                this.cb字体.Text = value.TextFontName;
                this.btn文本颜色.BackColor = value.TextColor;
                this.nud字号.Value = value.TextFontSize;
                this.cb时间格式.SelectedValue = value.TimeFormat;
                this.cb描边.Checked = value.ShowStroke;
                this.btn描边颜色.BackColor = value.StrokeColor;
                this.cb显示阴影.Checked = value.ShowShadow;
                this.nud阴影距离.Value = value.ShadowOffset;
                this.nud阴影的透明度.Value = value.ShadowAlpha;
                this.cb阴影描边.Checked = value.ShowShadowStroke;
                this.btn阴影的描边颜色.BackColor = value.ShadowStrokeColor;

                this.更新界面();
            }
        }

        public SettingForm()
        {
            InitializeComponent();

            #region 加装计时模式。
            {
                System.Collections.Generic.Dictionary<string, TimerMode> enums = new();
                TimerMode[] timerModeList = System.Enum.GetValues<TimerMode>();
                foreach (var timerMode in timerModeList)
                {
                    enums.Add(Define.GetDescription(timerMode), timerMode);
                }
                this.cb计时模式.DisplayMember = "Key";
                this.cb计时模式.ValueMember = "Value";
                this.cb计时模式.DataSource = new BindingSource(enums, null);
            }
            #endregion

            #region 加载字体列表。
            System.Drawing.Text.InstalledFontCollection objFont = new System.Drawing.Text.InstalledFontCollection();
            foreach (System.Drawing.FontFamily fm in objFont.Families)
            {
                this.cb字体.Items.Add(fm.Name.ToString());
            }
            this.cb字体.SelectedIndex = 0;
            #endregion

            #region 加装计时模式。
            {
                System.Collections.Generic.Dictionary<string, TimeFormats> enums = new();
                TimeFormats[] timeFormatList = System.Enum.GetValues<TimeFormats>();
                foreach (var timeFormat in timeFormatList)
                {
                    enums.Add(Define.GetDescription(timeFormat), timeFormat);
                }
                this.cb时间格式.DisplayMember = "Key";
                this.cb时间格式.ValueMember = "Value";
                this.cb时间格式.DataSource = new BindingSource(enums, null);
            }
            #endregion

            #region 加载音频文件列表。
            System.IO.DirectoryInfo soundDirectory = new(Define.SoundDirectory);
            if (!System.IO.Directory.Exists(Define.SoundDirectory))
            {
                System.IO.Directory.CreateDirectory(Define.SoundDirectory);
            }
            else
            {
                foreach (string ext in Define.AudioFileExtension)
                {
                    string[] files = System.IO.Directory.GetFiles(Define.SoundDirectory, "*" + ext, System.IO.SearchOption.AllDirectories);
                    foreach (string file in files)
                    {
                        this.Sounds.Add(System.IO.Path.GetFileNameWithoutExtension(file), file);
                    }
                }
            }

            this.cb结束提示音文件.DisplayMember = "Key";
            this.cb结束提示音文件.ValueMember = "Value";
            this.cb结束提示音文件.DataSource = new BindingSource(this.Sounds, null);
            this.cb预警提示音文件.DisplayMember = "Key";
            this.cb预警提示音文件.ValueMember = "Value";
            this.cb预警提示音文件.DataSource = new BindingSource(this.Sounds, null);
            #endregion
        }

        private void 更新界面()
        {
            switch ((TimerMode)this.cb计时模式.SelectedValue)
            {
                case TimerMode.Countdown:
                    this.l预警时长.Text = "倒计时结束前";
                    break;
                case TimerMode.ForwardTiming:
                    this.l预警时长.Text = "开始计时";
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

        private void cb计时模式_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.更新界面();
        }

        private void btn文本颜色_Click(object sender, EventArgs e)
        {
            this.colorDialog1.Color = this.btn文本颜色.BackColor;
            if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.btn文本颜色.BackColor = this.colorDialog1.Color;
            }
        }

        private void cb字体_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            System.Drawing.Font objFonts = new Font(this.cb字体.Items[e.Index].ToString(), this.Font.Size);
            e.ItemHeight = objFonts.Height;
        }

        private void cb字体_DrawItem(object sender, DrawItemEventArgs e)
        {
            System.Drawing.Font objFonts = new Font(this.cb字体.Items[e.Index].ToString(), this.Font.Size);
            e.DrawBackground();
            e.Graphics.DrawString(this.cb字体.Items[e.Index].ToString(), objFonts, new SolidBrush(e.ForeColor), new Point(e.Bounds.Left, e.Bounds.Top));
        }

        private void btn描边颜色_Click(object sender, EventArgs e)
        {
            this.colorDialog1.Color = this.btn描边颜色.BackColor;
            if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.btn描边颜色.BackColor = this.colorDialog1.Color;
            }
        }

        private void btn阴影的描边颜色_Click(object sender, EventArgs e)
        {
            this.colorDialog1.Color = this.btn阴影的描边颜色.BackColor;
            if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.btn阴影的描边颜色.BackColor = this.colorDialog1.Color;
            }
        }

        private void btn保存_Click(object sender, EventArgs e)
        {
            if (this.cb播放预警提示音.Checked && this.nud预警时长.Value >= this.nud总时长.Value)
            {
                MessageBox.Show(this, "预警提示音播放时间必须小于总时长");
                return;
            }

            string jsonSetting = System.Text.Json.JsonSerializer.Serialize(this.Setting, Define.JsonSerializerSettings);
            System.IO.File.WriteAllText(Define.SettingFile, jsonSetting);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn播放选中的音频1_Click(object sender, EventArgs e)
        {
            string file = Define.GetSoundFile((string)this.cb结束提示音文件.SelectedValue);
            this.Play(file);
        }

        private void btn播放选中的音频2_Click(object sender, EventArgs e)
        {
            string file = Define.GetSoundFile((string)this.cb预警提示音文件.SelectedValue);
            this.Play(file);
        }

        private void cb描边_CheckedChanged(object sender, EventArgs e)
        {
            this.gb描边.Enabled = this.cb描边.Checked;
        }

        private void cb显示阴影_CheckedChanged(object sender, EventArgs e)
        {
            this.gb阴影.Enabled = this.cb显示阴影.Checked;
        }

        private void cb播放结束提示音_CheckedChanged(object sender, EventArgs e)
        {
            this.gb结束提示音.Enabled = this.cb播放结束提示音.Checked;
        }

        private void cb播放预警提示音_CheckedChanged(object sender, EventArgs e)
        {
            this.gb预警提示音.Enabled = this.cb播放预警提示音.Checked;
        }

        private void SettingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.player != null)
            {
                this.player.Stop();
                this.player.Dispose();
                this.player = null;
            }
        }
    }
}
