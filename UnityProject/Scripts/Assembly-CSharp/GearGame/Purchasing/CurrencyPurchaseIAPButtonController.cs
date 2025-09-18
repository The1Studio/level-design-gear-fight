using GearGame.Control;
using TMPro;
using UnityEngine;

namespace GearGame.Purchasing
{
	public class CurrencyPurchaseIAPButtonController : IAPButtonController
	{
		public enum CollectionType
		{
			CurrencyDisplay = 0,
			SimpleIncrement = 1
		}

		[SerializeField]
		private CollectionType collectionType;

		[SerializeField]
		private CurrencySO currency;

		[SerializeField]
		private Transform spawnTransformForCurrencyBurst;

		[SerializeField]
		private int currencyAmount;

		[SerializeField]
		private string iapProductKey;

		[SerializeField]
		protected TextMeshProUGUI descriptionText;

		[SerializeField]
		protected string localizationKeyForDescription;

		protected override string IAPProductKey => null;

		protected override void Start()
		{
		}

		private void OnValidate()
		{
		}

		protected override void PurchaseCompleted()
		{
		}

		protected string GetLocalizationString()
		{
			return null;
		}

		protected override bool CanBePurchased()
		{
			return false;
		}
	}
}
