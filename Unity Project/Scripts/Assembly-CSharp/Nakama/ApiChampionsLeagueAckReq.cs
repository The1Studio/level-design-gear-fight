using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiChampionsLeagueAckReq
	{
		[Preserve]
		[DataMember(Name = "data")]
		public ApiChampionsLeagueRequestData Data { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
