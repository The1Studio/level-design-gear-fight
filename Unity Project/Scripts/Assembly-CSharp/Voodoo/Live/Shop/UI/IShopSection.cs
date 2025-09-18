using System;
using JetBrains.Annotations;
using UnityEngine;
using Voodoo.Live.Shop.Data;
using Voodoo.Live.Utils;

namespace Voodoo.Live.Shop.UI
{
	public interface IShopSection
	{
		void Init(ShopSections shopSection, [CanBeNull] Action showLoadingScreen, GameShop gameShop, RectTransform scrollViewRect, SpriteDictionarySO spriteDictionarySo);
	}
}
