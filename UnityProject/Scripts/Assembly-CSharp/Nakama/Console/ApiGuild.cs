using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ApiGuild
	{
		[DataMember(Name = "activity")]
		[Preserve]
		public GuildGuildActivity Activity { get; set; }

		[DataMember(Name = "id")]
		[Preserve]
		public string Id { get; set; }

		[DataMember(Name = "info")]
		[Preserve]
		public ApiGuildInfo Info { get; set; }

		[DataMember(Name = "members")]
		[Preserve]
		public List<ApiGuildMember> Members { get; set; }

		[DataMember(Name = "team_score")]
		[Preserve]
		public long TeamScore { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
