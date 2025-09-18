using System.Runtime.Serialization;

namespace Nakama
{
	public class ProtobufAny
	{
		[Preserve]
		[DataMember(Name = "@type")]
		public string type { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
