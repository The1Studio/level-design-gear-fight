using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class StoryEventEpisode
	{
		[Preserve]
		[DataMember(Name = "vote_timing_data")]
		public TimingData VoteTimingData;

		[DataMember(Name = "results")]
		[Preserve]
		public Dictionary<string, int> Results;

		[DataMember(Name = "number")]
		[Preserve]
		public int Number;

		[DataMember(Name = "total_votes")]
		[Preserve]
		public int TotalVotes;

		[DataMember(Name = "voted_option")]
		[Preserve]
		public int VotedOption;

		public StoryEventEpisode()
		{
		}

		public StoryEventEpisode(TimingData voteTimingDataParam, Dictionary<string, int> resultsParam, int numberParam, int totalVotesParam, int votedOptionParam)
		{
		}
	}
}
