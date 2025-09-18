using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Live.Offers;
using Voodoo.Live.Utils;

namespace Voodoo.Live.Sample.Offers.UI
{
	public class OfferPopupUI : FeaturePopup
	{
		[SerializeField]
		private TextMeshProUGUI _titleTxt;

		[SerializeField]
		private TextMeshProUGUI _discountTxt;

		[SerializeField]
		private TextMeshProUGUI _currentPriceTxt;

		[SerializeField]
		private TextMeshProUGUI _multiplierTxt;

		[SerializeField]
		private Countdown _countDownTxt;

		[SerializeField]
		private TextMeshProUGUI _oldPriceTxt;

		[SerializeField]
		private Image _illustrationImg;

		[SerializeField]
		private Transform _rewardsContainer;

		[SerializeField]
		private Button _purchaseBtn;

		[SerializeField]
		private OfferPurchaseBtnUI _purchaseBtnUI;

		[SerializeField]
		private Button _closeBtn;

		[SerializeField]
		private OfferPopupItemUI _rewardItemPrefab;

		[SerializeField]
		private GameObject _multiplierGO;

		[SerializeField]
		private GameObject _discountGO;

		[SerializeField]
		private GameObject _loadingScreen;

		private UIOffersConfigSO _uiConfig;

		public override void Show()
		{
		}

		private void Setup(Offer offer)
		{
		}

		public override void Purchase(IPurchasable purchasable)
		{
		}

		private void DisplayLoadingScreen(bool display)
		{
		}

		public override void OnStatusChanged(string status, IFeature feature)
		{
		}
	}
}
