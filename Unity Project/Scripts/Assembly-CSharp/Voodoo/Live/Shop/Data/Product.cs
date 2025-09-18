using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Voodoo.Live.Shop.Data
{
	[Serializable]
	public class Product
	{
		public enum Size
		{
			SMALL = 0,
			MEDIUM = 1,
			LARGE = 2,
			EXTRA_LARGE = 3
		}

		public string id;

		public string technicalName;

		public string name;

		public string type;

		public Reward reward;

		public Price price;

		public List<string> tags;

		public Size size;

		public int productIndex;

		public event Action<bool> OnPurchaseCompleted
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

		internal void CompletePurchase()
		{
		}

		internal void StopPurchase()
		{
		}

		public void SetSize()
		{
		}
	}
}
