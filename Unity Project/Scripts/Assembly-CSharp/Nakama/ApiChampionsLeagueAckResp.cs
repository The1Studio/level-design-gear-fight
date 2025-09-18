using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiChampionsLeagueAckResp
	{
		[Preserve]
		[DataMember(Name = "data")]
		public ApiChampionsLeagueData Data { get; set; }

		[Preserve]
		[DataMember(Name = "enabled")]
		public bool Enabled { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
