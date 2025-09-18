using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleGetDeepLinkUrlResponse
	{
		[DataMember(Name = "url")]
		[Preserve]
		public string Url { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
