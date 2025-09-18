using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ApiAccountDevice
	{
		[DataMember(Name = "id")]
		[Preserve]
		public string Id { get; set; }

		[Preserve]
		[DataMember(Name = "vars")]
		public Dictionary<string, string> Vars { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
