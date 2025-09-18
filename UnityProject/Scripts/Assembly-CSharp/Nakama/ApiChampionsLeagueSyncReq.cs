using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiChampionsLeagueSyncReq
	{
		[DataMember(Name = "data")]
		[Preserve]
		public ApiChampionsLeagueRequestData Data { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
