using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiUpdateTimedQuestsRoundDataRequest
	{
		[Preserve]
		[DataMember(Name = "data")]
		public ApiTimedQuestsData Data { get; set; }

		[Preserve]
		[DataMember(Name = "round_id")]
		public string RoundId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
