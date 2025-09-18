using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Live.Shop.Data;
using Voodoo.Live.Utils;

namespace Voodoo.Live.Sample.Shop.UI
{
	public class ProductSingleUI : ProductUI
	{
		[SerializeField]
		private TextMeshProUGUI rewardNameTxt;

		[SerializeField]
		private TextMeshProUGUI rewardAmountTxt;

		[SerializeField]
		private Image rewardImg;

		[SerializeField]
		private GameObject[] backgrounds;

		public override void Init(Product product, GameShop gameShop, RectTransform scrollViewRect, SpriteDictionarySO spriteDictionarySo)
		{
		}

		private void EnableBackground(int index)
		{
		}

		public void SetImage(Sprite sprite)
		{
		}
	}
}
