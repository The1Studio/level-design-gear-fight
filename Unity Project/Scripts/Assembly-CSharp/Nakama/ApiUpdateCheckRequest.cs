using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiUpdateCheckRequest
	{
		[DataMember(Name = "current_version")]
		[Preserve]
		public string CurrentVersion { get; set; }

		[Preserve]
		[DataMember(Name = "platform")]
		public ApiUpdateCheckPlatform Platform { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
