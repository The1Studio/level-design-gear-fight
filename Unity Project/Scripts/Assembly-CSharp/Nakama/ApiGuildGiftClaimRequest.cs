using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildGiftClaimRequest
	{
		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId { get; set; }

		[DataMember(Name = "gift_ids")]
		[Preserve]
		public List<string> GiftIds { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
