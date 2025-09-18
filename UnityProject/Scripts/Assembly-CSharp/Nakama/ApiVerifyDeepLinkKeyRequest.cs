using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiVerifyDeepLinkKeyRequest
	{
		[Preserve]
		[DataMember(Name = "key")]
		public string Key { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
