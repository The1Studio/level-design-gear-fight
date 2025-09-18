using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Live.Shop.Data;

namespace Voodoo.Live.Sample.Shop.UI
{
	public class ButtonProductUI : MonoBehaviour
	{
		[SerializeField]
		private Button _button;

		[SerializeField]
		private GameObject _iapGO;

		[SerializeField]
		private GameObject _adsGO;

		[SerializeField]
		private GameObject _softGO;

		[SerializeField]
		private TextMeshProUGUI _iapTxt;

		[SerializeField]
		private TextMeshProUGUI _adsTxt;

		[SerializeField]
		private TextMeshProUGUI _softTxt;

		private Product _product;

		private GameShop _gameShop;

		public void Init(Product product, GameShop gameShop)
		{
		}

		private void PurchaseIAP(string iapId)
		{
		}

		private void PurchaseRV()
		{
		}

		private void PurchaseSoftCurrency()
		{
		}
	}
}
