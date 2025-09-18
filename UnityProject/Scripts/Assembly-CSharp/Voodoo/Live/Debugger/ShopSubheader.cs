using UnityEngine;
using Voodoo.Live.Shop.Data;

namespace Voodoo.Live.Debugger
{
	public class ShopSubheader : SubHeader
	{
		[Header("Prefabs")]
		[SerializeField]
		private ShopProductDebug _shopProductDebugPrefab;

		public void Init(GameShop gameShop, Transform contentTR)
		{
		}
	}
}
