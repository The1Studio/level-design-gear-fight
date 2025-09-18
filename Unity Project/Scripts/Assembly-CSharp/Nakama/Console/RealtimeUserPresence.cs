using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class RealtimeUserPresence
	{
		[DataMember(Name = "persistence")]
		[Preserve]
		public bool Persistence { get; set; }

		[DataMember(Name = "session_id")]
		[Preserve]
		public string SessionId { get; set; }

		[DataMember(Name = "status")]
		[Preserve]
		public string Status { get; set; }

		[DataMember(Name = "user_id")]
		[Preserve]
		public string UserId { get; set; }

		[DataMember(Name = "username")]
		[Preserve]
		public string Username { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
