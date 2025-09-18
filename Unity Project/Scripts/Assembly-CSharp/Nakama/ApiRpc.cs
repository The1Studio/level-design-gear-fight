using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiRpc
	{
		[Preserve]
		[DataMember(Name = "http_key")]
		public string HttpKey { get; set; }

		[DataMember(Name = "id")]
		[Preserve]
		public string Id { get; set; }

		[Preserve]
		[DataMember(Name = "payload")]
		public string Payload { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
