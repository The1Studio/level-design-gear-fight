using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ApiStorageObjectAck
	{
		[DataMember(Name = "collection")]
		[Preserve]
		public string Collection { get; set; }

		[DataMember(Name = "key")]
		[Preserve]
		public string Key { get; set; }

		[DataMember(Name = "user_id")]
		[Preserve]
		public string UserId { get; set; }

		[Preserve]
		[DataMember(Name = "version")]
		public string Version { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
