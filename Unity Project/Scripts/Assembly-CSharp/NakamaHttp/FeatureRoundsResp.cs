using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class FeatureRoundsResp
	{
		[DataMember(Name = "rounds")]
		[Preserve]
		public List<FeatureRound> Rounds;

		public FeatureRoundsResp()
		{
		}

		public FeatureRoundsResp(List<FeatureRound> roundsParam)
		{
		}
	}
}
