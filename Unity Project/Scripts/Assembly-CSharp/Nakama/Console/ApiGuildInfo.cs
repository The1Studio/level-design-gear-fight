using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ApiGuildInfo
	{
		[Preserve]
		[DataMember(Name = "capacity")]
		public long Capacity { get; set; }

		[Preserve]
		[DataMember(Name = "description")]
		public string Description { get; set; }

		[DataMember(Name = "logo")]
		[Preserve]
		public string Logo { get; set; }

		[DataMember(Name = "name")]
		[Preserve]
		public string Name { get; set; }

		[DataMember(Name = "permission")]
		[Preserve]
		public GuildInfoGuildJoiningPermissions Permission { get; set; }

		[DataMember(Name = "required_level")]
		[Preserve]
		public long RequiredLevel { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
