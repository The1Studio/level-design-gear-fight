using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiCastleRaidArtifactGenerateResponse
	{
		[DataMember(Name = "newly_generated_artifact")]
		[Preserve]
		public ApiCastleRaidArtifact NewlyGeneratedArtifact { get; set; }

		[DataMember(Name = "owned_artifacts")]
		[Preserve]
		public List<ApiCastleRaidArtifact> OwnedArtifacts { get; set; }

		[DataMember(Name = "seconds_until_next_generate")]
		[Preserve]
		public int SecondsUntilNextGenerate { get; set; }

		[Preserve]
		[DataMember(Name = "status")]
		public CastleRaidArtifactGenerateResponseGenerateArtifactStatus Status { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
