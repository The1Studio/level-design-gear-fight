using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiScheduleTimedQuestsRoundRequest
	{
		[DataMember(Name = "feature")]
		[Preserve]
		public ApiTimedQuestsData Feature { get; set; }

		[DataMember(Name = "round")]
		[Preserve]
		public ApiScheduleRoundCommonData Round { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
