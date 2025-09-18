using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class NewGift
	{
		[Preserve]
		[DataMember(Name = "items")]
		public Dictionary<string, int> Items;

		[Preserve]
		[DataMember(Name = "message")]
		public string Message;

		public NewGift()
		{
		}

		public NewGift(Dictionary<string, int> itemsParam, string messageParam)
		{
		}
	}
}
