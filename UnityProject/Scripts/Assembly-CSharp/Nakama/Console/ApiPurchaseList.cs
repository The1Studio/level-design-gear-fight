using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ApiPurchaseList
	{
		[Preserve]
		[DataMember(Name = "cursor")]
		public string Cursor { get; set; }

		[Preserve]
		[DataMember(Name = "validated_purchases")]
		public List<ApiValidatedPurchase> ValidatedPurchases { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
