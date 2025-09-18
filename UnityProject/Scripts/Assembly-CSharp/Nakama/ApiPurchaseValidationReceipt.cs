using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiPurchaseValidationReceipt
	{
		[DataMember(Name = "currency")]
		[Preserve]
		public string Currency { get; set; }

		[DataMember(Name = "price_cents")]
		[Preserve]
		public int PriceCents { get; set; }

		[DataMember(Name = "product_id")]
		[Preserve]
		public string ProductId { get; set; }

		[Preserve]
		[DataMember(Name = "product_name")]
		public string ProductName { get; set; }

		[Preserve]
		[DataMember(Name = "shared_secret_id")]
		public string SharedSecretId { get; set; }

		[Preserve]
		[DataMember(Name = "token")]
		public string Token { get; set; }

		[DataMember(Name = "transaction_id")]
		[Preserve]
		public string TransactionId { get; set; }

		[Preserve]
		[DataMember(Name = "type")]
		public string Type { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
