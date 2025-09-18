using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Sauce.Ads;
using Voodoo.Sauce.Core;

namespace Voodoo.Sauce.Internal.Ads
{
	public class RewardedInterstitialManager : MonoBehaviour
	{
		private const string TAG = "RewardedInterstitialManager";

		private const string TOTAL_POPUP_SHOWN_COUNT = "TotalPopupShownCount";

		[Header("Configuration")]
		public Sprite softCurrencySprite;

		public Sprite hardCurrencySprite;

		public string softCurrencyText;

		public string hardCurrencyText;

		public RewardedInterstitialCallbacks callbacks;

		[Header("Internal")]
		public GameObject popup;

		public Button[] closeButtons;

		public Image rewardImage;

		public TMP_Text rewardText;

		private int _currentInterstitialCount;

		private int _popupShownCount;

		private int _currentIndex;

		private InterstitialCurrencyType _currentCurrencyType;

		private int _softCurrency;

		private int _hardCurrency;

		private RewardedInterstitial _config;

		public static RewardedInterstitialManager Instance { get; private set; }

		private int TotalPopupShownCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public RewardedInterstitial Config => null;

		private void Awake()
		{
		}

		private void Initialize(VoodooSauceInitCallbackResult result)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnCloseButtonClicked()
		{
		}

		private void ShowPopup()
		{
		}

		private void HidePopup()
		{
		}

		private void SetupPopup()
		{
		}

		private void GiveRewardWithoutShowingPopup()
		{
		}

		private void PrepareReward()
		{
		}

		private void GiveCurrency()
		{
		}

		private void OnInterstitialClosed()
		{
		}

		public void TryToShow()
		{
		}
	}
}
