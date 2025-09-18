using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class MatchmakerUser : IMatchmakerUser
	{
		public IDictionary<string, double> NumericProperties => null;

		[DataMember(Name = "numeric_properties")]
		[Preserve]
		public Dictionary<string, double> _numericProperties { get; set; }

		public IUserPresence Presence => null;

		[DataMember(Name = "presence")]
		[Preserve]
		public UserPresence _presence { get; set; }

		public IDictionary<string, string> StringProperties => null;

		[DataMember(Name = "string_properties")]
		[Preserve]
		public Dictionary<string, string> _stringProperties { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
