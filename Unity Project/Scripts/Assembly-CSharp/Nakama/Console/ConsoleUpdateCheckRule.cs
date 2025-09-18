using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleUpdateCheckRule
	{
		[Preserve]
		[DataMember(Name = "action")]
		public ApiUpdateCheckAction Action { get; set; }

		[DataMember(Name = "display_version_end")]
		[Preserve]
		public string DisplayVersionEnd { get; set; }

		[DataMember(Name = "display_version_start")]
		[Preserve]
		public string DisplayVersionStart { get; set; }

		[DataMember(Name = "platform")]
		[Preserve]
		public ApiUpdateCheckPlatform Platform { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
