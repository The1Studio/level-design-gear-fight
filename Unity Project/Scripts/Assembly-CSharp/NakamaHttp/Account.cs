using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class Account
	{
		[Preserve]
		[DataMember(Name = "user")]
		public User User;

		[DataMember(Name = "devices")]
		[Preserve]
		public List<AccountDevice> Devices;

		[DataMember(Name = "email")]
		[Preserve]
		public string Email;

		[DataMember(Name = "verify_time")]
		[Preserve]
		public string VerifyTime;

		[Preserve]
		[DataMember(Name = "disable_time")]
		public string DisableTime;

		public Account()
		{
		}

		public Account(User userParam, List<AccountDevice> devicesParam, string emailParam, string verifyTimeParam, string disableTimeParam)
		{
		}
	}
}
