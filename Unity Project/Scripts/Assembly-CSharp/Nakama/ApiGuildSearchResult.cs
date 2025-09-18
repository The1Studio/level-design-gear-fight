using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildSearchResult
	{
		[Preserve]
		[DataMember(Name = "guild")]
		public ApiGuild Guild { get; set; }

		[Preserve]
		[DataMember(Name = "state")]
		public GuildSearchResultGuildSearchState State { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
