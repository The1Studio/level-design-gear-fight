using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleApiEndpointDescriptor
	{
		[Preserve]
		[DataMember(Name = "body_template")]
		public string BodyTemplate { get; set; }

		[DataMember(Name = "method")]
		[Preserve]
		public string Method { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
