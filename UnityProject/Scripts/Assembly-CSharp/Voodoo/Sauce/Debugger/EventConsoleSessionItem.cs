using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Debugger
{
	public class EventConsoleSessionItem : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI title;

		[SerializeField]
		private Transform eventsContainer;

		[SerializeField]
		private Button copyButton;

		private int _sessionCount;

		private string _sessionId;

		public Transform GetContainer => null;

		public void Initialize(int sessionCount, string sessionId)
		{
		}

		private void Start()
		{
		}

		private void SetupUi()
		{
		}
	}
}
