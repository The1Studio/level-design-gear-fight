using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleMatchState
	{
		[Preserve]
		[DataMember(Name = "presences")]
		public List<RealtimeUserPresence> Presences { get; set; }

		[DataMember(Name = "state")]
		[Preserve]
		public string State { get; set; }

		[DataMember(Name = "tick")]
		[Preserve]
		public long Tick { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
