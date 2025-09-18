using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMocPvpSyncResp
	{
		[DataMember(Name = "acked_battle_result_ids")]
		[Preserve]
		public List<string> AckedBattleResultIds { get; set; }

		[DataMember(Name = "data")]
		[Preserve]
		public ApiMocPvpData Data { get; set; }

		[DataMember(Name = "enabled")]
		[Preserve]
		public bool Enabled { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
