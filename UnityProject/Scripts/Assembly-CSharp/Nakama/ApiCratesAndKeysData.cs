using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiCratesAndKeysData
	{
		[DataMember(Name = "reward_crate_id")]
		[Preserve]
		public string RewardCrateId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
