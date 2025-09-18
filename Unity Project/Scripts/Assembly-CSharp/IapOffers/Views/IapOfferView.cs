using Coffee.UIExtensions;
using Items;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Distribution;

namespace IapOffers.Views
{
	public class IapOfferView : MonoBehaviour
	{
		private const string _localizationKeyClaim = "Q_Claim_btn";

		private const string _localizationKeyClaimed = "Claimed";

		[SerializeField]
		private IapOfferDailyView[] _dailyViews;

		[SerializeField]
		private IapOfferIAPController _iapController;

		[SerializeField]
		private Button _purchaseButton;

		[SerializeField]
		private Button _claimButton;

		[SerializeField]
		private Translator _claimButtonTranslator;

		[SerializeField]
		private TMP_Text _timerText;

		[SerializeField]
		private GameObject _claimButtonShine;

		[SerializeField]
		private GameObject _claimNotification;

		[SerializeField]
		private UIParticle _onClaimParticles;

		[SerializeField]
		private UIParticle _onPurchaseParticles;

		private OfferType _offerType;

		private void Update()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Display(OfferType offerType)
		{
		}

		private IapOfferRewardState GetRewardState(int index, OfferType offerType)
		{
			return default(IapOfferRewardState);
		}

		private void OnPurchaseClicked()
		{
		}

		private void OnPurchaseCompleted()
		{
		}

		private void OnClaimClicked()
		{
		}
	}
}
