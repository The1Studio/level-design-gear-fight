using UnityEngine;
using Voodoo.Live.Shop.Data;

namespace Data.Shop
{
	[CreateAssetMenu(fileName = "ShopItemMetaData", menuName = "GearFight/Shop/ShopItemMetaData", order = 0)]
	public class ShopItemMetaData : ShopItemMetaBase
	{
		public RewardStruct Reward;

		public Sprite IconSprite;

		public Sprite IconSpriteForeground;

		protected override void SpecificInitWithProduct(Product product)
		{
		}
	}
}
