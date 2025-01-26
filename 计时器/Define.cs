namespace 计时器
{
    public class Define
    {
        /// <summary>
        /// 定义支持的音频文件类型。
        /// </summary>
        public static readonly string[] AudioFileExtension = new string[]
        {
            ".wav",
        };

        /// <summary>
        /// 配置文件。
        /// </summary>
        public static readonly string SettingFile;

        /// <summary>
        /// 音频文件目录。
        /// </summary>
        public static readonly string SoundDirectory;

        /// <summary>
        /// 最少输出内容的 Json 序列化设置。
        /// </summary>
        public static readonly System.Text.Json.JsonSerializerOptions JsonSerializerSettings;

        /// <summary>
        /// 最少输出内容的 Json 反序列化设置。
        /// </summary>
        public static readonly System.Text.Json.JsonSerializerOptions JsonDeserializeSettings;

        /// <summary>
        /// 一个静态构造方法。
        /// </summary>
        static Define()
        {
            #region 序列化/反序列化设置。
            {
                var colorConverter = new ColorConverter();

                #region 初始化“JsonMinimizeSerializerSettings”对象。
                {
                    System.Text.Json.JsonSerializerOptions jss = new();
                    jss.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
                    jss.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumConverter()); //将枚举类型成员序列化输出为成员名称。（当无此设置时，输出为枚举成员对应的数值。）
                    jss.WriteIndented = true;
                    jss.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(System.Text.Unicode.UnicodeRanges.All); //序列化时中文不被 Unicode 编码。

                    jss.Converters.Add(colorConverter);
                    Define.JsonSerializerSettings = jss;
                }
                #endregion

                #region 初始化“JsonMinimizeDeserializeSettings”对象。
                {
                    var jss = new System.Text.Json.JsonSerializerOptions();
                    jss.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumConverter()); //支持从枚举名称反序列化为枚举对象。（当无此设置时，仅支持从数值型枚举值反序列化为枚举对象）

                    jss.Converters.Add(colorConverter);
                    Define.JsonDeserializeSettings = jss;
                }
                #endregion
            }
            #endregion

            Define.SettingFile = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "setting.json");
            Define.SoundDirectory = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "sound");
        }

        /// <summary>
        /// 获取音频文件。
        /// </summary>
        /// <param name="soundName">音频名称。</param>
        /// <returns>返回音频文件。</returns>
        public static string GetSoundFile(string soundName)
        {
            return System.IO.Path.Combine(Define.SoundDirectory, soundName);
        }

        /// <summary>
        /// 获取枚举类型的说明。
        /// </summary>
        /// <param name="val">枚举类型的值。</param>
        /// <returns></returns>
		public static string GetDescription(Enum val)
		{
			var field = val.GetType().GetField(val.ToString());
			var customAttribute = Attribute.GetCustomAttribute(field, typeof(System.ComponentModel.DescriptionAttribute));
			return customAttribute == null ? val.ToString() : ((System.ComponentModel.DescriptionAttribute)customAttribute).Description;
		}

	}
}
