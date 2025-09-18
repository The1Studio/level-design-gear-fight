using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class StoryEventSyncReq
	{
		[DataMember(Name = "id")]
		[Preserve]
		public string Id;

		public StoryEventSyncReq()
		{
		}

		public StoryEventSyncReq(string idParam)
		{
		}
	}
}
