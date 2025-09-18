using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class StoryEvent
	{
		[DataMember(Name = "episodes")]
		[Preserve]
		public List<StoryEventEpisode> Episodes;

		[DataMember(Name = "id")]
		[Preserve]
		public string Id;

		public StoryEvent()
		{
		}

		public StoryEvent(List<StoryEventEpisode> episodesParam, string idParam)
		{
		}
	}
}
