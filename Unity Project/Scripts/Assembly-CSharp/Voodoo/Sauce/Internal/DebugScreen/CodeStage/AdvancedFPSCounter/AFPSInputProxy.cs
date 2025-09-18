using UnityEngine;

namespace Voodoo.Sauce.Internal.DebugScreen.CodeStage.AdvancedFPSCounter
{
	public static class AFPSInputProxy
	{
		public static bool GetHotKeyDown(KeyCode key)
		{
			return false;
		}

		public static bool GetControlKey()
		{
			return false;
		}

		public static bool GetAltKey()
		{
			return false;
		}

		public static bool GetShiftKey()
		{
			return false;
		}
	}
}
