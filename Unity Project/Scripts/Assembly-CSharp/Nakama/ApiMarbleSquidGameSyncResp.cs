using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMarbleSquidGameSyncResp
	{
		[Preserve]
		[DataMember(Name = "current_match")]
		public ApiMarbleSquidGameMatch CurrentMatch { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
