using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class ClientAttributes
	{
		[Preserve]
		[DataMember(Name = "platform")]
		public ClientPlatform Platform;

		[Preserve]
		[DataMember(Name = "version")]
		public ClientVersion Version;

		public ClientAttributes()
		{
		}

		public ClientAttributes(ClientPlatform platformParam, ClientVersion versionParam)
		{
		}
	}
}
