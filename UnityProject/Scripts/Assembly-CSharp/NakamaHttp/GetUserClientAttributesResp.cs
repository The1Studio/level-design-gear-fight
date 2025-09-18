using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class GetUserClientAttributesResp
	{
		[DataMember(Name = "client_attributes")]
		[Preserve]
		public ClientAttributes ClientAttributes;

		[Preserve]
		[DataMember(Name = "user_id")]
		public string UserId;

		public GetUserClientAttributesResp()
		{
		}

		public GetUserClientAttributesResp(ClientAttributes clientAttributesParam, string userIdParam)
		{
		}
	}
}
