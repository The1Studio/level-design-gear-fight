using GearGame.Purchasing;

namespace Gameplay.Blessings
{
	public class BlessingIAPController : IAPButtonController
	{
		protected override string IAPProductKey => null;

		protected override void InitializationCompleted(bool status)
		{
		}

		protected override void PurchaseCompleted()
		{
		}

		private void Enable(bool status)
		{
		}

		protected override bool CanBePurchased()
		{
			return false;
		}
	}
}
