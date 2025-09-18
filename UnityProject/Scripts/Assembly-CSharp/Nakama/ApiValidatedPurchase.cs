using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiValidatedPurchase
	{
		[Preserve]
		[DataMember(Name = "create_time")]
		public string CreateTime { get; set; }

		[DataMember(Name = "environment")]
		[Preserve]
		public ValidatedPurchaseEnvironment Environment { get; set; }

		[DataMember(Name = "product_id")]
		[Preserve]
		public string ProductId { get; set; }

		[DataMember(Name = "provider_response")]
		[Preserve]
		public string ProviderResponse { get; set; }

		[DataMember(Name = "purchase_time")]
		[Preserve]
		public string PurchaseTime { get; set; }

		[DataMember(Name = "store")]
		[Preserve]
		public ApiIAPStore Store { get; set; }

		[DataMember(Name = "transaction_id")]
		[Preserve]
		public string TransactionId { get; set; }

		[DataMember(Name = "update_time")]
		[Preserve]
		public string UpdateTime { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
