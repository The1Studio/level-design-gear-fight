using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiAuthenticateEmailVerifyCodeRequest
	{
		[DataMember(Name = "code")]
		[Preserve]
		public string Code { get; set; }

		[DataMember(Name = "create")]
		[Preserve]
		public bool Create { get; set; }

		[Preserve]
		[DataMember(Name = "email")]
		public string Email { get; set; }

		[Preserve]
		[DataMember(Name = "vars")]
		public Dictionary<string, string> Vars { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
