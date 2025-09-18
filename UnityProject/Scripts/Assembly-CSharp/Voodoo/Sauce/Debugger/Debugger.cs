using Voodoo.Sauce.Internal.StoreUtility;

namespace Voodoo.Sauce.Debugger
{
	public static class Debugger
	{
		private static readonly DebuggerCanvas _debugger;

		private static AppUpdateStatus _status;

		static Debugger()
		{
		}

		public static string GetDebuggerAuthorizationDescription()
		{
			return null;
		}

		public static void TryOpen()
		{
		}

		public static void TryClose()
		{
		}

		private static void OnAppUpdateStatusReceived(AppUpdateStatus status)
		{
		}

		public static void Show(Screen screen)
		{
		}

		public static void Previous()
		{
		}

		public static void Toggle(Screen screen)
		{
		}

		internal static void DisplayPopup(string message)
		{
		}

		internal static void DisplayPopup(string title, string message)
		{
		}

		internal static void DisplayPopup(DebuggerPopupConfig config)
		{
		}
	}
}
