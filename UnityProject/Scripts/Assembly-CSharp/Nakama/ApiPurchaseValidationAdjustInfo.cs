using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiPurchaseValidationAdjustInfo
	{
		[DataMember(Name = "ad_id")]
		[Preserve]
		public string AdId { get; set; }

		[DataMember(Name = "app_token")]
		[Preserve]
		public string AppToken { get; set; }

		[Preserve]
		[DataMember(Name = "event_name")]
		public string EventName { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
