using Items;
using UnityEngine;
using UnityEngine.Events;

namespace GearGame.Control
{
	public class GemTransactionHelper : MonoBehaviour
	{
		public UnityEvent PurchaseSuccessful;

		[SerializeField]
		private CurrencySO gemCurrency;

		[SerializeField]
		private TransactionLocation transactionLocation;

		[SerializeField]
		private int defaultGemCost;

		public void PressBuyButton()
		{
		}

		public bool TryBuy(int gemCost)
		{
			return false;
		}
	}
}
