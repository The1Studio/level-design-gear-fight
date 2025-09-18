using System;
using GearGame.UI;
using Items;
using UnityEngine;
using Voodoo.Sauce.IAP;

namespace Data.Operations
{
	[Serializable]
	public class IAPTransaction : ITransaction
	{
		[SerializeField]
		private string _iapProductKey;

		[SerializeField]
		private OfferType _offerType;

		[SerializeField]
		private bool _repeatable;

		[SerializeField]
		private int _totalClaimDays;

		private Action<bool> _onComplete;

		private TransactionLocation _location;

		private ProcessingPopup _processingPopup;

		private IAPAvailability _iAPAvailability;

		public PurchasableChecker PurchasableChecker => null;

		public IAPTransaction()
		{
		}

		public IAPTransaction(string iapProductKey, OfferType offer = OfferType.None, bool repeatable = false, int totalClaimDay = 0)
		{
		}

		public string GetPriceText()
		{
			return null;
		}

		public void ExecuteTransaction(Action<bool> onComplete, TransactionLocation location)
		{
		}

		private void PurchaseConcluded(ProductReceivedInfo product, bool status)
		{
		}

		public void TransactionShown(TransactionLocation location)
		{
		}
	}
}
