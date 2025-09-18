using UnityEngine;
using Voodoo.Sauce.Common.Utils.Data.ScreenUtilsConfig;

namespace Voodoo.Sauce.Internal.Utils
{
	public static class ScreenSizeUtils
	{
		private const int CUTOUT_HEIGHT_ANDROID = 80;

		private static Vector2 _nativeScreenResolution;

		private static VoodooScreenUtilsConfig _config;

		private static Vector2 GetUnityResolutions()
		{
			return default(Vector2);
		}

		private static Vector2 GetNativeResolutions()
		{
			return default(Vector2);
		}

		public static Vector2 GetResolutionNativeToUnityRatio()
		{
			return default(Vector2);
		}

		public static Vector2 GetResolutionUnityToNativeRatio()
		{
			return default(Vector2);
		}

		public static float GetDpi()
		{
			return 0f;
		}
	}
}
