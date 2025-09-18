using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiCastleRaidArtifactSyncResponse
	{
		[Preserve]
		[DataMember(Name = "linked_address")]
		public string LinkedAddress { get; set; }

		[DataMember(Name = "owned_artifacts")]
		[Preserve]
		public List<ApiCastleRaidArtifact> OwnedArtifacts { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
