using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMobWarsSyncReq
	{
		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId { get; set; }

		[Preserve]
		[DataMember(Name = "duel_results")]
		public List<ApiMobWarsDuelResult> DuelResults { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
