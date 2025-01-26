namespace 计时器
{
	/// <summary>
	/// 设置实体类。
	/// </summary>
	public class Setting
	{
		/// <summary>
		/// 计时模式
		/// </summary>
		public TimerMode TimerMode { get; set; }
		/// <summary>
		/// 总时长。
		/// </summary>
		public int Duration { get; set; }
        /// <summary>
        /// 窗体置顶
        /// </summary>
        public bool TopMost { get; set; }
        /// <summary>
        /// 是否播放结束提示音。
        /// </summary>
        public bool PlayEndSound { get; set; }
		/// <summary>
		/// 结束提示音。
		/// </summary>
		public string EndSound { get; set; }
		/// <summary>
		/// 是否播放预警提示音。
		/// </summary>
		public bool PlayWarningSound { get; set; }
		/// <summary>
		/// 预警提示音。
		/// </summary>
		public string WarningSound { get; set; }
		/// <summary>
		/// 预警时长。
		/// </summary>
		public int WarningDuration { get; set; }
		/// <summary>
		/// 字体
		/// </summary>
		public string TextFontName { get; set; }
		/// <summary>
		/// 字体
		/// </summary>
		public int TextFontSize { get; set; }
		/// <summary>
		/// 颜色
		/// </summary>
		public System.Drawing.Color TextColor { get; set; }
		/// <summary>
		/// 是否描边。
		/// </summary>
		public bool ShowStroke { get; set; }
		/// <summary>
		/// 描边颜色。
		/// </summary>
		public System.Drawing.Color StrokeColor { get; set; }
		/// <summary>
		/// 是否显示阴影。
		/// </summary>
		public bool ShowShadow { get; set; }
		/// <summary>
		/// 阴影距离。
		/// </summary>
		public int ShadowOffset { get; set; }
		/// <summary>
		/// 阴影的透明度。
		/// </summary>
		public int ShadowAlpha { get; set; }
		/// <summary>
		/// 是否显示阴影的描边。
		/// </summary>
		public bool ShowShadowStroke { get; set; }
		/// <summary>
		/// 阴影的描边颜色。
		/// </summary>
		public System.Drawing.Color ShadowStrokeColor { get; set; }
		/// <summary>
		/// 时间显示格式。
		/// </summary>
		public TimeFormats TimeFormat { get; set; }

		/// <summary>
		/// 水平坐标。
		/// </summary>
        public int X { get; set; }
		/// <summary>
		/// 垂直坐标。
		/// </summary>
        public int Y { get; set; }

        /// <summary>
        /// 一个构造方法。
        /// </summary>
        public Setting()
		{
		}
	}
}
