using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiCastleRaidAddressLinkRequest
	{
		[Preserve]
		[DataMember(Name = "wallet_address")]
		public string WalletAddress { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
