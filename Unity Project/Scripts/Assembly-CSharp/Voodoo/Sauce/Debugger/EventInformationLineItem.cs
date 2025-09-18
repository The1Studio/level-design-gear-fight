using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Debugger
{
	public class EventInformationLineItem : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI field;

		[SerializeField]
		private Button copyButton;

		private string _key;

		private string _value;

		private const int MAX_LENGTH = 50;

		private void Awake()
		{
		}

		public void UpdateData(KeyValuePair<string, object> information)
		{
		}
	}
}
