using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMobWarsSyncResp
	{
		[Preserve]
		[DataMember(Name = "acked_duel_ids")]
		public List<string> AckedDuelIds { get; set; }

		[DataMember(Name = "data")]
		[Preserve]
		public ApiMobWarsData Data { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
