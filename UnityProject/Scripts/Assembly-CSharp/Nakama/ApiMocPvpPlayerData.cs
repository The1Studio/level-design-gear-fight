using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMocPvpPlayerData
	{
		[Preserve]
		[DataMember(Name = "diorama_progress")]
		public ApiMocPvpDioramaProgress DioramaProgress { get; set; }

		[Preserve]
		[DataMember(Name = "max_available_emoji")]
		public int MaxAvailableEmoji { get; set; }

		[DataMember(Name = "shields")]
		[Preserve]
		public int Shields { get; set; }

		[DataMember(Name = "troop_data")]
		[Preserve]
		public ApiMocPvpTroopData TroopData { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
