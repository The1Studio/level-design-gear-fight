using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiStorageObject
	{
		[DataMember(Name = "collection")]
		[Preserve]
		public string Collection { get; set; }

		[DataMember(Name = "create_time")]
		[Preserve]
		public string CreateTime { get; set; }

		[DataMember(Name = "key")]
		[Preserve]
		public string Key { get; set; }

		[Preserve]
		[DataMember(Name = "permission_read")]
		public int PermissionRead { get; set; }

		[Preserve]
		[DataMember(Name = "permission_write")]
		public int PermissionWrite { get; set; }

		[DataMember(Name = "update_time")]
		[Preserve]
		public string UpdateTime { get; set; }

		[Preserve]
		[DataMember(Name = "user_id")]
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
