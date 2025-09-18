using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class StorageObjectAck
	{
		[DataMember(Name = "collection")]
		[Preserve]
		public string Collection;

		[DataMember(Name = "key")]
		[Preserve]
		public string Key;

		[DataMember(Name = "version")]
		[Preserve]
		public string Version;

		[Preserve]
		[DataMember(Name = "user_id")]
		public string UserId;

		public StorageObjectAck()
		{
		}

		public StorageObjectAck(string collectionParam, string keyParam, string versionParam, string userIdParam)
		{
		}
	}
}
