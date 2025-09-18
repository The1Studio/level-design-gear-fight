using UnityEngine;

namespace Voodoo.Sauce.Internal.StoreUtility
{
	public class AppUpdateCallback : AndroidJavaProxy
	{
		public AppUpdateInfo appUpdateInfo;

		public AppUpdateCallback()
			: base((string)null)
		{
		}

		public void onSuccess(string data)
		{
		}

		public void onFailure(string data)
		{
		}
	}
}
