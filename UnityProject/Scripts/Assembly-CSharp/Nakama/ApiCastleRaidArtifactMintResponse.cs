using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiCastleRaidArtifactMintResponse
	{
		[Preserve]
		[DataMember(Name = "status")]
		public CastleRaidArtifactMintResponseMintArtifactStatus Status { get; set; }

		[DataMember(Name = "tx_hash")]
		[Preserve]
		public string TxHash { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
