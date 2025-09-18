using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGlobalTournamentResponse
	{
		[DataMember(Name = "feature_state")]
		[Preserve]
		public ApiFeatureState FeatureState { get; set; }

		[DataMember(Name = "tournament_data")]
		[Preserve]
		public ApiGlobalTournamentData TournamentData { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
