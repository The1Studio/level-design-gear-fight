using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Debugger
{
	public class VoodooTuneLoadingDebugScreen : Screen
	{
		[Header("Loading Screen")]
		[SerializeField]
		private GameObject normalDisplay;

		[SerializeField]
		private GameObject errorDisplay;

		[SerializeField]
		private TextMeshProUGUI errorLabel;

		[SerializeField]
		private Screen screenToShow;

		[SerializeField]
		private GameObject commonElements;

		[SerializeField]
		private Button retryButton;

		private bool _initialised;

		private string _errorMessage;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void OnScreenShow()
		{
		}

		private void Load()
		{
		}

		private void OnSuccess()
		{
		}

		private void OnError(string message)
		{
		}
	}
}
