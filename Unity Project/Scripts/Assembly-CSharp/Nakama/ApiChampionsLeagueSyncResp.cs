using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiChampionsLeagueSyncResp
	{
		[DataMember(Name = "data")]
		[Preserve]
		public ApiChampionsLeagueData Data { get; set; }

		[DataMember(Name = "enabled")]
		[Preserve]
		public bool Enabled { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
