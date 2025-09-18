using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ApiPlayerData
	{
		[DataMember(Name = "avatar_id")]
		[Preserve]
		public string AvatarId { get; set; }

		[DataMember(Name = "avatar_url")]
		[Preserve]
		public string AvatarUrl { get; set; }

		[DataMember(Name = "display_name")]
		[Preserve]
		public string DisplayName { get; set; }

		[Preserve]
		[DataMember(Name = "points")]
		public long Points { get; set; }

		[Preserve]
		[DataMember(Name = "position_in_ranking")]
		public int PositionInRanking { get; set; }

		[Preserve]
		[DataMember(Name = "user_id")]
		public string UserId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
