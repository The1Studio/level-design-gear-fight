using UnityEngine;
using Voodoo.Live.Shop.Data;

namespace Data.Shop
{
	[CreateAssetMenu(fileName = "ShopMultiItemsMetaData", menuName = "GearFight/Shop/ShopMultiItemsMetaData", order = 0)]
	public class ShopMultiItemsMetaData : ShopItemMetaBase
	{
		public RewardStruct[] Rewards;

		protected override void SpecificInitWithProduct(Product product)
		{
		}
	}
}
