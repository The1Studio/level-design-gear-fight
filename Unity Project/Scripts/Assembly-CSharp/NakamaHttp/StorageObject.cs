using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class StorageObject
	{
		[Preserve]
		[DataMember(Name = "collection")]
		public string Collection;

		[Preserve]
		[DataMember(Name = "key")]
		public string Key;

		[Preserve]
		[DataMember(Name = "user_id")]
		public string UserId;

		[DataMember(Name = "value")]
		[Preserve]
		public string Value;

		[DataMember(Name = "version")]
		[Preserve]
		public string Version;

		[DataMember(Name = "update_time")]
		[Preserve]
		public string UpdateTime;

		public StorageObject()
		{
		}

		public StorageObject(string collectionParam, string keyParam, string userIdParam, string valueParam, string versionParam, string updateTimeParam)
		{
		}
	}
}
