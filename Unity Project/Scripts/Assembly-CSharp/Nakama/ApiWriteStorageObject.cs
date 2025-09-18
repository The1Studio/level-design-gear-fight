using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiWriteStorageObject
	{
		[Preserve]
		[DataMember(Name = "collection")]
		public string Collection { get; set; }

		[Preserve]
		[DataMember(Name = "key")]
		public string Key { get; set; }

		[DataMember(Name = "permission_read")]
		[Preserve]
		public int PermissionRead { get; set; }

		[DataMember(Name = "permission_write")]
		[Preserve]
		public int PermissionWrite { get; set; }

		[DataMember(Name = "value")]
		[Preserve]
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
