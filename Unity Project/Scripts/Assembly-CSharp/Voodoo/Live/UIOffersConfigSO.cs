using UnityEngine;
using Voodoo.Live.Sample.Offers;
using Voodoo.Live.Sample.Offers.UI;
using Voodoo.Live.Utils;

namespace Voodoo.Live
{
	[CreateAssetMenu(fileName = "UIOffersConfig", menuName = "VoodooLive/Offers/UI Config")]
	public class UIOffersConfigSO : ScriptableObject
	{
		[Header("Items Images")]
		public SpriteDictionarySO items;

		[Header("Popup Images")]
		public SpriteDictionarySO popups;

		[Header("Badge Icons")]
		public SpriteDictionarySO badges;

		[Header("UI Prefabs")]
		public FeaturePopup[] OfferPopups;

		public OfferBadgeUI[] OfferBadges;

		public OfferBadgesManagerUI OfferBadgesManager;

		public Canvas VoodooLiveCanvas;

		private const string TAG = "VOODOOLIVE_UI_OFFERS_CONFIG";

		private static UIOffersConfigSO _instance;

		public Sprite GetBadgeIconById(string id)
		{
			return null;
		}

		public Sprite GetPopupImageById(string id)
		{
			return null;
		}

		public Sprite GetItemImageById(string id)
		{
			return null;
		}

		public static UIOffersConfigSO Load()
		{
			return null;
		}
	}
}
