using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class ReadStorageObjectId
	{
		[DataMember(Name = "collection")]
		[Preserve]
		public string Collection;

		[DataMember(Name = "key")]
		[Preserve]
		public string Key;

		[DataMember(Name = "user_id")]
		[Preserve]
		public string UserId;

		public ReadStorageObjectId()
		{
		}

		public ReadStorageObjectId(string collectionParam, string keyParam, string userIdParam)
		{
		}
	}
}
