using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ProtobufAny
	{
		[Preserve]
		[DataMember(Name = "type_url")]
		public string TypeUrl { get; set; }

		[Preserve]
		[DataMember(Name = "value")]
		public string Value { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
