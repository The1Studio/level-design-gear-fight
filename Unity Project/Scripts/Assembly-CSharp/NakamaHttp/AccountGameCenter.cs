using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class AccountGameCenter
	{
		[DataMember(Name = "player_id")]
		[Preserve]
		public string PlayerId;

		[DataMember(Name = "bundle_id")]
		[Preserve]
		public string BundleId;

		[Preserve]
		[DataMember(Name = "timestamp_seconds")]
		public long TimestampSeconds;

		[DataMember(Name = "salt")]
		[Preserve]
		public string Salt;

		[Preserve]
		[DataMember(Name = "signature")]
		public string Signature;

		[Preserve]
		[DataMember(Name = "public_key_url")]
		public string PublicKeyUrl;

		public AccountGameCenter()
		{
		}

		public AccountGameCenter(string playerIdParam, string bundleIdParam, long timestampSecondsParam, string saltParam, string signatureParam, string publicKeyUrlParam)
		{
		}
	}
}
