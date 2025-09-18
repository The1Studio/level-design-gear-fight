using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierBadgeData
	{
		[DataMember(Name = "best_position")]
		[Preserve]
		public int BestPosition { get; set; }

		[DataMember(Name = "counter")]
		[Preserve]
		public int Counter { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
