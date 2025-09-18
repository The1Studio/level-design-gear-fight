using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Live.Debugger
{
	public class MessageTabTop : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private TextMeshProUGUI _messageTxt;

		[SerializeField]
		private Button _closeBtn;

		private void Awake()
		{
		}

		public void ShowMessage(string message)
		{
		}

		private void HideMessage()
		{
		}
	}
}
