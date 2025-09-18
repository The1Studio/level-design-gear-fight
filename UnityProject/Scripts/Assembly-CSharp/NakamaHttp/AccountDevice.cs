using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class AccountDevice
	{
		[DataMember(Name = "id")]
		[Preserve]
		public string Id;

		public AccountDevice()
		{
		}

		public AccountDevice(string idParam)
		{
		}
	}
}
