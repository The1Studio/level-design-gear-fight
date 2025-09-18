using System;

namespace Voodoo.Sauce.Privacy
{
	[Serializable]
	public class NeedConsentParams
	{
		public string bundle_id;

		public string user;

		public string popup_version;

		public string os_type;

		public string app_version;

		public string vs_version;

		public string locale;

		public string uuid;

		public string studio_name;

		public int gdpr_type;

		public string vendor_id;

		public string voodoo_user_id;

		public string idfa_authorization_status;

		public override string ToString()
		{
			return null;
		}
	}
}
