using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiScheduledRaceConfiguration
	{
		[DataMember(Name = "race_creation_enabled")]
		[Preserve]
		public bool RaceCreationEnabled { get; set; }

		[DataMember(Name = "race_type")]
		[Preserve]
		public ApiScheduledRaceType RaceType { get; set; }

		[DataMember(Name = "team_size")]
		[Preserve]
		public int TeamSize { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
