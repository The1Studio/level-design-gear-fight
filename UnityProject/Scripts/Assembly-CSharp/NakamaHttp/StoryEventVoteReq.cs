using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class StoryEventVoteReq
	{
		[Preserve]
		[DataMember(Name = "id")]
		public string Id;

		[Preserve]
		[DataMember(Name = "episode_number")]
		public int EpisodeNumber;

		[Preserve]
		[DataMember(Name = "option")]
		public int Option;

		public StoryEventVoteReq()
		{
		}

		public StoryEventVoteReq(string idParam, int episodeNumberParam, int optionParam)
		{
		}
	}
}
