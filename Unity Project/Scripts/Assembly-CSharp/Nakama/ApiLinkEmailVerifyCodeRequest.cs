using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiLinkEmailVerifyCodeRequest
	{
		[DataMember(Name = "code")]
		[Preserve]
		public string Code { get; set; }

		[DataMember(Name = "email")]
		[Preserve]
		public string Email { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
