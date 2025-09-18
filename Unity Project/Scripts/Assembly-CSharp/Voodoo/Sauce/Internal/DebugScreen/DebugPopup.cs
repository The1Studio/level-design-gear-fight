using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public class DebugPopup : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _text;

		[SerializeField]
		private Button _button;

		public void Initialize(string text, UnityAction buttonCallback = null)
		{
		}

		public void Initialize(UnityAction buttonCallback)
		{
		}

		public void Dispose()
		{
		}
	}
}
