using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Live.Utils;

namespace Voodoo.Live.Sample.Shop.UI
{
	public class ProductRewardUI : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI amountTxt;

		[SerializeField]
		private Image icon;

		public void Init(string item, int quantity, SpriteDictionarySO spriteDictionarySo)
		{
		}
	}
}
