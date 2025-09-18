using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Live.Shop.Data;

namespace Voodoo.Live.Debugger
{
	public class ShopProductDebug : MonoBehaviour
	{
		[SerializeField]
		[Header("Prefabs")]
		private ShopProductLabel _shopProductLabelPrefab;

		[SerializeField]
		private DebuggerKeyValuePair _keyValuePair;

		[SerializeField]
		private Toggle _toggle;

		[SerializeField]
		private Transform _subHeaderArrowTR;

		private List<GameObject> _gameObjects;

		public void SetProduct(Product product)
		{
		}

		private void CreateLabel(string key, string value)
		{
		}

		private void CreateValuePair(string key, string value)
		{
		}

		private void Init()
		{
		}

		private void OnValueChanged(bool value)
		{
		}
	}
}
