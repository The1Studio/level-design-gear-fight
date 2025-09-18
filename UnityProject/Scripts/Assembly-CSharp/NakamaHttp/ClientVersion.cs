using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class ClientVersion
	{
		[DataMember(Name = "version")]
		[Preserve]
		public string Version;

		[Preserve]
		[DataMember(Name = "updated_unix")]
		public int UpdatedUnix;

		public ClientVersion()
		{
		}

		public ClientVersion(string versionParam, int updatedUnixParam)
		{
		}
	}
}
