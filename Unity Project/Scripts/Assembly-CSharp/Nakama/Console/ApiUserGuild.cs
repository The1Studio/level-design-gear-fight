using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ApiUserGuild
	{
		[DataMember(Name = "guild")]
		[Preserve]
		public ApiGuild Guild { get; set; }

		[DataMember(Name = "role")]
		[Preserve]
		public ApiGuildRole Role { get; set; }

		[DataMember(Name = "state_change")]
		[Preserve]
		public ApiGuildStateChange StateChange { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
