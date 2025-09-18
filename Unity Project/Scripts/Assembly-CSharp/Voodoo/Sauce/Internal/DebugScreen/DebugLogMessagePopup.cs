using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Sauce.Debugger;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public class DebugLogMessagePopup : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _headerText;

		[SerializeField]
		private TextMeshProUGUI _bodyText;

		[SerializeField]
		private Button _closeScreen;

		private void Awake()
		{
		}

		public void Show(LogMessage logMessage)
		{
		}

		public void Hide()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
