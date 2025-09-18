using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Voodoo.Sauce.Privacy.UI
{
	[RequireComponent(typeof(GraphicRaycaster))]
	[RequireComponent(typeof(Canvas))]
	public class AccessDataScreen : MonoBehaviour
	{
		public class Parameters
		{
			public Color mainColor;

			public string title;

			public string intro;

			public string idfaTitle;

			public string idfa;

			public string emailTitle;

			public string idfvTitle;

			public string idfv;

			public UnityAction<UserDetails> sendRequestAction;

			public string sendRequestButtonText;

			public UnityAction closeAction;

			public string closeButtonText;

			public UnityAction tryOpenDebugger;
		}

		[SerializeField]
		private TextMeshProUGUI _titleText;

		[SerializeField]
		private TextMeshProUGUI _introText;

		[SerializeField]
		private TextMeshProUGUI _idfaTitle;

		[SerializeField]
		private TMP_InputField _idfa;

		[SerializeField]
		private TextMeshProUGUI _emailTitle;

		[SerializeField]
		private TMP_InputField _email;

		[SerializeField]
		private TextMeshProUGUI _idfvTitle;

		[SerializeField]
		private TMP_InputField _idfv;

		[SerializeField]
		private Button _sendRequestButton;

		[SerializeField]
		private TextMeshProUGUI _sendRequestButtonText;

		[SerializeField]
		private Button _closeButton;

		[SerializeField]
		private TextMeshProUGUI _closeButtonText;

		[SerializeField]
		[Header("Debugger Buttons")]
		private Button _debuggerButton0;

		[SerializeField]
		private Button _debuggerButton1;

		[SerializeField]
		private Button _debuggerButton2;

		private UnityAction<UserDetails> _sendRequestAction;

		public void Initialize(Parameters p)
		{
		}

		private void SendRequest()
		{
		}
	}
}
