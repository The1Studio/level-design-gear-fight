using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiAccount
	{
		[Preserve]
		[DataMember(Name = "devices")]
		public List<ApiAccountDevice> Devices { get; set; }

		[Preserve]
		[DataMember(Name = "disable_time")]
		public string DisableTime { get; set; }

		[DataMember(Name = "email")]
		[Preserve]
		public string Email { get; set; }

		[Preserve]
		[DataMember(Name = "user")]
		public ApiUser User { get; set; }

		[Preserve]
		[DataMember(Name = "verify_time")]
		public string VerifyTime { get; set; }

		[Preserve]
		[DataMember(Name = "wallet")]
		public string Wallet { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
