using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class LinkEmailRequestCodeRequest
	{
		[Preserve]
		[DataMember(Name = "email")]
		public string Email;

		public LinkEmailRequestCodeRequest()
		{
		}

		public LinkEmailRequestCodeRequest(string emailParam)
		{
		}
	}
}
