using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Live.Shop;

namespace Voodoo.Live.Debugger
{
	public class ShopSection : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private TextMeshProUGUI _shopIdTxt;

		[SerializeField]
		private TextMeshProUGUI _defaultTxt;

		[SerializeField]
		private TextMeshProUGUI _shopUrlTxt;

		[SerializeField]
		private Button _shopUrlCopyBtn;

		[SerializeField]
		private Button _shopDataCopyBtn;

		[SerializeField]
		private Transform _contentTransform;

		[SerializeField]
		private ShopSubheader _subHeader;

		public void Init(ShopManager shopManager)
		{
		}

		private void CopyShopUrl(ShopManager shopManager)
		{
		}

		private void CopyShopData(ShopManager shopManager)
		{
		}
	}
}
