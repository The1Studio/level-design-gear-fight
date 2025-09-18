using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ApiValidatedPurchase
	{
		[DataMember(Name = "create_time")]
		[Preserve]
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

		[Preserve]
		[DataMember(Name = "purchase_time")]
		public string PurchaseTime { get; set; }

		[Preserve]
		[DataMember(Name = "store")]
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
