using GearGame.Purchasing;
using Items;

namespace IapOffers.Views
{
	internal class IapOfferIAPController : IAPButtonController
	{
		public override int RewardRemainingDays => 0;

		protected override string IAPProductKey => null;

		public void Initialize(OfferType offerType)
		{
		}

		public override void OnPressed()
		{
		}

		protected override void PurchaseCompleted()
		{
		}

		protected override bool CanBePurchased()
		{
			return false;
		}
	}
}
