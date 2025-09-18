using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiScheduleCratesAndKeysRoundRequest
	{
		[DataMember(Name = "feature")]
		[Preserve]
		public ApiCratesAndKeysData Feature { get; set; }

		[DataMember(Name = "round")]
		[Preserve]
		public ApiScheduleRoundCommonData Round { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
