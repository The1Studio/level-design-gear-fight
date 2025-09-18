using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class WriteStorageObject
	{
		[Preserve]
		[DataMember(Name = "collection")]
		public string Collection;

		[DataMember(Name = "key")]
		[Preserve]
		public string Key;

		[DataMember(Name = "value")]
		[Preserve]
		public string Value;

		[DataMember(Name = "version")]
		[Preserve]
		public string Version;

		public WriteStorageObject()
		{
		}

		public WriteStorageObject(string collectionParam, string keyParam, string valueParam, string versionParam)
		{
		}
	}
}
