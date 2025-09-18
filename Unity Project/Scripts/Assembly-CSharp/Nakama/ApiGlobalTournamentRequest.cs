using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGlobalTournamentRequest
	{
		[DataMember(Name = "round_id")]
		[Preserve]
		public string RoundId { get; set; }

		[DataMember(Name = "total_points")]
		[Preserve]
		public int TotalPoints { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
