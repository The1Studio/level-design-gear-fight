using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildCreateResponse
	{
		[DataMember(Name = "guild")]
		[Preserve]
		public ApiUserGuild Guild { get; set; }

		[DataMember(Name = "result")]
		[Preserve]
		public GuildCreateResponseGuildCreateResult Result { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
