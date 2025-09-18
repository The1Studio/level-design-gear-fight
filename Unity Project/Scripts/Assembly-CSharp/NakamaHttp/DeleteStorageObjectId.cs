using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class DeleteStorageObjectId
	{
		[DataMember(Name = "collection")]
		[Preserve]
		public string Collection;

		[DataMember(Name = "key")]
		[Preserve]
		public string Key;

		public DeleteStorageObjectId()
		{
		}

		public DeleteStorageObjectId(string collectionParam, string keyParam)
		{
		}
	}
}
