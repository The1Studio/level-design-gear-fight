using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiVerifyDeepLinkKeyResponse
	{
		[Preserve]
		[DataMember(Name = "valid")]
		public bool Valid { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
