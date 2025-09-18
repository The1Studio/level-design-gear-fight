using Data.Operations;
using Data.Shop;
using Items;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Live.Shop.Data;

namespace UI.Shop
{
	[RequireComponent(typeof(Button))]
	[DisallowMultipleComponent]
	public class ShopButton : MonoBehaviour
	{
		[SerializeField]
		[Space(20f)]
		private ShopItemMetaBase _metadata;

		[SerializeField]
		[Space]
		private TextMeshProUGUI _headerText;

		[SerializeField]
		private TextMeshProUGUI _descriptionText;

		[SerializeField]
		private TextMeshProUGUI _priceText;

		[Space]
		[SerializeField]
		private GameObject _headerRoot;

		[SerializeField]
		private Image _icon;

		[SerializeField]
		private Image _iconForeground;

		[SerializeField]
		private GameObject _yesAffordRoot;

		[SerializeField]
		private GameObject _noAffordRoot;

		[SerializeField]
		private ShopItemDisplay _shopItemDisplayPrefab;

		[SerializeField]
		private Transform _shopItemDisplayParent;

		[SerializeField]
		private GameObject[] _backgrounds;

		[Space]
		[SerializeField]
		private AudioSource _onPurchaseAudioSource;

		[SerializeField]
		private TransactionLocation transactionLocation;

		private Button _button;

		private ITransaction _transaction;

		private GameShop _gameShop;

		public ShopItemMetaBase Metadata => null;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		public void InitFromVL(Product product, GameShop gameShop)
		{
		}

		private ShopItemMetaBase GetMetaDataForProduct(Product product)
		{
			return null;
		}

		private void RefreshDisplay()
		{
		}

		private void CurrencyValueChanged(double obj)
		{
		}

		private void OnButtonPressed()
		{
		}

		private void SetBackground(int index)
		{
		}
	}
}
