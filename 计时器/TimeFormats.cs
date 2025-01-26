using System.ComponentModel;

namespace 计时器
{
	/// <summary>
	/// 时间显示格式。
	/// </summary>
	public enum TimeFormats
	{
		/// <summary>
		/// 长格式（00:00:00）
		/// </summary>
		[Description("长格式（00:00:00）")]
		Long = 0,
		/// <summary>
		/// 当不足一分钟时仅显示秒 <see cref="TimeFormats.Seconds"/>，否则显示长格式 <see cref="TimeFormats.Long"/>
		/// </summary>
		[Description("短格式")]
		Short = 1,
		/// <summary>
		/// 仅显示以秒为单位的整数。
		/// </summary>
		[Description("仅显示秒")]
		Seconds = 2,
	}
}
