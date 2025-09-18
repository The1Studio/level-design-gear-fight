using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiRoundData
	{
		[DataMember(Name = "player_state")]
		[Preserve]
		public ApiPlayerState PlayerState { get; set; }

		[Preserve]
		[DataMember(Name = "round_id")]
		public string RoundId { get; set; }

		[Preserve]
		[DataMember(Name = "round_state")]
		public ApiRoundState RoundState { get; set; }

		[Preserve]
		[DataMember(Name = "seconds_until_end")]
		public int SecondsUntilEnd { get; set; }

		[DataMember(Name = "seconds_until_start")]
		[Preserve]
		public int SecondsUntilStart { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
