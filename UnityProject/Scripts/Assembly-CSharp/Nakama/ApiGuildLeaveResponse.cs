using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildLeaveResponse
	{
		[DataMember(Name = "result")]
		[Preserve]
		public GuildLeaveResponseGuildLeaveResult Result { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
