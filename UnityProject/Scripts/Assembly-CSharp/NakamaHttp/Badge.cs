using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class Badge
	{
		[DataMember(Name = "best_position")]
		[Preserve]
		public int BestPosition;

		[DataMember(Name = "counter")]
		[Preserve]
		public int Counter;

		public Badge()
		{
		}

		public Badge(int bestPositionParam, int counterParam)
		{
		}
	}
}
