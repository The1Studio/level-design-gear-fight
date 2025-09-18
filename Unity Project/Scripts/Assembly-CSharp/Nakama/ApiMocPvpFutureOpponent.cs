using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMocPvpFutureOpponent
	{
		[DataMember(Name = "opponent_player_data")]
		[Preserve]
		public ApiMocPlayerData OpponentPlayerData { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
