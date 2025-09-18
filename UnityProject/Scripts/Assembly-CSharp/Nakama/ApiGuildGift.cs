using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildGift
	{
		[Preserve]
		[DataMember(Name = "claimed")]
		public bool Claimed { get; set; }

		[DataMember(Name = "giver_display_name")]
		[Preserve]
		public string GiverDisplayName { get; set; }

		[Preserve]
		[DataMember(Name = "giver_user_id")]
		public string GiverUserId { get; set; }

		[Preserve]
		[DataMember(Name = "id")]
		public string Id { get; set; }

		[Preserve]
		[DataMember(Name = "request_id")]
		public string RequestId { get; set; }

		[Preserve]
		[DataMember(Name = "type")]
		public string Type { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
