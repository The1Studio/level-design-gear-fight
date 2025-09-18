using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Debugger
{
	public class VoodooTuneHomeDebugScreen : Screen
	{
		private const string TAG = "VoodooTuneHomeDebugScreen";

		[SerializeField]
		[Header("Loading Screen")]
		private GameObject loadingRoot;

		[SerializeField]
		private GameObject normalDisplay;

		[SerializeField]
		private GameObject errorDisplay;

		[SerializeField]
		private TextMeshProUGUI errorLabel;

		[SerializeField]
		private Button retryButton;

		[Header("Home")]
		[SerializeField]
		private GameObject homeRoot;

		[SerializeField]
		private GameObject headerRoot;

		[SerializeField]
		private Screen abTestScreen;

		[SerializeField]
		private Screen segmentsScreen;

		[SerializeField]
		private Screen sandboxScreen;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
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

		private void OnInitDone()
		{
		}

		private void ShowCurrentConfig()
		{
		}

		private void CreateInitRequest()
		{
		}

		private void OnAbTestButtonClick()
		{
		}

		private void OnSegmentsButtonClick()
		{
		}

		private void OnSandboxButtonClick()
		{
		}

		private static void OnTimeoutInputEndEdit(string text)
		{
		}

		private static string GetResponseName(double httpCode)
		{
			return null;
		}
	}
}
