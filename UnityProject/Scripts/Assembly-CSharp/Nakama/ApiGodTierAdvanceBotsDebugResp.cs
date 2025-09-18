using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierAdvanceBotsDebugResp
	{
		[DataMember(Name = "num_bots_evaluated")]
		[Preserve]
		public int NumBotsEvaluated { get; set; }

		[DataMember(Name = "success")]
		[Preserve]
		public bool Success { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
