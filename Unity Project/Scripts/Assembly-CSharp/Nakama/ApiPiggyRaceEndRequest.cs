using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiPiggyRaceEndRequest
	{
		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId { get; set; }

		[DataMember(Name = "race_id")]
		[Preserve]
		public int RaceId { get; set; }

		[DataMember(Name = "utc_offset")]
		[Preserve]
		public int UtcOffset { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
