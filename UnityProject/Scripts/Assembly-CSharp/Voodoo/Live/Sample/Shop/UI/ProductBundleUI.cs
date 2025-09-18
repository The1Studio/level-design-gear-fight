using UnityEngine;
using Voodoo.Live.Shop.Data;
using Voodoo.Live.Utils;

namespace Voodoo.Live.Sample.Shop.UI
{
	public class ProductBundleUI : ProductUI
	{
		[SerializeField]
		private Transform rewardsContainer;

		[SerializeField]
		private ProductRewardUI _productRewardUIPrefab;

		public override void Init(Product product, GameShop gameShop, RectTransform scrollViewRect, SpriteDictionarySO spriteDictionarySo)
		{
		}
	}
}
