using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class StoryEventVoteResp
	{
		[DataMember(Name = "story_event")]
		[Preserve]
		public StoryEvent StoryEvent;

		[Preserve]
		[DataMember(Name = "success")]
		public bool Success;

		public StoryEventVoteResp()
		{
		}

		public StoryEventVoteResp(StoryEvent storyEventParam, bool successParam)
		{
		}
	}
}
