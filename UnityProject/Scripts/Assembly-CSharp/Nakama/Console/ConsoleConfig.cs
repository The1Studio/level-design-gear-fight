using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleConfig
	{
		[Preserve]
		[DataMember(Name = "config")]
		public string Config { get; set; }

		[Preserve]
		[DataMember(Name = "server_version")]
		public string ServerVersion { get; set; }

		[Preserve]
		[DataMember(Name = "warnings")]
		public List<ConfigWarning> Warnings { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
