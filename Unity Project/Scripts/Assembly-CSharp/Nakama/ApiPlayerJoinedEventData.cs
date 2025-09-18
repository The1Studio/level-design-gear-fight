using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiPlayerJoinedEventData
	{
		[Preserve]
		[DataMember(Name = "display_name")]
		public string DisplayName { get; set; }

		[Preserve]
		[DataMember(Name = "player_id")]
		public string PlayerId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
