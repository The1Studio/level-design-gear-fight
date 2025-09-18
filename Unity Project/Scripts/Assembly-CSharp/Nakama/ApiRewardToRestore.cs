using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiRewardToRestore
	{
		[Preserve]
		[DataMember(Name = "reward_id")]
		public string RewardId { get; set; }

		[DataMember(Name = "transaction_id")]
		[Preserve]
		public string TransactionId { get; set; }

		[DataMember(Name = "voodoo_id")]
		[Preserve]
		public string VoodooId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
