using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiValidateIAPRequest
	{
		[Preserve]
		[DataMember(Name = "platform")]
		public ApiIAPStore Platform { get; set; }

		[Preserve]
		[DataMember(Name = "receipt")]
		public string Receipt { get; set; }

		[Preserve]
		[DataMember(Name = "signature")]
		public string Signature { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
