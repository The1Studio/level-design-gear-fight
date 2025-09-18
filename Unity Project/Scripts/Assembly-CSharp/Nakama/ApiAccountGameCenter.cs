using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiAccountGameCenter
	{
		[Preserve]
		[DataMember(Name = "bundle_id")]
		public string BundleId { get; set; }

		[Preserve]
		[DataMember(Name = "player_id")]
		public string PlayerId { get; set; }

		[DataMember(Name = "public_key_url")]
		[Preserve]
		public string PublicKeyUrl { get; set; }

		[DataMember(Name = "salt")]
		[Preserve]
		public string Salt { get; set; }

		[Preserve]
		[DataMember(Name = "signature")]
		public string Signature { get; set; }

		[DataMember(Name = "timestamp_seconds")]
		[Preserve]
		public long TimestampSeconds { get; set; }

		[Preserve]
		[DataMember(Name = "vars")]
		public Dictionary<string, string> Vars { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
