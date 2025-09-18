using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMarbleSquidGameMatch
	{
		[Preserve]
		[DataMember(Name = "picked_marbles")]
		public int PickedMarbles { get; set; }

		[DataMember(Name = "remaining_marbles")]
		[Preserve]
		public int RemainingMarbles { get; set; }

		[DataMember(Name = "round_history")]
		[Preserve]
		public List<ApiMarbleSquidGameRound> RoundHistory { get; set; }

		[Preserve]
		[DataMember(Name = "round_id")]
		public int RoundId { get; set; }

		[DataMember(Name = "status")]
		[Preserve]
		public ApiMarbleSquidGameStatus Status { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
