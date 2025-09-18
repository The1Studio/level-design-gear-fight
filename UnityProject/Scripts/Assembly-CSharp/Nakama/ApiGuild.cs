using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuild
	{
		[Preserve]
		[DataMember(Name = "activity")]
		public GuildGuildActivity Activity { get; set; }

		[Preserve]
		[DataMember(Name = "id")]
		public string Id { get; set; }

		[DataMember(Name = "info")]
		[Preserve]
		public ApiGuildInfo Info { get; set; }

		[Preserve]
		[DataMember(Name = "members")]
		public List<ApiGuildMember> Members { get; set; }

		[DataMember(Name = "team_points")]
		[Preserve]
		public int TeamPoints { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
