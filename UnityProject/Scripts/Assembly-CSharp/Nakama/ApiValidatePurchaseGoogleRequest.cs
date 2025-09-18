using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiValidatePurchaseGoogleRequest
	{
		[DataMember(Name = "purchase")]
		[Preserve]
		public string Purchase { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
