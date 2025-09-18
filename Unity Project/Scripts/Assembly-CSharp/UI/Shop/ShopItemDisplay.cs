using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Shop
{
	public class ShopItemDisplay : MonoBehaviour
	{
		[SerializeField]
		private Image _icon;

		[SerializeField]
		private TextMeshProUGUI _quantityText;

		public void Init(Sprite icon, int quantity)
		{
		}
	}
}
