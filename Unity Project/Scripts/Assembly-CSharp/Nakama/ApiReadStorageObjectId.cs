using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiReadStorageObjectId
	{
		[Preserve]
		[DataMember(Name = "collection")]
		public string Collection { get; set; }

		[DataMember(Name = "key")]
		[Preserve]
		public string Key { get; set; }

		[Preserve]
		[DataMember(Name = "user_id")]
		public string UserId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
