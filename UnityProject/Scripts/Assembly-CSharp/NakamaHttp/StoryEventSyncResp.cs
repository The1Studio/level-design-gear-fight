using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class StoryEventSyncResp
	{
		[DataMember(Name = "story_event")]
		[Preserve]
		public StoryEvent StoryEvent;

		[Preserve]
		[DataMember(Name = "story_active")]
		public bool StoryActive;

		public StoryEventSyncResp()
		{
		}

		public StoryEventSyncResp(StoryEvent storyEventParam, bool storyActiveParam)
		{
		}
	}
}
