using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleAuthenticateRequest
	{
		[DataMember(Name = "password")]
		[Preserve]
		public string Password { get; set; }

		[DataMember(Name = "username")]
		[Preserve]
		public string Username { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
