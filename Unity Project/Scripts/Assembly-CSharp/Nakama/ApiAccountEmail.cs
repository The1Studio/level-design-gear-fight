using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiAccountEmail
	{
		[DataMember(Name = "email")]
		[Preserve]
		public string Email { get; set; }

		[DataMember(Name = "password")]
		[Preserve]
		public string Password { get; set; }

		[Preserve]
		[DataMember(Name = "vars")]
		public Dictionary<string, string> Vars { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
