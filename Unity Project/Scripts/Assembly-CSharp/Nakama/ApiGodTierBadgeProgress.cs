using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierBadgeProgress
	{
		[DataMember(Name = "after")]
		[Preserve]
		public ApiGodTierBadgeData After { get; set; }

		[DataMember(Name = "before")]
		[Preserve]
		public ApiGodTierBadgeData Before { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
