using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierAddBotsDebugResp
	{
		[Preserve]
		[DataMember(Name = "success")]
		public bool Success { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
