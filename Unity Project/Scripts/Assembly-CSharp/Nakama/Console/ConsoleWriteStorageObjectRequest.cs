using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleWriteStorageObjectRequest
	{
		[Preserve]
		[DataMember(Name = "collection")]
		public string Collection { get; set; }

		[Preserve]
		[DataMember(Name = "key")]
		public string Key { get; set; }

		[Preserve]
		[DataMember(Name = "permission_read")]
		public int PermissionRead { get; set; }

		[Preserve]
		[DataMember(Name = "permission_write")]
		public int PermissionWrite { get; set; }

		[Preserve]
		[DataMember(Name = "user_id")]
		public string UserId { get; set; }

		[Preserve]
		[DataMember(Name = "value")]
		public string Value { get; set; }

		[Preserve]
		[DataMember(Name = "version")]
		public string Version { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
