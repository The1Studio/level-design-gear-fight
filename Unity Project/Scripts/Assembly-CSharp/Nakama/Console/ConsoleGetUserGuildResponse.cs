using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleGetUserGuildResponse
	{
		[DataMember(Name = "user_guild")]
		[Preserve]
		public ApiUserGuild UserGuild { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
