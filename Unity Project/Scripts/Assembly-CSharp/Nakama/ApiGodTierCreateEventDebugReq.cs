using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierCreateEventDebugReq
	{
		[Preserve]
		[DataMember(Name = "current_gods_allowed")]
		public bool CurrentGodsAllowed { get; set; }

		[DataMember(Name = "event_id")]
		[Preserve]
		public string EventId { get; set; }

		[DataMember(Name = "invited_user_ids")]
		[Preserve]
		public List<string> InvitedUserIds { get; set; }

		[DataMember(Name = "timing_data")]
		[Preserve]
		public ApiTimingData TimingData { get; set; }

		[Preserve]
		[DataMember(Name = "week_duration_secs")]
		public string WeekDurationSecs { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
