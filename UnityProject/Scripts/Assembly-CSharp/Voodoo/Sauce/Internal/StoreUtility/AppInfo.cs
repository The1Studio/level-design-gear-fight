using System;

namespace Voodoo.Sauce.Internal.StoreUtility
{
	public static class AppInfo
	{
		public static void OpenStore()
		{
		}

		public static void GetAppUpdateStatus(Action<AppUpdateStatus> onAppUpdateStatusRetrieved)
		{
		}

		public static int GetVersionCode()
		{
			return 0;
		}

		public static bool IsSandbox()
		{
			return false;
		}
	}
}
