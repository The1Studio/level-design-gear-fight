using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMocPvpData
	{
		[Preserve]
		[DataMember(Name = "future_opponents")]
		public List<ApiMocPvpFutureOpponent> FutureOpponents { get; set; }

		[Preserve]
		[DataMember(Name = "received_attacks")]
		public List<ApiMocPvpReceivedAttack> ReceivedAttacks { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
