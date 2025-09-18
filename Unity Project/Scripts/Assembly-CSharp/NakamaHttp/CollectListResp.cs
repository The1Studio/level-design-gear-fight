using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class CollectListResp
	{
		[Preserve]
		[DataMember(Name = "events")]
		public List<CollectEvent> Events;

		public CollectListResp()
		{
		}

		public CollectListResp(List<CollectEvent> eventsParam)
		{
		}
	}
}
