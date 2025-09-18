using System;
using System.Runtime.CompilerServices;
using GearGame.UI;
using Items;
using TMPro;
using UnityEngine;
using Voodoo.Sauce.IAP;

namespace GearGame.Purchasing
{
	public abstract class IAPButtonController : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI costDisplayText;

		private ProcessingPopup _processingPopup;

		[SerializeField]
		protected TransactionLocation transactionLocation;

		[SerializeField]
		protected OfferType _offerType;

		[SerializeField]
		protected bool _isPurchaseRepeatable;

		protected abstract string IAPProductKey { get; }

		public virtual int RewardRemainingDays { get; }

		public event Action OnPurchaseCompleted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected abstract void PurchaseCompleted();

		protected abstract bool CanBePurchased();

		protected virtual void Start()
		{
		}

		private void OnEnable()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public virtual void OnPressed()
		{
		}

		private void PurchaseConcluded(ProductReceivedInfo product, bool status)
		{
		}

		protected virtual void InitializationCompleted(bool status)
		{
		}
	}
}
