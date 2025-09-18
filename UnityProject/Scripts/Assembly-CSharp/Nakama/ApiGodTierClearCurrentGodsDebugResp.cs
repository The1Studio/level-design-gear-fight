using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierClearCurrentGodsDebugResp
	{
		[DataMember(Name = "current_gods")]
		[Preserve]
		public ApiGodTierGodData CurrentGods { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
