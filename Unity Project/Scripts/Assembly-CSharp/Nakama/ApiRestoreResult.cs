using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiRestoreResult
	{
		[DataMember(Name = "failure_reason")]
		[Preserve]
		public string FailureReason { get; set; }

		[DataMember(Name = "reward")]
		[Preserve]
		public ApiRewardToRestore Reward { get; set; }

		[DataMember(Name = "success")]
		[Preserve]
		public bool Success { get; set; }

		[Preserve]
		[DataMember(Name = "user_id")]
		public string UserId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
