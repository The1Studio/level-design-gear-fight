using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiAbTestSyncReq
	{
		[DataMember(Name = "ab_test_names")]
		[Preserve]
		public List<string> AbTestNames { get; set; }

		[DataMember(Name = "num_game_rounds")]
		[Preserve]
		public int NumGameRounds { get; set; }

		[DataMember(Name = "voodoo_tune_config_id")]
		[Preserve]
		public string VoodooTuneConfigId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
