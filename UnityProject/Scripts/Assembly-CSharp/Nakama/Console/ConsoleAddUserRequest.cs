using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleAddUserRequest
	{
		[DataMember(Name = "email")]
		[Preserve]
		public string Email { get; set; }

		[DataMember(Name = "newsletter_subscription")]
		[Preserve]
		public bool NewsletterSubscription { get; set; }

		[DataMember(Name = "password")]
		[Preserve]
		public string Password { get; set; }

		[Preserve]
		[DataMember(Name = "role")]
		public ConsoleUserRole Role { get; set; }

		[DataMember(Name = "username")]
		[Preserve]
		public string Username { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
