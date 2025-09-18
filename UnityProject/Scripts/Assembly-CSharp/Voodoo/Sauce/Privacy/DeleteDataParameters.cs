using System;

namespace Voodoo.Sauce.Privacy
{
	[Serializable]
	public class DeleteDataParameters
	{
		public string uuid;

		public string appVersion;

		public string vsVersion;

		public string bundleId;

		public string platform;

		public string locale;

		public string email;

		public string studioName;

		public int gdprType;

		public string vendor_id;

		public string voodoo_user_id;
	}
}
