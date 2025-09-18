using TMPro;
using UI.Shop;
using UnityEngine;
using Voodoo.Live.Shop.Data;

namespace Voodoo.Live.Sample.Shop.UI
{
	public class ShopSectionUI : MonoBehaviour
	{
		public string SectionName;

		[SerializeField]
		private TextMeshProUGUI _sectionTitleTxt;

		[SerializeField]
		private Transform[] _productsContainer;

		[SerializeField]
		private ShopButton _productSingleUIPrefab;

		[SerializeField]
		private ShopButton _productBundleUIPrefab;

		[SerializeField]
		private int _maxButtonsPerTransform;

		public void Init(ShopSections shopSection, GameShop gameShop)
		{
		}

		public Transform GetFirstProductContainer()
		{
			return null;
		}

		private Transform GetProductContainerToSpawnNewButton()
		{
			return null;
		}
	}
}
