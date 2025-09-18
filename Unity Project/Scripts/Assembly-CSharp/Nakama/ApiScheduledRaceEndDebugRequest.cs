using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiScheduledRaceEndDebugRequest
	{
		[DataMember(Name = "race_id")]
		[Preserve]
		public int RaceId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
