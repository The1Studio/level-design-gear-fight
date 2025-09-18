using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class UserPresence : IUserPresence
	{
		internal static readonly IReadOnlyList<UserPresence> NoPresences;

		[Preserve]
		[DataMember(Name = "persistence")]
		public bool Persistence { get; set; }

		[DataMember(Name = "session_id")]
		[Preserve]
		public string SessionId { get; set; }

		[Preserve]
		[DataMember(Name = "status")]
		public string Status { get; set; }

		[Preserve]
		[DataMember(Name = "user_id")]
		public string UserId { get; set; }

		public override bool Equals(object obj)
		{
			return false;
		}

		private bool Equals(IUserPresence other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
