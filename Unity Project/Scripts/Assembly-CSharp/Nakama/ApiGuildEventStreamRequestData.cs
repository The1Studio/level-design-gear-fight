using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildEventStreamRequestData
	{
		[DataMember(Name = "event_types")]
		[Preserve]
		public List<ApiGuildEventType> EventTypes { get; set; }

		[DataMember(Name = "last_sync_timestamp")]
		[Preserve]
		public long LastSyncTimestamp { get; set; }

		[DataMember(Name = "max_events")]
		[Preserve]
		public int MaxEvents { get; set; }

		[DataMember(Name = "max_predefined_message_id")]
		[Preserve]
		public int MaxPredefinedMessageId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
