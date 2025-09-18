using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class ClientPlatform
	{
		[Preserve]
		[DataMember(Name = "platform")]
		public string Platform;

		[Preserve]
		[DataMember(Name = "updated_unix")]
		public int UpdatedUnix;

		public ClientPlatform()
		{
		}

		public ClientPlatform(string platformParam, int updatedUnixParam)
		{
		}
	}
}
