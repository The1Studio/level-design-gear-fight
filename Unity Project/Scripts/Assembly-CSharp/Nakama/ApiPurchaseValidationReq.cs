using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiPurchaseValidationReq
	{
		[Preserve]
		[DataMember(Name = "adjust_info")]
		public ApiPurchaseValidationAdjustInfo AdjustInfo { get; set; }

		[DataMember(Name = "advertising_id")]
		[Preserve]
		public string AdvertisingId { get; set; }

		[DataMember(Name = "app_version")]
		[Preserve]
		public string AppVersion { get; set; }

		[Preserve]
		[DataMember(Name = "bundle_id")]
		public string BundleId { get; set; }

		[Preserve]
		[DataMember(Name = "connectivity")]
		public string Connectivity { get; set; }

		[Preserve]
		[DataMember(Name = "device")]
		public string Device { get; set; }

		[DataMember(Name = "idfv")]
		[Preserve]
		public string Idfv { get; set; }

		[DataMember(Name = "limit_ad_tracking")]
		[Preserve]
		public bool LimitAdTracking { get; set; }

		[DataMember(Name = "locale")]
		[Preserve]
		public string Locale { get; set; }

		[Preserve]
		[DataMember(Name = "os_version")]
		public string OsVersion { get; set; }

		[DataMember(Name = "platform")]
		[Preserve]
		public string Platform { get; set; }

		[DataMember(Name = "receipt")]
		[Preserve]
		public ApiPurchaseValidationReceipt Receipt { get; set; }

		[Preserve]
		[DataMember(Name = "user_id")]
		public string UserId { get; set; }

		[DataMember(Name = "van_info")]
		[Preserve]
		public ApiPurchaseValidationVanInfo VanInfo { get; set; }

		[DataMember(Name = "vs_version")]
		[Preserve]
		public string VsVersion { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
