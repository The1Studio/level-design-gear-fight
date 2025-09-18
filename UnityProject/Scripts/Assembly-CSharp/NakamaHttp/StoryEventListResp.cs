using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class StoryEventListResp
	{
		[Preserve]
		[DataMember(Name = "story_events")]
		public List<StoryEvent> StoryEvents;

		public StoryEventListResp()
		{
		}

		public StoryEventListResp(List<StoryEvent> storyEventsParam)
		{
		}
	}
}
