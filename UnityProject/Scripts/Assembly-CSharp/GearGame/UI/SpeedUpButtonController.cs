using GearGame.Purchasing;
using UnityEngine;

namespace GearGame.UI
{
	public class SpeedUpButtonController : IAPButtonController
	{
		[SerializeField]
		private SpeedUpPopupController popupController;

		protected override string IAPProductKey => null;

		protected override bool CanBePurchased()
		{
			return false;
		}

		protected override void InitializationCompleted(bool status)
		{
		}

		public override void OnPressed()
		{
		}

		protected override void PurchaseCompleted()
		{
		}
	}
}
