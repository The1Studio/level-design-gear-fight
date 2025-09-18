namespace Nakama
{
	public class WriteStorageObject
	{
		public string Collection { get; set; }

		public string Key { get; set; }

		public int PermissionRead { get; set; }

		public int PermissionWrite { get; set; }

		public string Value { get; set; }

		public string Version { get; set; }
	}
}
