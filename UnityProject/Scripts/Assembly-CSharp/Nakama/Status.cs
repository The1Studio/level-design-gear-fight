using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class Status : IStatus
	{
		public IEnumerable<IUserPresence> Presences => null;

		[Preserve]
		[DataMember(Name = "presences")]
		public List<UserPresence> PresencesField { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
