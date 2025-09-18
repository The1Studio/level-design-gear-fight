using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiPiggyRaceSimulateBotPointsResponse
	{
		[DataMember(Name = "points")]
		[Preserve]
		public List<int> Points { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
