using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class Gift
	{
		[DataMember(Name = "items")]
		[Preserve]
		public Dictionary<string, int> Items;

		[DataMember(Name = "id")]
		[Preserve]
		public string Id;

		[Preserve]
		[DataMember(Name = "message")]
		public string Message;

		[Preserve]
		[DataMember(Name = "sent_at_unix_secs")]
		public int SentAtUnixSecs;

		[Preserve]
		[DataMember(Name = "claimed_at_unix_secs")]
		public int ClaimedAtUnixSecs;

		[DataMember(Name = "type")]
		[Preserve]
		public GiftType Type;

		public Gift()
		{
		}

		public Gift(Dictionary<string, int> itemsParam, string idParam, string messageParam, int sentAtUnixSecsParam, int claimedAtUnixSecsParam, GiftType typeParam)
		{
		}
	}
}
