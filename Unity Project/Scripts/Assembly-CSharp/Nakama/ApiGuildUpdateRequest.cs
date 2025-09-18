using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildUpdateRequest
	{
		[DataMember(Name = "capacity")]
		[Preserve]
		public int Capacity { get; set; }

		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId { get; set; }

		[DataMember(Name = "description")]
		[Preserve]
		public string Description { get; set; }

		[DataMember(Name = "guild_id")]
		[Preserve]
		public string GuildId { get; set; }

		[Preserve]
		[DataMember(Name = "logo")]
		public string Logo { get; set; }

		[DataMember(Name = "name")]
		[Preserve]
		public string Name { get; set; }

		[DataMember(Name = "permission")]
		[Preserve]
		public ApiNullableGuildJoiningPermissions Permission { get; set; }

		[Preserve]
		[DataMember(Name = "required_points")]
		public int RequiredPoints { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
