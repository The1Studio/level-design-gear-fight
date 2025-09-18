using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiCastleRaidArtifact
	{
		[Preserve]
		[DataMember(Name = "artifact_id")]
		public string ArtifactId { get; set; }

		[Preserve]
		[DataMember(Name = "fq_tn")]
		public string FqTn { get; set; }

		[Preserve]
		[DataMember(Name = "image_properties")]
		public ApiCastleRaidImageProperties ImageProperties { get; set; }

		[DataMember(Name = "name")]
		[Preserve]
		public string Name { get; set; }

		[DataMember(Name = "properties")]
		[Preserve]
		public List<ApiCastleRaidArtifactProperty> Properties { get; set; }

		[Preserve]
		[DataMember(Name = "tx_hash")]
		public string TxHash { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
