using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class InvitationRewardItem
	{
		[Preserve]
		[DataMember(Name = "items")]
		public Dictionary<string, int> Items;

		public InvitationRewardItem()
		{
		}

		public InvitationRewardItem(Dictionary<string, int> itemsParam)
		{
		}
	}
}
