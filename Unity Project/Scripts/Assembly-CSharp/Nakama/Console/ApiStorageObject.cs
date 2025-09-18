using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ApiStorageObject
	{
		[DataMember(Name = "collection")]
		[Preserve]
		public string Collection { get; set; }

		[Preserve]
		[DataMember(Name = "create_time")]
		public string CreateTime { get; set; }

		[DataMember(Name = "key")]
		[Preserve]
		public string Key { get; set; }

		[DataMember(Name = "permission_read")]
		[Preserve]
		public int PermissionRead { get; set; }

		[DataMember(Name = "permission_write")]
		[Preserve]
		public int PermissionWrite { get; set; }

		[DataMember(Name = "update_time")]
		[Preserve]
		public string UpdateTime { get; set; }

		[DataMember(Name = "user_id")]
		[Preserve]
		public string UserId { get; set; }

		[Preserve]
		[DataMember(Name = "value")]
		public string Value { get; set; }

		[DataMember(Name = "version")]
		[Preserve]
		public string Version { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
