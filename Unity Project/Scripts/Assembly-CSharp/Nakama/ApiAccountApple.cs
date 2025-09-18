using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiAccountApple
	{
		[Preserve]
		[DataMember(Name = "token")]
		public string Token { get; set; }

		[Preserve]
		[DataMember(Name = "vars")]
		public Dictionary<string, string> Vars { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
