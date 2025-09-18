using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMergeAccountRequest
	{
		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId { get; set; }

		[DataMember(Name = "from_account_session_token")]
		[Preserve]
		public string FromAccountSessionToken { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
