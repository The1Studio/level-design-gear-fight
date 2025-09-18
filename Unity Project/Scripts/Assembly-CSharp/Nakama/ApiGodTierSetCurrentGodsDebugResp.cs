using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierSetCurrentGodsDebugResp
	{
		[Preserve]
		[DataMember(Name = "current_gods")]
		public ApiGodTierGodData CurrentGods { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
