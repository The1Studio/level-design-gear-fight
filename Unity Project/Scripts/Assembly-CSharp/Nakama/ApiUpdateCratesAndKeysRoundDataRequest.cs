using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiUpdateCratesAndKeysRoundDataRequest
	{
		[DataMember(Name = "data")]
		[Preserve]
		public ApiCratesAndKeysData Data { get; set; }

		[Preserve]
		[DataMember(Name = "round_id")]
		public string RoundId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
