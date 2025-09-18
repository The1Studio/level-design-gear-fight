using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiValidatePurchaseResponse
	{
		[Preserve]
		[DataMember(Name = "validated_purchases")]
		public List<ApiValidatedPurchase> ValidatedPurchases { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
