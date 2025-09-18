using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleConsoleUIConfig
	{
		[DataMember(Name = "okta_client_id")]
		[Preserve]
		public string OktaClientId { get; set; }

		[DataMember(Name = "okta_issuer_url")]
		[Preserve]
		public string OktaIssuerUrl { get; set; }

		[Preserve]
		[DataMember(Name = "okta_redirect_url")]
		public string OktaRedirectUrl { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
