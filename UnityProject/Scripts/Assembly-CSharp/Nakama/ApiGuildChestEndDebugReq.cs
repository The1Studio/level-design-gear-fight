using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildChestEndDebugReq
	{
		[Preserve]
		[DataMember(Name = "event_id")]
		public long EventId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
