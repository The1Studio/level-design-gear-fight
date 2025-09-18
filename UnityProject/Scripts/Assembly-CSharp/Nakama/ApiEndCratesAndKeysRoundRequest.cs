using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiEndCratesAndKeysRoundRequest
	{
		[DataMember(Name = "round_id")]
		[Preserve]
		public string RoundId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
