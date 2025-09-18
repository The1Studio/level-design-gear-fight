using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiAccountGoogle
	{
		[Preserve]
		[DataMember(Name = "token")]
		public string Token { get; set; }

		[DataMember(Name = "vars")]
		[Preserve]
		public Dictionary<string, string> Vars { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
