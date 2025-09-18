using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMobWarsJoinEventResp
	{
		[Preserve]
		[DataMember(Name = "data")]
		public ApiMobWarsData Data { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
