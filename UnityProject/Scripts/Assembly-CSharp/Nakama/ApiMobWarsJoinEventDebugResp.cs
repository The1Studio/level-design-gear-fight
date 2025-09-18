using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMobWarsJoinEventDebugResp
	{
		[DataMember(Name = "data")]
		[Preserve]
		public ApiMobWarsData Data { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
