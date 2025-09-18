using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleStatusList
	{
		[DataMember(Name = "nodes")]
		[Preserve]
		public List<ConsoleStatusListStatus> Nodes { get; set; }

		[Preserve]
		[DataMember(Name = "timestamp")]
		public string Timestamp { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
