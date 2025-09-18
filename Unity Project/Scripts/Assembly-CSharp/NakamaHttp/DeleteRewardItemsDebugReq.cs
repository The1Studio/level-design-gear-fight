using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class DeleteRewardItemsDebugReq
	{
		[DataMember(Name = "identifiers")]
		[Preserve]
		public List<string> Identifiers;

		public DeleteRewardItemsDebugReq()
		{
		}

		public DeleteRewardItemsDebugReq(List<string> identifiersParam)
		{
		}
	}
}
