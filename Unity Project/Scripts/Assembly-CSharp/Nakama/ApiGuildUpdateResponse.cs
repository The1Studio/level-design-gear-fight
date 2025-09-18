using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildUpdateResponse
	{
		[DataMember(Name = "guild")]
		[Preserve]
		public ApiGuild Guild { get; set; }

		[DataMember(Name = "result")]
		[Preserve]
		public GuildUpdateResponseGuildUpdateResult Result { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
