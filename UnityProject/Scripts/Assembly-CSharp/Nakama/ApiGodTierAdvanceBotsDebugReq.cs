using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierAdvanceBotsDebugReq
	{
		[DataMember(Name = "event_id")]
		[Preserve]
		public string EventId { get; set; }

		[DataMember(Name = "max_points_to_add")]
		[Preserve]
		public int MaxPointsToAdd { get; set; }

		[DataMember(Name = "min_points_to_add")]
		[Preserve]
		public int MinPointsToAdd { get; set; }

		[DataMember(Name = "total_bots_to_advance")]
		[Preserve]
		public int TotalBotsToAdvance { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
