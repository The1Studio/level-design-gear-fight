using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.Ads
{
	public class AudioAdsPopup : MonoBehaviour
	{
		private const string ENGLISH_FALLBACK = "English";

		private const string ENGLISH_BODY_FALLBACK = "Purchase the no ads version to remove audio ads.";

		private const string ENGLISH_PURCHASE_FALLBACK = "Purchase";

		private const string ENGLISH_CANCEL_FALLBACK = "Cancel";

		[SerializeField]
		private TextMeshProUGUI _bodyMsg;

		[SerializeField]
		private TextMeshProUGUI _purchaseBtnMsg;

		[SerializeField]
		private TextMeshProUGUI _cancelBtnMsg;

		[SerializeField]
		private Button _purchaseBtn;

		[SerializeField]
		private Button _cancelBtn;

		private IReadOnlyList<AudioAdsPopupLocalisation> _localisations;

		private AudioAdsPopupLocalisation _currentLocalisation;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		private AudioAdsPopupLocalisation TryGetLocalisation()
		{
			return null;
		}

		private AudioAdsPopupLocalisation ForceEnglishFallbackLocalisation()
		{
			return null;
		}

		private void RefreshTexts()
		{
		}

		private void SetVisibility(bool isVisible)
		{
		}

		private void PurchaseNoAds()
		{
		}

		private void OnPurchaseBtnClicked()
		{
		}

		private void OnCancelBtnClicked()
		{
		}

		private void OnPurchaseComplete()
		{
		}
	}
}
