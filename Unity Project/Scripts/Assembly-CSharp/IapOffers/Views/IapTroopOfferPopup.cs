using Core.UI;
using UnityEngine;

namespace IapOffers.Views
{
	public class IapTroopOfferPopup : Popup
	{
		[SerializeField]
		private IapOfferView _sequentialOfferView;

		[SerializeField]
		private IapOfferView _instantOfferView;

		private IapOfferView _currentView;

		protected override void OnOpen()
		{
		}
	}
}
