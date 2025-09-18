using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiTimedQuestsResponse
	{
		[DataMember(Name = "feature_data")]
		[Preserve]
		public ApiFeatureData FeatureData { get; set; }

		[DataMember(Name = "feature_data_next")]
		[Preserve]
		public ApiFeatureData FeatureDataNext { get; set; }

		[Preserve]
		[DataMember(Name = "timed_quests_data")]
		public ApiTimedQuestsData TimedQuestsData { get; set; }

		[Preserve]
		[DataMember(Name = "timed_quests_data_next")]
		public ApiTimedQuestsData TimedQuestsDataNext { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
