using System;
using System.Collections.Generic;

namespace Voodoo.Live.Shop.Data
{
	[Serializable]
	public class GameShop
	{
		public string id;

		public string name;

		public bool isdefaultstore;

		public List<ShopSections> sections;

		public string sourceId;

		public string sourceName;

		public List<Product> ShopProducts { get; private set; }

		public void SetSource(string sourceId, string sourceName)
		{
		}

		public void SetupSections()
		{
		}

		public ShopSections GetSectionByProductId(string productId)
		{
			return null;
		}
	}
}
