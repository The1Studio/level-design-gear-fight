using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiLinkEmailRequestCodeRequest
	{
		[DataMember(Name = "email")]
		[Preserve]
		public string Email { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
