using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class AccountFacebookInstantGame
	{
		[Preserve]
		[DataMember(Name = "signed_player_info")]
		public string SignedPlayerInfo;

		public AccountFacebookInstantGame()
		{
		}

		public AccountFacebookInstantGame(string signedPlayerInfoParam)
		{
		}
	}
}
