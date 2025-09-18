using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace NakamaHttp
{
	public class AuthenticateDeviceRequest
	{
		[DataMember(Name = "account")]
		[Preserve]
		public AccountDevice Account;

		[DataMember(Name = "create")]
		[Preserve]
		public bool? Create;

		[DataMember(Name = "voodoo_id")]
		[CanBeNull]
		[Preserve]
		public string VoodooId;

		[DataMember(Name = "utc_offset")]
		[Preserve]
		public int UtcOffset;

		public AuthenticateDeviceRequest()
		{
		}

		public AuthenticateDeviceRequest(AccountDevice accountParam, bool? createParam, string voodooIdParam, int utcOffsetParam)
		{
		}
	}
}
