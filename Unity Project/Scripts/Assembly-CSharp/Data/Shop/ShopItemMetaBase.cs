using Data.Operations;
using UnityEngine;
using Voodoo.Live.Shop.Data;

namespace Data.Shop
{
	public abstract class ShopItemMetaBase : ScriptableObject
	{
		public Price Price;

		[Space(20f)]
		[SerializeField]
		private string _headerLocKey;

		[SerializeField]
		private string _failedPurchaseLocKey;

		public int BackgroundIndex;

		public string GetHeaderLocalizedText()
		{
			return null;
		}

		public string GetFailedPurchaseLocalizedText()
		{
			return null;
		}

		public ITransaction GetTransaction()
		{
			return null;
		}

		public void InitWithProduct(Product product)
		{
		}

		protected abstract void SpecificInitWithProduct(Product product);
	}
}
