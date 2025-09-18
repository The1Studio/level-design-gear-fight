using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class GetUserClientAttributesReq
	{
		[DataMember(Name = "user_id")]
		[Preserve]
		public string UserId;

		public GetUserClientAttributesReq()
		{
		}

		public GetUserClientAttributesReq(string userIdParam)
		{
		}
	}
}
