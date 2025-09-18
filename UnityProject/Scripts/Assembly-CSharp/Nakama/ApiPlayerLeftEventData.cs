using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiPlayerLeftEventData
	{
		[Preserve]
		[DataMember(Name = "display_name")]
		public string DisplayName { get; set; }

		[DataMember(Name = "player_id")]
		[Preserve]
		public string PlayerId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
