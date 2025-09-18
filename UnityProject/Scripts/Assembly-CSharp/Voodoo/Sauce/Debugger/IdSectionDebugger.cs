using TMPro;
using UnityEngine;

namespace Voodoo.Sauce.Debugger
{
	public class IdSectionDebugger : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI text;

		private string _currentId;

		public void UpdateDisplay(bool show, string prefixLabel, string id)
		{
		}

		private void Show(string prefixLabel, string id)
		{
		}

		private void Hide()
		{
		}

		public void CopyToClipboard()
		{
		}
	}
}
