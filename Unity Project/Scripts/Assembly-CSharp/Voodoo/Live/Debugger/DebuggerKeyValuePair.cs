using TMPro;
using UnityEngine;

namespace Voodoo.Live.Debugger
{
	public class DebuggerKeyValuePair : MonoBehaviour
	{
		[SerializeField]
		[Header("References")]
		private TextMeshProUGUI _keyText;

		[SerializeField]
		private TextMeshProUGUI _valueText;

		public void Init(string key, string value)
		{
		}
	}
}
