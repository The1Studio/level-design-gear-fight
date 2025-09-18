using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiCastleRaidArtifactMintRequest
	{
		[Preserve]
		[DataMember(Name = "artifact_id")]
		public string ArtifactId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
