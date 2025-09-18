using System.Collections.Generic;
using Voodoo.Sauce.Common.Utils;
using Voodoo.Sauce.Core;

namespace Voodoo.Sauce.Internal.Utils
{
	public static class ManifestUtils
	{
		private const string DESTINATION_APPLICATION_MANIFEST_PATH = "Assets/Plugins/Android/AndroidManifest.xml";

		private static ManifestUtilsImpl _legacyManifestUtilsImpl;

		private static NewManifestUtilsImpl _newManifestUtilsImpl;

		private static VoodooSettings _settings;

		private static NewManifestUtilsImpl GetNewManifest()
		{
			return null;
		}

		public static bool Add(string manifestSourcePath)
		{
			return false;
		}

		public static bool Replace(Dictionary<string, string> keysValues)
		{
			return false;
		}
	}
}
