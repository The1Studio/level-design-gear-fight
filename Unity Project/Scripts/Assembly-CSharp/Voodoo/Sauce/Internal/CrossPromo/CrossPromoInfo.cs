using System.Collections.Generic;
using Voodoo.Sauce.Internal.CrossPromo.Models;

namespace Voodoo.Sauce.Internal.CrossPromo
{
	internal class CrossPromoInfo
	{
		public bool HasInternet;

		public GameModel CurrentGame { get; set; }

		public string Uuid { get; private set; }

		public List<AssetModel> Assets { get; }

		public List<AssetModel> Waterfall { get; }

		public List<AssetModel> GamesInstalled { get; }

		public bool CrossPromoIsReady { get; set; }

		public string Format { get; set; }

		public void GenerateUuid()
		{
		}

		public bool GetInternetStatus()
		{
			return false;
		}

		public void FilterAssets()
		{
		}

		public void FillAssetsListFromCache()
		{
		}

		private static void Shuffle<T>(IList<T> list)
		{
		}
	}
}
