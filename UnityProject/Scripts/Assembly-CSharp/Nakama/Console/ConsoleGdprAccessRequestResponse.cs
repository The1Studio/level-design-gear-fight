using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleGdprAccessRequestResponse
	{
		[DataMember(Name = "data")]
		[Preserve]
		public Dictionary<string, string> Data { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
