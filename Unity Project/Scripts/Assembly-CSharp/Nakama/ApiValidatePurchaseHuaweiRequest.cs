using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiValidatePurchaseHuaweiRequest
	{
		[DataMember(Name = "purchase")]
		[Preserve]
		public string Purchase { get; set; }

		[DataMember(Name = "signature")]
		[Preserve]
		public string Signature { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
