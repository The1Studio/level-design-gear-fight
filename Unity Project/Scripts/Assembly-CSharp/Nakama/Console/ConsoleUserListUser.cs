using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleUserListUser
	{
		[Preserve]
		[DataMember(Name = "email")]
		public string Email { get; set; }

		[DataMember(Name = "role")]
		[Preserve]
		public ConsoleUserRole Role { get; set; }

		[Preserve]
		[DataMember(Name = "username")]
		public string Username { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
