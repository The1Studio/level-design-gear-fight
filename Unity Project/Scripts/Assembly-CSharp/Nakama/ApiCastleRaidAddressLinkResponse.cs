using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiCastleRaidAddressLinkResponse
	{
		[Preserve]
		[DataMember(Name = "linked_wallet")]
		public string LinkedWallet { get; set; }

		[Preserve]
		[DataMember(Name = "owned_artifacts")]
		public List<ApiCastleRaidArtifact> OwnedArtifacts { get; set; }

		[DataMember(Name = "status")]
		[Preserve]
		public CastleRaidAddressLinkResponseLinkAddressStatus Status { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
