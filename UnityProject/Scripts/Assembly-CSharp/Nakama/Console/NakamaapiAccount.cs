using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class NakamaapiAccount
	{
		[DataMember(Name = "devices")]
		[Preserve]
		public List<ApiAccountDevice> Devices { get; set; }

		[DataMember(Name = "disable_time")]
		[Preserve]
		public string DisableTime { get; set; }

		[DataMember(Name = "email")]
		[Preserve]
		public string Email { get; set; }

		[DataMember(Name = "user")]
		[Preserve]
		public NakamaapiUser User { get; set; }

		[DataMember(Name = "verify_time")]
		[Preserve]
		public string VerifyTime { get; set; }

		[DataMember(Name = "wallet")]
		[Preserve]
		public string Wallet { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
