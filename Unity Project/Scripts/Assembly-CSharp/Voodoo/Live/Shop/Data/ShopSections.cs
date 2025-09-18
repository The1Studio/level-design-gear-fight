using System;
using System.Collections.Generic;

namespace Voodoo.Live.Shop.Data
{
	[Serializable]
	public class ShopSections
	{
		public string id;

		public string name;

		public List<Product> purchasable;

		public int sectionIndex;

		public void SetupProducts()
		{
		}
	}
}
