using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Live.Debugger
{
	public class Label : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private TextMeshProUGUI _labelText;

		[SerializeField]
		private Button _labelBtn;

		[SerializeField]
		private Transform _arrow;

		[SerializeField]
		private Toggle _toggle;

		public List<GameObject> itemsInContent;

		private string _name;

		public void Init(string labelName, string data)
		{
		}

		private void OnClick(string data)
		{
		}

		public void Toggle(bool value)
		{
		}
	}
}
