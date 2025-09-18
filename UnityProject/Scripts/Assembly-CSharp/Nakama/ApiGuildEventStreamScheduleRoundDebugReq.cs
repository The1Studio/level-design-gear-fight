using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildEventStreamScheduleRoundDebugReq
	{
		[Preserve]
		[DataMember(Name = "round")]
		public ApiScheduleRoundCommonData Round { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
