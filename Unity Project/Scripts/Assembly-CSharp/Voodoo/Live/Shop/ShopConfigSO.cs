using UnityEngine;

namespace Voodoo.Live.Shop
{
	[CreateAssetMenu(fileName = "ShopConfig", menuName = "VoodooLive/Shop/Config")]
	public class ShopConfigSO : ScriptableObject
	{
		[Header("Shop Spreadsheet Url")]
		public string shopSpreadsheetUrl;

		[Header("Cache Build")]
		public string shopConfig;

		public void CacheShopData(string data)
		{
		}

		public void ClearCache()
		{
		}
	}
}
