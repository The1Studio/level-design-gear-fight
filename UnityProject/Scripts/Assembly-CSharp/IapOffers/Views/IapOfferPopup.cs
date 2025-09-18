using Core.UI;
using UnityEngine;
using UnityEngine.UI;

namespace IapOffers.Views
{
	public class IapOfferPopup : Popup
	{
		private enum PopupState
		{
			Undefined = -1,
			Standard = 0,
			Premium = 1
		}

		[SerializeField]
		private Button _standardOfferButton;

		[SerializeField]
		private GameObject _standardOfferSelection;

		[SerializeField]
		private IapOfferView _standardOfferView;

		[SerializeField]
		private Button _premiumOfferButton;

		[SerializeField]
		private GameObject _premiumOfferSelection;

		[SerializeField]
		private IapOfferView _premiumOfferView;

		[SerializeField]
		private GameObject _premiumShine;

		[SerializeField]
		private GameObject _premiumNotification;

		private PopupState _state;

		protected override void OnOpen()
		{
		}

		protected override void OnClose()
		{
		}

		private void SetState(PopupState state)
		{
		}

		private void OnStandardSelected()
		{
		}

		private void OnPremiumSelected()
		{
		}
	}
}
