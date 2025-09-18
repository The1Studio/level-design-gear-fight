using UnityEngine;

namespace Voodoo.Live.Offers
{
	[CreateAssetMenu(fileName = "OffersConfig", menuName = "VoodooLive/Offers/Config")]
	public class OffersConfigSO : ScriptableObject
	{
		[Header("Cache Build")]
		public string offersConfig;

		private const string TAG = "VOODOOLIVE_OFFERS_CONFIG";

		public void CacheOffersData(string data)
		{
		}

		public void ClearCache()
		{
		}
	}
}
