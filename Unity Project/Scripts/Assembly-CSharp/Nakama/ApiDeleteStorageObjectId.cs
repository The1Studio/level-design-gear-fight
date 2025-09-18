using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiDeleteStorageObjectId
	{
		[Preserve]
		[DataMember(Name = "collection")]
		public string Collection { get; set; }

		[DataMember(Name = "key")]
		[Preserve]
		public string Key { get; set; }

		[DataMember(Name = "version")]
		[Preserve]
		public string Version { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
