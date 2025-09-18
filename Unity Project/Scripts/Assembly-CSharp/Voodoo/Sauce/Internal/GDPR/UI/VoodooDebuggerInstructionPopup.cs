using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Voodoo.Sauce.Internal.DebugScreen;

namespace Voodoo.Sauce.Internal.GDPR.UI
{
	public class VoodooDebuggerInstructionPopup : MonoBehaviour
	{
		private const string _missingConsent = "You need to consent in order to have access to the debugger.";

		private const string _deviceIDPrefix = "Idfv :";

		private const string _secondPairPrefix = "Idfa :";

		[SerializeField]
		private GameObject _idParent;

		[SerializeField]
		private TextMeshProUGUI _deviceId;

		[SerializeField]
		private Button _copyButton;

		[SerializeField]
		private GameObject _secondPair;

		[SerializeField]
		private TextMeshProUGUI _secondPairText;

		[SerializeField]
		private Button _secondPairbutton;

		[SerializeField]
		private DebugPopup _debugPopup;

		private string _deviceIdValue;

		private string _secondPairValue;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Show(string instruction, bool showUserId, UnityAction buttonCallback = null)
		{
		}

		private void DisplayInstructions(bool showUserId, string deviceId = null)
		{
		}

		private void DisplaySecondInstructions(bool showUserId, string deviceId = null)
		{
		}
	}
}
