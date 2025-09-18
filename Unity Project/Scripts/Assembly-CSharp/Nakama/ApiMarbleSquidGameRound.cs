using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMarbleSquidGameRound
	{
		[Preserve]
		[DataMember(Name = "round_id")]
		public int RoundId { get; set; }

		[Preserve]
		[DataMember(Name = "won")]
		public bool Won { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
