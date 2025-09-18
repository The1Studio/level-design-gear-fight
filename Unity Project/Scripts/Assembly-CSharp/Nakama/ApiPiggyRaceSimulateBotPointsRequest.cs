using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiPiggyRaceSimulateBotPointsRequest
	{
		[Preserve]
		[DataMember(Name = "config_id")]
		public string ConfigId { get; set; }

		[DataMember(Name = "num_bots")]
		[Preserve]
		public int NumBots { get; set; }

		[DataMember(Name = "seconds_passed_since_start")]
		[Preserve]
		public int SecondsPassedSinceStart { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
