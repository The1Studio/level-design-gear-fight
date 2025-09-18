using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiValidatePurchaseAppleRequest
	{
		[DataMember(Name = "receipt")]
		[Preserve]
		public string Receipt { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
