using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class Rpc
	{
		[DataMember(Name = "id")]
		[Preserve]
		public string Id;

		[DataMember(Name = "payload")]
		[Preserve]
		public string Payload;

		[Preserve]
		[DataMember(Name = "http_key")]
		public string HttpKey;

		public Rpc()
		{
		}

		public Rpc(string idParam, string payloadParam, string httpKeyParam)
		{
		}
	}
}
