using System;
using System.Runtime.CompilerServices;
using Data.Shop;
using GearGame.Control;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Purchasing
{
	public class BulkOfferingItem : MonoBehaviour
	{
		[SerializeField]
		private Image displayImage;

		[SerializeField]
		private Image displayImageForeground;

		[SerializeField]
		private TextMeshProUGUI quantityText;

		[SerializeField]
		private TextMeshProUGUI costText;

		[SerializeField]
		private TextMeshProUGUI discountText;

		[SerializeField]
		private GameObject discountRoot;

		[SerializeField]
		private GameObject yesAffordRoot;

		[SerializeField]
		private GameObject noAffordRoot;

		[SerializeField]
		private GameObject[] allClaimedObjects;

		[SerializeField]
		private GameObject[] allNotClaimedObjects;

		private bool purchasedState;

		private ShopItemMetaData shopData;

		private int adjustedCost;

		private CurrencySO _gems;

		public bool IsPurchased => false;

		public int Index { get; private set; }

		private CurrencySO Gems => null;

		public event Action<BulkOfferingItem> OnPurchased
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

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void ValueChanged(double value)
		{
		}

		public void Initialize(ShopItemMetaData metaData, int index)
		{
		}

		public void SetPuchasedState(bool state)
		{
		}

		public void OnPressed()
		{
		}

		public void SetDiscount(float discount01)
		{
		}
	}
}
