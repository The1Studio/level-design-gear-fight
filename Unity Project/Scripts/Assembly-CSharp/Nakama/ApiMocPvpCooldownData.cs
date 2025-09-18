using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMocPvpCooldownData
	{
		[Preserve]
		[DataMember(Name = "secs_until_standard_attacks_allowed")]
		public int SecsUntilStandardAttacksAllowed { get; set; }

		[Preserve]
		[DataMember(Name = "standard_attacks_allowed")]
		public bool StandardAttacksAllowed { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
