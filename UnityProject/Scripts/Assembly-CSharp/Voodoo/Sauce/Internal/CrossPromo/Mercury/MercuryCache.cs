using Voodoo.Sauce.Internal.CrossPromo.Mercury.Models;

namespace Voodoo.Sauce.Internal.CrossPromo.Mercury
{
	public static class MercuryCache
	{
		private const string TAG = "CrossPromoMercuryCache";

		private const string CACHE_DIRECTORY_NAME = "Mercury";

		private static string _parentDirectory;

		private static string _cachePath;

		public static MercuryPromotedAsset GetAsset(string assetId)
		{
			return null;
		}

		public static MercuryWaterfall GetWaterfall(string waterfallId)
		{
			return null;
		}

		public static bool IsCached(string assetId)
		{
			return false;
		}

		public static void SaveAsset(MercuryPromotedAsset asset, byte[] videoBytes)
		{
		}

		public static void SaveWaterfall(MercuryWaterfall waterfall)
		{
		}

		private static void CreateDirectoryForFile(string filePath)
		{
		}

		public static void ClearCache()
		{
		}

		private static string GetVideoPath(string assetId)
		{
			return null;
		}

		private static string GetAssetPath(string assetId)
		{
			return null;
		}
	}
}
