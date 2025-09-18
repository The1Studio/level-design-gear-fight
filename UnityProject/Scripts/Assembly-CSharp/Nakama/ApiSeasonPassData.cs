using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiSeasonPassData
	{
		[DataMember(Name = "season_id")]
		[Preserve]
		public string SeasonId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
