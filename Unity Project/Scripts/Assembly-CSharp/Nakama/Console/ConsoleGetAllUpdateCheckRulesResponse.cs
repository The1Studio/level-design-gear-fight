using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleGetAllUpdateCheckRulesResponse
	{
		[Preserve]
		[DataMember(Name = "rules")]
		public List<ConsoleUpdateCheckRule> Rules { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
