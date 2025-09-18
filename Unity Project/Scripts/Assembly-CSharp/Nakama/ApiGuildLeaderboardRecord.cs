using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildLeaderboardRecord
	{
		[DataMember(Name = "id")]
		[Preserve]
		public string Id { get; set; }

		[Preserve]
		[DataMember(Name = "logo")]
		public string Logo { get; set; }

		[DataMember(Name = "name")]
		[Preserve]
		public string Name { get; set; }

		[Preserve]
		[DataMember(Name = "rank")]
		public int Rank { get; set; }

		[Preserve]
		[DataMember(Name = "score")]
		public int Score { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
