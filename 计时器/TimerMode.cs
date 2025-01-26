using System.ComponentModel;

namespace 计时器
{
	public enum TimerMode
	{
		/// <summary>
		/// 倒计时
		/// </summary>
		[Description("倒计时")]
		Countdown = 0,
		/// <summary>
		/// 正向计时
		/// </summary>
		[Description("正向计时")]
		ForwardTiming = 1,
	}
}
