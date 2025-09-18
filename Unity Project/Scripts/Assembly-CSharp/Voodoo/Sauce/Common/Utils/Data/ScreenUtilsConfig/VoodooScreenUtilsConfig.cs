using UnityEngine;

namespace Voodoo.Sauce.Common.Utils.Data.ScreenUtilsConfig
{
	public class VoodooScreenUtilsConfig : ScriptableObject
	{
		public const string NAME = "VoodooScreenUtilsConfig";

		public bool IsAndroidRenderOutsideSafeArea;

		public static VoodooScreenUtilsConfig Load()
		{
			return null;
		}

		public void Save()
		{
		}
	}
}
