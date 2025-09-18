using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildChestPlayerProgress
	{
		[DataMember(Name = "points")]
		[Preserve]
		public int Points { get; set; }

		[DataMember(Name = "position_in_ranking")]
		[Preserve]
		public int PositionInRanking { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
