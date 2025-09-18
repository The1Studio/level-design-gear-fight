using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Voodoo.Live.Debugger
{
	public class DebuggerKeyInputPair : MonoBehaviour
	{
		[SerializeField]
		[Header("References")]
		private TextMeshProUGUI _keyText;

		[SerializeField]
		private TMP_InputField _inputText;

		public void Init(string key, string value, UnityAction<string> onEdit)
		{
		}
	}
}
