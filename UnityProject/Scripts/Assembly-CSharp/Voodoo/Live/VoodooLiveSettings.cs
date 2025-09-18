using UnityEngine;
using Voodoo.Live.Offers;
using Voodoo.Live.Shop;

namespace Voodoo.Live
{
	[CreateAssetMenu(fileName = "VoodooLiveSettings", menuName = "VoodooLive/VoodooLive Settings")]
	public class VoodooLiveSettings : ScriptableObject
	{
		[Header("Info")]
		public string version;

		[Header("Settings")]
		public bool isOfferEnabled;

		public bool isShopEnabled;

		[SerializeField]
		[Header("Configs")]
		private OffersConfigSO _offersConfig;

		[SerializeField]
		private ShopConfigSO _shopConfig;

		[SerializeField]
		[Header("Services")]
		private bool _purchasingService;

		private const string TAG = "VOODOOLIVE_SETTINGS_CONFIG";

		private static VoodooLiveSettings _instance;

		public OffersConfigSO OffersConfig => null;

		public ShopConfigSO ShopConfig => null;

		public static VoodooLiveSettings Load()
		{
			return null;
		}
	}
}
